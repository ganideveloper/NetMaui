namespace Notes
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new AppShell();
         Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
      }
   }
}