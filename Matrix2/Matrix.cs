using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix2
{
    class Matrix
    {
        public double[,] matrixA;
        public double[,] matrixB;
        public int i, j, row1, col1, row2, col2;

        //Read-only properties for columns and rows-----------------
        private readonly int cols;
        private readonly int rows;

        public int Cols { get { return cols; } }
        public int Rows { get { return rows; } }

        //Constructor-----
        public Matrix(int rows, int cols) 
        {
            this.rows = rows;
            this.cols = cols;
        }

        public Matrix (double[,] matrixA, double [,] matrixB)
        {
            this.matrixA = matrixA;
            this.matrixB = matrixB;
        }

        //Operations methods-----------------------------------------
        public double[,] Add(double [,] matrix1, double [,] matrix2)
        {
            int i, j, n = 10;
            double[,] arr1 = matrix1;
            double[,] arr2 = matrix2;
            double[,] arr3 = new double[20, 20];

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            return arr3;
        }

        public void Subtract(double[,] matrix1, double[,] matrix2)
        {
            int i, j, n = 10;
            double[,] arr1 = matrix1;
            double[,] brr1 = matrix2;
            double[,] crr1 = new double[50, 50];

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", crr1[i, j]);
            }
        }

        public void Multiply(double[,] matrix1, double[,] matrix2)
        {
            int m = 2, n = 3, i, j;
            double[,] a = matrix1;
            double[,] b = matrix2;

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    //Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Equals methods----------------------------------------------
        public bool colsEqual()
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int flag = 1;
            
            if (col1 != col2) {
                return false;
            } 
            else
            {
                Console.Write("Comparison of Matrices: \n");
                for (i = 0; i < row1; i++)
                {
                    for (j = 0; j < col2; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    return true;
                else
                    return false;
            }
        }
        public bool rowsEqual()
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int flag = 1;

            if (row1 != row2) {
                return false;
            } else
            {
                Console.Write("Comparison of Matrices: \n");
                for (i = 0; i < row1; i++)
                {
                    for (j = 0; j < col2; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    return true;
                else
                    return false;
            }
        }
        public bool dimsEqual()
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int flag = 1;
            if (row1 != row2 && col1 != col2) {
                return false;
            } else
            {
                Console.Write("Comparison of Matrices: \n");
                for (i = 0; i < row1; i++)
                {
                    for (j = 0; j < col2; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    return true;
                else
                    return false;
            }
        }


        //Override Methods Below--------------------------------------
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //Overridden GetHashCode

        public override int GetHashCode()
        {
            // Use sum for hash code
            return sum(matrixA, matrixB).GetHashCode(); // Note that double overrides this too
        }

        public double[,] sum(double[,] matrix1, double[,] matrix2)
        {
            return Add(matrix1, matrix2);
        }

        public void makeId()
        { 

        }

        public void clone()
        {
            double[,] result = (double[,])matrixA.Clone();
        }
        public void copy(Matrix m) 
        {

        }

        public void populateRand() 
        {

        }

        public void populateOrd() 
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
