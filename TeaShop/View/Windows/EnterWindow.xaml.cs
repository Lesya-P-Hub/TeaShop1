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
using System.Windows.Shapes;

namespace TeaShop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : System.Windows.Window
    {
        public EnterWindow()
        {
            InitializeComponent();
            Loaded += EnterWindow_Loaded;
        }

        private void EnterWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Activate();
        }
    }
}