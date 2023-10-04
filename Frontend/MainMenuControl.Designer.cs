
namespace Frontend
{
    partial class MainMenuControl
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
            this.ButtonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlotModuleButton = new System.Windows.Forms.Button();
            this.BrowserModuleButton = new System.Windows.Forms.Button();
            this.FinderModuleButton = new System.Windows.Forms.Button();
            this.RandomModuleButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLayoutPanel
            // 
            this.ButtonLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonLayoutPanel.Controls.Add(this.PlotModuleButton);
            this.ButtonLayoutPanel.Controls.Add(this.BrowserModuleButton);
            this.ButtonLayoutPanel.Controls.Add(this.FinderModuleButton);
            this.ButtonLayoutPanel.Controls.Add(this.RandomModuleButton);
            this.ButtonLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(324, 93);
            this.ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            this.ButtonLayoutPanel.Size = new System.Drawing.Size(159, 330);
            this.ButtonLayoutPanel.TabIndex = 4;
            // 
            // PlotModuleButton
            // 
            this.PlotModuleButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlotModuleButton.Location = new System.Drawing.Point(3, 3);
            this.PlotModuleButton.Name = "PlotModuleButton";
            this.PlotModuleButton.Size = new System.Drawing.Size(153, 47);
            this.PlotModuleButton.TabIndex = 1;
            this.PlotModuleButton.Text = "Grafritare";
            this.PlotModuleButton.UseVisualStyleBackColor = true;
            // 
            // BrowserModuleButton
            // 
            this.BrowserModuleButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BrowserModuleButton.Location = new System.Drawing.Point(3, 56);
            this.BrowserModuleButton.Name = "BrowserModuleButton";
            this.BrowserModuleButton.Size = new System.Drawing.Size(153, 47);
            this.BrowserModuleButton.TabIndex = 2;
            this.BrowserModuleButton.Text = "Browser";
            this.BrowserModuleButton.UseVisualStyleBackColor = true;
            // 
            // FinderModuleButton
            // 
            this.FinderModuleButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FinderModuleButton.Location = new System.Drawing.Point(3, 109);
            this.FinderModuleButton.Name = "FinderModuleButton";
            this.FinderModuleButton.Size = new System.Drawing.Size(153, 47);
            this.FinderModuleButton.TabIndex = 3;
            this.FinderModuleButton.Text = "Filutforskare";
            this.FinderModuleButton.UseVisualStyleBackColor = true;
            // 
            // RandomModuleButton
            // 
            this.RandomModuleButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandomModuleButton.Location = new System.Drawing.Point(3, 162);
            this.RandomModuleButton.Name = "RandomModuleButton";
            this.RandomModuleButton.Size = new System.Drawing.Size(153, 47);
            this.RandomModuleButton.TabIndex = 4;
            this.RandomModuleButton.Text = "Knapplek";
            this.RandomModuleButton.UseVisualStyleBackColor = true;
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(271, 11);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(278, 52);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Välj modul";
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Controls.Add(this.MainLabel);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(819, 495);
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ButtonLayoutPanel;
        private System.Windows.Forms.Button PlotModuleButton;
        private System.Windows.Forms.Button BrowserModuleButton;
        private System.Windows.Forms.Button FinderModuleButton;
        private System.Windows.Forms.Button RandomModuleButton;
        private System.Windows.Forms.Label MainLabel;
    }
}
