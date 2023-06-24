using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        static string path = @"D:\C#\temp\";
        static string name = "Score";
        static string ext = ".txt";
        //static string FinalPath = path + name + ext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
   

        float click = -1;
        bool timerStart;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Gold;
            button1.Text = "Click";
            timerStart = true;
            int stopper = 1;
            while (stopper == 1)
            {
                click++;
                label1.Text = Convert.ToString(click);
                stopper = 0;
            }
        }

        float seconds;
        float scoreCont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerStart) 
            {

                seconds++;
                label2.Text = Convert.ToString(seconds);
                if (seconds == 10)
                {
                    string FinalPath = path + name + ext;
                    if (scoreCont < click)
                    {
                        /*scoreCont = click;
                        using (filestream file = new filestream(finalpath, filemode.create))
                        {
                            byte[] buffer = encoding.default.getbytes(convert.tostring(scorecont));

                            file.write(buffer, 0, buffer.length);
                            file.close();
                        }
                        */
                    }

                    label9.Text = Convert.ToString(click / seconds);
                    button1.Enabled = false;
                    timer1.Enabled = false;
                    label10.Text = Convert.ToString(scoreCont);
                    

                    if (scoreCont < click)
                    {
                        scoreCont = click;
                        label10.Text = Convert.ToString(scoreCont);
                    }
                    if (click < 50)label3.Text = "Медленно";
                    else if (click < 60 && click >= 50)label3.Text = "Средняя скорость";
                    else if (click < 70 && click >= 60)label3.Text = "Быстро";
                    else if (click < 80 && click >= 70)label3.Text = "Пулемёт";
                    else if (click < 90 && click >= 80)label3.Text = "Скорость света";
                    else if (click < 100 && click >= 90)label3.Text = "Скорость света преодалена";
                    else if (click < 110 && click >= 100)label3.Text = "Читы - это не хорошо";
                    else label3.Text = "Error: clickMaxNum.";
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            click = -1;
            seconds = 0;
            button1.Enabled = true;
            timer1.Enabled = false;
            label1.Text = "0";
            label2.Text = "0";
            button1.BackColor = Color.Lime;
            button1.Text = "Start";
            label3.Text = "";
            label9.Text = "-";
            label3.Text = "-";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
