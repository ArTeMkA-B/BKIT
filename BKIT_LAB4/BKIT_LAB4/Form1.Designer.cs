namespace BKIT_LAB4
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
            this.ExactMathRB = new System.Windows.Forms.RadioButton();
            this.LevenDistRB = new System.Windows.Forms.RadioButton();
            this.OptimizationCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DistUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(279, 690);
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
            this.LoadTimeLabel.Location = new System.Drawing.Point(474, 709);
            this.LoadTimeLabel.Name = "LoadTimeLabel";
            this.LoadTimeLabel.Size = new System.Drawing.Size(231, 23);
            this.LoadTimeLabel.TabIndex = 1;
            this.LoadTimeLabel.Text = "Load time: ";
            this.LoadTimeLabel.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(352, 197);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(192, 26);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(576, 192);
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
            this.FoundWordsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoundWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoundWordsListBox.ForeColor = System.Drawing.Color.Green;
            this.FoundWordsListBox.FormattingEnabled = true;
            this.FoundWordsListBox.ItemHeight = 22;
            this.FoundWordsListBox.Location = new System.Drawing.Point(64, 332);
            this.FoundWordsListBox.Name = "FoundWordsListBox";
            this.FoundWordsListBox.Size = new System.Drawing.Size(243, 334);
            this.FoundWordsListBox.TabIndex = 4;
            this.FoundWordsListBox.Visible = false;
            // 
            // SearchTimeLabel
            // 
            this.SearchTimeLabel.AutoSize = true;
            this.SearchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeLabel.Location = new System.Drawing.Point(14, 236);
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
            this.InstructionLabel.Location = new System.Drawing.Point(14, 196);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(283, 25);
            this.InstructionLabel.TabIndex = 7;
            this.InstructionLabel.Text = "Enter the word you want to find:";
            this.InstructionLabel.Visible = false;
            // 
            // NotFoundWordsListBox
            // 
            this.NotFoundWordsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotFoundWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotFoundWordsListBox.ForeColor = System.Drawing.Color.Red;
            this.NotFoundWordsListBox.FormattingEnabled = true;
            this.NotFoundWordsListBox.ItemHeight = 22;
            this.NotFoundWordsListBox.Location = new System.Drawing.Point(421, 332);
            this.NotFoundWordsListBox.Name = "NotFoundWordsListBox";
            this.NotFoundWordsListBox.Size = new System.Drawing.Size(244, 334);
            this.NotFoundWordsListBox.TabIndex = 8;
            this.NotFoundWordsListBox.Visible = false;
            // 
            // FirstSubtitle
            // 
            this.FirstSubtitle.AutoSize = true;
            this.FirstSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstSubtitle.Location = new System.Drawing.Point(132, 292);
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
            this.SecondSubtitle.Location = new System.Drawing.Point(484, 292);
            this.SecondSubtitle.Name = "SecondSubtitle";
            this.SecondSubtitle.Size = new System.Drawing.Size(126, 26);
            this.SecondSubtitle.TabIndex = 10;
            this.SecondSubtitle.Text = "Not existing";
            this.SecondSubtitle.Visible = false;
            // 
            // DistUpDown
            // 
            this.DistUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistUpDown.Location = new System.Drawing.Point(490, 165);
            this.DistUpDown.Name = "DistUpDown";
            this.DistUpDown.Size = new System.Drawing.Size(54, 26);
            this.DistUpDown.TabIndex = 11;
            this.DistUpDown.Visible = false;
            // 
            // LevenshteinLabel
            // 
            this.LevenshteinLabel.AutoSize = true;
            this.LevenshteinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevenshteinLabel.Location = new System.Drawing.Point(14, 163);
            this.LevenshteinLabel.Name = "LevenshteinLabel";
            this.LevenshteinLabel.Size = new System.Drawing.Size(436, 25);
            this.LevenshteinLabel.TabIndex = 12;
            this.LevenshteinLabel.Text = "Set the maximum value of Levenshtein distance: ";
            this.LevenshteinLabel.Visible = false;
            // 
            // ExactMathRB
            // 
            this.ExactMathRB.AutoSize = true;
            this.ExactMathRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExactMathRB.Location = new System.Drawing.Point(119, 79);
            this.ExactMathRB.Name = "ExactMathRB";
            this.ExactMathRB.Size = new System.Drawing.Size(134, 28);
            this.ExactMathRB.TabIndex = 13;
            this.ExactMathRB.Text = "Еxact match";
            this.ExactMathRB.UseVisualStyleBackColor = true;
            this.ExactMathRB.Visible = false;
            this.ExactMathRB.CheckedChanged += new System.EventHandler(this.ExactMathRB_CheckedChanged);
            // 
            // LevenDistRB
            // 
            this.LevenDistRB.AutoSize = true;
            this.LevenDistRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevenDistRB.Location = new System.Drawing.Point(388, 79);
            this.LevenDistRB.Name = "LevenDistRB";
            this.LevenDistRB.Size = new System.Drawing.Size(208, 28);
            this.LevenDistRB.TabIndex = 14;
            this.LevenDistRB.Text = "Levenshtein distance";
            this.LevenDistRB.UseVisualStyleBackColor = true;
            this.LevenDistRB.Visible = false;
            this.LevenDistRB.CheckedChanged += new System.EventHandler(this.LevenDistRB_CheckedChanged);
            // 
            // OptimizationCheckbox
            // 
            this.OptimizationCheckbox.AutoSize = true;
            this.OptimizationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptimizationCheckbox.Location = new System.Drawing.Point(422, 109);
            this.OptimizationCheckbox.Name = "OptimizationCheckbox";
            this.OptimizationCheckbox.Size = new System.Drawing.Size(156, 24);
            this.OptimizationCheckbox.TabIndex = 15;
            this.OptimizationCheckbox.Text = "with optimization";
            this.OptimizationCheckbox.UseVisualStyleBackColor = true;
            this.OptimizationCheckbox.Visible = false;
            this.OptimizationCheckbox.CheckedChanged += new System.EventHandler(this.OptimizationCheckbox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 764);
            this.Controls.Add(this.OptimizationCheckbox);
            this.Controls.Add(this.LevenDistRB);
            this.Controls.Add(this.ExactMathRB);
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
            this.Text = "BKIT_LAB4";
            ((System.ComponentModel.ISupportInitialize)(this.DistUpDown)).EndInit();
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
        private System.Windows.Forms.RadioButton ExactMathRB;
        private System.Windows.Forms.RadioButton LevenDistRB;
        private System.Windows.Forms.CheckBox OptimizationCheckbox;
    }
}

