using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixVisualizer
{
    public static class MatrixVisualizer
    {
        public static Bitmap DrawMatrixImage(double[,] matrix, string name, double threshold = double.MaxValue)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);
            var cellSize = m < n ? 400/n : 400/m;
            var bmp = new Bitmap(m*cellSize, n*cellSize);
            var graphics = Graphics.FromImage(bmp);

            var brushes = Enumerable.Range(0, 256).Reverse().Select(i => new SolidBrush(Color.FromArgb(255, i, i, i))).ToList();
            var max = double.MinValue;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }
            max = max > threshold ? threshold : max;
            var unit = max/255.0;

            graphics.Clear(Color.White);
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var value = matrix[i, j] > threshold ? threshold : matrix[i, j];
                    graphics.FillRectangle(brushes[(int) (value/unit)], i*cellSize, j*cellSize, cellSize, cellSize);
                }
            }
            return bmp;
        }

        public static void SaveMatrixImage(double[,] matrix, string name, double threshold = double.MaxValue)
        {
            var bmp = DrawMatrixImage(matrix, name, threshold);
            bmp.Save(name + ".png", ImageFormat.Png);
        }
    }
}