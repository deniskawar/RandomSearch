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
    public partial class Main : Form
    {
        private int iterationsAmount;
        private int stopIterations;
        private int realIterations;
        private int n;
        private int str_orig;
        private int stolb_orig;
        private Smezh smezh;
        private static Random random = new Random();
        private Rasst rasst;
        private Result result;
        private Positions positions;
        private GetSmezh getSmezh;
        private int[,] matrixSmezh;
        private int[,] matrixRasst;
        private int[] resultPositions;
        private int[] celRazmesh;
        private int celFunction = Int32.MaxValue;
        private int[] basicRazmesh;
        private int basicCelFunction = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void mainAlgorythm()
        {
            celRazmesh = new int[n];
            celFunction = Int32.MaxValue;
            int povtor = 0;
            int iteration = 0;
            while (iteration != iterationsAmount)
            {
                int[] randomNumbers = new int[n];
                for (int i = 0; i < n; i++) // заполняем массив рандомом
                {
                    while (true)
                    {
                        bool contains = false;
                        int tmpRand = random.Next(1, n + 1);
                        for (int j = 0; j < n; j++)
                        {
                            if (randomNumbers[j] == tmpRand)
                            {
                                contains = true;
                                break;
                            }
                        }
                        if (!contains)
                        {
                            randomNumbers[i] = tmpRand;
                            break;
                        }
                    }
                }
                resultPositions = new int[n];

                /////////////////////////////

                int tmpCelFunction = 0;

                // ВЫЧИСЛЕНИЕ ЦЕЛЕВОЙ ФУНКЦИИ
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tmpCelFunction = tmpCelFunction + matrixSmezh[randomNumbers[i]-1, randomNumbers[j]-1] * matrixRasst[i, j];
                        
                    }
                }
                tmpCelFunction /= 2;
                // ВЫЧИСЛЕНИЕ ЦЕЛЕВОЙ ФУНКЦИИ

                // ПРОВЕРКА И СРАВЕНИЕ
                if (tmpCelFunction == celFunction && stopIterations != 0 && iteration != 0)
                {
                    povtor++;
                    if (povtor == stopIterations) break;
                }

                if ((iteration == 0) || (tmpCelFunction < celFunction))
                {
                    celFunction = tmpCelFunction;
                    celRazmesh = randomNumbers;
                }

                // ПРОВЕРКА И СРАВЕНИЕ

                ////////////////////////////
                iteration++;
            }
            realIterations = iteration;            
        }

        private void countBasicRazmesh()
        {
            basicRazmesh = new int[n];
            basicCelFunction = 0;

            for (int i = 0; i < n; i++) basicRazmesh[i] = i+1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    basicCelFunction = basicCelFunction + matrixSmezh[basicRazmesh[i] - 1, basicRazmesh[j] - 1] * matrixRasst[i, j];

                }
            }
            basicCelFunction /= 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonShowResult.Enabled = true;
            buttonMakeResult.Enabled = false;
            mainAlgorythm();
            countBasicRazmesh();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGetRasst.Enabled = false;
            buttonGetSmezh.Enabled = false;
            buttonPutSmezh.Enabled = false;
            buttonMakeResult.Enabled = false;
            buttonShowPositions.Enabled = false;
            buttonShowResult.Enabled = false;
            buttonStrStolb.Enabled = false;
            comboBox1.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox2.Text = "0";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getSmezh = new GetSmezh(matrixSmezh);
            getSmezh.showMatrixWithN(n);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            string s = textBoxN.Text;
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            TextBox textBoxSample = null;
            string errorMessage = "Вы ввели не целое числовое значение";
            try
            {
                textBoxSample = textBoxN;
                int n = Int32.Parse(s);
                if (n < 2 || n > 20)
                {
                    errorMessage = "Введенное число выходит из допустимого диапазона (от 2 до 20)";
                    throw new FormatException();
                }
                textBoxN.BackColor = Color.White;
                textBoxSample = textBox1;

                iterationsAmount = Int32.Parse(t1);
                if (iterationsAmount < 1)
                {
                    errorMessage = "Количество итераций должно быть не меньше 1";
                    throw new FormatException();
                }
                textBox1.BackColor = Color.White;
                textBoxSample = textBox2;

                stopIterations = Int32.Parse(t2);
                if (stopIterations < 0)
                {
                    errorMessage = "Введено отрицательное значение";
                    throw new FormatException();
                }
                textBox2.BackColor = Color.White;
                this.n = n;
                buttonStrStolb.Enabled = true;
                buttonN.Enabled = false;
                textBoxN.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                switch (n)
                {
                    case 2:
                        comboBox1.Items.Add("2 X 2");
                        break;
                    case 3:
                        comboBox1.Items.Add("2 X 2");
                        break;
                    case 4:
                        comboBox1.Items.Add("2 X 2");
                        break;
                    case 5:
                        comboBox1.Items.Add("2 X 3");
                        comboBox1.Items.Add("3 X 2");
                        break;
                    case 6:
                        comboBox1.Items.Add("2 X 3");
                        comboBox1.Items.Add("3 X 2");
                        break;
                    case 7:
                        comboBox1.Items.Add("2 X 4");
                        comboBox1.Items.Add("4 X 2");
                        break;
                    case 8:
                        comboBox1.Items.Add("2 X 4");
                        comboBox1.Items.Add("4 X 2");
                        break;
                    case 9:
                        comboBox1.Items.Add("3 X 3");
                        break;
                    case 10:
                        comboBox1.Items.Add("2 X 5");
                        comboBox1.Items.Add("5 X 2");
                        break;
                    case 11:
                        comboBox1.Items.Add("3 X 4");
                        comboBox1.Items.Add("4 X 3");
                        break;
                    case 12:                        
                        comboBox1.Items.Add("3 X 4");
                        comboBox1.Items.Add("4 X 3");
                        comboBox1.Items.Add("2 X 6");
                        comboBox1.Items.Add("6 X 2");
                        break;
                    case 13:
                        comboBox1.Items.Add("2 X 7");
                        comboBox1.Items.Add("7 X 2");
                        break;
                    case 14:
                        comboBox1.Items.Add("2 X 7");
                        comboBox1.Items.Add("7 X 2");
                        break;
                    case 15:
                        comboBox1.Items.Add("5 X 3");
                        comboBox1.Items.Add("3 X 5");
                        break;
                    case 16:
                        comboBox1.Items.Add("4 X 4");
                        break;
                    case 17:
                        comboBox1.Items.Add("6 X 3");
                        comboBox1.Items.Add("3 X 6");
                        comboBox1.Items.Add("2 X 9");
                        comboBox1.Items.Add("9 X 2");
                        break;
                    case 18:
                        comboBox1.Items.Add("6 X 3");
                        comboBox1.Items.Add("3 X 6");
                        comboBox1.Items.Add("2 X 9");
                        comboBox1.Items.Add("9 X 2");
                        break;
                    case 19:
                        comboBox1.Items.Add("5 X 4");
                        comboBox1.Items.Add("4 X 5");
                        break;
                    case 20:
                        comboBox1.Items.Add("5 X 4");
                        comboBox1.Items.Add("4 X 5");
                        break;
                }
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = 0;

            }
            catch (FormatException ex)
            {
                textBoxSample.BackColor = Color.Pink;
                MessageBox.Show(errorMessage, "Сообщение об ошибке");
            }
            
        }

        private void buttonPutSmezh_Click(object sender, EventArgs e)
        {
            smezh = new Smezh(this);
            smezh.showDialogWithN(n);
            matrixSmezh = smezh.getSmezhMatrix();       
        }

        private void buttonGetRasst_Click(object sender, EventArgs e)
        {
            rasst = new Rasst();
            matrixRasst = rasst.determineAndGetRasst(n, str_orig, stolb_orig);
            rasst.Show();
        }
        public void setEnabledButtonResult(bool boo)
        {
            buttonMakeResult.Enabled = boo;
        }
        public void setEnabledButtonGetSmezh(bool boo)
        {
            buttonGetSmezh.Enabled = boo;
        }
        public void setEnabledButtonPutSmezh(bool boo)
        {
            buttonPutSmezh.Enabled = boo;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            n = 0;
            smezh = null;
            result = null;
            rasst = null;
            buttonPutSmezh.Enabled = false;
            buttonGetRasst.Enabled = false;
            buttonGetSmezh.Enabled = false;
            buttonN.Enabled = true;
            buttonMakeResult.Enabled = false;
            textBoxN.Enabled = false;
            textBoxN.Text = null;
            textBoxN.Enabled = true;
            buttonShowResult.Enabled = false;
            buttonShowPositions.Enabled = false;
            buttonStrStolb.Enabled = false;
            comboBox1.Items.Clear();
            comboBox1.Enabled = false;
            rasst = new Rasst();
            celFunction = Int32.MaxValue;
            textBox2.Text = "0";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = null;

        }

        private void buttonShowPositions_Click(object sender, EventArgs e)
        {
            positions = new Positions();
            positions.showDialogWithN(n,str_orig, stolb_orig);
        }

        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            result = new Result(celRazmesh, basicCelFunction, celFunction, n, realIterations, str_orig, stolb_orig);
            result.showResult();
        }

        private void buttonStrStolb_Click(object sender, EventArgs e)
        {
            try
            {
                int str = 0;
                int stolb = 0;
                switch (n)
                {
                    case 2:
                        str = 2;
                        stolb = 2;
                        break;
                    case 3:
                        str = 2;
                        stolb = 2;
                        break;
                    case 4:
                        str = 2;
                        stolb = 2;
                        break;
                    case 5:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 3;
                        }
                        else
                        {
                            str = 3;
                            stolb = 2;
                        }
                        break;
                    case 6:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 3;
                        }
                        else
                        {
                            str = 3;
                            stolb = 2;
                        }
                        break;
                    case 7:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 4;
                        }
                        else
                        {
                            str = 4;
                            stolb = 2;
                        }
                        break;
                    case 8:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 4;
                        }
                        else
                        {
                            str = 4;
                            stolb = 2;
                        }
                        break;
                    case 9:
                        str = 3;
                        stolb = 3;
                        break;
                    case 10:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 5;
                        }
                        else
                        {
                            str = 5;
                            stolb = 2;
                        }
                        break;
                    case 11:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 3;
                            stolb = 4;
                        }
                        else
                        {
                            str = 4;
                            stolb = 3;
                        }
                        break;
                    case 12:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 3;
                            stolb = 4;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 1)
                        {
                            str = 4;
                            stolb = 3;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 2)
                        {
                            str = 2;
                            stolb = 6;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 3)
                        {
                            str = 6;
                            stolb = 2;
                        }
                        break;
                    case 13:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 7;
                        }
                        else
                        {
                            str = 7;
                            stolb = 2;
                        }
                        break;
                    case 14:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 2;
                            stolb = 7;
                        }
                        else
                        {
                            str = 7;
                            stolb = 2;
                        }
                        break;
                    case 15:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 5;
                            stolb = 3;
                        }
                        else
                        {
                            str = 3;
                            stolb = 5;
                        }
                        break;
                    case 16:
                        str = 4;
                        stolb = 4;
                        break;
                    case 17:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 6;
                            stolb = 3;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 1)
                        {
                            str = 3;
                            stolb = 6;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 2)
                        {
                            str = 2;
                            stolb = 9;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 3)
                        {
                            str = 9;
                            stolb = 2;
                        }
                        break;
                    case 18:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 6;
                            stolb = 3;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 1)
                        {
                            str = 3;
                            stolb = 6;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 2)
                        {
                            str = 2;
                            stolb = 9;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 3)
                        {
                            str = 9;
                            stolb = 2;
                        }
                        break;
                    case 19:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 5;
                            stolb = 4;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 1)
                        {
                            str = 4;
                            stolb = 5;
                        }
                        break;
                    case 20:
                        if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 0)
                        {
                            str = 5;
                            stolb = 4;
                        }
                        else if (comboBox1.Items.IndexOf(comboBox1.SelectedItem) == 1)
                        {
                            str = 4;
                            stolb = 5;
                        }
                        break;
                }
                str_orig = str;
                stolb_orig = stolb;
                buttonPutSmezh.Enabled = true;
                buttonGetRasst.Enabled = true;
                buttonShowPositions.Enabled = true;
                buttonStrStolb.Enabled = false;
                comboBox1.Enabled = false;
                rasst = new Rasst();
                matrixRasst = rasst.determineAndGetRasst(n, str, stolb);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка ввода", "Ошибка ввода");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
