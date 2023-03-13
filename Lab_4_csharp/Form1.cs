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
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int rowCount = Convert.ToInt32(rowCountTextBox.Text);
            int columnCount = Convert.ToInt32(columnCountTextBox.Text);
            int[,] matrix = new int[rowCount, columnCount];
            dataGridView1.ColumnCount= columnCount;
            dataGridView1.RowCount = rowCount;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                  
                    matrix[i,j] = rnd.Next(-10,10);

                      dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            // Кількість рядків, що містять хоча б один нульовий елемент
            int rowsWithZeroes = 0;
            for (int i = 0; i < rowCount; i++)
            {
                bool rowHasZero = false;
                for (int j = 0; j < columnCount; j++)
                {
                    if (matrix[i, j] == 0)
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
            Number_of_lines_with_zeros.Text = "Кількість рядків з нулями: " + rowsWithZeroes;

            // Номер стовпця з найбільшою кількістю однакових елементів
            int maxCount = 0;
            int maxCountColumn = -1;
            for (int j = 0; j < columnCount; j++)
            {
                int[] columnElements = new int[rowCount];
                for (int i = 0; i < rowCount; i++)
                {
                    columnElements[i] = matrix[i, j];
                }
                int count = 1;
                for (int i = 0; i < columnElements.Length - 1; i++)
                {
                    if (columnElements[i] == columnElements[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxCountColumn = j;
                    }
                }
            }
            label1.Text = "Номер стовпця з найбільшою кількістю однакових елементів: " + maxCountColumn;
        }

    }
}
