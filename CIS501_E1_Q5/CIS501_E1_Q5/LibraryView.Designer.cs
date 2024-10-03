namespace CIS501_E1_Q5
{
    partial class LibraryView
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
            uxOpenBookButton = new Button();
            BookListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BookListBox);
            splitContainer1.Panel1.Padding = new Padding(100, 0, 100, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(uxOpenBookButton);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 369;
            splitContainer1.TabIndex = 0;
            // 
            // uxOpenBookButton
            // 
            uxOpenBookButton.Location = new Point(361, 42);
            uxOpenBookButton.Name = "uxOpenBookButton";
            uxOpenBookButton.Size = new Size(75, 23);
            uxOpenBookButton.TabIndex = 0;
            uxOpenBookButton.Text = "Open";
            uxOpenBookButton.UseVisualStyleBackColor = true;
            uxOpenBookButton.Click += uxOpenBookButton_Click;
            // 
            // BookListBox
            // 
            BookListBox.Dock = DockStyle.Fill;
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 15;
            BookListBox.Location = new Point(100, 0);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(600, 369);
            BookListBox.TabIndex = 0;
            BookListBox.SelectedIndexChanged += BookListBox_SelectedIndexChanged;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "LibraryView";
            Text = "LibraryView";
            FormClosing += LibraryView_FormClosing;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox BookListBox;
        private Button uxOpenBookButton;
    }
}