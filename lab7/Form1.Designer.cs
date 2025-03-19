namespace lab7
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportBooks = new Button();
            btnSearchBook = new Button();
            btnExportBooks = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            txtSearch = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnImportBooks
            // 
            btnImportBooks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnImportBooks.Location = new Point(123, 263);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(145, 29);
            btnImportBooks.TabIndex = 23;
            btnImportBooks.Text = "Import Book";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click_1;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearchBook.Location = new Point(646, 43);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(94, 29);
            btnSearchBook.TabIndex = 22;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click_1;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExportBooks.Location = new Point(123, 228);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(145, 29);
            btnExportBooks.TabIndex = 21;
            btnExportBooks.Text = "Export Book";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click_1;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(123, 147);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(145, 27);
            txtBookTitle.TabIndex = 20;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(123, 114);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(145, 27);
            txtAuthorName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(33, 150);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Book Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(33, 117);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 17;
            label1.Text = "Author:";
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddBook.Location = new Point(123, 189);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(145, 33);
            btnAddBook.TabIndex = 16;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click_1;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = SystemColors.Info;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(304, 114);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(436, 304);
            listBoxBooks.TabIndex = 15;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPreviousPage.Location = new Point(546, 440);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 14;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click_1;
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNextPage.Location = new Point(646, 440);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 13;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click_1;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPageNumber.Location = new Point(446, 444);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(47, 20);
            lblPageNumber.TabIndex = 12;
            lblPageNumber.Text = "Page:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(149, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(491, 27);
            txtSearch.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(33, 47);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 25;
            label3.Text = "Seach Book:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBook);
            Controls.Add(btnExportBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImportBooks;
        private Button btnSearchBook;
        private Button btnExportBooks;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Label label2;
        private Label label1;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Label lblPageNumber;
        private TextBox txtSearch;
        private Label label3;
    }
}
