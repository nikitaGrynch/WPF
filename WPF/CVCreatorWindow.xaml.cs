using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for CVCreatorWindow.xaml
    /// </summary>
    public partial class CVCreatorWindow : Window
    {
        private List<UserCV> usersCV;
        public CVCreatorWindow()
        {
            InitializeComponent();
            usersCV = new List<UserCV>();
            FetchUsersCV();
            AddCVsToComboBox();
        }

        private void ignoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear CV?", "Warning", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ClearCV();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(nameTextBox.Text) && !String.IsNullOrEmpty(ageTextBox.Text) 
                && !String.IsNullOrEmpty(maritalStatusTextBox.Text) && !String.IsNullOrEmpty(addressTextBox.Text)
                && !String.IsNullOrEmpty(emailTextBox.Text))
            {
                SaveUsersCV();
            }
        }

        private void ClearCV()
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            maritalStatusTextBox.Text = "";
            addressTextBox.Text = "";
            emailTextBox.Text = "";
            foreach (var item in skillsPanel.Children)
            {
                if (item as CheckBox != null)
                {
                    (item as CheckBox)!.IsChecked = false;
                }
            }
        }

        private void SaveUsersCV()
        {
            var skillsList = new List<String>();
            foreach (var item in skillsPanel.Children)
            {
                if (item as CheckBox != null)
                {
                    if((bool)(item as CheckBox)!.IsChecked!)
                    {
                        skillsList.Add(((item as CheckBox)!.Content as String)!);
                    }
                }
            }
            try
            {
                using (FileStream fs = new FileStream("usersCV.json", FileMode.Create))
                {
                    var cv = new UserCV(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text), maritalStatusTextBox.Text, addressTextBox.Text, emailTextBox.Text, skillsList);
                    this.usersCV.Add(cv);
                    JsonSerializer.Serialize<List<UserCV>>(fs, this.usersCV);
                    MessageBox.Show("CV saved!");
                    ClearCV();
                    AddCVsToComboBox();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong(");
            }
        }

        private void FetchUsersCV()
        {
            try
            {
                using (FileStream fs = new FileStream("usersCV.json", FileMode.Open))
                {
                    this.usersCV = JsonSerializer.Deserialize<List<UserCV>>(fs)!;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong(");
            }
        }

        private void AddCVsToComboBox()
        {
            usersList.Items.Clear();
            usersList.Items.Add("New User");
            foreach (var cv in usersCV)
            {
                usersList.Items.Add(cv);
            }
            usersList.SelectedIndex = 0;
        }

        private void usersList_Selected(object sender, RoutedEventArgs e)
        {
            if(usersList.Items.Count > 1) {
                if (usersList.SelectedIndex == 0)
                {
                    ClearCV();
                }
                else if (usersList.SelectedItem as UserCV != null)
                {
                    ClearCV();
                    UserCV cv = (usersList.SelectedItem as UserCV)!;
                    nameTextBox.Text = cv.Name;
                    ageTextBox.Text = cv.Age.ToString();
                    maritalStatusTextBox.Text = cv.MaritalStatus;
                    addressTextBox.Text = cv.Address;
                    emailTextBox.Text = cv.Email;
                    if (cv.Skills != null)
                    {
                        foreach (var skill in skillsPanel.Children)
                        {
                            if (skill as CheckBox != null)
                            {
                                if (cv.Skills.Contains((skill as CheckBox)!.Content))
                                {
                                    (skill as CheckBox)!.IsChecked = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    class UserCV
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String MaritalStatus { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public List<String> Skills { get; set; }

        public UserCV(String name, int age, String maritalStatus, String address, String email, List<String> skills)
        {
            this.Name = name;
            this.Age = age;
            this.MaritalStatus = maritalStatus;
            this.Address = address;
            this.Email = email;
            this.Skills = skills;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
