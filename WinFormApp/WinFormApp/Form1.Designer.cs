
namespace WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.viewPreferencesButton = new System.Windows.Forms.Button();
            this.enrollActivitiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // viewPreferencesButton
            // 
            this.viewPreferencesButton.Location = new System.Drawing.Point(305, 270);
            this.viewPreferencesButton.Name = "viewPreferencesButton";
            this.viewPreferencesButton.Size = new System.Drawing.Size(175, 33);
            this.viewPreferencesButton.TabIndex = 3;
            this.viewPreferencesButton.Text = "View Preferences";
            this.viewPreferencesButton.UseVisualStyleBackColor = true;
            this.viewPreferencesButton.Click += new System.EventHandler(this.viewPreferencesButton_Click);
            // 
            // enrollActivitiesButton
            // 
            this.enrollActivitiesButton.Location = new System.Drawing.Point(305, 196);
            this.enrollActivitiesButton.Name = "enrollActivitiesButton";
            this.enrollActivitiesButton.Size = new System.Drawing.Size(175, 33);
            this.enrollActivitiesButton.TabIndex = 4;
            this.enrollActivitiesButton.Text = "Enroll in activities";
            this.enrollActivitiesButton.UseVisualStyleBackColor = true;
            this.enrollActivitiesButton.Click += new System.EventHandler(this.enrollActivitiesButton_Click);

            if (_loggedUser.UserType.Equals("FACILITATOR") || _loggedUser.UserType.Equals("ADMIN"))
            {
                this.createEventButton = new System.Windows.Forms.Button();
                this.manageActivitiesButton = new System.Windows.Forms.Button();

                // 
                // createEventButton
                // 
                this.createEventButton.Location = new System.Drawing.Point(305, 47);
                this.createEventButton.Name = "createEventButton";
                this.createEventButton.Size = new System.Drawing.Size(175, 33);
                this.createEventButton.TabIndex = 1;
                this.createEventButton.Text = "Create Event";
                this.createEventButton.UseVisualStyleBackColor = true;
                this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);

                // 
                // manageActivitiesButton
                // 
                this.manageActivitiesButton.Location = new System.Drawing.Point(305, 123);
                this.manageActivitiesButton.Name = "manageActivitiesButton";
                this.manageActivitiesButton.Size = new System.Drawing.Size(175, 33);
                this.manageActivitiesButton.TabIndex = 2;
                this.manageActivitiesButton.Text = "Manage Activities";
                this.manageActivitiesButton.UseVisualStyleBackColor = true;
                this.manageActivitiesButton.Click += new System.EventHandler(this.manageActivitiesButton_Click);
            }

            if (_loggedUser.UserType.Equals("ADMIN"))
            {
                this.resolveComplainButton = new System.Windows.Forms.Button();

                // 
                // resolveComplainButton
                // 
                this.resolveComplainButton.Location = new System.Drawing.Point(305, 339);
                this.resolveComplainButton.Name = "resolveComplainButton";
                this.resolveComplainButton.Size = new System.Drawing.Size(175, 33);
                this.resolveComplainButton.TabIndex = 5;
                this.resolveComplainButton.Text = "Resolve complain";
                this.resolveComplainButton.UseVisualStyleBackColor = true;
                this.resolveComplainButton.Click += new System.EventHandler(this.resolveComplainButton_Click);
            }

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resolveComplainButton);
            this.Controls.Add(this.enrollActivitiesButton);
            this.Controls.Add(this.viewPreferencesButton);
            this.Controls.Add(this.manageActivitiesButton);
            this.Controls.Add(this.createEventButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button manageActivitiesButton;
        private System.Windows.Forms.Button viewPreferencesButton;
        private System.Windows.Forms.Button enrollActivitiesButton;
        private System.Windows.Forms.Button resolveComplainButton;
    }
}

