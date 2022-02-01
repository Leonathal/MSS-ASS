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
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createActivityButton);
            this.Name = "NewActivityForm";
            this.Text = "NewActivityForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createActivityButton;
    }
}