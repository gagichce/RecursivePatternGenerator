using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Workflow.ComponentModel.Design;

namespace RecursivePatternGenerator
{
    public partial class Form1 : Form
    {
        RecursivePattern currentPattern;

        public Form1()
        {
            InitializeComponent();
            currentPattern = new RecursivePattern(21, 21);
            //currentPattern.TogglePosition(1, 0);
            //currentPattern.TogglePosition(1, 1);
            //currentPattern.TogglePosition(1, 2);
            //currentPattern.TogglePosition(1, 3);
            //currentPattern.TogglePosition(1, 4);
            //currentPattern.TogglePosition(1, 5);
            //currentPattern.TogglePosition(1, 6);
            //currentPattern.TogglePosition(1, 7);
            //currentPattern.TogglePosition(1, 8);
            //currentPattern.TogglePosition(1, 9);
            //currentPattern.TogglePosition(1, 10);
            //currentPattern.TogglePosition(1, 11);
            //currentPattern.TogglePosition(1, 12);
            //currentPattern.TogglePosition(1, 13);

            //currentPattern.TogglePosition(0, 1);
            //currentPattern.TogglePosition(1, 1);
            //currentPattern.TogglePosition(2, 1);
            //currentPattern.TogglePosition(3, 1);
            //currentPattern.TogglePosition(4, 1);
            //currentPattern.TogglePosition(5, 1);
            //currentPattern.TogglePosition(6, 1);
            //currentPattern.TogglePosition(7, 1);
            //currentPattern.TogglePosition(8, 1);
            //currentPattern.TogglePosition(9, 1);
            //currentPattern.TogglePosition(10, 1);
            //currentPattern.TogglePosition(11, 1);
            //currentPattern.TogglePosition(12, 1);
            //currentPattern.TogglePosition(13, 1);
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            this.mainDisplayBox.Image = ImageGenerator.GenerateImage(currentPattern, (int)this.pixelDensity.Value);
        }

        private void mainDisplayBox_Click(object sender, EventArgs e)
        {
            Point myPoint = this.PointToClient(MousePosition);
            ProcessClick(myPoint.X, myPoint.Y);
        }

        private void ProcessClick(int x, int y)
        {
            int adjustedX = x - this.mainDisplayBox.Location.X;
            int adjustedY = y - this.mainDisplayBox.Location.Y;

            int correctX = (adjustedX % (this.mainDisplayBox.Width / 3)) / ((this.mainDisplayBox.Width / 3) / this.currentPattern.xSize);
            int correctY = (adjustedY % (this.mainDisplayBox.Height / 3)) / ((this.mainDisplayBox.Height / 3) / this.currentPattern.ySize);

            this.lblFeedBack.Text = correctX + "," + correctY;
            this.currentPattern.TogglePosition(correctX, correctY);
            UpdateDisplay();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Point myPoint = this.PointToClient(MousePosition);
            //ProcessClick(myPoint.X, myPoint.Y);

        }

        private void mainDisplayBox_MouseMove(object sender, MouseEventArgs e)
        {
            //Point myPoint = this.PointToClient(MousePosition);
            //ProcessClick(myPoint.X, myPoint.Y);
        }
    }
}
