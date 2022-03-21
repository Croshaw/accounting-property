using accounting_property_source.Classes;
using System;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class EditSupplierForm : Form
    {
        private Supplier supplier;

        public EditSupplierForm()
        {
            InitializeComponent();
        }

        private void EditSupliesForm_Load(object sender, EventArgs e)
        {
            supplier = new Supplier();
            dataGridView1.DataSource = supplier.GetTable();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Org_tb.Text) || string.IsNullOrEmpty(Contract_tb.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            if (Edit_cb.Checked)
            {
                if (dataGridView1.Rows.Count < 1) { MessageBox.Show("Нечего менять"); return; }
                if (supplier.UpdateElement(Org_tb.Text, Contract_tb.Text, dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (supplier.IsOrgExists(Org_tb.Text))
                {
                    MessageBox.Show("Такая запись уже есть!");
                    return;
                }
                if (supplier.AddElement(Org_tb.Text, Contract_tb.Text) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            dataGridView1.DataSource = supplier.GetTable();
            Org_tb.Clear();
            Contract_tb.Clear();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) return;
            if (supplier.DeleteElement(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                MessageBox.Show("Что-то пошло не так!");
            dataGridView1.DataSource = supplier.GetTable();
            Org_tb.Clear();
            Contract_tb.Clear();
        }

        private void Edit_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true)
            {
                Add_btn.Text = "Изменить";
                if (dataGridView1.Rows.Count < 1) return;
                Org_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                Contract_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            }
            else
            {
                Add_btn.Text = "Добавить";
                Org_tb.Clear();
                Contract_tb.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Edit_cb.Checked && e.RowIndex >= 0)
            {
                Org_tb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Contract_tb.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }
    }
}
