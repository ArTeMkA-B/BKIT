using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using BKIT_LAB5;

namespace BKIT_DZ
{
    public partial class MainForm : Form
    {
        Mutex mut = new Mutex();

        List<string> words;

        string inputWord;
        int limitDiff;
        bool isWordExists;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenTextFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            words = new List<string>();
            FoundWordsListBox.Items.Clear();
            NotFoundWordsListBox.Items.Clear();
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

            ExactMathRadio.Visible = true;
            LevenDistRadio.Visible = true;
            LoadTimeLabel.Visible = true;
            SaveButton.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            isWordExists = false;
            timer.Start();
            if (ExactMathRadio.Checked)
                isWordExists = words.Contains(SearchTextBox.Text);
            else
            {
                if (MultithreadedOptimRadio.Checked)
                {
                    limitDiff = Convert.ToInt32(DistUpDown.Value);
                    inputWord = SearchTextBox.Text;
                    int threadsNum = (int)ThreadsUpDown.Value;
                    int startIndex = 0;
                    int count = words.Count / threadsNum + ((words.Count % threadsNum != 0) ? 1 : 0);
                    Task[] tasks = new Task[threadsNum];
                    for (int i = 0; i < threadsNum; ++i)
                    {
                        tasks[i] = new Task(CheckDist, words.GetRange(startIndex, count));
                        tasks[i].Start();
                        startIndex += count;
                        if (count > words.Count - startIndex)
                            count = words.Count - startIndex;
                    }
                    Task.WaitAll(tasks);
                }
                else
                {
                    Distance dist = new Distance();
                    dist.IsOptimized = (SingleThreadedOptimRadio.Checked);
                    dist.Str1 = SearchTextBox.Text;
                    limitDiff = Convert.ToInt32(DistUpDown.Value);
                    foreach (string word in words)
                    {
                        dist.Str2 = word;
                        if (dist.GetLevenDist() <= limitDiff)
                        {
                            isWordExists = true;
                            break;
                        }
                    }
                }
            }
            timer.Stop();

            SearchTimeLabel.Text = "Search time: " + timer.Elapsed.TotalMilliseconds.ToString() + " ms";
            ListBox targetListBox = (isWordExists) ? FoundWordsListBox : NotFoundWordsListBox;
            targetListBox.BeginUpdate();
            targetListBox.Items.Add(SearchTextBox.Text);
            targetListBox.EndUpdate();
        }

        private void CheckDist(object words)
        {
            List<string> someWords = (List<string>)words;
            Distance dist = new Distance();
            dist.IsOptimized = true;
            dist.Str1 = inputWord;
            foreach (string word in someWords)
            {
                if (!isWordExists)
                {
                    dist.Str2 = word;
                    if (dist.GetLevenDist() <= limitDiff)
                    {
                        //mut.WaitOne();
                        isWordExists = true;
                        //mut.ReleaseMutex();
                        return;
                    }
                }
                else return;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenTextFileDialog.ShowDialog();
        }

        private void ExactMathRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ExactMathRadio.Checked)
            {
                LevenshteinLabel.Visible = false;
                DistUpDown.Visible = false;
                ModesGroupBox.Visible = false;

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
            if (LevenDistRadio.Checked)
            {
                ModesGroupBox.Visible = true;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string log = words.Count + " unique words were loaded from \"" + OpenTextFileDialog.FileName + "\"\n" + LoadTimeLabel.Text + "\n";
            log += "Found words:\n";
            foreach (object items in FoundWordsListBox.Items)
                log += items.ToString() + "\n";
            log += "\nNot found words:\n";
            foreach (object items in NotFoundWordsListBox.Items)
                log += items.ToString() + "\n";
            string fileName = "Log info for " + DateTime.Now.ToString("dd_MM_yyyy_HHmmss") + ".txt";
            File.WriteAllText(fileName, log);
            MessageBox.Show("Done!");
        }

        private void SingleThreadedOptimRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SingleThreadedOptimRadio.Checked)
            {
                ThreadsLabel.Visible = false;
                ThreadsUpDown.Visible = false;
            }
        }

        private void NoOptimRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (NoOptimRadio.Checked)
            {
                ThreadsLabel.Visible = false;
                ThreadsUpDown.Visible = false;
            }
        }

        private void MultithreadedOptimRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MultithreadedOptimRadio.Checked)
            {
                ThreadsLabel.Visible = true;
                ThreadsUpDown.Visible = true;
            }
        }
    }
}
