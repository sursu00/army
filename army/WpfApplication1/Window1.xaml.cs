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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
	
    public partial class Window1 : Window
    {
		//TODO: переименовать всё
        public Window1()
        {
            InitializeComponent();
            textBox1.Text = "Answer1";
            textBox2.Text = "Answer2";
            textBox3.Text = "Answer3";
            textBox4.Text = "Answer4";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {   
            i.numq++;
            if (textBox1.Text=="Answer1" && radioButton1.IsChecked==true)
                i.cnt++;
            if (i.numq == 10)
            {
                this.Close();
                Window2 Window2 = new Window2();
                Window2.Show();
            }
        }
       
        
    }
}
