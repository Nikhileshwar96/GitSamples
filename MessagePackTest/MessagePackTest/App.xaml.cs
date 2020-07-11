using System;
using MessagePack.Resolvers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagePackTest
{
    public partial class App : Application
    {
        public App()
        {
            StaticCompositeResolver.Instance.Register(
                 MessagePack.Resolvers.GeneratedResolver.Instance,
                 MessagePack.Resolvers.StandardResolver.Instance
            );

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
