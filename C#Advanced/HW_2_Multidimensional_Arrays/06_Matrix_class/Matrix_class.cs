/*Write a class Matrix, to hold a matrix of integers. 
 * Overload the operators for adding, subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().
 
 * I have used as a base the following code:
 * https://social.msdn.microsoft.com/Forums/en-US/c2d1b5d1-e384-47cb-923f-6551a07f4023/c-class-to-handle-matrices?forum=Vsexpressvcs 
 */

using System;
using System.Linq;
using System.Text;

    class Matrix
    {
        static void Main()
        {


            Matrix m1 = new Matrix(2,3);
            Matrix m2 = new Matrix(3,2);
            int [] row0 = {1,2,3};
            int[] row1 = {4, 5, 6};
            m1.SetRow(0,row0);
            m1.SetRow(1,row1);
            Console.WriteLine("m1 = ");
            Console.WriteLine(m1.ToString());

            int[] column0 = { 1, 2, 3 };
            int[] column1 = { 4, 5, 6 };
            m2.SetColumn(0,column0);
            m2.SetColumn(1,column1);
            Console.WriteLine("m2 = ");

            Console.WriteLine(m2.ToString());

            Matrix m3 = m1 + m1;
            Console.WriteLine("m1 + m1 =");
            Console.WriteLine(m3.ToString());

            Matrix m4 = m1 - m1;
            Console.WriteLine("m1 - m1 =");
            Console.WriteLine(m4.ToString());

            Matrix m5 = m1 * m2;
            Console.WriteLine("m1*m2 =");
            Console.WriteLine(m5.ToString());

            Matrix m6 = 5*m2;
            Console.WriteLine("5*m2 =");
            Console.WriteLine(m6.ToString());


           Console.WriteLine("m1 == m2?");
           Console.WriteLine(m1==m2);








        }

        private int[,] m;
		private int mRowCount = 0;
        private int mColumnCount = 0;

        //parameterless constructor
        public Matrix()
		{ 
		
		}

        //constructor with parameters
        public Matrix(int rowCount, int columnCount)
        {
            mRowCount = rowCount;
            mColumnCount = columnCount;
            m = new int[rowCount, columnCount];
        }


        //row dimension getter
		public int RowCount
		{
			get { return mRowCount; }
		}

        //column dimension getter
		public int ColumnCount
		{
			get { return mColumnCount; }
		}

        //matrix elements setters and getters
		public int this[int i,int j]
		{
			get
			{
				return this.m[i, j];
			}
			set
			{
				this.m[i, j] = value;
			}
		}

        //get matrix elements of given row= rowIndex
		public int[] GetRow(int rowIndex)
		{
			int[] rowValues = new int[mColumnCount];
			for (int j = 0; j < mColumnCount; j++)
			{
				rowValues[j] = m[rowIndex, j];
			}
			return rowValues;
		}

        //set matrix elements of given row= rowIndex
		public void SetRow(int rowIndex,int[] value)
		{
			if (value.Length != mColumnCount)
			{
				throw new Exception("Invalid column length");
			}
			for (int i = 0; i < value.Length; i++)
			{
				m[rowIndex, i] = value[i];
			}
		}

        //get matrix elements of given column= columnIndex
		public int[] GetColumn(int columnIndex)
		{ 
			int[] columnValues = new int[mRowCount];
			for (int i = 0; i < mRowCount; i++)
			{
				columnValues[i] = m[i, columnIndex];
			}
			return columnValues;
		}

        //set matrix elements of given column= columnIndex
		public void SetColumn(int columnIndex,int[] value)
		{ 
			if (value.Length != mRowCount)
			{
				throw new Exception("Invalid row length");
			}
			for (int i = 0; i < value.Length; i++)
			{
				m[i, columnIndex] = value[i];
			}
		}

		//overload the operator + for adding elements of two matrices m1 and m2
		public static Matrix operator +(Matrix m1,Matrix m2)
		{
			if (!(m1.RowCount == m2.RowCount && m1.ColumnCount == m2.ColumnCount))
			{
				throw new Exception("The row or column dimensions of both matrices are different");
			}
			Matrix resultMartix = new Matrix(m1.RowCount, m1.ColumnCount);
			for (int i = 0; i < m1.RowCount; i++)
			{
				for (int j = 0; j < m1.ColumnCount; j++)
				{
					resultMartix[i, j] = m1[i, j] + m2[i, j];
				}
			}
			return resultMartix;
		}

        //overload the operator * for multiplying the matrix elements by scalar value
		public static Matrix operator *(int scalarValue, Matrix m)
		{
			Matrix resultMartix = new Matrix(m.RowCount, m.ColumnCount);
			for (int i = 0; i < m.RowCount; i++)
			{
				for (int j = 0; j < m.ColumnCount; j++)
				{
					resultMartix[i, j] = scalarValue*m[i, j];
				}
			}
			return resultMartix;
		}

        //overload the operator - for subtracting elements of two matrices m1 and m2
		public static Matrix operator -(Matrix m1, Matrix m2)
		{
			if (!(m1.RowCount == m2.RowCount && m1.ColumnCount == m2.ColumnCount))
			{
                throw new Exception("The row or column dimensions of both matrices are different");
			}
			return (m1 + (-1 * m2));
		}

        //overload the operator == for comparing elements of two matrices m1 and m2
		public static bool operator ==(Matrix m1, Matrix m2)
		{
			if (!(m1.RowCount == m2.RowCount && m1.ColumnCount == m2.ColumnCount))
			{
                //The row or column dimensions of both matrices are different
				return false;
			}
			for (int i = 0; i < m1.RowCount; i++)
			{
				for (int j = 0; j < m1.ColumnCount; j++)
				{
					if (m1[i, j] != m2[i, j])
					{
						return false;
					}
				}
			}
			return true; 
		}


        //overload the operator == for comparing elements of two matrices m1 and m2
		public static bool operator !=(Matrix m1, Matrix m2)
		{
			return !(m1 == m2);
		}


		public static Matrix operator -(Matrix pMatrix)
		{
			return -1 * pMatrix;
		}


         //overload the operator ++ for matrix m1
		public static Matrix operator ++(Matrix m1)
		{
			
			for (int i = 0; i < m1.RowCount; i++)//iterate over rows
			{
				for (int j = 0; j < m1.ColumnCount; j++)//iterate over columns
				{
					m1[i, j] += 1;
				}
			}
			return m1;
		}


        //overload the operator * for matrix multiplication of the matrices m1 and m2
		public static Matrix operator * (Matrix m1, Matrix m2)
		{
			if (m1.ColumnCount != m2.RowCount)
			{
                throw new Exception("The column dimension of m1 and row dimension of m2 are different");
			}
			Matrix resultMatrix = new Matrix(m1.RowCount, m2.ColumnCount);
			for (int i = 0; i<m1.RowCount; i++)//iterate over rows of m1
			{
				int[] rowValues = m1.GetRow(i);
				for (int j = 0; j<m2.ColumnCount; j++)//iteate over column values of m2
				{
					int[] columnValues = m2.GetColumn(j);
					int value=0;
					for (int a = 0; a < rowValues.Length; a++)
					{
						value+=rowValues[a] * columnValues[a];
					}
					resultMatrix[i, j] = value;
				}
			}
			return resultMatrix;
		}


       

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.RowCount; row++)
            {
                for (int col = 0; col < this.ColumnCount; col++)
                {
                    result.Append(string.Format("{0} ", this.m[row, col] ));

                }
                result.Append(string.Format("\n"));
            }

            return result.ToString();
        }

    }
