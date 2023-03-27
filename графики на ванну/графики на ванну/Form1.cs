using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace графики_на_ванну
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new enter("Графики на ванну.docx");
            string daten = dateTimePicker1.Value.ToString("d MMMM");
            string q = dateTimePicker1.Value.AddDays(6).ToString("d MMMM");
            string w = dateTimePicker1.Value.AddDays(7).ToString("d MMMM");
            string ee = dateTimePicker1.Value.AddDays(13).ToString("d MMMM");
            string r = dateTimePicker1.Value.AddDays(14).ToString("d MMMM");
            string t = dateTimePicker1.Value.AddDays(20).ToString("d MMMM");
            string y = dateTimePicker1.Value.AddDays(21).ToString("d MMMM");
            string u = dateTimePicker1.Value.AddDays(27).ToString("d MMMM");
            string i = dateTimePicker1.Value.AddDays(28).ToString("d MMMM");
            string o = dateTimePicker1.Value.AddDays(34).ToString("d MMMM");
            string p = dateTimePicker1.Value.AddDays(35).ToString("d MMMM");
            string a = dateTimePicker1.Value.AddDays(41).ToString("d MMMM");
            string s = dateTimePicker1.Value.AddDays(42).ToString("d MMMM");
            string d = dateTimePicker1.Value.AddDays(48).ToString("d MMMM");
            string f = dateTimePicker1.Value.AddDays(49).ToString("d MMMM");
            string g = dateTimePicker1.Value.AddDays(55).ToString("d MMMM");
            string h = dateTimePicker1.Value.AddDays(56).ToString("d MMMM");
            string j = dateTimePicker1.Value.AddMonths(62).ToString("d MMMM");




            var items = new Dictionary<string, string>
            {
                { "<daten>", daten },
                { "<q>", q },
                { "<w>", w },
                { "<e>", ee },
                { "<r>", r },
                { "<t>", t },
                { "<y>", y },
                { "<u>", u },
                { "<i>", i },
                { "<o>", o },
                { "<p>", p },
                { "<a>", a },
                { "<h>", h },
                { "<j>", j },
                { "<s>", s },
                { "<d>", d },
                { "<f>", f },
                { "<g>", g },

            };
            helper.Process(items);

        }
    }
}
