namespace lab5
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearchBook = new Button();
            btnDeleteBook = new Button();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnShowBooks = new Button();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 185);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 25;
            label4.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 148);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 23;
            label2.Text = "Book Author:";
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(688, 35);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(80, 29);
            btnSearchBook.TabIndex = 22;
            btnSearchBook.Text = "Search";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteBook.Location = new Point(127, 338);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(125, 29);
            btnDeleteBook.TabIndex = 21;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(127, 182);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 20;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateBook.Location = new Point(127, 303);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(125, 29);
            btnUpdateBook.TabIndex = 19;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnShowBooks.Location = new Point(127, 268);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(125, 29);
            btnShowBooks.TabIndex = 18;
            btnShowBooks.Text = "Show Book";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddBook.Location = new Point(127, 233);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(125, 29);
            btnAddBook.TabIndex = 17;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += Add_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = SystemColors.Info;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(269, 105);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(499, 264);
            listBoxBooks.TabIndex = 16;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(127, 145);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 15;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(127, 105);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(269, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(413, 27);
            txtSearch.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 39);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 27;
            label1.Text = "Search Book:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 434);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnShowBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 5 - Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearchBook;
        private Button btnDeleteBook;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnShowBooks;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private TextBox txtSearch;
        private Label label1;
    }
}
