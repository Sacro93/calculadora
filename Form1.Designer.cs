namespace calculadora__
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.HISTORY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(56, 127);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(431, 73);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(121, 215);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(65, 87);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnAction);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(199, 215);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(65, 87);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnAction);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(277, 215);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 87);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnAction);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 608);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 87);
            this.button4.TabIndex = 4;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 313);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 87);
            this.button5.TabIndex = 5;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 313);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 87);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(355, 313);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 87);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(56, 412);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 87);
            this.button8.TabIndex = 8;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(206, 412);
            this.button9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 87);
            this.button9.TabIndex = 9;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(355, 412);
            this.button10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 87);
            this.button10.TabIndex = 10;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(56, 510);
            this.button11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(136, 87);
            this.button11.TabIndex = 11;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(206, 510);
            this.button12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 87);
            this.button12.TabIndex = 12;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(355, 510);
            this.button13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(136, 87);
            this.button13.TabIndex = 13;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(56, 608);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(136, 87);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(355, 608);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(136, 87);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(56, 215);
            this.btnSum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(52, 87);
            this.btnSum.TabIndex = 16;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnAction);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(349, 215);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 87);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button17_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 25;
            this.lstHistory.Location = new System.Drawing.Point(531, 215);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(264, 479);
            this.lstHistory.TabIndex = 18;
            // 
            // HISTORY
            // 
            this.HISTORY.AutoSize = true;
            this.HISTORY.Location = new System.Drawing.Point(532, 147);
            this.HISTORY.Name = "HISTORY";
            this.HISTORY.Size = new System.Drawing.Size(112, 25);
            this.HISTORY.TabIndex = 19;
            this.HISTORY.Text = "HISTORY";
            this.HISTORY.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 865);
            this.Controls.Add(this.HISTORY);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label HISTORY;
    }
}

