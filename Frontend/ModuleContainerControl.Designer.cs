
namespace Frontend
{
    partial class ModuleContainerControl
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ModulePanel = new System.Windows.Forms.Panel();
            this.ModuleName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnButton.Location = new System.Drawing.Point(815, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(132, 35);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Tillbaka";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // ModulePanel
            // 
            this.ModulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModulePanel.Location = new System.Drawing.Point(0, 35);
            this.ModulePanel.Name = "ModulePanel";
            this.ModulePanel.Size = new System.Drawing.Size(947, 561);
            this.ModulePanel.TabIndex = 6;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSize = true;
            this.ModuleName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModuleName.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModuleName.Location = new System.Drawing.Point(0, 0);
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Size = new System.Drawing.Size(205, 33);
            this.ModuleName.TabIndex = 5;
            this.ModuleName.Text = "Placeholder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ModuleName);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 35);
            this.panel1.TabIndex = 8;
            // 
            // ModuleContainerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModulePanel);
            this.Controls.Add(this.panel1);
            this.Name = "ModuleContainerControl";
            this.Size = new System.Drawing.Size(947, 596);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel ModulePanel;
        private System.Windows.Forms.Label ModuleName;
        private System.Windows.Forms.Panel panel1;
    }
}
