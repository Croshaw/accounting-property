using accounting_property_source.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class EditPropertysForm : Form
    {
        private Propertys propertys;

        public EditPropertysForm()
        {
            InitializeComponent();
        }

        private void EditPropertysForm_Load(object sender, EventArgs e)
        {
            propertys = new Propertys();
            dataGridView1.DataSource = propertys.GetTable();
            dataGridView1.Columns[0].Visible = false;
            Types_cb.Items.AddRange(propertys.GetTypes().ToArray());
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PropertysName_tb.Text) || string.IsNullOrEmpty(Cost_tb.Text) || Types_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            string id = propertys.GetIdType(Types_cb.SelectedItem.ToString());
            if (Edit_cb.Checked)
            {
                if (dataGridView1.Rows.Count < 1) { MessageBox.Show("Нечего менять"); return; }
                if (propertys.UpdateElement(PropertysName_tb.Text, id, Cost_tb.Text, AuthorizationForm.UserId, dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (propertys.AddElement(PropertysName_tb.Text, id, Cost_tb.Text, AuthorizationForm.UserId) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            dataGridView1.DataSource = propertys.GetTable();
            PropertysName_tb.Clear();
            Types_cb.SelectedIndex = -1;
            Cost_tb.Clear();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) return;
            if (propertys.DeleteElement(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                MessageBox.Show("Что-то пошло не так!");
            dataGridView1.DataSource = propertys.GetTable();
            PropertysName_tb.Clear();
            Types_cb.SelectedIndex = -1;
            Cost_tb.Clear();
        }

        private void Edit_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true)
            {
                Add_btn.Text = "Изменить";
                if (dataGridView1.Rows.Count < 1) return;
                PropertysName_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                Types_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value;
                Cost_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            }
            else
            {
                Add_btn.Text = "Добавить";
                PropertysName_tb.Clear();
                Types_cb.SelectedIndex = -1;
                Cost_tb.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Edit_cb.Checked && e.RowIndex>=0)
            {
                PropertysName_tb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Types_cb.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                Cost_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }
    }
}
