using System.Windows;
using ViewModel;
using ViewModelProject;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MyView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private MainViewModel xxx;

        public double Number1 { get; set; }
        public MainView()
        {
            xxx = new MainViewModel()
            {
                PartA = new PartAViewModel(),
                PartB = new PartBViewModel(),
            };
            InitializeComponent();
            DataContext = xxx;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xxx.PartA.UserText = exampleTextBox.Text;
        }
    }























}
