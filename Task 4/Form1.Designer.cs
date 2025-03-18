namespace Task_4
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
            listBoxResults = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = SystemColors.Info;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(248, 73);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(478, 304);
            listBoxResults.TabIndex = 5;
            // 
            // btnSort
            // 
            btnSort.BackColor = SystemColors.ButtonShadow;
            btnSort.Location = new Point(75, 73);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(113, 40);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab1 Task 4 - Form";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort;
    }
}
