namespace lab3
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
            btnShowBookInfo = new Button();
            btnShowList = new Button();
            listBoxBooks = new ListBox();
            SuspendLayout();
            // 
            // btnShowBookInfo
            // 
            btnShowBookInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnShowBookInfo.Location = new Point(37, 92);
            btnShowBookInfo.Name = "btnShowBookInfo";
            btnShowBookInfo.Size = new Size(135, 29);
            btnShowBookInfo.TabIndex = 0;
            btnShowBookInfo.Text = "Show Book Info";
            btnShowBookInfo.UseVisualStyleBackColor = true;
            btnShowBookInfo.Click += btnShowBookInfo_Click;
            // 
            // btnShowList
            // 
            btnShowList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnShowList.Location = new Point(37, 140);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(135, 29);
            btnShowList.TabIndex = 1;
            btnShowList.Text = "Show List";
            btnShowList.UseVisualStyleBackColor = true;
            btnShowList.Click += btnShowList_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = SystemColors.Info;
            listBoxBooks.ForeColor = SystemColors.WindowText;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(210, 88);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(605, 284);
            listBoxBooks.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(listBoxBooks);
            Controls.Add(btnShowList);
            Controls.Add(btnShowBookInfo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowBookInfo;
        private Button btnShowList;
        private ListBox listBoxBooks;
    }
}
