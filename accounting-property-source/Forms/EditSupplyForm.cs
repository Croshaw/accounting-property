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
    public partial class EditSupplyForm : Form
    {
        Supply supply;
        Supplier supplier;
        Propertys propertys;
        string idProp, idOrg;
        string minDate, maxDate;
        string idPropFilter=null, idOrgFilter=null;

        public EditSupplyForm()
        {
            InitializeComponent();
        }

        private void EditSupplyForm_Load(object sender, EventArgs e)
        {
            supply = new Supply();
            supplier = new Supplier();
            propertys = new Propertys();
            dataGridView1.DataSource = supply.GetTable(null,null, null, null);
            for (int i = 0; i < 3; i++)
                dataGridView1.Columns[i].Visible = false;
            Org_cb.Items.AddRange(supplier.GetOrg().ToArray());
            Prop_cb.Items.AddRange(propertys.GetProp().ToArray());
            OrgFilter_cb.Items.AddRange(supplier.GetOrg().ToArray());
            PropFilter_cb.Items.AddRange(propertys.GetProp().ToArray());

            this.rjDatePicker2.Format = this.rjDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePicker2.CustomFormat = this.rjDatePicker3.CustomFormat = " ";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (Org_cb.SelectedIndex == -1 || Prop_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            idOrg = supplier.GetId(Org_cb.SelectedItem.ToString());
            idProp = propertys.GetId(Prop_cb.SelectedItem.ToString());
            if (Edit_cb.Checked)
            {
                if (dataGridView1.Rows.Count < 1) { MessageBox.Show("Нечего менять"); return; }
                if (supply.UpdateElement(idOrg, idProp, rjDatePicker1.Value.ToString("M/d/yyyy").Replace('.', '/'), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (supply.AddElement(idOrg, idProp, rjDatePicker1.Value.ToString("M/d/yyyy").Replace('.', '/')) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
            Org_cb.SelectedIndex = -1;
            Prop_cb.SelectedIndex = -1;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1) return;
            if (supply.DeleteElement(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()) != 1)
                MessageBox.Show("Что-то пошло не так!");
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
            Org_cb.SelectedIndex = -1;
            Prop_cb.SelectedIndex = -1;
        }

        private void Edit_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true)
            {
                Add_btn.Text = "Изменить";
                if (dataGridView1.Rows.Count < 1) return;
                Org_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value;
                Prop_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value;
            }
            else
            {
                Add_btn.Text = "Добавить";
                Org_cb.SelectedIndex = -1;
                Prop_cb.SelectedIndex = -1;
            }
        }

        private void OrgFilter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrgFilter_cb.SelectedIndex != -1)
                idOrgFilter = supplier.GetId(OrgFilter_cb.SelectedItem.ToString());
            else idOrgFilter = null;
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
        }

        private void PropFilter_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PropFilter_cb.SelectedIndex != -1)
                idPropFilter = propertys.GetId(PropFilter_cb.SelectedItem.ToString());
            else idPropFilter = null;
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
        }

        private void ResetOrgFilter_btn_Click(object sender, EventArgs e) => OrgFilter_cb.SelectedIndex = -1;

        private void ResetPropFilter_btn_Click(object sender, EventArgs e) => PropFilter_cb.SelectedIndex = -1;

        private void ResetDateFilt_btn_Click(object sender, EventArgs e)
        {
            this.rjDatePicker2.Format = this.rjDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePicker2.CustomFormat = this.rjDatePicker3.CustomFormat = " ";
            minDate = maxDate = null;
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
        }

        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (this.rjDatePicker2.Format == DateTimePickerFormat.Custom)
                this.rjDatePicker2.Format = DateTimePickerFormat.Short;
            maxDate = rjDatePicker2.Value.ToString("M/d/yyyy").Replace('.','/');
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
        }

        private void rjDatePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (this.rjDatePicker3.Format == DateTimePickerFormat.Custom)
                this.rjDatePicker3.Format = DateTimePickerFormat.Short;
            minDate = rjDatePicker3.Value.ToString("M/d/yyyy").Replace('.', '/');
            dataGridView1.DataSource = supply.GetTable(idOrgFilter, idPropFilter, minDate, maxDate);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Edit_cb.Checked && e.RowIndex >= 0)
            {
                Org_cb.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                Prop_cb.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value;
            }
        }
    }
}
