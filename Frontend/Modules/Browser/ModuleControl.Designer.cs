
namespace Frontend.Modules.Browser
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrowserOutput = new System.Windows.Forms.TextBox();
            this.WordRanking = new System.Windows.Forms.GroupBox();
            this.WordRankingOutput = new System.Windows.Forms.TextBox();
            this.HeaderPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WordRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.SearchBar);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.ProgressBar);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(867, 40);
            this.HeaderPanel.TabIndex = 0;
            // 
            // SearchBar
            // 
            this.SearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBar.Location = new System.Drawing.Point(63, 0);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(804, 31);
            this.SearchBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Besök:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.ProgressBar.Location = new System.Drawing.Point(0, 30);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(867, 10);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrowserOutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultat fönster";
            // 
            // BrowserOutput
            // 
            this.BrowserOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowserOutput.Location = new System.Drawing.Point(3, 27);
            this.BrowserOutput.Multiline = true;
            this.BrowserOutput.Name = "BrowserOutput";
            this.BrowserOutput.ReadOnly = true;
            this.BrowserOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BrowserOutput.Size = new System.Drawing.Size(561, 474);
            this.BrowserOutput.TabIndex = 0;
            this.BrowserOutput.WordWrap = false;
            // 
            // WordRanking
            // 
            this.WordRanking.Controls.Add(this.WordRankingOutput);
            this.WordRanking.Dock = System.Windows.Forms.DockStyle.Right;
            this.WordRanking.Location = new System.Drawing.Point(567, 40);
            this.WordRanking.Name = "WordRanking";
            this.WordRanking.Size = new System.Drawing.Size(300, 504);
            this.WordRanking.TabIndex = 1;
            this.WordRanking.TabStop = false;
            this.WordRanking.Text = "Vanligaste orden";
            // 
            // WordRankingOutput
            // 
            this.WordRankingOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.WordRankingOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordRankingOutput.Location = new System.Drawing.Point(55, 27);
            this.WordRankingOutput.Multiline = true;
            this.WordRankingOutput.Name = "WordRankingOutput";
            this.WordRankingOutput.ReadOnly = true;
            this.WordRankingOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordRankingOutput.Size = new System.Drawing.Size(242, 474);
            this.WordRankingOutput.TabIndex = 1;
            this.WordRankingOutput.WordWrap = false;
            // 
            // ModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WordRanking);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "ModuleControl";
            this.Size = new System.Drawing.Size(867, 544);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WordRanking.ResumeLayout(false);
            this.WordRanking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BrowserOutput;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.GroupBox WordRanking;
        private System.Windows.Forms.TextBox WordRankingOutput;
    }
}
