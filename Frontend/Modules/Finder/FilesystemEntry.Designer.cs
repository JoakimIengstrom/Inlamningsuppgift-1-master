
namespace Frontend.Modules.Finder
{
    partial class FileSystemEntry
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
            this.Label = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(132, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "placeholder file";
            // 
            // Icon
            // 
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Icon.Dock = System.Windows.Forms.DockStyle.Right;
            this.Icon.Image = global::Frontend.Properties.Resources.eye;
            this.Icon.InitialImage = global::Frontend.Properties.Resources.eye;
            this.Icon.Location = new System.Drawing.Point(258, 0);
            this.Icon.Margin = new System.Windows.Forms.Padding(6);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(32, 30);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 3;
            this.Icon.TabStop = false;
            // 
            // FileSystemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.Label);
            this.Name = "FileSystemEntry";
            this.Size = new System.Drawing.Size(290, 30);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox Icon;
    }
}
