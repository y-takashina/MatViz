using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixVisualizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MatrixVisualizer.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}, "positive", 1);
            MatrixVisualizer.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}, "positive-flipped", 1, false);
            MatrixVisualizer.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative", 1);
            MatrixVisualizer.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative-flipped", 1, false);
        }
    }
}