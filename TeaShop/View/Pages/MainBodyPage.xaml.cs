﻿using System;
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

namespace TeaShop.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainBodyPage.xaml
    /// </summary>
    public partial class MainBodyPage : Page
    {
        public MainBodyPage()
        {
            InitializeComponent();
            ProductLb.ItemsSource = App.context.Product.ToList();
            ArticleLb.ItemsSource = App.context.Article.ToList();
        }
    }
}
