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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class i { 
           public static int cnt=0,numq=0;
        }
    public class str {
        public static string s,data,passexit="exit",passcheck="check";
    }
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 Window1=new Window1();
            str.data = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            Window1.Show();
        }
    }
}
