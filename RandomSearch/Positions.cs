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
    public partial class Positions : Form
    {
        private int n;
        private Label[] positions;
        private Label[] headers; // надписи

        public Positions()
        {
            InitializeComponent();
        }

        private void Positions_Load(object sender, EventArgs e)
        {

        }

        public void showDialogWithN(int n, int str, int stolb)
        {
            this.n = n;
            positions = new Label[20];
            headers = new Label[20];
            foreach (Control control in Controls) // после этого в массиве positions все позиции
            {
                if (control is Label)
                {
                    Label label = control as Label;
                    for (int i = 0; i < 20; i++)
                    {
                        if (label.Name.Equals("label" + (i+1)))
                        {
                            positions[i] = label;
                        }
                        if (label.Name.Equals("header" + (i + 1)))
                        {
                            headers[i] = label;
                        }

                    }                 
                }
            }
            //
            int element = 1;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (!(i == 0 && j == 0))
                    {
                        positions[element].Location = new Point(positions[0].Location.X + j * 66, positions[0].Location.Y + i * 73);
                        headers[element].Location = new Point(headers[0].Location.X + j * 66, headers[0].Location.Y + i * 73);
                        element++;
                    }
                }
            }            
            //
            for (int i = n; i < 20; i++) // невидимые позиции
            {
                positions[i].Visible = false;
                headers[i].Visible = false;
            }
            if (label000.Location.X + label000.Size.Width < positions[stolb - 1].Location.X + positions[stolb-1].Size.Width)
            {
                Size = new Size(positions[stolb - 1].Location.X + 70, positions[n - stolb].Location.Y + 70);
            }
            else
            {
                Size = new Size(label000.Location.X + 250, positions[n - stolb].Location.Y + 70);
            }
            pictureBox1.Location = new Point(positions[0].Location.X - 30, positions[0].Location.Y - 30);
            pictureBox1.Size = new Size(positions[stolb-1].Location.X - positions[0].Location.X + 70, 
                positions[n-stolb].Location.Y - positions[0].Location.Y + 60);
            /*
            if (n <= 3)
            {
                Size = new Size(label000.Location.X + 250, positions[n - 1].Location.Y + 70);
            } 
            else
            {
                if (n == 4) Size = new Size(positions[n - 1].Location.X + 90, positions[n - 1].Location.Y + 70);
                Size = new Size(Size.Width -20,positions[n - 1].Location.Y + 70);
            }*/
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
