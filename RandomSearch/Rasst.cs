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
    public partial class Rasst : Form
    {
        private int n;
        private int str_orig;
        private int stolb_orig;
        private Label[,] rasstLabels;
        private int[,] rasstReal;

        public Rasst()
        {
            InitializeComponent();
        }
        public int[,] getMatrixRasst()
        {
            return rasstReal;
        }

        private void Rasst_Load(object sender, EventArgs e)
        {

        }
        public int[,] determineAndGetRasst(int n, int str_orig, int stolb_orig)
        {
            this.n = n;
            this.stolb_orig = stolb_orig;
            this.str_orig = str_orig;
            rasstReal = new int[n, n];
            rasstLabels = new Label[20, 20];
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
                            rasstLabels[i, j] = label;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++) // видимость
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((i >= n) || (j >= n))
                        rasstLabels[i, j].Visible = false;
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
                Size = new Size(label1.Location.X + 222, rasstLabels[n - 1, n - 1].Location.Y + 70);
            }
            else
            {
                Size = new Size(rasstLabels[n - 1, n - 1].Location.X + 60, rasstLabels[n - 1, n - 1].Location.Y + 70);
            }
            determineAndShowRasst();
            return rasstReal;
        }
        public void showDialogWithN(int n)
        {
            this.n = n; /*
            rasstReal = new int[n, n];
            rasstLabels = new Label[20, 20];
            Label[] tmpLabels = new Label[400];
            int k = 0;
            foreach (Control contr in Controls) // заполняем массив textbox-ов, чтобы удобнее было с ними работать
            {
                if (contr is Label)
                {
                    Label label = contr as Label;
                    if (label.Name.Contains("_")) {
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
                            rasstLabels[i,j] = label;
                        }
                    }
                }
            }
            */
            for (int i = 0; i < 20; i++) // видимость
            { 
                for (int j = 0; j < 20; j++)
                {
                    if ((i >= n) || (j >= n))
                    rasstLabels[i, j].Visible = false;
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
                Size = new Size(label1.Location.X + 222, rasstLabels[n-1,n-1].Location.Y + 70);
            }
            else
            {
                Size = new Size(rasstLabels[n - 1, n - 1].Location.X + 60, rasstLabels[n - 1, n - 1].Location.Y + 70);
            }
            determineAndShowRasst();
            Show();

        }

        private void determineAndShowRasst()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (str_orig < stolb_orig)
                    {
                        rasstLabels[i, j].Text = "" + (Math.Abs(i / (str_orig + Math.Abs(stolb_orig - str_orig))
                            - j / (str_orig + Math.Abs(stolb_orig - str_orig)))
                            + Math.Abs(i % stolb_orig - j % stolb_orig));
                    }
                    else
                    {
                        rasstLabels[i, j].Text = "" + ( Math.Abs(i / str_orig - j / str_orig)
                            + Math.Abs(i % (stolb_orig + Math.Abs(stolb_orig - str_orig))
                            - j % (stolb_orig + Math.Abs(stolb_orig - str_orig))) );
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rasstReal[i,j] = Int32.Parse(rasstLabels[i,j].Text); 
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
