using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Отдел_по_работе_с_клиентами_IT_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Проекты". При необходимости она может быть перемещена или удалена.
            this.проектыTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Проекты);

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Клиенты клиенты = new Клиенты();
            клиенты.Show();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Договор договор = new Договор();
            договор.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Заказы заказы = new Заказы();
            заказы.Show();
        }

        private void этапыПроектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Этапы_проекта этапы_Проекта = new Этапы_проекта();
            этапы_Проекта.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Услуги услуги = new Услуги();
            услуги.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сотрудники сотрудники = new Сотрудники();
            сотрудники.Show();
        }
        private void UpdateProgram()
        {
            услугиTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Услуги);
            проектыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Проекты);
            заказыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Заказы);
        }


        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProgram();
            MessageBox.Show("Успешно сохранено");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateProgram();
            MessageBox.Show("Успешно удалено");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                проектыBindingSource.Filter = string.Format("Наименование_проекта like '%{0}%' ", textBox3.Text);
            }
            if (textBox1.Text != "")
            {
                string query = "Наименование_заказа LIKE  '*" + textBox1.Text + "*'";
                DataRow[] Заказы = кожухар_ИТ2001_ITformatDataSet.Заказы.Select(query);
                query = "Номер_заказа=" + Заказы[0]["Номер_заказа"];
                проектыBindingSource.Filter = query;
            }
            if (textBox2.Text != "")
            {
                string query1 = "Наименование_услуги LIKE  '*" + textBox2.Text + "*'";
                DataRow[] Услуги = кожухар_ИТ2001_ITformatDataSet.Услуги.Select(query1);
                query1 = "Код_услуги=" + Услуги[0]["Код_услуги"];
                проектыBindingSource.Filter = query1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            проектыBindingSource.Filter = null;
        }
    }
}
