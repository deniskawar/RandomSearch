using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSearch
{
    public partial class Result : Form
    {
        private Label[] resultPositions;
        private int[] razmesh;
        private int L0;
        private int L;
        private int n;
        private int realIterations;
        private int str;
        private int stolb;

        public Result(int[] razmesh, int L0, int L, int n, int realIterations, int str, int stolb)
        {
            InitializeComponent();
            this.razmesh = razmesh;
            this.L0 = L0;
            this.L = L;
            this.n = n;
            this.realIterations = realIterations;
            this.str = str;
            this.stolb = stolb;
        }

        public void showResult()
        {
            resultPositions = new Label[20];
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label label = control as Label;
                    for (int i = 0; i < 20; i++)
                    {
                        if (label.Name.Equals("label" + (i+1)))
                        {
                            resultPositions[i] = label;
                        }
                    } 
                }
            }
            for (int i = n; i < 20; i++)
            {
                resultPositions[i].Visible = false;
            }
            for (int i = 0; i < n; i++)
            {
                resultPositions[i].Text = "e" + razmesh[i];
            }
            //
            int maxY = 0;
            for (int i = 0; i < n; i++)
            {
                if (maxY < resultPositions[i].Location.Y + resultPositions[i].Height) maxY = resultPositions[i].Location.Y + resultPositions[i].Height;
            }
            if (maxY < labelL0.Location.Y) maxY = labelL0.Location.Y;
            if (maxY < labelL.Location.Y) maxY = labelL.Location.Y;
            if (maxY < labelRealIterations.Location.Y) maxY = labelRealIterations.Location.Y;

            int element = 1;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (!(i == 0 && j == 0))
                    {
                        resultPositions[element].Location = new Point(resultPositions[0].Location.X + j * 77, resultPositions[0].Location.Y + i * 77);
                        element++;
                    }
                }
            }
            Size = new Size(labelL0.Location.X + labelL0.Width + 25, maxY + 90);
            //
            labelL0.Text = "" + L0;
            labelL.Text  = "" + L;
            labelRealIterations.Text = "" + realIterations;

            pictureBox1.Location = new Point(resultPositions[0].Location.X - 10, resultPositions[0].Location.Y - 10);
            pictureBox1.Size = new Size(resultPositions[stolb - 1].Location.X - resultPositions[0].Location.X + 85,
                resultPositions[n - stolb].Location.Y - resultPositions[0].Location.Y + 85);
            Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
