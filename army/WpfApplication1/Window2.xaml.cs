using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            textBox1.Text = str.data;
            textBox2.Text = i.cnt.ToString();
            textBox3.Text = (10 - i.cnt).ToString();//comment//
            textBox4.Text = Math.Ceiling(i.cnt / 2.0).ToString();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox1.Password == str.passexit)
            {
                     App.Current.Shutdown();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(passwordBox2.Password==str.passcheck)
            { 
                Window3 Window3=new Window3();
                this.Close();
                Window3.Show();
            }
        }
    }
}