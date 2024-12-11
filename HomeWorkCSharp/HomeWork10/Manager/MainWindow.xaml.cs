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

namespace Manager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        private Menu _menuWindow;
        private Menu MenuWindow
        {
            get
            {
                if (_menuWindow == null || !_menuWindow.IsLoaded)
                {
                    _menuWindow = new Menu();
                    _menuWindow.Owner = this;
                    _menuWindow.Closed += (s, ev) => _menuWindow = null;
                    _menuWindow.Show();
                }
                return _menuWindow;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Manager_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow.Activate();
        }

        private void btnClick_Consultant_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
