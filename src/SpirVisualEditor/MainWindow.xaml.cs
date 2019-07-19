using System.Windows;
using SpirVisualEditor.Model;
using SpirVisualEditor.ViewModel;

namespace SpirVisualEditor
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DependencyContainer _container;

        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _container = new DependencyContainer();
            _viewModel = _container.Resolve<MainViewModel>();
            DataContext = _viewModel;
        }
    }
}