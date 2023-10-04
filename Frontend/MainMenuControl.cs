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
    public partial class MainMenuControl : UserControl
    {
        private readonly MenuManager _menuManager;

        public MainMenuControl(MenuManager menuManager)
        {
            InitializeComponent();
            _menuManager = menuManager;

            PlotModuleButton.Click += PlotModuleButton_Click;
            BrowserModuleButton.Click += BrowserModuleButton_Click;
            FinderModuleButton.Click += FinderModuleButton_Click;
            RandomModuleButton.Click += RandomModuleButton_Click;
        }

        private void RandomModuleButton_Click(object sender, EventArgs e)
        {
            _menuManager.SwitchToModule(RandomModuleButton.Text, new Modules.RandomButtonGame.ModuleControl());
        }

        private void FinderModuleButton_Click(object sender, EventArgs e)
        {
            _menuManager.SwitchToModule(FinderModuleButton.Text, new Modules.Finder.ModuleControl());
        }

        private void BrowserModuleButton_Click(object sender, EventArgs e)
        {
            _menuManager.SwitchToModule(BrowserModuleButton.Text, new Modules.Browser.ModuleControl());
        }

        private void PlotModuleButton_Click(object sender, EventArgs e)
        {
            _menuManager.SwitchToModule(PlotModuleButton.Text, new Modules.Plot.ModuleControl());
        }
    }
}
