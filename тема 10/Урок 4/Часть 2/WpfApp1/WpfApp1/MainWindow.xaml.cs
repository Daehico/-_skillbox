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
            Accepted();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Sent();
        }

        public static Stack<string> textQueue = new Stack<string>();
        public static int id = textQueue.Count;

        public static int TextCount()
        {
            id = textQueue.Count;
            return id;
        }

        private void Accepted()
        {
            if (id >= 5)
            {
                MessageBox.Show("Стоянка самолетов заполнена","Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                textQueue.Push("Cамолет №" + id);
                MessageBox.Show(string.Format("Самолет № {0} принят", id), "Самолет принят", MessageBoxButton.OK, MessageBoxImage.Information);
                TextCount();
            }
        }
        private void Sent()
        {
            if (id < 0)
            {
                MessageBox.Show("Cамолетов не обнаружено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                TextCount();
                textQueue.Push("Cамолет №" + id);
                MessageBox.Show(string.Format("Самолет № {0} отправлен", id), "Самолет отправлен", MessageBoxButton.OK, MessageBoxImage.Information);
                TextCount();
            }
        }
    }
}
