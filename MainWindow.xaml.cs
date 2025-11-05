using DataBinding.Data;
using System.Text;
using System.Windows;
namespace DataBinding
{
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person {Name = "Grisha", Age= 18},
            new Person {Name = "Anton", Age= 22},
            new Person {Name = "Stas", Age= 20},
            new Person {Name = "Ura", Age= 32}

        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxNames.ItemsSource = People;
        }
    }
}