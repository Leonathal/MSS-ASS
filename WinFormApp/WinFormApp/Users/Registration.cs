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
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private Button Register;
        private Button button2;
        private TextBox textBox1;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(272, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(293, 23);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of birth";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(293, 23);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(272, 261);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(293, 23);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(272, 315);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(293, 23);
            this.textBox7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(272, 364);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(293, 23);
            this.textBox8.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "User type";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(120, 417);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 14;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(740, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            UserFactory userFactory = null;
            int userId = int.Parse(textBox1.Text);
            Debug.WriteLine("User id: {0}", userId);

            string firstName = textBox2.Text;
            Debug.WriteLine("First name: {0}", firstName);

            string lastName = textBox3.Text;
            Debug.WriteLine("Last name: {0}", lastName);

            int age = int.Parse(textBox4.Text);
            Debug.WriteLine("Age: {0}", age);

            DateTime dateOfBirth = Convert.ToDateTime(textBox5.Text);
            Debug.WriteLine("Date of birth: {0}", dateOfBirth);

            string email = textBox6.Text;
            Debug.WriteLine("Email: {0}", email);

            string password = textBox7.Text;
            Debug.WriteLine("Password: {0}", password);

            string userType = textBox8.Text;
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

            User user = userFactory.GetUserType();
            Debug.WriteLine("\nYour user details are below : \n");
            Debug.WriteLine("User Type: {0}\nFirst name: {1}\nLast name: {2}\nAge: {3}\nDate of birth: {4}\nEmail: {5}\nPassword: {6}\nUser id: {7}",
                user.UserType, user.FirstName, user.LastName, user.Age, user.DateOfBirth, user.Email, user.Password, user.UserId);

            TextWriter tsw = new StreamWriter(@"C:\Users\Andrei Badeci\Documents\Info\Facultate\Master\MSS + ASS\MSS-ASS\Andrei\Cod\WinFormsApp1\jucatori.txt", true);

            //Writing text to the file.
            tsw.WriteLine(user.ToString());

            //Close the file.
            tsw.Close();

        }
    }
}
