namespace BKIT_DZ
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadButton = new System.Windows.Forms.Button();
            this.OpenTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadTimeLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FoundWordsListBox = new System.Windows.Forms.ListBox();
            this.SearchTimeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.NotFoundWordsListBox = new System.Windows.Forms.ListBox();
            this.FirstSubtitle = new System.Windows.Forms.Label();
            this.SecondSubtitle = new System.Windows.Forms.Label();
            this.DistUpDown = new System.Windows.Forms.NumericUpDown();
            this.LevenshteinLabel = new System.Windows.Forms.Label();
            this.ExactMathRadio = new System.Windows.Forms.RadioButton();
            this.LevenDistRadio = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NoOptimRadio = new System.Windows.Forms.RadioButton();
            this.ModesGroupBox = new System.Windows.Forms.GroupBox();
            this.MultithreadedOptimRadio = new System.Windows.Forms.RadioButton();
            this.SingleThreadedOptimRadio = new System.Windows.Forms.RadioButton();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.ThreadsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DistUpDown)).BeginInit();
            this.ModesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(277, 678);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(171, 55);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load text file";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // OpenTextFileDialog
            // 
            this.OpenTextFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.OpenTextFileDialog.Title = "Choose the .txt file";
            this.OpenTextFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenTextFileDialog_FileOk);
            // 
            // LoadTimeLabel
            // 
            this.LoadTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTimeLabel.Location = new System.Drawing.Point(472, 695);
            this.LoadTimeLabel.Name = "LoadTimeLabel";
            this.LoadTimeLabel.Size = new System.Drawing.Size(231, 23);
            this.LoadTimeLabel.TabIndex = 1;
            this.LoadTimeLabel.Text = "Load time: ";
            this.LoadTimeLabel.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(350, 285);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(192, 26);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(574, 280);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 35);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Find word";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FoundWordsListBox
            // 
            this.FoundWordsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoundWordsListBox.CausesValidation = false;
            this.FoundWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundWordsListBox.ForeColor = System.Drawing.Color.Green;
            this.FoundWordsListBox.ItemHeight = 22;
            this.FoundWordsListBox.Location = new System.Drawing.Point(52, 397);
            this.FoundWordsListBox.Name = "FoundWordsListBox";
            this.FoundWordsListBox.Size = new System.Drawing.Size(243, 246);
            this.FoundWordsListBox.TabIndex = 4;
            this.FoundWordsListBox.Visible = false;
            // 
            // SearchTimeLabel
            // 
            this.SearchTimeLabel.AutoSize = true;
            this.SearchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeLabel.Location = new System.Drawing.Point(12, 324);
            this.SearchTimeLabel.Name = "SearchTimeLabel";
            this.SearchTimeLabel.Size = new System.Drawing.Size(109, 20);
            this.SearchTimeLabel.TabIndex = 5;
            this.SearchTimeLabel.Text = "Search time: ";
            this.SearchTimeLabel.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(220, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(284, 49);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Words searcher";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionLabel.Location = new System.Drawing.Point(13, 283);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(283, 25);
            this.InstructionLabel.TabIndex = 7;
            this.InstructionLabel.Text = "Enter the word you want to find:";
            this.InstructionLabel.Visible = false;
            // 
            // NotFoundWordsListBox
            // 
            this.NotFoundWordsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotFoundWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotFoundWordsListBox.ForeColor = System.Drawing.Color.Red;
            this.NotFoundWordsListBox.FormattingEnabled = true;
            this.NotFoundWordsListBox.ItemHeight = 22;
            this.NotFoundWordsListBox.Location = new System.Drawing.Point(421, 397);
            this.NotFoundWordsListBox.Name = "NotFoundWordsListBox";
            this.NotFoundWordsListBox.Size = new System.Drawing.Size(244, 246);
            this.NotFoundWordsListBox.TabIndex = 8;
            this.NotFoundWordsListBox.Visible = false;
            // 
            // FirstSubtitle
            // 
            this.FirstSubtitle.AutoSize = true;
            this.FirstSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstSubtitle.Location = new System.Drawing.Point(130, 368);
            this.FirstSubtitle.Name = "FirstSubtitle";
            this.FirstSubtitle.Size = new System.Drawing.Size(89, 26);
            this.FirstSubtitle.TabIndex = 9;
            this.FirstSubtitle.Text = "Existing";
            this.FirstSubtitle.Visible = false;
            // 
            // SecondSubtitle
            // 
            this.SecondSubtitle.AutoSize = true;
            this.SecondSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondSubtitle.Location = new System.Drawing.Point(482, 368);
            this.SecondSubtitle.Name = "SecondSubtitle";
            this.SecondSubtitle.Size = new System.Drawing.Size(126, 26);
            this.SecondSubtitle.TabIndex = 10;
            this.SecondSubtitle.Text = "Not existing";
            this.SecondSubtitle.Visible = false;
            // 
            // DistUpDown
            // 
            this.DistUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistUpDown.Location = new System.Drawing.Point(488, 253);
            this.DistUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DistUpDown.Name = "DistUpDown";
            this.DistUpDown.Size = new System.Drawing.Size(54, 26);
            this.DistUpDown.TabIndex = 11;
            this.DistUpDown.Visible = false;
            // 
            // LevenshteinLabel
            // 
            this.LevenshteinLabel.AutoSize = true;
            this.LevenshteinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevenshteinLabel.Location = new System.Drawing.Point(12, 251);
            this.LevenshteinLabel.Name = "LevenshteinLabel";
            this.LevenshteinLabel.Size = new System.Drawing.Size(436, 25);
            this.LevenshteinLabel.TabIndex = 12;
            this.LevenshteinLabel.Text = "Set the maximum value of Levenshtein distance: ";
            this.LevenshteinLabel.Visible = false;
            // 
            // ExactMathRadio
            // 
            this.ExactMathRadio.AutoSize = true;
            this.ExactMathRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactMathRadio.Location = new System.Drawing.Point(121, 72);
            this.ExactMathRadio.Name = "ExactMathRadio";
            this.ExactMathRadio.Size = new System.Drawing.Size(134, 28);
            this.ExactMathRadio.TabIndex = 13;
            this.ExactMathRadio.Text = "Еxact match";
            this.ExactMathRadio.UseVisualStyleBackColor = true;
            this.ExactMathRadio.Visible = false;
            this.ExactMathRadio.CheckedChanged += new System.EventHandler(this.ExactMathRB_CheckedChanged);
            // 
            // LevenDistRadio
            // 
            this.LevenDistRadio.AutoSize = true;
            this.LevenDistRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevenDistRadio.Location = new System.Drawing.Point(390, 72);
            this.LevenDistRadio.Name = "LevenDistRadio";
            this.LevenDistRadio.Size = new System.Drawing.Size(208, 28);
            this.LevenDistRadio.TabIndex = 14;
            this.LevenDistRadio.Text = "Levenshtein distance";
            this.LevenDistRadio.UseVisualStyleBackColor = true;
            this.LevenDistRadio.Visible = false;
            this.LevenDistRadio.CheckedChanged += new System.EventHandler(this.LevenDistRB_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(277, 747);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(171, 55);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save results";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NoOptimRadio
            // 
            this.NoOptimRadio.AutoSize = true;
            this.NoOptimRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoOptimRadio.Location = new System.Drawing.Point(14, 21);
            this.NoOptimRadio.Name = "NoOptimRadio";
            this.NoOptimRadio.Size = new System.Drawing.Size(178, 24);
            this.NoOptimRadio.TabIndex = 17;
            this.NoOptimRadio.Text = "without optimization";
            this.NoOptimRadio.UseVisualStyleBackColor = true;
            this.NoOptimRadio.CheckedChanged += new System.EventHandler(this.NoOptimRadio_CheckedChanged);
            // 
            // ModesGroupBox
            // 
            this.ModesGroupBox.Controls.Add(this.MultithreadedOptimRadio);
            this.ModesGroupBox.Controls.Add(this.SingleThreadedOptimRadio);
            this.ModesGroupBox.Controls.Add(this.NoOptimRadio);
            this.ModesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModesGroupBox.Location = new System.Drawing.Point(405, 104);
            this.ModesGroupBox.Name = "ModesGroupBox";
            this.ModesGroupBox.Size = new System.Drawing.Size(275, 128);
            this.ModesGroupBox.TabIndex = 19;
            this.ModesGroupBox.TabStop = false;
            this.ModesGroupBox.Text = "Mode";
            this.ModesGroupBox.Visible = false;
            // 
            // MultithreadedOptimRadio
            // 
            this.MultithreadedOptimRadio.AutoSize = true;
            this.MultithreadedOptimRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultithreadedOptimRadio.Location = new System.Drawing.Point(14, 78);
            this.MultithreadedOptimRadio.Name = "MultithreadedOptimRadio";
            this.MultithreadedOptimRadio.Size = new System.Drawing.Size(226, 24);
            this.MultithreadedOptimRadio.TabIndex = 19;
            this.MultithreadedOptimRadio.Text = "multithreaded optimization";
            this.MultithreadedOptimRadio.UseVisualStyleBackColor = true;
            this.MultithreadedOptimRadio.CheckedChanged += new System.EventHandler(this.MultithreadedOptimRadio_CheckedChanged);
            // 
            // SingleThreadedOptimRadio
            // 
            this.SingleThreadedOptimRadio.AutoSize = true;
            this.SingleThreadedOptimRadio.Checked = true;
            this.SingleThreadedOptimRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingleThreadedOptimRadio.Location = new System.Drawing.Point(14, 48);
            this.SingleThreadedOptimRadio.Name = "SingleThreadedOptimRadio";
            this.SingleThreadedOptimRadio.Size = new System.Drawing.Size(240, 24);
            this.SingleThreadedOptimRadio.TabIndex = 18;
            this.SingleThreadedOptimRadio.TabStop = true;
            this.SingleThreadedOptimRadio.Text = "single-threaded optimization";
            this.SingleThreadedOptimRadio.UseVisualStyleBackColor = true;
            this.SingleThreadedOptimRadio.CheckedChanged += new System.EventHandler(this.SingleThreadedOptimRadio_CheckedChanged);
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreadsLabel.Location = new System.Drawing.Point(12, 220);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(242, 25);
            this.ThreadsLabel.TabIndex = 20;
            this.ThreadsLabel.Text = "Set the number of threads:";
            this.ThreadsLabel.Visible = false;
            // 
            // ThreadsUpDown
            // 
            this.ThreadsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreadsUpDown.Location = new System.Drawing.Point(296, 220);
            this.ThreadsUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ThreadsUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThreadsUpDown.Name = "ThreadsUpDown";
            this.ThreadsUpDown.Size = new System.Drawing.Size(54, 26);
            this.ThreadsUpDown.TabIndex = 21;
            this.ThreadsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ThreadsUpDown.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 836);
            this.Controls.Add(this.ThreadsUpDown);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.ModesGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LevenDistRadio);
            this.Controls.Add(this.ExactMathRadio);
            this.Controls.Add(this.LevenshteinLabel);
            this.Controls.Add(this.DistUpDown);
            this.Controls.Add(this.SecondSubtitle);
            this.Controls.Add(this.FirstSubtitle);
            this.Controls.Add(this.NotFoundWordsListBox);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SearchTimeLabel);
            this.Controls.Add(this.FoundWordsListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.LoadTimeLabel);
            this.Controls.Add(this.LoadButton);
            this.Name = "MainForm";
            this.Text = "BKIT_DZ";
            ((System.ComponentModel.ISupportInitialize)(this.DistUpDown)).EndInit();
            this.ModesGroupBox.ResumeLayout(false);
            this.ModesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog OpenTextFileDialog;
        private System.Windows.Forms.Label LoadTimeLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox FoundWordsListBox;
        private System.Windows.Forms.Label SearchTimeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.ListBox NotFoundWordsListBox;
        private System.Windows.Forms.Label FirstSubtitle;
        private System.Windows.Forms.Label SecondSubtitle;
        private System.Windows.Forms.NumericUpDown DistUpDown;
        private System.Windows.Forms.Label LevenshteinLabel;
        private System.Windows.Forms.RadioButton ExactMathRadio;
        private System.Windows.Forms.RadioButton LevenDistRadio;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RadioButton NoOptimRadio;
        private System.Windows.Forms.GroupBox ModesGroupBox;
        private System.Windows.Forms.RadioButton MultithreadedOptimRadio;
        private System.Windows.Forms.RadioButton SingleThreadedOptimRadio;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.NumericUpDown ThreadsUpDown;
    }
}

