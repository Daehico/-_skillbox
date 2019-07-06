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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    this.button1.IsEnabled = !string.IsNullOrEmpty(this.textBox.Text);
        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MakeAnOrder();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CompleteOrder();
        }
        public static Queue<string> textQueue = new Queue<string>();
        public static int id = textQueue.Count;
        public static string a;

        public static int TextCount()
        {
            id = textQueue.Count;
            return id;
        }

        private void MakeAnOrder()
        {
            if (id >= 10)
            {
                MessageBox.Show(string.Format("Очередь заказазов переполнена"), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                textQueue.Enqueue("Заказ " + id);
                MessageBox.Show(string.Format("Заказ № {0} сделан", id), "Заказ сделан", MessageBoxButton.OK, MessageBoxImage.Information);
                TextCount();
            }
          
        }
        private void CompleteOrder()
        {
            if (id < 10)
            {
                MessageBox.Show(string.Format("Заказов не обнаружено"), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                TextCount();
                textQueue.Dequeue();
                MessageBox.Show(string.Format("Заказ № {0} выполнен", id), "Заказ выполнен", MessageBoxButton.OK, MessageBoxImage.Information);
                TextCount();
            }
           
        }
    }
}
