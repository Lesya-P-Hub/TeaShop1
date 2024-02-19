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

namespace TeaShop.View.Window
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : System.Windows.Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegistBtn_Click(object sender, RoutedEventArgs e)
        {
            //string mes="";
            //if(string.IsNullOrEmpty(NameTb.Text))
            //{
            //mes +="Введите имя!\n";
            //}
            //if(string.IsNullOrEmpty(SurnameTb.Text))
            //{
            //mes+="Введите фамилию!\n";
            //}
            //if(string.IsNullOrEmpty(PhoneTb.Text))
            //{
            //mes+="Введите телефон (логин)!\n";
            //}
            //if(string.IsNullOrEmpty(PasswordPb.Password))
            //{
            //mes+="Введите пароль!\n";
            //}
            //if(ChekCb.IsChecked == false)
            //{
            //mes+="Без согласия на обработку данных мы не можем допустить вас к использованию приложения\n";
            //}
            //if(mes!="")
            //{
            //MessageBox.Show(mes);
            //mes = "";
            //return;
            //}
            //User user = new User
            //{
            //Name = NameTb.Text,
            //Surname = SurnameTb.Text,
            //Patronimyc = PatronimycTb.Text,
            //Phone = PhoneTb.Text,
            //Address = "Не указан",
            //StatusId = 3,
            //Password = PasswordPb.Password
            //};
            //App.context.User.Add(user);
            //App.contxet.User.SaveChages();
            //App.enteredUser = user;
            //ShopMainWindow shopMainWindow = new ShopMainWindow();
            //shopMainWindow.Show();
            //this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
