using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Modules.Browser
{
    // BUG Normalt sett ska de tio vanligaste orden i hemsidan dyka upp, men nu kommer inga ord. Bara sifforna 1 - 10
    /*
       Länken (http://www.textfiles.com/stories/3gables.txt) ska till exempel ge:
       1: the
       2: I
       3: a
       4: to
       5: of
       6: and
       7: you
       8: was
       9: that
       10: in
     */
    public partial class ModuleControl : UserControl
    {
        private readonly WebFetcher _webFetcher;

        public ModuleControl()
        {
            InitializeComponent();

            SearchBar.GotFocus += SearchBar_GotFocus;
            SearchBar.KeyPress += SearchBar_KeyPress;

            _webFetcher = new WebFetcher(ProgressBar);
        }

        private async void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            e.Handled = true;

            string pageContent;

            // TODO Vad gör denna try/catch-satsen och varför är det lägligt att skriva den här och inte innuti FetchSearch() metoden?
            try
            {
                pageContent = await _webFetcher.FetchSearch(SearchBar.Text);
            }
            catch (Exception exception) when (exception is 
                    UriFormatException or 
                    HttpRequestException)
            {
                pageContent = exception.Message;
            }

            BrowserOutput.Text = pageContent;

            var words = WordHandler.SplitTextIntoWords(pageContent);
            var topTen = WordHandler.GetTopTenMostFrequent(words);

            string formatted = "";
            for (int i = 0; i < topTen.Length; i++)
            {
                formatted += $"{i + 1}: {topTen[i]}{Environment.NewLine}";
            }
            WordRankingOutput.Text = formatted;
        }

        private void SearchBar_GotFocus(object sender, EventArgs e)
        {
            SearchBar.Text = "";
        }
    }
}
