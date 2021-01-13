
namespace HandsOnTry.Medium
{
    internal class RotateImage
    {
        // Rotate n * n array
        internal void Rotate(int[][] matrix)
        {
            var length = matrix.Length;

            for (var j = 0; j < length; j++)
            {
                for (var k = j; k < length; k++)
                {
                    var temp = matrix[j][k];
                    matrix[j][k] = matrix[k][j];
                    matrix[k][j] = temp;
                }
            }

            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j < length / 2; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][length - 1 - j];
                    matrix[i][length - 1 - j] = temp;
                }
            }
        }
    }
}
