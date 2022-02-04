using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinFormsApp;

namespace WinFormApp
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationForm = new WinFormsApp.RegistrationForm();
            registrationForm.Closed += (s, args) => this.Close();
            registrationForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Andrei Badeci\Documents\Info\Facultate\Master\MSS + ASS\MSS-ASS\WinFormApp\WinFormApp\jucatori.txt");

            UserFactory userFactory = null;
            int userId = 0;
            string firstName = "";
            string lastName = "";
            int age = 0;
            DateTime dateOfBirth = Convert.ToDateTime("01/01/1901");
            string email = "";
            string password = "";
            string userType = "";

            string emailLogin = emailTextBox.Text;
            Debug.WriteLine("Email: {0}", emailLogin);

            string passwordLogin = passwordTextBox.Text;
            Debug.WriteLine("Password: {0}", passwordLogin);
            
            if (emailLogin.Length > 0 && passwordLogin.Length > 0)
            {
                foreach (string line in lines)
                {
                    if (line.Contains(emailLogin) && line.Contains(passwordLogin))
                    {
                        string[] words = line.Split(",");
                        foreach (string word in words)
                        {
                            Debug.WriteLine("word is ", word);
                            switch (word)
                            {
                                case string userTypeWord when word.Contains("User Type"):
                                    userType = userTypeWord.Substring(userTypeWord.IndexOf(":") + 2);
                                    Debug.WriteLine("User Type is: {0}", userType);
                                    break;
                                case string firstNameWord when word.Contains("First name"):
                                    firstName = firstNameWord.Substring(firstNameWord.IndexOf(":") + 2);
                                    Debug.WriteLine("First name is: {0}", firstName);
                                    break;
                                case string lastNameWord when word.Contains("Last name"):
                                    lastName = lastNameWord.Substring(lastNameWord.IndexOf(":") + 2);
                                    Debug.WriteLine("Last name is: {0}", lastName);
                                    break;
                                case string ageWord when word.Contains("Age"):
                                    age = int.Parse(ageWord.Substring(ageWord.IndexOf(":") + 2));
                                    Debug.WriteLine("Age is: {0}", age);
                                    break;
                                case string dateOfBirthWord when word.Contains("Date of birth"):
                                    dateOfBirth = Convert.ToDateTime(dateOfBirthWord.Substring(dateOfBirthWord.IndexOf(":") + 2));
                                    Debug.WriteLine("Date of birth is: {0}", dateOfBirth);
                                    break;
                                case string emailWord when word.Contains("Email"):
                                    email = emailWord.Substring(emailWord.IndexOf(":") + 2);
                                    Debug.WriteLine("Email is: {0}", email);
                                    break;
                                case string passwordWord when word.Contains("Password: "):
                                    password = passwordWord.Substring(passwordWord.IndexOf(":") + 2);
                                    Debug.WriteLine("Password is: {0}", password);
                                    break;
                                case string userIdWord when word.Contains("User id"):
                                    userId = int.Parse(userIdWord.Substring(userIdWord.IndexOf(":") + 2));
                                    Debug.WriteLine("UserId is: {0}", userId);
                                    break;
                                default:
                                    break;
                            }

                            Debug.WriteLine("\n\n");
                        }
                    }
                }
            }

            switch (userType.ToLower())
            {
                case "admin":
                    userFactory = new AdminFactory(userId, firstName, lastName, age, dateOfBirth, email, password);
                    break;
                case "facilitator":
                    userFactory = new FacilitatorFactory(userId, firstName, lastName, age, dateOfBirth, email, password);
                    break;
                case "player":
                    userFactory = new PlayerFactory(userId, firstName, lastName, age, dateOfBirth, email, password);
                    break;
                default:
                    break;
            }
            if(userFactory != null) 
            { 
            User user = userFactory.GetUserType();
            Debug.WriteLine("\nYour user fetched details are below : \n");
            Debug.WriteLine("User Type: {0}\nFirst name: {1}\nLast name: {2}\nAge: {3}\nDate of birth: {4}\nEmail: {5}\nPassword: {6}\nUser id: {7}",
                user.UserType, user.FirstName, user.LastName, user.Age, user.DateOfBirth, user.Email, user.Password, user.UserId);
            String userToTxtFile = "User Type: " + user.UserType + ", First name: " + user.FirstName + ", Last name: " + user.LastName + ", Age: " + user.Age
                + ", Date of birth: " + user.DateOfBirth + ", Email: " + user.Email + ", Password: " + user.Password + ", User id: " + user.UserId;
                this.Hide();
                var form1 = new WinFormApp.Form1(user);
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            } else
            {
                Debug.WriteLine("User is null");
            }


        }
    }
}
