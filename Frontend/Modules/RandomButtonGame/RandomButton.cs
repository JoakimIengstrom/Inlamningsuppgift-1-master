using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Modules.RandomButtonGame
{
    public partial class RandomButton : UserControl
    {
        public readonly int Number;
        public RandomButton(int number)
        {
            InitializeComponent();

            Number = number;
            Button.Text = "#" + number;

            Button.Click += RandomButton_Click;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, e);
        }
    }
}
