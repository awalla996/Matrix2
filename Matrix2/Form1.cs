using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix2
{
    public partial class Form1 : Form
    {
        double[,] MatrixA;
        double[,] MatrixB;
        private int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private double[,] CreateMatrix(int row, int col)
        {
            double[,] matrix = new double[row, col];
            Random autorand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Math.Round(autorand.NextDouble() * 10.0, 1);
                }
            }
            return matrix;
        }

        private double[,] CreateIMatrix(int row, int col)
        {
            double[,] matrix = new double[row, col];
            Random autorand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }
            return matrix;
        }
        private string ConvertMatrixString(int row, int col, double[,] matrix)
        {
            StringBuilder stringBulider = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    stringBulider.Append(matrix[i, j] + " ");
                }
                stringBulider.Append(Environment.NewLine);
            }
            return stringBulider.ToString();
        }
        private void rbAddition()
        {
            double finalMatrixA = MatrixA[0, 1];
            double finalMatrixB = MatrixB[0, 1];
            int row = Convert.ToInt32(txtMakeMatrixARow.Text);
            int col = Convert.ToInt32(txtMatrixACol.Text);

            double[,] matrixC = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i, j] = MatrixA[i, j] + MatrixB[i, j];
                }
            }
            txtMatrixC.Text = ConvertMatrixString(row, col, matrixC);
        }

        private void rbSubtract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSub()
        {

            double finalMatrixA = MatrixA[0, 1];
            double finalMatrixB = MatrixB[0, 1];
            int row = Convert.ToInt32(txtMakeMatrixARow.Text);
            int col = Convert.ToInt32(txtMatrixACol.Text);

            double[,] matrixC = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i, j] = MatrixA[i, j] - MatrixB[i, j];
                }
            }
            txtMatrixC.Text = ConvertMatrixString(row, col, matrixC);
        }

        private void rbMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMult()
        {

            double finalMatrixA = MatrixA[0, 1];
            double finalMatrixB = MatrixB[0, 1];
            int row = Convert.ToInt32(txtMakeMatrixARow.Text);
            int col = Convert.ToInt32(txtMatrixACol.Text);

            double[,] matrixC = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i, j] = MatrixA[i, j] * MatrixB[i, j];
                }
            }
            txtMatrixC.Text = ConvertMatrixString(row, col, matrixC);
        }

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {
            try
            {
                txtMakeMatrixARow.Focus();
                int RowA = Convert.ToInt32(txtMakeMatrixARow.Text);
                if (RowA < 1 || RowA > 10)
                {
                    MessageBox.Show("Row A must be atleast 1 and less than 10 ");
                    txtMakeMatrixARow.Focus();
                }
                int ColA = Convert.ToInt32(txtMatrixACol.Text);
                if (ColA < 1 || ColA > 10)
                {
                    MessageBox.Show("Col A entry must be atleast 1 and less than 10 ");
                    txtMatrixACol.Focus();
                }
                MatrixA = CreateMatrix(RowA, ColA);
                txtMatrixA.Text = ConvertMatrixString(RowA, ColA, MatrixA);
                flag = 0;
            }
            catch (Exception)
            {
                if (txtMakeMatrixARow.Text == "")
                {
                    MessageBox.Show("Row A is a required field.", "Entry Error");
                    txtMakeMatrixARow.Focus();
                }
                if (txtMatrixACol.Text == "")
                {
                    MessageBox.Show("Col A is a required field.", "Entry Error");
                    txtMatrixACol.Focus();
                }
            }
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            try
            {

                int RowB = Convert.ToInt32(txtMakeMatrixBRow.Text);
                if (RowB < 1 || RowB > 10)
                {
                    MessageBox.Show("Row B must be atleast 1 and less than 10 ");
                    txtMakeMatrixARow.Focus();
                }
                int ColB = Convert.ToInt32(txtMatrixBCol.Text);
                if (ColB < 1 || ColB > 10)
                {
                    MessageBox.Show("Col B entry must be atleast 1 and less than 10 ");
                    txtMatrixACol.Focus();
                }
                MatrixB = CreateMatrix(RowB, ColB);
                txtMatrixB.Text = ConvertMatrixString(RowB, ColB, MatrixB);
            }
            catch (Exception)
            {
                if (txtMakeMatrixBRow.Text == "")
                {
                    MessageBox.Show("Row B is a required field.", "Entry Error");
                    txtMakeMatrixARow.Focus();
                }
                if (txtMatrixBCol.Text == "")
                {
                    MessageBox.Show("Col B is a required field.", "Entry Error");
                    txtMatrixACol.Focus();
                }
            }
        }

        private void btnMakeBCopyOfA_Click(object sender, EventArgs e)
        {

        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked == true)
            {
                if (!(txtMakeMatrixARow.Text.Equals(txtMakeMatrixBRow.Text)))
                    MessageBox.Show("Dimension of Row A and Row B must be equal.", "Entry Error");
                if (!(txtMatrixACol.Text.Equals(txtMatrixBCol.Text)))
                    MessageBox.Show("Dimension of column A and column B must be equal.", "Entry Error");
                else
                {
                    if (txtMatrixA.Text.Equals(""))
                    {
                        btnMakeMatrixA.PerformClick();

                        rbAddition();
                    }
                    if (txtMatrixB.Text.Equals(""))
                    {
                        btnMakeMatrixB.PerformClick();
                        rbAddition();
                    }
                    if (!(txtMatrixA.Text.Equals("") && txtMatrixB.Text.Equals("")))
                    {

                        rbAddition();
                    }
                }
            }
            else if (rbSubtract.Checked == true)
            {
                if (!(txtMakeMatrixARow.Text.Equals(txtMakeMatrixBRow.Text)))
                    MessageBox.Show("Dimension of Row A and Row B must be equal.", "Entry Error");
                if (!(txtMatrixACol.Text.Equals(txtMatrixBCol.Text)))
                    MessageBox.Show("Dimension of column A and column B must be equal.", "Entry Error");
                else
                {
                    if (txtMatrixA.Text.Equals(""))
                    {
                        btnMakeMatrixA.PerformClick();

                        rbSub();
                    }
                    if (txtMatrixB.Text.Equals(""))
                    {
                        btnMakeMatrixB.PerformClick();
                        rbSub();
                    }
                    if (!(txtMatrixA.Text.Equals("") && txtMatrixB.Text.Equals("")))
                    {

                        rbSub();
                    }
                }
            }
            else if (rbMultiply.Checked == true)
            {
                if (!(txtMatrixACol.Text.Equals(txtMakeMatrixBRow.Text)))
                    MessageBox.Show("Dimension of Matix A column must be equal to Matrix B row for multiplication.", "Entry Error");
                else
                {
                    if (txtMatrixA.Text.Equals(""))
                    {
                        btnMakeMatrixA.PerformClick();

                        rbMult();
                    }
                    if (txtMatrixB.Text.Equals(""))
                    {
                        btnMakeMatrixB.PerformClick();
                        rbMult();
                    }
                    if (!(txtMatrixA.Text.Equals("") && txtMatrixB.Text.Equals("")))
                    {

                        rbMult();
                    }
                }
            }
        }

        private void btnClearMatrices_Click(object sender, EventArgs e)
        {
            txtMakeMatrixARow.Text = "";
            txtMakeMatrixBRow.Text = "";
            txtMatrixACol.Text = "";
            txtMatrixBCol.Text = "";
            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();        
        }


    }
}
