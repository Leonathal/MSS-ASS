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
            this.createTeamActivityButton = new System.Windows.Forms.Button();
            this.activitiesListView = new System.Windows.Forms.ListView();
            this.removeActivityButton = new System.Windows.Forms.Button();
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
            // activitiesListView
            // 
            this.activitiesListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activitiesListView.HideSelection = false;
            this.activitiesListView.Location = new System.Drawing.Point(158, 90);
            this.activitiesListView.Name = "activitiesListView";
            this.activitiesListView.Size = new System.Drawing.Size(296, 200);
            this.activitiesListView.TabIndex = 6;
            this.activitiesListView.UseCompatibleStateImageBehavior = false;
            // 
            // removeActivityButton
            // 
            this.removeActivityButton.Location = new System.Drawing.Point(505, 219);
            this.removeActivityButton.Name = "removeActivityButton";
            this.removeActivityButton.Size = new System.Drawing.Size(175, 33);
            this.removeActivityButton.TabIndex = 7;
            this.removeActivityButton.Text = "Remove Activity";
            this.removeActivityButton.UseVisualStyleBackColor = true;
            this.removeActivityButton.Click += new System.EventHandler(this.removeActivityButton_Click);
            // 
            // NewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 323);
            this.Controls.Add(this.removeActivityButton);
            this.Controls.Add(this.activitiesListView);
            this.Controls.Add(this.createTeamActivityButton);
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
        private System.Windows.Forms.Button createTeamActivityButton;
        private System.Windows.Forms.ListView activitiesListView;
        private System.Windows.Forms.Button removeActivityButton;
        private System.Windows.Forms.ColumnHeader activityName;
    }
}