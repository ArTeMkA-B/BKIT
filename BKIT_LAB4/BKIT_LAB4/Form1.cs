using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BKIT_LAB4
{
    public partial class MainForm : Form
    {
        public List<string> words;

        public MainForm()
        {
            InitializeComponent();
            words = new List<string>();
        }

        private void OpenTextFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string[] text = File.ReadAllText(OpenTextFileDialog.FileName, Encoding.UTF8).Split(' ');
            foreach (string word in text)
            {
                if (!words.Contains(word))
                    words.Add(word);
            }
            timer.Stop();
            LoadTimeLabel.Text = "Load time: " + timer.Elapsed.TotalMilliseconds.ToString() + " ms";

            InstructionLabel.Visible = true;
            SearchTextBox.Visible = true;
            SearchButton.Visible = true;
            SearchTimeLabel.Visible = true;
            FoundWordsListBox.Visible = true;
            NotFoundWordsListBox.Visible = true;
            LoadTimeLabel.Visible = true;
            FirstSubtitle.Visible = true;
            SecondSubtitle.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            bool isExists = words.Contains(SearchTextBox.Text);
            timer.Stop();
            SearchTimeLabel.Text = "Search time: " + timer.Elapsed.TotalMilliseconds.ToString() + " ms";
            ListBox targetListBox = (isExists) ? FoundWordsListBox : NotFoundWordsListBox;
            targetListBox.BeginUpdate();
            targetListBox.Items.Add(SearchTextBox.Text);
            targetListBox.EndUpdate();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenTextFileDialog.ShowDialog();
        }
    }
}
