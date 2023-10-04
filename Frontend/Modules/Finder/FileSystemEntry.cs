using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Modules.Finder
{
    public partial class FileSystemEntry : UserControl
    {
        public FileSystemEntry(string name, Color info, Bitmap eye, EventHandler handler)
        {
            InitializeComponent();

            Name = name;
            Label.Text = name;

            BackColor = info;

            Icon.Image = eye;
            Icon.InitialImage = eye;

            Icon.Click += handler;
        }
    }
}
