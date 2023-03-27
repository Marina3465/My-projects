using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_жизнь
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init_labels();
        }

        //размеры одной клетки
        int width = 20;
        int height = 20;
        int w, h;
        //создаём массив
        Label[,] lab;
        Clean clean;

        //задаём цвета

        Color co_none = Color.White;
        Color co_live = Color.Green;
        Color co_born = Color.LightBlue;
        Color co_died = Color.DarkRed;

        private void init_labels()
        {
            //количество клеток в ширину
            w = panel1.Width / width;
            //количество клеток в высоту
            h = panel1.Height / height;
            clean = new Clean(w, h);
            lab = new Label[w, h];
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                    add_label1(x, y);
        }

        //добавление объектов мышкой
        private void label1_Click(object sender, EventArgs e)
        {
            int x = ((Label)sender).Location.X / width;
            int y = ((Label)sender).Location.Y / height;

            if (clean.turn(x, y) == 1)
                lab[x, y].BackColor = co_live;
            else
                lab[x, y].BackColor = co_none;
        }

        //создаём поле для клеток
        private void add_label1(int x, int y)
        {
            lab[x, y] = new Label();
            //праметры поля
            lab[x, y].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lab[x, y].Location = new Point(x * width, y * height);
            lab[x, y].Size = new System.Drawing.Size(width + 1, height + 1);
            lab[x, y].Parent = panel1;
            lab[x, y].Click += new EventHandler(this.label1_Click);
            lab[x, y].BackColor = co_none;
        }

        //обновление цветом клеток
        private void refresh()
        {
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    switch (clean.get(x, y))
                    {
                        case 0: lab[x, y].BackColor = co_none; break;
                        case 1: lab[x, y].BackColor = co_live; break;
                        case 2: lab[x, y].BackColor = co_died; break;
                        case -1: lab[x, y].BackColor = co_born; break;

                    }
                }
        }

        //смена поколений (чередование)
        bool first = true;
        int pokolenie = 1;

        public void time()
        {
            int count = 0;
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                    if (lab[x, y].BackColor == co_none)
                        count++;
                    else
                        timer1.Enabled = true;
            if (count == w * h)
                timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (first)
            {
                clean.stap1();
            }
            else
            {
                clean.stap2();
            }

            first = !first;
            time();
            refresh();
            if (timer1.Enabled == true)
            {
                pokolenie++;
                label2.Text = pokolenie.ToString();
            }
            else
            {
                label2.Text = pokolenie.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
