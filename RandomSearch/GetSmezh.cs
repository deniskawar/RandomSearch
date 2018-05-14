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
    public partial class GetSmezh : Form
    {
        private int[,] smezhMatrix;
        private Label[,] smezhLabels;
        private int n;

        public GetSmezh(int[,] smezhMatrix)
        {
            InitializeComponent();
            this.smezhMatrix = smezhMatrix;
        }

        public void showMatrixWithN(int n)
        {
            this.n = n;
            smezhLabels = new Label[20, 20];
            Label[] tmpLabels = new Label[400];
            int k = 0;
            foreach (Control contr in Controls) // заполняем массив textbox-ов, чтобы удобнее было с ними работать
            {
                if (contr is Label)
                {
                    Label label = contr as Label;
                    if (label.Name.Contains("_"))
                    {
                        tmpLabels[k] = label;
                        k++;
                    }
                }
            }
            foreach (Label label in tmpLabels)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (label.Name.Equals("label" + i + "_" + j))
                        {
                            smezhLabels[i, j] = label;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++) // видимость
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((i >= n) || (j >= n))
                        smezhLabels[i, j].Visible = false;
                }
            }
            foreach (Control contr in Controls)
            {
                if (contr is Label)
                {
                    Label tmpLabel = (Label)contr;
                    for (int i = n + 1; i <= 20; i++)
                    {
                        string str = "label" + i + "str";
                        string stolb = "label" + i + "stolb";
                        if ((tmpLabel.Name.Equals(str)) || (tmpLabel.Name.Equals(stolb))) tmpLabel.Visible = false;
                    }
                }
            }
            if (n < 6)
            {
                Size = new Size(label1.Location.X + 222, smezhLabels[n - 1, n - 1].Location.Y + 70);
            }
            else
            {
                Size = new Size(smezhLabels[n - 1, n - 1].Location.X + 57, smezhLabels[n - 1, n - 1].Location.Y + 70);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    smezhLabels[i, j].Text = "" + smezhMatrix[i,j];
                }
            }
            Show();
        }

        private void GetSmezh_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
