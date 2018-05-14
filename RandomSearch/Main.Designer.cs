namespace RandomSearch
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonMakeResult = new System.Windows.Forms.Button();
            this.buttonPutSmezh = new System.Windows.Forms.Button();
            this.buttonGetSmezh = new System.Windows.Forms.Button();
            this.buttonGetRasst = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonShowPositions = new System.Windows.Forms.Button();
            this.buttonShowResult = new System.Windows.Forms.Button();
            this.buttonStrStolb = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMakeResult
            // 
            this.buttonMakeResult.Location = new System.Drawing.Point(213, 302);
            this.buttonMakeResult.Name = "buttonMakeResult";
            this.buttonMakeResult.Size = new System.Drawing.Size(203, 23);
            this.buttonMakeResult.TabIndex = 0;
            this.buttonMakeResult.Text = "Выполнить размещение";
            this.buttonMakeResult.UseVisualStyleBackColor = true;
            this.buttonMakeResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPutSmezh
            // 
            this.buttonPutSmezh.Location = new System.Drawing.Point(213, 273);
            this.buttonPutSmezh.Name = "buttonPutSmezh";
            this.buttonPutSmezh.Size = new System.Drawing.Size(203, 23);
            this.buttonPutSmezh.TabIndex = 3;
            this.buttonPutSmezh.Text = "Задать матрицу смежности";
            this.buttonPutSmezh.UseVisualStyleBackColor = true;
            this.buttonPutSmezh.Click += new System.EventHandler(this.buttonPutSmezh_Click);
            // 
            // buttonGetSmezh
            // 
            this.buttonGetSmezh.Location = new System.Drawing.Point(4, 302);
            this.buttonGetSmezh.Name = "buttonGetSmezh";
            this.buttonGetSmezh.Size = new System.Drawing.Size(203, 23);
            this.buttonGetSmezh.TabIndex = 4;
            this.buttonGetSmezh.Text = "Посмотреть матрицу смежности";
            this.buttonGetSmezh.UseVisualStyleBackColor = true;
            this.buttonGetSmezh.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonGetRasst
            // 
            this.buttonGetRasst.Location = new System.Drawing.Point(4, 273);
            this.buttonGetRasst.Name = "buttonGetRasst";
            this.buttonGetRasst.Size = new System.Drawing.Size(203, 23);
            this.buttonGetRasst.TabIndex = 5;
            this.buttonGetRasst.Text = "Посмотреть матрицу расстояний";
            this.buttonGetRasst.UseVisualStyleBackColor = true;
            this.buttonGetRasst.Click += new System.EventHandler(this.buttonGetRasst_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(124, 384);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(190, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество размещаемых элементов(макс. 20):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(263, 7);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(84, 20);
            this.textBoxN.TabIndex = 8;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(278, 164);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(51, 21);
            this.buttonN.TabIndex = 9;
            this.buttonN.Text = "Ввод";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonShowPositions
            // 
            this.buttonShowPositions.Location = new System.Drawing.Point(4, 244);
            this.buttonShowPositions.Name = "buttonShowPositions";
            this.buttonShowPositions.Size = new System.Drawing.Size(203, 23);
            this.buttonShowPositions.TabIndex = 10;
            this.buttonShowPositions.Text = "Посмотреть расположение позиций\r\n";
            this.buttonShowPositions.UseVisualStyleBackColor = true;
            this.buttonShowPositions.Click += new System.EventHandler(this.buttonShowPositions_Click);
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.Location = new System.Drawing.Point(4, 331);
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(203, 23);
            this.buttonShowResult.TabIndex = 11;
            this.buttonShowResult.Text = "Показать результат";
            this.buttonShowResult.UseVisualStyleBackColor = true;
            this.buttonShowResult.Click += new System.EventHandler(this.buttonShowResult_Click);
            // 
            // buttonStrStolb
            // 
            this.buttonStrStolb.Location = new System.Drawing.Point(365, 206);
            this.buttonStrStolb.Name = "buttonStrStolb";
            this.buttonStrStolb.Size = new System.Drawing.Size(51, 21);
            this.buttonStrStolb.TabIndex = 16;
            this.buttonStrStolb.Text = "Ввод";
            this.buttonStrStolb.UseVisualStyleBackColor = true;
            this.buttonStrStolb.Click += new System.EventHandler(this.buttonStrStolb_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Размер платы (кол-во строк X кол-во столбцов):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Количество итераций: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 91);
            this.label3.TabIndex = 23;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(320, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Made by Denis Yakovlev";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonStrStolb);
            this.Controls.Add(this.buttonShowResult);
            this.Controls.Add(this.buttonShowPositions);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGetRasst);
            this.Controls.Add(this.buttonGetSmezh);
            this.Controls.Add(this.buttonPutSmezh);
            this.Controls.Add(this.buttonMakeResult);
            this.Name = "Main";
            this.Text = "Метод случайного поиска";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMakeResult;
        private System.Windows.Forms.Button buttonPutSmezh;
        private System.Windows.Forms.Button buttonGetSmezh;
        private System.Windows.Forms.Button buttonGetRasst;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonShowPositions;
        private System.Windows.Forms.Button buttonShowResult;
        private System.Windows.Forms.Button buttonStrStolb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

