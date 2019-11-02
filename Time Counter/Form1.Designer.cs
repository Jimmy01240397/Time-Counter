namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 303);
            this.button1.TabIndex = 0;
            this.button1.Text = "計時";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 303);
            this.button2.TabIndex = 0;
            this.button2.Text = "倒數";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(150, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 151);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "000";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "    00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "開始";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(463, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 61);
            this.button5.TabIndex = 3;
            this.button5.Text = "歸零";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(374, 370);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 61);
            this.button6.TabIndex = 3;
            this.button6.Text = "記錄";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(6, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 504);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Location = new System.Drawing.Point(6, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 487);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Location = new System.Drawing.Point(128, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(660, 69);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.ok);
            this.panel4.Controls.Add(this.number1);
            this.panel4.Controls.Add(this.number6);
            this.panel4.Controls.Add(this.number3);
            this.panel4.Controls.Add(this.number7);
            this.panel4.Controls.Add(this.number2);
            this.panel4.Controls.Add(this.number8);
            this.panel4.Controls.Add(this.number0);
            this.panel4.Controls.Add(this.number9);
            this.panel4.Controls.Add(this.number4);
            this.panel4.Controls.Add(this.number5);
            this.panel4.Location = new System.Drawing.Point(225, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 230);
            this.panel4.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(257, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "重設";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.no_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(37, 173);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(181, 44);
            this.ok.TabIndex = 6;
            this.ok.Text = "確定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(13, 16);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(64, 55);
            this.number1.TabIndex = 5;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(13, 94);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(64, 55);
            this.number6.TabIndex = 5;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(213, 16);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(64, 55);
            this.number3.TabIndex = 5;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(113, 94);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(64, 55);
            this.number7.TabIndex = 5;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(113, 16);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(64, 55);
            this.number2.TabIndex = 5;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(213, 94);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(64, 55);
            this.number8.TabIndex = 5;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(413, 94);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(64, 55);
            this.number0.TabIndex = 5;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(313, 94);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(64, 55);
            this.number9.TabIndex = 5;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(313, 16);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(64, 55);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(413, 16);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(64, 55);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button button7;
    }
}

