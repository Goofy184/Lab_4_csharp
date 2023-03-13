using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_csharp
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        private int rowCount;
        private int columnCount;
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            ReadUserInputs();
            FillMatrixWithRandomNumberAndShow();
            ShowMatrix();
            Number_of_lines_with_zeros.Text = "Кількість рядків з нулями: " + CountNumberOfRowsWithZeros();
            ColumnWithMostDuplicates.Text = "Номер стовпця з найбільшою кількістю однакових елементів: " + 
                GetIndexOfFirstColumnWithMostDuplicates();
        }
        private void ReadUserInputs()
        {
            rowCount = Convert.ToInt32(rowCountTextBox.Text);
            columnCount = Convert.ToInt32(columnCountTextBox.Text);
            matrix = new int[rowCount, columnCount];

        }
        private void FillMatrixWithRandomNumberAndShow()
        {
            Random rnd = new Random();
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    matrix[rowIndex, columnIndex] = rnd.Next(-10, 10);
                }
            }
        }
        private void ShowMatrix()
        {
            dataGridView1.ColumnCount = matrix.GetLength(1);
            dataGridView1.RowCount = matrix.GetLength(0);
            for (int rowIndex = 0; rowIndex < dataGridView1.RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < dataGridView1.ColumnCount; columnIndex++)
                {

                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = matrix[rowIndex, columnIndex];
                }
            }
        }
        private int CountNumberOfRowsWithZeros()
        {
            int rowsWithZeroes = 0;
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                bool rowHasZero = false;
                for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
                {
                    if (matrix[rowIndex, columnIndex] == 0)
                    {
                        rowHasZero = true;
                        break;
                    }
                }
                if (rowHasZero)
                {
                    rowsWithZeroes++;
                }
            }
            return rowsWithZeroes;
        }
        private int GetIndexOfFirstColumnWithMostDuplicates()
        {
            int maxCount = 0;
            int maxCountColumn = -1;
            for (int columnIndex = 0; columnIndex < columnCount; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < matrix.GetLength(1) - 1; rowIndex++)
                {
                    int count = CountDuplicatesInColumn(columnIndex, rowIndex);
                    if (count > maxCount)
                    {
                        maxCountColumn = columnIndex;
                        maxCount = count;
                    }
                }
            }
            return maxCountColumn;
        }
        private int CountDuplicatesInColumn(int columnsIndex, int rowIndex)
        {
            int count = 1;
            for (int k = rowIndex; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[rowIndex, columnsIndex] == matrix[k, columnsIndex])
                {
                    count++;
                }
            }
            return count;

        }
    }
}
