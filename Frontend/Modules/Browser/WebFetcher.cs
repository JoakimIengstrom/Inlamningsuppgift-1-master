using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace Frontend.Modules.Browser
{
    class WebFetcher
    {
        // TODO Vad används ett HttpClient objekt för i denna klassen?
        private static readonly HttpClient HttpClient = new HttpClient();
        private readonly ProgressBar _progressBar;

        public WebFetcher(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }

        public async Task<string> FetchSearch(string search)
        {
            if (!search.StartsWith("https://") && !search.StartsWith("http://"))
                search = "https://" + search;

            EmptyProgressbar();

            var uri = new Uri(search);

            using var response = await HttpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            using var stream = await response.Content.ReadAsStreamAsync();

            var sb = new StringBuilder();
            var buffer = new byte[1024];
            int bytesReceived;
            do
            {
                bytesReceived = await stream.ReadAsync(buffer, 0, 1024);
                string textSnippet = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                sb.Append(textSnippet);

                IncreaseProgressbar();
            } while (bytesReceived > 0);

            FillProgressbar();
            await Task.Delay(1000);
            EmptyProgressbar();

            return sb.ToString();
        }

        private void EmptyProgressbar()
        {
            _progressBar.Value = _progressBar.Minimum;
        }
        private void IncreaseProgressbar()
        {
            _progressBar.Value += (_progressBar.Maximum - _progressBar.Value) / 4;
        }
        private void FillProgressbar()
        {
            _progressBar.Value = _progressBar.Maximum;
        }
    }

}
