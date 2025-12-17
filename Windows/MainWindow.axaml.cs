using Avalonia.Controls;

namespace SyxActorTool
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainContent.Content = new SettingsView();
        }
    }
}