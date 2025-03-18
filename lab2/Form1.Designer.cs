namespace lab2
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
            txtExponentInput = new TextBox();
            lblFibonacciResult = new Label();
            txtFibonacciInput = new TextBox();
            btnCalculateFibonacci = new Button();
            lblPowerResult = new Label();
            txtBaseInput = new TextBox();
            btnCalculatePower = new Button();
            lblSumResult = new Label();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            SuspendLayout();
            // 
            // txtExponentInput
            // 
            txtExponentInput.Font = new Font("Segoe UI", 10.2F);
            txtExponentInput.Location = new Point(444, 281);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(142, 30);
            txtExponentInput.TabIndex = 25;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI", 10.2F);
            lblFibonacciResult.Location = new Point(605, 238);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(132, 23);
            lblFibonacciResult.TabIndex = 24;
            lblFibonacciResult.Text = "Fibonacci Result";
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Font = new Font("Segoe UI", 10.2F);
            txtFibonacciInput.Location = new Point(286, 235);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(300, 30);
            txtFibonacciInput.TabIndex = 23;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.BackColor = SystemColors.ButtonShadow;
            btnCalculateFibonacci.FlatStyle = FlatStyle.Popup;
            btnCalculateFibonacci.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCalculateFibonacci.Location = new Point(64, 235);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(188, 29);
            btnCalculateFibonacci.TabIndex = 22;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = false;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 10.2F);
            lblPowerResult.Location = new Point(605, 284);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(107, 23);
            lblPowerResult.TabIndex = 21;
            lblPowerResult.Text = "Power Result";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Font = new Font("Segoe UI", 10.2F);
            txtBaseInput.Location = new Point(286, 281);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(140, 30);
            txtBaseInput.TabIndex = 20;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.BackColor = SystemColors.ButtonShadow;
            btnCalculatePower.FlatStyle = FlatStyle.Popup;
            btnCalculatePower.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCalculatePower.Location = new Point(64, 281);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(188, 29);
            btnCalculatePower.TabIndex = 19;
            btnCalculatePower.Text = "Calculate Power";
            btnCalculatePower.UseVisualStyleBackColor = false;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 10.2F);
            lblSumResult.Location = new Point(605, 190);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(95, 23);
            lblSumResult.TabIndex = 18;
            lblSumResult.Text = "Sum Result";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Font = new Font("Segoe UI", 10.2F);
            txtArrayInput.Location = new Point(286, 187);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(300, 30);
            txtArrayInput.TabIndex = 17;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.BackColor = SystemColors.ButtonShadow;
            btnCalculateSum.FlatStyle = FlatStyle.Popup;
            btnCalculateSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCalculateSum.Location = new Point(64, 187);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(188, 29);
            btnCalculateSum.TabIndex = 16;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = false;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F);
            lblResult.Location = new Point(605, 144);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 23);
            lblResult.TabIndex = 15;
            lblResult.Text = "Result";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 10.2F);
            txtInput.Location = new Point(286, 141);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 30);
            txtInput.TabIndex = 14;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.BackColor = SystemColors.ButtonShadow;
            btnCalculateFactorial.FlatStyle = FlatStyle.Popup;
            btnCalculateFactorial.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCalculateFactorial.Location = new Point(64, 140);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(188, 29);
            btnCalculateFactorial.TabIndex = 13;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = false;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtExponentInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(txtFibonacciInput);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(lblPowerResult);
            Controls.Add(txtBaseInput);
            Controls.Add(btnCalculatePower);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculateFactorial);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 2 - Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExponentInput;
        private Label lblFibonacciResult;
        private TextBox txtFibonacciInput;
        private Button btnCalculateFibonacci;
        private Label lblPowerResult;
        private TextBox txtBaseInput;
        private Button btnCalculatePower;
        private Label lblSumResult;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblResult;
        private TextBox txtInput;
        private Button btnCalculateFactorial;
    }
}
