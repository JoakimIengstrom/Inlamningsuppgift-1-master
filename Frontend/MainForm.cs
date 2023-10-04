using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend.Modules;
using Frontend.Modules.Browser;
using Frontend.Modules.Plot;
using Microsoft.VisualBasic.CompilerServices;

namespace Frontend
{
    public partial class MainForm : Form
    {
        //TODO Vad är skillnaden på en vanlig metod och en konstruktor som 'MainForm'?
        public MainForm()
        {
            InitializeComponent();

            var menuManager = new MenuManager(this);
            menuManager.SwitchToMainMenu();
        }
    }
}