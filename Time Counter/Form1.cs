using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FontStyle fs;
        FontFamily fm;
        Font f;
        Stopwatch sw = new Stopwatch();
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static float size;
        public static bool stop = true;
        public static bool off = false;
        public static double milliseconds;
        public static int seconds;
        public static int minute;
        public static int hour;
        public static int x = 0;
        public Form1()
        {
            InitializeComponent();
            fm = new FontFamily(label1.Font.Name);
            f = new Font(fm, 80, FontStyle.Bold);
            label1.Font = f;
            fm = new FontFamily(label2.Font.Name);
            f = new Font(fm, 16, FontStyle.Bold);
            label2.Font = f;
            fm = new FontFamily(button1.Font.Name);
            f = new Font(fm, 30, FontStyle.Bold);
            button1.Font = f;
            fm = new FontFamily(button2.Font.Name);
            f = new Font(fm, 30, FontStyle.Bold);
            button2.Font = f;

            timer1.Interval = 1;
            timer2.Interval = 800;
            timer1.Start();
            timer2.Start();
        }

        private void playSound(string path)
        {
            WMPLib.WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();
            sound.URL = path;
            sound.controls.play();
        }


        private string RoundDown(double d, int digits)
        {
            if (d == Double.NaN || d == 0)
                return "0";

            string s = "";
            if (d.ToString().IndexOf(".") != -1)
            {
                if (digits == 0)
                    s = d.ToString().Substring(0, d.ToString().IndexOf("."));
                else
                {
                    int length = digits + d.ToString().IndexOf(".") + 1;
                    if (d.ToString().Length < length)
                        s = d.ToString().PadRight(length, '0');
                    else
                        s = d.ToString().Substring(0, digits + d.ToString().IndexOf(".") + 1);
                }
            }
            else
                return d.ToString();
            return s;
        }

        private int BackTen(int number)
        {
            int s = number;
            while(s>99)
            {
                s=s-100;
            }
            return s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            button6.Visible = false;
            numericUpDown1.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            button6.Visible = true;
            numericUpDown1.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Visible == true)
            {
                if (stop == false)
                {
                    milliseconds = milliseconds + 15.6;
                    if (milliseconds >= 1000)
                    {
                        milliseconds = milliseconds - 1000;
                        seconds++;
                    }
                    if (seconds >= 60)
                    {
                        seconds = seconds - 60;
                        minute++;
                    }
                    if (minute >= 60)
                    {
                        minute = minute - 60;
                        hour++;
                    }
                    label2.Text = RoundDown(milliseconds, 0);
                    label1.Text = "";
                    if (seconds < 10)
                    {
                        if (minute < 10)
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                            }
                        }
                        else
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                            }
                        }
                    }
                    else
                    {
                        if (minute < 10)
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                            }
                        }
                        else
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                            }
                        }
                    }
                }
            }
            else
            {
                if (stop == false)
                {
                    milliseconds = milliseconds - 15.6;
                    if (milliseconds < 0)
                    {
                        milliseconds = milliseconds + 1000;
                        seconds--;
                    }
                    if (seconds < 0)
                    {
                        seconds = seconds + 60;
                        minute--;
                    }
                    if (minute < 0)
                    {
                        minute = minute + 60;
                        hour--;
                    }
                    label2.Text = RoundDown(milliseconds, 0);
                    label1.Text = "";
                    if (seconds < 10)
                    {
                        if (minute < 10)
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                            }
                        }
                        else
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                            }
                        }
                    }
                    else
                    {
                        if (minute < 10)
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                            }
                        }
                        else
                        {
                            if (hour < 10)
                            {
                                label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                            }
                            else
                            {
                                label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                            }
                        }
                    }
                    if (hour < 0)
                    {
                        label1.Text = "    00:00:00";
                        label2.Text = "000";
                        playSound("classic_alarm.mp3");
                        button4.Visible = false;
                        stop = true;
                        button4.Text = "暫停";
                        off = true;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
            panel1.BackColor = System.Drawing.SystemColors.Control;
            off = false;
            button4.Visible = true;
            panel3.Visible = false;
            panel2.Visible = true;
            button6.Visible = false;
            numericUpDown1.Visible = false;
            stop = true;
            button4.Text = "開始";
            milliseconds = 0;
            seconds = 0;
            minute = 0;
            hour = 0;
            label1.Text = "    00:00:00";
            label2.Text = "000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (stop)
            {
                case true:
                    stop = false; 
                    button4.Text = "暫停";
                    break;
                case false:
                    stop = true;
                    button4.Text = "開始";
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Stop();
            panel1.BackColor = System.Drawing.SystemColors.Control;
            off = false;
            button4.Visible = true;
            stop = true;
            button4.Text = "開始";
            milliseconds = 0;
            seconds = 0;
            minute = 0;
            hour = 0;
            label1.Text = "    00:00:00";
            label2.Text = "000";
            if (numericUpDown1.Visible == false)
            {
                panel5.Visible = false;
                panel4.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (off == true)
            {
                
                if (panel1.BackColor == System.Drawing.SystemColors.Control)
                {
                    panel1.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    panel1.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void number1_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 1;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 2;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 3;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 4;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 5;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 6;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 7;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 8;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            seconds = seconds * 10 + 9;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                x = 2;
            }
            else
            {
                x = 1;
            }
            seconds = seconds * 10 + 0;
            if (seconds > 99 || seconds == 0)
            {
                minute = minute * 10 + (seconds - BackTen(seconds)) / 100;
                seconds = BackTen(seconds);
            }
            if (minute > 99 || minute == 0)
            {
                hour = hour * 10 + (minute - BackTen(minute)) / 100;
                minute = BackTen(minute);
            }
            if (hour > 99 || hour == 0)
            {
                hour = BackTen(hour);
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            x = 0;
            if (seconds >= 60)
            {
                seconds = seconds - 60;
                minute++;
            }
            if (minute >= 60)
            {
                minute = minute - 60;
                hour++;
            }
            label1.Text = "";
            if (seconds < 10)
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":0" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":0" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":0" + seconds;
                    }
                }
            }
            else
            {
                if (minute < 10)
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":0" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":0" + minute + ":" + seconds;
                    }
                }
                else
                {
                    if (hour < 10)
                    {
                        label1.Text = "    0" + hour + ":" + minute + ":" + seconds;
                    }
                    else
                    {
                        label1.Text = "    " + hour + ":" + minute + ":" + seconds;
                    }
                }
            }
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void no_Click(object sender, EventArgs e)
        {
            x = 0;
            milliseconds = 0;
            seconds = 0;
            minute = 0;
            hour = 0;
            label1.Text = "    00:00:00";
            label2.Text = "000";
        }
    }
}
