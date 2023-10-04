using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class ModuleContainerControl : UserControl
    {
        private readonly MenuManager _menuManager;

        public ModuleContainerControl(MenuManager menuManager, string name, UserControl module)
        {
            InitializeComponent();
            _menuManager = menuManager;

            ReturnButton.Click += ReturnButton_Click;
            ModuleName.Text = name;

            ModulePanel.Controls.Add(module);

            module.Dock = DockStyle.Fill;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            _menuManager.SwitchToMainMenu();
        }
    }
}
