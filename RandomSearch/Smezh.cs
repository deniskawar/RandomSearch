using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RandomSearch
{
    public partial class Smezh : Form
    {
        private TextBox[,] smezhTextBox;
        private int[,] smezhMatrix;
        private int n;
        private Main parent;
        private string errorMessage;
        private int errorI;
        private int errorJ;

        public Smezh(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public int[,] getSmezhMatrix()
        {
            return smezhMatrix;
        }
        public void showDialogWithN(int n) // вызывается из Main, показывает окно с матрицей смежности
        {
            this.n = n;
            TextBox[] tmpTextBox = new TextBox[400];
            int k = 0;
            foreach (Control contr in Controls) // заполняем массив textbox-ов, чтобы удобнее было с ними работать
            {
                if (contr is TextBox)
                {
                    TextBox txt = contr as TextBox;
                    tmpTextBox[k] = txt;
                    k++;
                }                
            }
            smezhTextBox = new TextBox[20,20];
            for (int i = 0; i < 20; i++) // закидываем боксы в двумерный массив по имени
            {
                for (int j = 0; j < 20; j++)
                {
                    string test = "textBox" + i + "_" + j;
                    foreach (TextBox txtbx in tmpTextBox)
                    {
                        if (txtbx.Name.Equals(test)) smezhTextBox[i,j] = txtbx;
                    }
                }
            }
            for (int i = 0; i < 20; i++) // делаем неактивные ячейки невидимыми
            {
                for (int j = 0; j < 20; j++)
                {
                    if ((i >= n) || (j >= n)) smezhTextBox[i, j].Visible = false;
                }
            }
            foreach (Control contr in Controls)
            {
                if (contr is Label)
                {
                    Label tmpLabel = (Label) contr;
                    for (int i = n+1; i <= 20; i++)
                    {
                        string str = "label" + i + "str";
                        string stolb = "label" + i + "stolb";
                        if ((tmpLabel.Name.Equals(str)) || (tmpLabel.Name.Equals(stolb))) tmpLabel.Visible = false;
                    } 
                }
            }
            if (n >= 9) // выравнивание по координатам
            {
                Size = new Size(smezhTextBox[0,n-1].Location.X + 52, smezhTextBox[n-1,0].Location.Y + 63);
            }
            else
            {
                Size = new Size(buttonAccept.Location.X + 95, smezhTextBox[n-1,0].Location.Y + 63);
            }            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        smezhTextBox[i, j].Enabled = false;
                        if (i == j) smezhTextBox[i, j].Text = "0";
                    }
                }
            }        
            ShowDialog();
        }

        public int[,] makeMatrixSmezh()
        {
            int[,] smezhMatrix = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        errorI = i;
                        errorJ = j;
                        smezhMatrix[i, j] = Int32.Parse(smezhTextBox[i, j].Text);
                        errorMessage = "В ячейку введено не целочисленное значение";
                        if (smezhMatrix[i, j] < 0)
                        {
                            errorMessage = "В ячейку введено отрицательное значение";
                            throw new FormatException();
                        }
                    }
                }
            }
            //
            //
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        smezhTextBox[j, i].Text = smezhTextBox[i, j].Text;
                    }
                }
            }
            //
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        smezhMatrix[j, i] = smezhMatrix[i,j];
                    }
                }
            }
            //
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    errorI = i;
                    errorJ = j;
                    if (smezhMatrix[i, j] != smezhMatrix[j, i])
                    {
                        errorMessage = "Матрица введена не симметрично";
                        throw new FormatException();
                    }
                }
            }
            return smezhMatrix;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Smezh_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox209_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
            {
                if (i!=j) smezhTextBox[i,j].BackColor = Color.White;
            }

            errorMessage = "В одной из ячеек введено некорректное значение.";
            try
            {
                smezhMatrix = makeMatrixSmezh();
                parent.setEnabledButtonGetSmezh(true);
                parent.setEnabledButtonPutSmezh(false);
                parent.setEnabledButtonResult(true);
                this.Close();
            }
            catch (FormatException formatEx)
            {
                smezhTextBox[errorI,errorJ].BackColor = Color.Pink;
                if (errorMessage.Equals("Матрица введена не симметрично")) smezhTextBox[errorJ, errorI].BackColor = Color.Pink;
                MessageBox.Show(errorMessage, "Сообщение об ошибке");
            }
        }

        private void label1stolb_Click(object sender, EventArgs e)
        {

        }
    }
}
