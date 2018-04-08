using System;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using StudentManagement.ViewModels;
using StudentManagement.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using StudentManagement.Enums;
using StudentManagement.Helpers;
using StudentManagement.Interfaces;
using StudentManagement.Models;
using StudentManagement.Services.LocalDatabase;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StudentManagement
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */

        #region Properties

        private ISQLiteHelper _sqLiteHelper;

        #endregion

        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitDatabase();
            InitMockData();
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
            StartApp();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<TestPage>();
        }

        private void InitDatabase()
        {
            var connectionService = DependencyService.Get<IDatabaseConnection>();
            _sqLiteHelper = new SQLiteHelper(connectionService);
        }

        private void InitMockData()
        {
            var setting = _sqLiteHelper.Get<Setting>("1");
            if (setting != null)
            {
                if (!setting.IsInitData)
                {
                    var mockData = new MockData(_sqLiteHelper);
                    mockData.InitMockData();
                }
            }
            else
            {
                var mockData = new MockData(_sqLiteHelper);
                mockData.InitMockData();
            }
        }

        private async void StartApp()
        {
            var user = _sqLiteHelper.GetUser();

            string uri = PageManager.MultiplePage(new[]
            {
                PageManager.HomePage, PageManager.NavigationPage,
            });
            var navParam = new NavigationParameters();

            if (user == null)
                uri = PageManager.LoginPage;
            // If PrincipalRole
            else if (user.Role.Equals(RoleManager.PrincipalRole))
                uri += "/" + PageManager.ListClassesPage;
            // If TeacherRole
            else if (user.Role.Equals(RoleManager.TeacherRole))
            {
                uri += "/" + PageManager.DetailClassPage;
                var classInfo = _sqLiteHelper.Get<Class>(c => c.Id == user.ClassId);
                classInfo.CountStudent(_sqLiteHelper);
                navParam.Add(ParamKey.DetailClassPageType.ToString(), DetailClassPageType.ClassInfo);
                navParam.Add(ParamKey.ClassInfo.ToString(), classInfo);
            }
            // If StudentRole
            else
            {
                uri += "/" + PageManager.DetailStudentPage;
                navParam.Add(ParamKey.DetailStudentPageType.ToString(), DetailStudentPageType.StudentInfo);
                navParam.Add(ParamKey.StudentInfo.ToString(), _sqLiteHelper.Get<Student>(s => s.Id == user.Id));
            }

            await NavigationService.NavigateAsync(new Uri($"https://np2qt.com/{uri}"), navParam);
        }
    }
}
