using accounting_property_source.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class SvodkaForm : Form
    {
        Invertarization invent;
        DataSet ds;

        public SvodkaForm()
        {
            InitializeComponent();
        }

        private void SvodkaForm_Load(object sender, EventArgs e)
        {
            invent = new Invertarization();
            ds = new DataSet();
            ds.Tables.Add();
            dataGridView1.Rows.Add("Списана", invent.GetCount("Списана"));
            dataGridView1.Rows.Add("Введение в эксплуатацию", invent.GetCount("Введение в эксплуатацию"));
            dataGridView1.Rows.Add("Утилизация", invent.GetCount("Утилизация"));
            dataGridView1.Rows.Add("Ремонт", invent.GetCount("Ремонт"));
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            if (Open_btn.Text == "Открыть")
            {
                if (dataGridView1.CurrentRow.Index >= 0)
                {
                    Open_btn.Location = new Point(209, 284);
                    Open_btn.Text = "Назад";
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                }
                switch (dataGridView1.CurrentRow.Index)
                {
                    case (0):
                        dataGridView2.DataSource = invent.GetTable(null,"Списана",null,null);
                        break;
                    case (1):
                        dataGridView2.DataSource = invent.GetTable(null, "Введение в эксплуатацию", null, null);
                        break;
                    case (2):
                        dataGridView2.DataSource = invent.GetTable(null,"Утилизация", null, null);
                        break;
                    case (3):
                        dataGridView2.DataSource = invent.GetTable(null, "Ремонт", null, null);
                        break;
                    default:
                        break;
                }
                dataGridView2.Columns[0].Visible = false;
            }
            else
            {
                Open_btn.Location = new Point(93, 190);
                Open_btn.Text = "Открыть";
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
        }
    }
}
