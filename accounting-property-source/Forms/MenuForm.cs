using accounting_property_source.Classes;
using System;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class MenuForm : Form
    {
        bool isRightExit = false;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void Property_btn_Click(object sender, EventArgs e)
        {
            new EditPropertysForm().Show();
            isRightExit = true;
            this.Close();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isRightExit) { DataBase.CloseConnection(); Environment.Exit(0); }
        }
    }
}
