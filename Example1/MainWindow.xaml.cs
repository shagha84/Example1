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

namespace Example1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person currentPerson;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Add(currentPerson.FullInformation());
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            bool isOk = ListBox1.SelectedIndex >= 0;
            if (!isOk)
            {
                MessageBox.Show("Azizam aval yek gozine ra entekhab kon, merci, ah!");
            }
            else
            {
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
            }
        }

        private void BtnCreateObj_Click(object sender, RoutedEventArgs e)
        {
            string name = txtBoxName.Text;
            string job = txtBoxJob.Text;
            int age = Convert.ToInt32(txtBoxAge.Text);
            Person person1 = new Person(name, job, age);
            currentPerson = person1;
        }
    }
}
