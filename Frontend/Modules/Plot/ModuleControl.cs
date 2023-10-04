using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace Frontend.Modules.Plot
{
    // BUG Funktionen "x^2" (x upphöjt till två) ska se ut som en uppvänd parabol (https://www.wolframalpha.com/input/?i=x%5E2).
    // Kolla om det inte är någon miss som skett.
    public partial class ModuleControl : UserControl
    {
        private readonly FunctionCollection _funcCollection;

        public ModuleControl()
        {
            InitializeComponent();
            PlotView.Model = new PlotModel();

            PlaceholderButton.Hide();

            _funcCollection = new FunctionCollection();

            string[] functionTexts = _funcCollection.GetAvailableFunctions();
            for (int i = 0; i < functionTexts.Length; i++)
            {
                string function = functionTexts[i];
                var button = MakeButton(function);

                button.Click += Button_Click;
                ButtonsPanel.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            var series = _funcCollection.CreateDataForPlot(button.Text);
            SwapInNewSeries(series);
        }

        private void SwapInNewSeries(Series series)
        {
            PlotView.Model.Series.Clear();
            PlotView.Model.Series.Add(series);

            // Säger till OxyPlot att skapa om hela grafen på nytt
            PlotView.Model.InvalidatePlot(true);
            PlotView.Invalidate();
        }

        private Button MakeButton(string name)
        {
            Button newButton = new Button
            {
                Dock = DockStyle.Top,
                Location = new Point(0, 0),
                Margin = new Padding(6),
                Name = "Button",
                Size = new Size(194, 34),
                TabIndex = 0,
                Text = name,
                UseVisualStyleBackColor = true
            };

            return newButton;
        }
    }
}
