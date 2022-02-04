using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace WinFormsApp
{
    public partial class RegistrationForm : Form
    {
        private Label userIdLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Label dateOfBirthLabel;
        private TextBox dateOfBirthTextBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox userTypeTextBox;
        private Label userTypeLabel;
        private Button registerButton;
        private Button loginButton;
        private TextBox userIdTextBox;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userTypeTextBox = new System.Windows.Forms.TextBox();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(177, 35);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(43, 15);
            this.userIdLabel.TabIndex = 0;
            this.userIdLabel.Text = "User id";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(272, 32);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(293, 23);
            this.userIdTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(272, 79);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(293, 23);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(177, 82);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(62, 15);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(272, 120);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(293, 23);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(177, 123);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last name";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(272, 211);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(293, 23);
            this.ageTextBox.TabIndex = 7;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(177, 214);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(28, 15);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(177, 163);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(73, 15);
            this.dateOfBirthLabel.TabIndex = 6;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(272, 160);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(293, 23);
            this.dateOfBirthTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(272, 261);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(293, 23);
            this.emailTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(177, 264);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(272, 315);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(293, 23);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(177, 318);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // userTypeTextBox
            // 
            this.userTypeTextBox.Location = new System.Drawing.Point(272, 364);
            this.userTypeTextBox.Name = "userTypeTextBox";
            this.userTypeTextBox.Size = new System.Drawing.Size(293, 23);
            this.userTypeTextBox.TabIndex = 13;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Location = new System.Drawing.Point(177, 367);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(56, 15);
            this.userTypeLabel.TabIndex = 12;
            this.userTypeLabel.Text = "User type";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(177, 417);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.Register_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(490, 417);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // RegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(740, 486);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.userTypeTextBox);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.userIdLabel);
            this.Name = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Register_Click(object sender, EventArgs e)
        {
            UserFactory userFactory = null;
            if (userIdTextBox.Text.Length > 0 && firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0 && ageTextBox.Text.Length > 0 &&
                dateOfBirthTextBox.Text.Length > 0 && emailTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0 && userTypeTextBox.Text.Length > 0)
            {
                int userId = int.Parse(userIdTextBox.Text);
                Debug.WriteLine("User id: {0}", userId);

                string firstName = firstNameTextBox.Text;
                Debug.WriteLine("First name: {0}", firstName);

                string lastName = lastNameTextBox.Text;
                Debug.WriteLine("Last name: {0}", lastName);

                int age = int.Parse(ageTextBox.Text);
                Debug.WriteLine("Age: {0}", age);

                DateTime dateOfBirth = Convert.ToDateTime(dateOfBirthTextBox.Text);
                Debug.WriteLine("Date of birth: {0}", dateOfBirth);

                string email = emailTextBox.Text;
                Debug.WriteLine("Email: {0}", email);

                string password = passwordTextBox.Text;
                Debug.WriteLine("Password: {0}", password);

                string userType = userTypeTextBox.Text;
                Debug.WriteLine("User type: {0}", userType);


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
            }
            if (userFactory != null)
            {
                User user = userFactory.GetUserType();
                Debug.WriteLine("\nYour user details are below : \n");
                Debug.WriteLine("User Type: {0}\nFirst name: {1}\nLast name: {2}\nAge: {3}\nDate of birth: {4}\nEmail: {5}\nPassword: {6}\nUser id: {7}",
                    user.UserType, user.FirstName, user.LastName, user.Age, user.DateOfBirth, user.Email, user.Password, user.UserId);
                String userToTxtFile = "User Type: " + user.UserType + ", First name: " + user.FirstName + ", Last name: " + user.LastName + ", Age: " + user.Age
                    + ", Date of birth: " + user.DateOfBirth + ", Email: " + user.Email + ", Password: " + user.Password + ", User id: " + user.UserId + "\n";

                TextWriter tsw = new StreamWriter(@"C:\Users\Andrei Badeci\Documents\Info\Facultate\Master\MSS + ASS\MSS-ASS\WinFormApp\WinFormApp\jucatori.txt", true);

                //Writing text to the file.
                tsw.WriteLine(userToTxtFile);

                //Close the file.
                tsw.Close();

                this.Hide();
                var loginForm = new WinFormApp.Login();
                loginForm.Closed += (s, args) => this.Close();
                loginForm.Show();
            } else
            {
                Debug.WriteLine("User is null");
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new WinFormApp.Login();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
