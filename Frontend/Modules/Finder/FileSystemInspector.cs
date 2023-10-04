using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Modules.Finder
{
    class FileSystemInspector
    {
        // TODO Vad innebär det att _currentDirectory är 'private'? Varför är inte TryGoDown också 'private'?
        private DirectoryInfo _currentDirectory;

        public FileSystemInspector()
        {
            _currentDirectory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public void TryGoUp()
        {
            _currentDirectory = _currentDirectory.Parent;
        }

        public void TryGoDown(string name)
        {
            foreach (var dir in _currentDirectory.EnumerateDirectories())
            {
                if (dir.Name == name)
                {
                    _currentDirectory = dir;
                    break;
                }
            }
        }

        public string ViewFileFirstNChars(string name, int n)
        {
            FileInfo fileToView = null;

            // TODO Finns det någon nackdel med att använda for-loopar istället för foreach-loopar?
            // Skriv om denna foreach-loopen nedan till en for-loop istället.
            // Använd '_currentDirectory.GetFiles' istället för '_currentDirectory.EnumerateFiles'
            foreach (var file in _currentDirectory.EnumerateFiles())
            {
                if (file.Name == name)
                {
                    fileToView = file;
                    break;
                }
            }

            using var sr = fileToView.OpenText();
            var contents = sr.ReadToEnd();
            var snippet = contents.Substring(0, Math.Min(n, contents.Length));

            return snippet;
        }

        public IEnumerable<string> AllFileNames =>
            _currentDirectory.GetFiles().Select(i => i.Name);
        public IEnumerable<string> AllDirectoryNames =>
            _currentDirectory.GetDirectories().Select(i => i.Name);

        public string CurrentPath => _currentDirectory.FullName;
    }
}
