using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HomeWork9
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

        private void Answer_Click_1(object sender, RoutedEventArgs e)
        {
            // считываем ввод с клавиатуры
            string inputString = textBox_Input.Text;

            // Разбиваемна пробелы
            string[] words = inputString.Split(' ');

            // Список обЪекта Class1_Task1
            var item = new List<Class1_Task1>();

            // Добавляем каждое слово в ListBox
            foreach (string word in words)
            {
                item.Add(new Class1_Task1 { text = word });
            }
            ListBoxView.ItemsSource = item;


        }

        private void Answer_Click_2(object sender, RoutedEventArgs e)
        {
            string inputText = textBox_Input.Text;
            string[] words = inputText.Split(' ');
            string reversedText = string.Join(" ", words.Reverse());
            Lable_Button2.Content = reversedText;
        }
       
    }
}
