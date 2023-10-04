using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Modules.RandomButtonGame
{
    class Game
    {
        private readonly RandomButton[] _buttons;
        private bool _isDone;

        public Game()
        {
            _buttons = new RandomButton[10];
        }

        public bool IsDone()
        {
            return _isDone;
        }

        //TODO Utifrån hur metoden 'PrepNewGame' nedan är skriven. Vilken knapp kommer att hamna på _buttons[10]?
        public void PrepNewGame(Control container)
        {
            Random random = new Random(236763541);
            for (int i = 0; i < _buttons.Length; i++)
            {
                RandomButton newButton = new RandomButton(i + 1);
                RandomButton oldButton = _buttons[i];

                newButton.Click += Button_Click;

                int x = random.Next(container.ClientSize.Width - newButton.Width / 2);
                int y = random.Next(container.ClientSize.Height - newButton.Height / 2);
                newButton.Location = new Point(x, y);

                _buttons[i] = newButton;

                if (oldButton != null) container.Controls.Remove(oldButton);
                container.Controls.Add(newButton);
            }

            _isDone = false;
        }
        
        private void Button_Click(object? sender, EventArgs e)
        {
            RandomButton button = sender as RandomButton;

            bool lowerNumberHidden = true;
            for (int i = 0; i < button.Number - 1; i++)
            {
                RandomButton previousButton = _buttons[i];
                if (previousButton.Visible)
                {
                    lowerNumberHidden = false;
                }
            }

            if (lowerNumberHidden)
            {
                button.Hide();

                if (button.Number == _buttons.Length)
                {
                    _isDone = true;
                }
            }
        }
    }
}
