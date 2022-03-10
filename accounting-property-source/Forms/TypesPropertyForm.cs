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
    public partial class TypesPropertyForm : Form
    {
        Propertys property;
        TypePropertys typePropertys;
        Form _owner;

        public TypesPropertyForm(Form _owner)
        {
            InitializeComponent();
            this._owner = _owner;
        }

        private void TypesPropertyForm_Load(object sender, EventArgs e)
        {
            property = new Propertys();
            typePropertys = new TypePropertys();
            listBox1.Items.AddRange(property.GetTypes().ToArray());

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_tb.Text))
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            if(typePropertys.isTypeExists(Name_tb.Text))
            {
                MessageBox.Show("Такая запись уже есть!");
                return;
            }
            if (Edit_cb.Checked)
            {
                if (listBox1.SelectedItem == null) return;
                string id = typePropertys.GetIdByName(listBox1.SelectedItem.ToString());
                if (typePropertys.UpdateElement(Name_tb.Text,id) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (typePropertys.AddElement(Name_tb.Text) != 1)
                    MessageBox.Show("Что-то пошло не так!");
            }
            Name_tb.Clear();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(property.GetTypes().ToArray());
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            string id = typePropertys.GetIdByName(listBox1.SelectedItem.ToString());
            if (typePropertys.DeleteElement(id) != 1)
                MessageBox.Show("Что-то пошло не так!");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(property.GetTypes().ToArray());
        }

        private void Edit_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true)
            {
                Add_btn.Text = "Изменить";
                if (listBox1.SelectedItem == null) return;
                Name_tb.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                Add_btn.Text = "Добавить";
                Name_tb.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Edit_cb.Checked == true && listBox1.SelectedItem != null) Name_tb.Text = listBox1.SelectedItem.ToString();
        }

        private void TypesPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.Show();
        }
    }
}
