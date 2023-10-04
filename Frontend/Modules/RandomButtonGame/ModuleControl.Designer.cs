
namespace Frontend.Modules.RandomButtonGame
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GameAreaPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HighScorePanel = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameAreaPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameAreaPanel
            // 
            this.GameAreaPanel.Controls.Add(this.StartButton);
            this.GameAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameAreaPanel.Location = new System.Drawing.Point(0, 0);
            this.GameAreaPanel.Name = "GameAreaPanel";
            this.GameAreaPanel.Size = new System.Drawing.Size(619, 544);
            this.GameAreaPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HighScorePanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(619, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 544);
            this.panel2.TabIndex = 1;
            // 
            // HighScorePanel
            // 
            this.HighScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HighScorePanel.Location = new System.Drawing.Point(0, 150);
            this.HighScorePanel.Name = "HighScorePanel";
            this.HighScorePanel.Size = new System.Drawing.Size(300, 394);
            this.HighScorePanel.TabIndex = 1;
            this.HighScorePanel.TabStop = false;
            this.HighScorePanel.Text = "High Score";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClockLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 150);
            this.panel3.TabIndex = 0;
            // 
            // ClockLabel
            // 
            this.ClockLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockLabel.Location = new System.Drawing.Point(-9, 29);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(306, 96);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "00:00:00";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(246, 227);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 34);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameAreaPanel);
            this.Controls.Add(this.panel2);
            this.Name = "ModuleControl";
            this.Size = new System.Drawing.Size(919, 544);
            this.GameAreaPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel GameAreaPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox HighScorePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Button StartButton;
    }
}
