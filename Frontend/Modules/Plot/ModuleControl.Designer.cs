
namespace Frontend.Modules.Plot
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.PlaceholderButton = new System.Windows.Forms.Button();
            this.PlotView = new OxyPlot.WindowsForms.PlotView();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.PlaceholderButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(194, 709);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // PlaceholderButton
            // 
            this.PlaceholderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaceholderButton.Location = new System.Drawing.Point(0, 0);
            this.PlaceholderButton.Margin = new System.Windows.Forms.Padding(6);
            this.PlaceholderButton.Name = "PlaceholderButton";
            this.PlaceholderButton.Size = new System.Drawing.Size(194, 34);
            this.PlaceholderButton.TabIndex = 0;
            this.PlaceholderButton.Text = "placeholder";
            this.PlaceholderButton.UseVisualStyleBackColor = true;
            // 
            // PlotView
            // 
            this.PlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlotView.Location = new System.Drawing.Point(194, 0);
            this.PlotView.Name = "PlotView";
            this.PlotView.Padding = new System.Windows.Forms.Padding(10);
            this.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotView.Size = new System.Drawing.Size(1090, 709);
            this.PlotView.TabIndex = 1;
            this.PlotView.Text = "Plot View";
            this.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // PlotModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlotView);
            this.Controls.Add(this.ButtonsPanel);
            this.Name = "PlotModule";
            this.Size = new System.Drawing.Size(1284, 709);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button PlaceholderButton;
        private OxyPlot.WindowsForms.PlotView PlotView;
    }
}
