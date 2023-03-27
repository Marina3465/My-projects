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
    public partial class Договор : Form
    {
        public Договор()
        {
            InitializeComponent();
        }

        private void Договор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кожухар_ИТ2001_ITformatDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.кожухар_ИТ2001_ITformatDataSet.Договор);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Заказы);
            клиентыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Клиенты);
            договорTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Договор);
            MessageBox.Show("Успешно сохранено");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            заказыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Заказы);
            клиентыTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Клиенты);
            договорTableAdapter.Update(кожухар_ИТ2001_ITformatDataSet.Договор);
            MessageBox.Show("Успешно удалено");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "") 
            {
                string query = "Наименование_компании LIKE  '*" + textBox3.Text + "*'";
                DataRow[] Клиенты = кожухар_ИТ2001_ITformatDataSet.Клиенты.Select(query);
                query = "Код_клиента=" + Клиенты[0]["Код_клиента"];
                договорBindingSource.Filter = query;
            }
            if (textBox1.Text != "")
            {
                string query = "Наименование_заказа LIKE  '*" + textBox1.Text + "*'";
                DataRow[] Заказы = кожухар_ИТ2001_ITformatDataSet.Заказы.Select(query);
                query = "Номер_заказа=" + Заказы[0]["Номер_заказа"];
                договорBindingSource.Filter = query;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            договорBindingSource.Filter = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var helper = new Word("договор на услуги.doc");
            string daten = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string dateo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string client_num = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string query1 = "Код_клиента= '" + client_num + "'";
            DataRow[] Клиенты = кожухар_ИТ2001_ITformatDataSet.Клиенты.Select(query1);
            string org = "" + Клиенты[0]["Наименование_компании"];
            string f = "" + Клиенты[0]["Фамилия"];
            string i = "" + Клиенты[0]["Имя"];
            string o = "" + Клиенты[0]["Отчество"];
            string adress = "" + Клиенты[0]["Адрес"];
            string inn = "" + Клиенты[0]["ИНН"];
            daten = daten.Substring(0, daten.Length - 8);
            dateo = dateo.Substring(0, dateo.Length - 8);

            var items = new Dictionary<string, string>
            {
                { "<price>", price },
                { "<daten>", daten },
                { "<org>", org },
                { "<dateo>", dateo },
                { "<f>", f },
                { "<i>", i },
                { "<o>", o },
                { "<adress>", adress },
                { "<inn>", inn },
            };
            helper.Process(items);
        }
    }
}
