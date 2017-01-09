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
            MatrixVisualizer.SaveMatrixImage(new[,] {{0.0, 0, 1, 0, 1}, {1, 0, 1, 0, 0}}, "test", 1);
        }
    }
}