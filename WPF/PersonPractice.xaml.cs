using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for PersonPractice.xaml
    /// </summary>
    public partial class PersonPractice : Window
    {
        public Person person = new Person("Adam", "Johnson", 23);
        public PersonPractice()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            //String surname = nameTextBox.Text;
            //String name = nameTextBox.Text;
            //int age = Convert.ToInt32(ageTextBox.Text);
            //this.person = new Person(name, surname, age);
            person.Name = "empty";
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.ToString());
        }
    }

    public class Person: INotifyPropertyChanged
    {
        public String Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }
        public String Surname { get; set; }
        public int Age { get; set; }

        public Person(String name, String surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
                MessageBox.Show("changed!");
            }

        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nSurname: {this.Surname}\nAge: {this.Age}";
        }
    }
}
