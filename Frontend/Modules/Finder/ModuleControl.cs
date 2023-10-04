using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Modules.Finder
{
    // BUG Programmet kraschar med ett undantag om man forstätter att gå upp en folder
    // Normalt sett ska inget hända om man fortsätter gå upp när man redan står i root foldern (t.ex. "C:\")
    // 
    public partial class ModuleControl : UserControl
    {
        private readonly FileSystemInspector _inspector;

        public ModuleControl()
        {
            InitializeComponent();

            MoveUpIcon.Click += MoveUpIcon_Click;

            _inspector = new FileSystemInspector();
            UpdateVisuals();
        }

        private void MoveUpIcon_Click(object sender, EventArgs e)
        {
            _inspector.TryGoUp();
            UpdateVisuals();
        }

        private void MoveDownIcon_Click(object sender, EventArgs e)
        {
            var icon = sender as PictureBox;
            var entry = icon.Parent as FileSystemEntry;

            _inspector.TryGoDown(entry.Name);
            UpdateVisuals();
        }

        private void EyeFileIcon_Click(object sender, EventArgs e)
        {
            var icon = sender as PictureBox;
            var entry = icon.Parent as FileSystemEntry;

            var snippet = _inspector.ViewFileFirstNChars(entry.Name, 400);
            MessageBox.Show(snippet, entry.Name, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void UpdateVisuals()
        {
            CurrentPathDisplay.Text = _inspector.CurrentPath;

            FolderContents.Controls.Clear();

            foreach (var name in _inspector.AllFileNames)
            {
                var entry = MakeFileEntry(name);
                AddEntryToContents(entry);
            }
            foreach (var name in _inspector.AllDirectoryNames)
            {
                var entry = MakeDirectoryEntry(name);
                AddEntryToContents(entry);
            }
        }

        private void AddEntryToContents(Control entry)
        {
            entry.Dock = DockStyle.Top;
            FolderContents.Controls.Add(entry);
        }
        private FileSystemEntry MakeFileEntry(string name)
        {
            var entry = new FileSystemEntry(name, SystemColors.Info, Properties.Resources.eye, EyeFileIcon_Click);
            return entry;
        }
        private FileSystemEntry MakeDirectoryEntry(string name)
        {
            var entry = new FileSystemEntry(name, SystemColors.ActiveCaption, Properties.Resources.arrow_down, MoveDownIcon_Click);
            return entry;
        }
    }
}
