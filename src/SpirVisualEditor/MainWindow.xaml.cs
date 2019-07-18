using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SpirVisualEditor.Model;
using SpirVisualEditor.ViewModel;

namespace SpirVisualEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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
