namespace WinFormApp.EventsActivity.Forms
{
    partial class NewEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createActivityButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.createTeamActivityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createActivityButton
            // 
            this.createActivityButton.Location = new System.Drawing.Point(505, 93);
            this.createActivityButton.Name = "createActivityButton";
            this.createActivityButton.Size = new System.Drawing.Size(175, 33);
            this.createActivityButton.TabIndex = 0;
            this.createActivityButton.Text = "Create Activity";
            this.createActivityButton.UseVisualStyleBackColor = true;
            this.createActivityButton.Click += new System.EventHandler(this.createActivityButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activities";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(142, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 187);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // createTeamActivityButton
            // 
            this.createTeamActivityButton.Location = new System.Drawing.Point(505, 154);
            this.createTeamActivityButton.Name = "createTeamActivityButton";
            this.createTeamActivityButton.Size = new System.Drawing.Size(175, 33);
            this.createTeamActivityButton.TabIndex = 5;
            this.createTeamActivityButton.Text = "Create Team Activity";
            this.createTeamActivityButton.UseVisualStyleBackColor = true;
            this.createTeamActivityButton.Click += new System.EventHandler(this.createTeamActivityButton_Click);
            // 
            // NewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTeamActivityButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createActivityButton);
            this.Name = "NewEventForm";
            this.Text = "New Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createActivityButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button createTeamActivityButton;
    }
}