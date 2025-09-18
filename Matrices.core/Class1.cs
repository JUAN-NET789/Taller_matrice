namespace Matrices.core
{
    public class MatrixOperations
    {
        public static int[,] FillMatrixA(int m, int n)
        {
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = (i + 1) * j;
            return A;
        }

        public static int[,] FillMatrixB(int n, int p)
        {
            int[,] B = new int[n, p];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < p; j++)
                    B[i, j] = (j + 1) * i;
            return B;
        }

        public static int[,] Multiply(int[,] A, int[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(1);

            int[,] C = new int[m, p];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                        sum += A[i, k] * B[k, j];
                    C[i, j] = sum;
                }

            return C;
        }
    }

}
