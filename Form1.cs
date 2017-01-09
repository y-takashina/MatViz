using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DisplayMatrix(new[,] {{1, 0, 1, 0, 0}, {0, 1, 1, 0, 0}});
            //DisplayMatrix(new[,] {{100, 0, 100, 50, 0}, {0, 30, 10, 0, 13}});
        }
    }
}