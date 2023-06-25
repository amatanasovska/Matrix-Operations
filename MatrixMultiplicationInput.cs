﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MatrixOperations
{
    public partial class MatrixMultiplicationInput : Form
    {
        //decimal XFirstMatrix;
        //decimal YFirstMatrix;
        //decimal XSecondMatrix;  
        //decimal YSecondMatrix;
        
        
        public MatrixMultiplicationInput(decimal XFirstMatrix, decimal YFirstMatrix, decimal XSecondMatrix, decimal YSecondMatrix)
        {
            InitializeComponent();
            this.SetWidthAndHeight((int)XFirstMatrix, (int)YFirstMatrix, (int)XSecondMatrix, (int)YSecondMatrix);
            this.GenerateMatrices((int)XFirstMatrix, (int)YFirstMatrix, (int)XSecondMatrix, (int)YSecondMatrix);

        }
    }
}
