using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatViz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}, "positive", 1);
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}, "positive-flipped", 1, false);
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative", 1);
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative-flipped", 1, false);
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative-threshold", 0.5);
            MatViz.SaveMatrixImage(new[,] {{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}, "negative-flipped-threshold", 0.5, false);
        }
    }
}