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
        //Constructors are a special methods used to initiazing objects of a class. They are called at the instance when an object is created. 
        //While a metod is used to preform action such as returns and calculation, adding and store information. 
        public MainForm()
        {
            InitializeComponent();

            var menuManager = new MenuManager(this);
            menuManager.SwitchToMainMenu();
        }
    }
}