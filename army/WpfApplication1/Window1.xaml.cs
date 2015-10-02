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
            AnswerA.Content = "Answer1";
            AnswerB.Content = "Answer2";
            AnswerC.Content = "Answer3";
            AnswerD.Content = "Answer4";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {   
            
        }
       
        
    }
}
