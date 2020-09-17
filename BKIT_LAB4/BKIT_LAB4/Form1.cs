using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using BKIT_LAB5;

namespace BKIT_LAB4
{
    public partial class MainForm : Form
    {
        enum Mode { ExactMath, LevenDist };
        Mode mode;
        bool isOptimized;

        List<string> words;

        public MainForm()
        {
            InitializeComponent();
            words = new List<string>();
            isOptimized = false;
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

            ExactMathRB.Visible = true;
            LevenDistRB.Visible = true;
            OptimizationCheckbox.Visible = true;
            LoadTimeLabel.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            bool isExists = false;

            timer.Start();
            if (mode == Mode.ExactMath)
                isExists = words.Contains(SearchTextBox.Text);
            else
            {
                Distance dist = new Distance();
                dist.IsOptimized = isOptimized;
                dist.Str1 = SearchTextBox.Text;
                int limitDiff = Convert.ToInt32(DistUpDown.Value);
                foreach (string word in words)
                {
                    dist.Str2 = word;
                    if (dist.GetLevenDist() <= limitDiff)
                    {
                        isExists = true;
                        break;
                    }
                }
            }
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

        private void ExactMathRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ExactMathRB.Checked)
            {
                mode = Mode.ExactMath;

                LevenshteinLabel.Visible = false;
                DistUpDown.Visible = false;

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
        }

        private void LevenDistRB_CheckedChanged(object sender, EventArgs e)
        {
            if (LevenDistRB.Checked)
            {
                mode = Mode.LevenDist;

                LevenshteinLabel.Visible = true;
                DistUpDown.Visible = true;
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
        }

        private void OptimizationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            isOptimized = OptimizationCheckbox.Checked;
        }
    }
}
