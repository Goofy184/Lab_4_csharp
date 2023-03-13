
namespace Lab_4_csharp
{
    partial class Form1
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
            this.Matrix = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.Number_of_lines_with_zeros = new System.Windows.Forms.Label();
            this.ColumnWithMostDuplicates = new System.Windows.Forms.Label();
            this.columnCountTextBox = new System.Windows.Forms.TextBox();
            this.rowCountTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Matrix
            // 
            this.Matrix.AutoSize = true;
            this.Matrix.Location = new System.Drawing.Point(12, 84);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(190, 13);
            this.Matrix.TabIndex = 0;
            this.Matrix.Text = "Введіть розмір прямокутної матриці";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(510, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Результат";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Number_of_lines_with_zeros
            // 
            this.Number_of_lines_with_zeros.AutoSize = true;
            this.Number_of_lines_with_zeros.Location = new System.Drawing.Point(12, 134);
            this.Number_of_lines_with_zeros.Name = "Number_of_lines_with_zeros";
            this.Number_of_lines_with_zeros.Size = new System.Drawing.Size(137, 13);
            this.Number_of_lines_with_zeros.TabIndex = 3;
            this.Number_of_lines_with_zeros.Text = "Кількість рядків з нулями";
            // 
            // ColumnWithMostDuplicates
            // 
            this.ColumnWithMostDuplicates.AutoSize = true;
            this.ColumnWithMostDuplicates.Location = new System.Drawing.Point(12, 187);
            this.ColumnWithMostDuplicates.Name = "ColumnWithMostDuplicates";
            this.ColumnWithMostDuplicates.Size = new System.Drawing.Size(317, 13);
            this.ColumnWithMostDuplicates.TabIndex = 5;
            this.ColumnWithMostDuplicates.Text = "Номер стовпця з найбільшою кількістю однакових елементів";
            // 
            // columnCountTextBox
            // 
            this.columnCountTextBox.Location = new System.Drawing.Point(485, 95);
            this.columnCountTextBox.Name = "columnCountTextBox";
            this.columnCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.columnCountTextBox.TabIndex = 7;
            // 
            // rowCountTextBox
            // 
            this.rowCountTextBox.Location = new System.Drawing.Point(485, 58);
            this.rowCountTextBox.Name = "rowCountTextBox";
            this.rowCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowCountTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rowCountTextBox);
            this.Controls.Add(this.columnCountTextBox);
            this.Controls.Add(this.ColumnWithMostDuplicates);
            this.Controls.Add(this.Number_of_lines_with_zeros);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.Matrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matrix;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label Number_of_lines_with_zeros;
        private System.Windows.Forms.Label ColumnWithMostDuplicates;
        private System.Windows.Forms.TextBox columnCountTextBox;
        private System.Windows.Forms.TextBox rowCountTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

