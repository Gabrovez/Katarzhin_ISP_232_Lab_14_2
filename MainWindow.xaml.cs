using DataBinding.Data;
using System.Text;
using System.Windows;
namespace DataBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxNames.ItemsSource = new List<string>()
            {
                "Grisha",
                "Anton",
                "Stas",
                "Ura"
            };
            

        }
    }
}