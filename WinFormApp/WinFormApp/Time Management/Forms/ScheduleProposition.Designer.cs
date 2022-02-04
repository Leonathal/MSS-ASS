
namespace WinFormApp.TimeManagement.Forms
{
    partial class ScheduleProposition
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
            this.activityListView = new System.Windows.Forms.ListView();
            this.selectActivity = new System.Windows.Forms.ColumnHeader();
            this.activityName = new System.Windows.Forms.ColumnHeader();
            this.activityStart = new System.Windows.Forms.ColumnHeader();
            this.activityEnd = new System.Windows.Forms.ColumnHeader();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activityListView
            // 
            this.activityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectActivity,
            this.activityName,
            this.activityStart,
            this.activityEnd});
            this.activityListView.HideSelection = false;
            this.activityListView.Location = new System.Drawing.Point(12, 12);
            this.activityListView.Name = "activityListView";
            this.activityListView.OwnerDraw = true;
            this.activityListView.Size = new System.Drawing.Size(536, 285);
            this.activityListView.TabIndex = 0;
            this.activityListView.UseCompatibleStateImageBehavior = false;
            this.activityListView.View = System.Windows.Forms.View.Details;
            this.activityListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.activityListView_ColumnClick);
            this.activityListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.activityListView_DrawColumnHeader);
            this.activityListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.activityListView_DrawItem);
            this.activityListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.activityListView_DrawSubItem);
            // 
            // selectActivity
            // 
            this.selectActivity.Text = "";
            this.selectActivity.Width = 30;
            // 
            // activityName
            // 
            this.activityName.Text = "Activity name";
            this.activityName.Width = 200;
            // 
            // activityStart
            // 
            this.activityStart.Text = "Start Time";
            this.activityStart.Width = 150;
            // 
            // activityEnd
            // 
            this.activityEnd.Text = "End Time";
            this.activityEnd.Width = 150;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(445, 311);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 31);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(336, 311);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 31);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // ScheduleProposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 354);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.activityListView);
            this.Name = "ScheduleProposition";
            this.Text = "Schedule Proposition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView activityListView;
        private System.Windows.Forms.ColumnHeader activityName;
        private System.Windows.Forms.ColumnHeader activityStart;
        private System.Windows.Forms.ColumnHeader activityEnd;
        private System.Windows.Forms.ColumnHeader selectActivity;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
    }
}