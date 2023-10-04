using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public class MenuManager
    {
        private readonly Form _mainForm;
        
        public MenuManager(Form mainForm)
        {
            _mainForm = mainForm;
        }

        //TODO Vad är 'this' just i denna koden?
        public void SwitchToMainMenu()
        {
            SwitchToControl(new MainMenuControl(this));
        }

        public void SwitchToModule(string name, UserControl module)
        {
            SwitchToControl(new ModuleContainerControl(this, name, module));
        }

        private void SwitchToControl(Control control)
        {
            control.Dock = DockStyle.Fill;

            _mainForm.Controls.Clear();
            _mainForm.Controls.Add(control);
        }
    }
}
