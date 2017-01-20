using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatViz
{
    public static class MatViz
    {
        public static Bitmap CreateMatrixImage(double[,] matrix, double threshold = double.MaxValue, bool bgWhite = true)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);
            if (m == 0 | n == 0) throw new NullReferenceException("Invalid matrix size: #raws or #cols is zero.");
            var cellSize = m < n ? 1280/n : 1280/m;
            var bmp = new Bitmap(n*cellSize, m*cellSize);
            var graphics = Graphics.FromImage(bmp);

            var brushes = Enumerable.Range(0, 256).Select(i => new SolidBrush(Color.FromArgb(255, i, i, i))).ToList();
            var minusBrushes = Enumerable.Range(0, 256).Select(i => new SolidBrush(Color.FromArgb(255, bgWhite ? 255 : i, bgWhite ? 255 - i : 0, bgWhite ? 255 - i : 0))).ToList();
            if (bgWhite) brushes.Reverse();
            var max = double.MinValue;
            var min = double.MaxValue;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
            }
            max = max > -min ? max : -min;
            max = max > threshold ? threshold : max;
            var unit = max/255.0;

            graphics.Clear(bgWhite ? Color.White : Color.Black);
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var value = matrix[i, j] > threshold ? threshold : matrix[i, j] < -threshold ? -threshold : matrix[i, j];
                    var brush = value >= 0 ? brushes[(int) (value/unit)] : minusBrushes[(int) (-value/unit)];
                    graphics.FillRectangle(brush, j*cellSize, i*cellSize, cellSize, cellSize);
                }
            }
            return bmp;
        }

        public static void SaveMatrixImage(double[,] matrix, string name, double threshold = double.MaxValue, bool bgWhite = true)
        {
            var bmp = CreateMatrixImage(matrix, threshold, bgWhite);
            bmp.Save(name + ".png", ImageFormat.Png);
        }
    }
}