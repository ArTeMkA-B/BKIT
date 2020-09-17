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
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(279, 608);
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
            this.LoadTimeLabel.Location = new System.Drawing.Point(474, 627);
            this.LoadTimeLabel.Name = "LoadTimeLabel";
            this.LoadTimeLabel.Size = new System.Drawing.Size(231, 23);
            this.LoadTimeLabel.TabIndex = 1;
            this.LoadTimeLabel.Text = "Load time: ";
            this.LoadTimeLabel.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(351, 104);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(192, 26);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(575, 99);
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
            this.FoundWordsListBox.Location = new System.Drawing.Point(63, 259);
            this.FoundWordsListBox.Name = "FoundWordsListBox";
            this.FoundWordsListBox.Size = new System.Drawing.Size(243, 312);
            this.FoundWordsListBox.TabIndex = 4;
            this.FoundWordsListBox.Visible = false;
            // 
            // SearchTimeLabel
            // 
            this.SearchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTimeLabel.Location = new System.Drawing.Point(13, 139);
            this.SearchTimeLabel.Name = "SearchTimeLabel";
            this.SearchTimeLabel.Size = new System.Drawing.Size(229, 32);
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
            this.InstructionLabel.Location = new System.Drawing.Point(12, 105);
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
            this.NotFoundWordsListBox.Location = new System.Drawing.Point(420, 259);
            this.NotFoundWordsListBox.Name = "NotFoundWordsListBox";
            this.NotFoundWordsListBox.Size = new System.Drawing.Size(244, 312);
            this.NotFoundWordsListBox.TabIndex = 8;
            this.NotFoundWordsListBox.Visible = false;
            // 
            // FirstSubtitle
            // 
            this.FirstSubtitle.AutoSize = true;
            this.FirstSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstSubtitle.Location = new System.Drawing.Point(141, 217);
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
            this.SecondSubtitle.Location = new System.Drawing.Point(479, 217);
            this.SecondSubtitle.Name = "SecondSubtitle";
            this.SecondSubtitle.Size = new System.Drawing.Size(126, 26);
            this.SecondSubtitle.TabIndex = 10;
            this.SecondSubtitle.Text = "Not existing";
            this.SecondSubtitle.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 698);
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
    }
}

