using accounting_property_source.Classes;
using System;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Property_btn_Click(object sender, EventArgs e)
        {
            new EditPropertysForm(this).Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.CloseConnection(); Environment.Exit(0);
        }

        private void TypesPropForm_btn_Click(object sender, EventArgs e)
        {
            new TypesPropertyForm(this).Show();
            this.Hide();
        }
    }
}
