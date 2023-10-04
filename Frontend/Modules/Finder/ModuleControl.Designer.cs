
namespace Frontend.Modules.Finder
{
    partial class ModuleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CurrentPathDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveUpIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderContents = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveUpIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.CurrentPathDisplay);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.MoveUpIcon);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.HeaderPanel.Size = new System.Drawing.Size(870, 43);
            this.HeaderPanel.TabIndex = 1;
            // 
            // CurrentPathDisplay
            // 
            this.CurrentPathDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPathDisplay.Location = new System.Drawing.Point(159, 5);
            this.CurrentPathDisplay.Name = "CurrentPathDisplay";
            this.CurrentPathDisplay.ReadOnly = true;
            this.CurrentPathDisplay.Size = new System.Drawing.Size(671, 31);
            this.CurrentPathDisplay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuvarande folder:";
            // 
            // MoveUpIcon
            // 
            this.MoveUpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoveUpIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoveUpIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoveUpIcon.Image = global::Frontend.Properties.Resources.arrow_up;
            this.MoveUpIcon.InitialImage = global::Frontend.Properties.Resources.arrow_up;
            this.MoveUpIcon.Location = new System.Drawing.Point(830, 5);
            this.MoveUpIcon.Margin = new System.Windows.Forms.Padding(6);
            this.MoveUpIcon.Name = "MoveUpIcon";
            this.MoveUpIcon.Size = new System.Drawing.Size(35, 33);
            this.MoveUpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoveUpIcon.TabIndex = 2;
            this.MoveUpIcon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FolderContents);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(870, 533);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Innehåll";
            // 
            // FolderContents
            // 
            this.FolderContents.AutoScroll = true;
            this.FolderContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderContents.Location = new System.Drawing.Point(10, 34);
            this.FolderContents.Margin = new System.Windows.Forms.Padding(0);
            this.FolderContents.Name = "FolderContents";
            this.FolderContents.Size = new System.Drawing.Size(850, 489);
            this.FolderContents.TabIndex = 2;
            // 
            // ModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "ModuleControl";
            this.Size = new System.Drawing.Size(870, 576);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveUpIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox CurrentPathDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MoveUpIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel FolderContents;
    }
}
