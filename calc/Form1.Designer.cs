namespace calc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.zap = new System.Windows.Forms.Button();
            this.buttonPlusToMin = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonProis = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonsqrt = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonravno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(759, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ClearALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zap
            // 
            this.zap.Location = new System.Drawing.Point(710, 357);
            this.zap.Name = "zap";
            this.zap.Size = new System.Drawing.Size(75, 23);
            this.zap.TabIndex = 2;
            this.zap.Text = ",";
            this.zap.UseVisualStyleBackColor = true;
            this.zap.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPlusToMin
            // 
            this.buttonPlusToMin.Location = new System.Drawing.Point(710, 164);
            this.buttonPlusToMin.Name = "buttonPlusToMin";
            this.buttonPlusToMin.Size = new System.Drawing.Size(75, 23);
            this.buttonPlusToMin.TabIndex = 3;
            this.buttonPlusToMin.Text = "+/-";
            this.buttonPlusToMin.UseVisualStyleBackColor = true;
            this.buttonPlusToMin.Click += new System.EventHandler(this.buttonPlusToMin_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(710, 322);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 28);
            this.buttonMul.TabIndex = 4;
            this.buttonMul.Text = "*";
            this.buttonMul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(710, 287);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 29);
            this.buttonDiv.TabIndex = 5;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(710, 251);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 30);
            this.buttonSum.TabIndex = 6;
            this.buttonSum.Text = "+";
            this.buttonSum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(710, 222);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 7;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonProis
            // 
            this.buttonProis.Location = new System.Drawing.Point(710, 193);
            this.buttonProis.Name = "buttonProis";
            this.buttonProis.Size = new System.Drawing.Size(75, 23);
            this.buttonProis.TabIndex = 8;
            this.buttonProis.Text = "a^b";
            this.buttonProis.UseVisualStyleBackColor = true;
            this.buttonProis.Click += new System.EventHandler(this.buttonProis_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 415);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonone
            // 
            this.buttonone.Location = new System.Drawing.Point(12, 386);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(75, 23);
            this.buttonone.TabIndex = 10;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.buttonone_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonsqrt
            // 
            this.buttonsqrt.Location = new System.Drawing.Point(12, 107);
            this.buttonsqrt.Name = "buttonsqrt";
            this.buttonsqrt.Size = new System.Drawing.Size(75, 23);
            this.buttonsqrt.TabIndex = 19;
            this.buttonsqrt.Text = "sqrt";
            this.buttonsqrt.UseVisualStyleBackColor = true;
            this.buttonsqrt.Click += new System.EventHandler(this.buttonsqrt_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(710, 135);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(75, 23);
            this.buttonSquare.TabIndex = 20;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(710, 386);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Factorial";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonravno
            // 
            this.buttonravno.Location = new System.Drawing.Point(710, 106);
            this.buttonravno.Name = "buttonravno";
            this.buttonravno.Size = new System.Drawing.Size(75, 23);
            this.buttonravno.TabIndex = 22;
            this.buttonravno.Text = "=";
            this.buttonravno.UseVisualStyleBackColor = true;
            this.buttonravno.Click += new System.EventHandler(this.buttonravno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.buttonravno);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonsqrt);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonone);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonProis);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonPlusToMin);
            this.Controls.Add(this.zap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор С#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zap;
        private System.Windows.Forms.Button buttonPlusToMin;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonProis;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonsqrt;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonravno;
    }
}

