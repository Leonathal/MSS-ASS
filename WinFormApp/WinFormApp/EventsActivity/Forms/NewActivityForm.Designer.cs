namespace WinFormApp.EventsActivity.Forms
{
    partial class NewActivityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.activityNameTextBox = new System.Windows.Forms.TextBox();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createActivityButton
            // 
            this.createActivityButton.Location = new System.Drawing.Point(595, 391);
            this.createActivityButton.Name = "createActivityButton";
            this.createActivityButton.Size = new System.Drawing.Size(175, 33);
            this.createActivityButton.TabIndex = 1;
            this.createActivityButton.Text = "Submit";
            this.createActivityButton.UseVisualStyleBackColor = true;
            this.createActivityButton.Click += new System.EventHandler(this.createActivityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Activity name";
            // 
            // activityNameTextBox
            // 
            this.activityNameTextBox.Location = new System.Drawing.Point(158, 24);
            this.activityNameTextBox.Name = "activityNameTextBox";
            this.activityNameTextBox.Size = new System.Drawing.Size(209, 23);
            this.activityNameTextBox.TabIndex = 3;
            // 
            // timePickerStart
            // 
            this.timePickerStart.Location = new System.Drawing.Point(158, 112);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(209, 23);
            this.timePickerStart.TabIndex = 5;
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.Location = new System.Drawing.Point(561, 113);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(209, 23);
            this.timePickerEnd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time slot start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(447, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time slot end";
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(187, 185);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(121, 23);
            this.categoryCombo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.timePickerStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activityNameTextBox);
            this.Controls.Add(this.createActivityButton);
            this.Name = "NewActivityForm";
            this.Text = "NewActivityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createActivityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox activityNameTextBox;
        private System.Windows.Forms.DateTimePicker timePickerStart;
        private System.Windows.Forms.DateTimePicker timePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label4;
    }
}