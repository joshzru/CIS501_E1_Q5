namespace CIS501_E1_Q5
{
    partial class BookView
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
            splitContainer1 = new SplitContainer();
            uxGoToPageButton = new Button();
            GoToPageTextBox = new TextBox();
            uxPreviousPageButton = new Button();
            splitContainer2 = new SplitContainer();
            BookPageLabel = new Label();
            uxRemoveBookmarkButton = new Button();
            uxAddBookMarkButton = new Button();
            uxNextPageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(uxGoToPageButton);
            splitContainer1.Panel1.Controls.Add(GoToPageTextBox);
            splitContainer1.Panel1.Controls.Add(uxPreviousPageButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 150;
            splitContainer1.TabIndex = 0;
            // 
            // uxGoToPageButton
            // 
            uxGoToPageButton.Location = new Point(38, 41);
            uxGoToPageButton.Name = "uxGoToPageButton";
            uxGoToPageButton.Size = new Size(75, 23);
            uxGoToPageButton.TabIndex = 2;
            uxGoToPageButton.Text = "Go To Page";
            uxGoToPageButton.UseVisualStyleBackColor = true;
            uxGoToPageButton.Click += uxGoToPageButton_Click;
            // 
            // GoToPageTextBox
            // 
            GoToPageTextBox.Location = new Point(27, 12);
            GoToPageTextBox.Name = "GoToPageTextBox";
            GoToPageTextBox.Size = new Size(100, 23);
            GoToPageTextBox.TabIndex = 1;
            GoToPageTextBox.TextChanged += GoToPageTextBox_TextChanged;
            // 
            // uxPreviousPageButton
            // 
            uxPreviousPageButton.Anchor = AnchorStyles.Left;
            uxPreviousPageButton.Location = new Point(12, 207);
            uxPreviousPageButton.Name = "uxPreviousPageButton";
            uxPreviousPageButton.Size = new Size(75, 23);
            uxPreviousPageButton.TabIndex = 0;
            uxPreviousPageButton.Text = "<--";
            uxPreviousPageButton.UseVisualStyleBackColor = true;
            uxPreviousPageButton.Click += uxPreviousPageButton_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(BookPageLabel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(uxRemoveBookmarkButton);
            splitContainer2.Panel2.Controls.Add(uxAddBookMarkButton);
            splitContainer2.Panel2.Controls.Add(uxNextPageButton);
            splitContainer2.Size = new Size(646, 450);
            splitContainer2.SplitterDistance = 487;
            splitContainer2.TabIndex = 0;
            // 
            // BookPageLabel
            // 
            BookPageLabel.Dock = DockStyle.Fill;
            BookPageLabel.Location = new Point(0, 0);
            BookPageLabel.Name = "BookPageLabel";
            BookPageLabel.Size = new Size(487, 450);
            BookPageLabel.TabIndex = 0;
            BookPageLabel.Text = "BookContent";
            // 
            // uxRemoveBookmarkButton
            // 
            uxRemoveBookmarkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uxRemoveBookmarkButton.Location = new Point(39, 41);
            uxRemoveBookmarkButton.Name = "uxRemoveBookmarkButton";
            uxRemoveBookmarkButton.Size = new Size(75, 23);
            uxRemoveBookmarkButton.TabIndex = 2;
            uxRemoveBookmarkButton.Text = "-";
            uxRemoveBookmarkButton.UseVisualStyleBackColor = true;
            uxRemoveBookmarkButton.Click += uxRemoveBookmarkButton_Click;
            // 
            // uxAddBookMarkButton
            // 
            uxAddBookMarkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uxAddBookMarkButton.Location = new Point(39, 12);
            uxAddBookMarkButton.Name = "uxAddBookMarkButton";
            uxAddBookMarkButton.Size = new Size(75, 23);
            uxAddBookMarkButton.TabIndex = 1;
            uxAddBookMarkButton.Text = "+";
            uxAddBookMarkButton.UseVisualStyleBackColor = true;
            uxAddBookMarkButton.Click += uxAddBookMarkButton_Click;
            // 
            // uxNextPageButton
            // 
            uxNextPageButton.Anchor = AnchorStyles.Right;
            uxNextPageButton.Location = new Point(68, 207);
            uxNextPageButton.Name = "uxNextPageButton";
            uxNextPageButton.Size = new Size(75, 23);
            uxNextPageButton.TabIndex = 0;
            uxNextPageButton.Text = "-->";
            uxNextPageButton.UseVisualStyleBackColor = true;
            uxNextPageButton.Click += uxNextPageButton_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "BookView";
            Text = "BookTitle";
            FormClosing += BookView_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button uxNextPageButton;
        private Button uxGoToPageButton;
        private TextBox GoToPageTextBox;
        private Button uxPreviousPageButton;
        private Label BookPageLabel;
        private Button uxRemoveBookmarkButton;
        private Button uxAddBookMarkButton;
    }
}