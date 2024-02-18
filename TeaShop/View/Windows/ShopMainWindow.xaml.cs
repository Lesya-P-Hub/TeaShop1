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
using TeaShop.AppData;

namespace TeaShop.View.Window
{
    /// <summary>
    /// Логика взаимодействия для ShopMainWindow.xaml
    /// </summary>
    public partial class ShopMainWindow : System.Windows.Window
    {
        public ShopMainWindow()
        {
            InitializeComponent();
            FrameClass.LogoFrame = LogoFrm;
            LogoFrm.Navigate( new View.Pages.LogoPage());
            FrameClass.BodyFrame = BodyFrm;
            BodyFrm.Navigate(new View.Pages.MainBodyPage());
            FrameClass.MenuFrame = MenuFrm;
            MenuFrm.Navigate( new View.Pages.MenuPage());
        }
    }
}
