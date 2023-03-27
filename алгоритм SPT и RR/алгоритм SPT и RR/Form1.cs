using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace алгоритм_SPT_и_RR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void WithoutSort(List<int> task)
        {
            int time = 0;
            int smallTask = 0;
            int quantyty_smallTask = 0;
            int probability = Convert.ToInt32(textBox3.Text);
            Queue<int> processor = new Queue<int>();
            for (int i = 0; i < task.Count; i++)
            {
                processor.Enqueue(task[i]);
            }

            for (int i = 0; i < task.Count; i++)
            {
                if (rand.Next(0, 101) <= probability)
                {
                    processor.Dequeue();
                    time += task[i];
                    if (task[i] > qvant)
                    {
                        smallTask += task[i];
                        quantyty_smallTask++;
                    }
                }
                else
                    time++;
            }
            double waitingTime = Math.Round(Convert.ToDouble(smallTask) / Convert.ToDouble(quantyty_smallTask), 4);
            listBox1.Items.Clear();
            listBox1.Items.Add("сумма длин всех заявок " + task.Sum());
            listBox1.Items.Add("время обработки " + time);
            listBox1.Items.Add("среднее время ожидания для короткой заявки " + waitingTime);
        }

        public void SortSPT(List<int> task)
        {
            int time = 0;
            int smallTask = 0;
            int quantyty_smallTask = 0;
            task.Sort();
            int probability = Convert.ToInt32(textBox4.Text);
            Queue<int> processor = new Queue<int>();
            for (int i = 0; i < task.Count; i++)
            {
                processor.Enqueue(task[i]);
            }

            for (int i = 0; i < task.Count; i++)
            {
                if (rand.Next(0, 101) <= probability)
                {
                    processor.Dequeue();
                    time += task[i];
                    if (task[i] > qvant)
                    {
                        smallTask += task[i];
                        quantyty_smallTask++;
                    }
                }
                else
                    time++;
            }
            double waitingTime = Math.Round(Convert.ToDouble(smallTask) / Convert.ToDouble(quantyty_smallTask), 4);
            listBox2.Items.Clear();
            listBox2.Items.Add("SPT:");
            listBox2.Items.Add("сумма длин всех заявок " + task.Sum());
            listBox2.Items.Add("время обработки " + time);
            listBox2.Items.Add("среднее время ожидания для короткой заявки " + waitingTime);
        }

        public void SortRR(List<int> task)
        {
            int time = 0;
            int smallTask = 0;
            int quantyty_smallTask = 0;
            task.Sort();
            int probability = Convert.ToInt32(textBox4.Text);
            Queue<int> processor = new Queue<int>();
            for (int i = 0; i < task.Count; i++)
            {
                processor.Enqueue(task[i]);
            }
            while (processor.Count > 0)
            {
                if (rand.Next(0, 101) <= probability)
                {
                    if (processor.Peek() <= qvant)
                    {
                        time += processor.Peek();
                        processor.Dequeue();
                    }
                    else
                    {
                        int t = processor.Peek();
                        smallTask += t;
                        quantyty_smallTask++;
                        t = t - qvant;
                        time += t;
                        processor.Dequeue();
                        processor.Enqueue(t);
                    }
                }
                else
                    time++;
            }
            double waitingTime = Math.Round(Convert.ToDouble(smallTask) / Convert.ToDouble(quantyty_smallTask), 4);
            listBox2.Items.Add("RR:");
            listBox2.Items.Add("сумма длин всех заявок " + task.Sum());
            listBox2.Items.Add("время обработки " + time);
            listBox2.Items.Add("среднее время ожидания для короткой заявки " + waitingTime);
        }

        int qvant;
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int n = Convert.ToInt32(textBox1.Text);
                qvant = Convert.ToInt32(textBox2.Text);
                string bidWithout = textBox5.Text;
                string bidSort = textBox6.Text;
                string[] split1 = bidWithout.Split(new char[] { '-' });
                string[] split2 = bidSort.Split(new char[] { '-' });


                List<int> task1 = new List<int>();
                List<int> task2 = new List<int>();
                List<int> task3 = new List<int>();

                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    task1.Add(rand.Next(Convert.ToInt32(split1[0]), Convert.ToInt32(split1[1]) + 1));
                    task2.Add(rand.Next(Convert.ToInt32(split2[0]), Convert.ToInt32(split2[1]) + 1));
                    task3.Add(rand.Next(Convert.ToInt32(split2[0]), Convert.ToInt32(split2[1]) + 1));
                }

                WithoutSort(task1);
                SortSPT(task2);
                SortRR(task3);
            }
            catch(Exception)
            {
                MessageBox.Show("Неправильно введены данные или не во всех окнах введены данные!");
            }
        }
    }
}
