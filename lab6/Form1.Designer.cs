namespace lab6
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
            label1 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearchBook = new Button();
            btnDeleteBook = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnFetchBooks = new Button();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            txtNewBookTitle = new TextBox();
            txtNewAuthorName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 65);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 41;
            label1.Text = "Search Book:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(210, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(555, 27);
            txtSearch.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 297);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 39;
            label4.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 174);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 38;
            label3.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 134);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 37;
            label2.Text = "Book Author:";
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(771, 61);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(80, 29);
            btnSearchBook.TabIndex = 36;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteBook.Location = new Point(210, 462);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(125, 29);
            btnDeleteBook.TabIndex = 35;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click_1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(210, 294);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 34;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateBook.Location = new Point(210, 427);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(125, 29);
            btnUpdateBook.TabIndex = 33;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click_1;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFetchBooks.Location = new Point(210, 215);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(125, 29);
            btnFetchBooks.TabIndex = 32;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnShowBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddBook.Location = new Point(210, 250);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(125, 29);
            btnAddBook.TabIndex = 31;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = SystemColors.Info;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(352, 131);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(499, 364);
            listBoxBooks.TabIndex = 30;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(210, 171);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 29;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(210, 131);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 28;
            // 
            // txtNewBookTitle
            // 
            txtNewBookTitle.Location = new Point(210, 377);
            txtNewBookTitle.Name = "txtNewBookTitle";
            txtNewBookTitle.Size = new Size(125, 27);
            txtNewBookTitle.TabIndex = 44;
            // 
            // txtNewAuthorName
            // 
            txtNewAuthorName.Location = new Point(210, 337);
            txtNewAuthorName.Name = "txtNewAuthorName";
            txtNewAuthorName.Size = new Size(125, 27);
            txtNewAuthorName.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 340);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 45;
            label5.Text = "New Book Author:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 380);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 46;
            label6.Text = "New Book Title:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 12);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(925, 10);
            progressBar.TabIndex = 42;
            // 
            // Form1
            // 
            this.Controls.Add(this.progressBar);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 602);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNewBookTitle);
            Controls.Add(txtNewAuthorName);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnFetchBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearchBook;
        private Button btnDeleteBook;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnFetchBooks;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private ProgressBar progressBar;
        private TextBox txtNewBookTitle;
        private TextBox txtNewAuthorName;
        private Label label5;
        private Label label6;
    }
}
