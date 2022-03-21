using accounting_property_source.Classes;
using System;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class EditInvertalForm : Form
    {
        Invertarization invent;
        Propertys prop;
        string[] idProp;

        public EditInvertalForm()
        {
            InitializeComponent();
        }

        private void Edit_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true)
            {
                Add_btn.Text = "Изменить";
                if (dataGridView1.Rows.Count < 1) return;
                Prop_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value;
                Status_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
            }
            else
            {
                Add_btn.Text = "Добавить";
                Status_cb.SelectedIndex = -1;
                Prop_cb.SelectedIndex = -1;
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Prop_cb.SelectedIndex == -1 || Status_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            if (Edit_cb.Checked)
            {
                if (dataGridView1.Rows.Count < 1) { MessageBox.Show("Нечего менять"); return; }
                if (invent.UpdateElement(idProp[Prop_cb.SelectedIndex], Status_cb.SelectedItem.ToString(), rjDatePicker1.Value.ToShortDateString(), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (invent.IsExists(idProp[Prop_cb.SelectedIndex]))
                {
                    MessageBox.Show("Это уже списано!");
                    return;
                }
                if (invent.AddElement(idProp[Prop_cb.SelectedIndex], Status_cb.SelectedItem.ToString(), rjDatePicker1.Value.ToShortDateString()) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            dataGridView1.DataSource = invent.GetTable();
            Prop_cb.SelectedIndex = -1;
            Status_cb.SelectedIndex = -1;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) return;
            if (invent.DeleteElement(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                MessageBox.Show("Что-то пошло не так!");
            dataGridView1.DataSource = invent.GetTable();
            Prop_cb.SelectedIndex = -1;
            Status_cb.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Edit_cb.Checked && e.RowIndex >= 0)
            {
                Prop_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value;
                Status_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
            }
        }

        private void EditInvertalForm_Load(object sender, EventArgs e)
        {
            invent = new Invertarization();
            prop = new Propertys();
            dataGridView1.DataSource = invent.GetTable();
            dataGridView1.Columns[0].Visible = false;
            Prop_cb.Items.AddRange(prop.GetProp().ToArray());
            idProp = prop.GetIds().ToArray();
        }
    }
}
