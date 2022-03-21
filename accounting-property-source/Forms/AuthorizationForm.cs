using accounting_property_source.Classes;
using accounting_property_source.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace accounting_property_source
{
    public partial class AuthorizationForm : Form
    {
        private Users users;
        private ExtraTools extra;

        public static string UserId = null;
        private void SetConString()
        {
            if (!File.Exists("DBmain.mdb"))
            {
                if (MessageBox.Show("Не можем обнаружить БД. Выберите путь вручную!", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.Cancel) Environment.Exit(0);
                else
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                        DataBase.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ofd.FileName;
                }
            }
            else DataBase.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBmain.mdb";
        }

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, System.EventArgs e)
        {
            users = new Users();
            extra = new ExtraTools();
            SetConString();
            try { DataBase.OpenConnection(); }
            catch { MessageBox.Show("Не правильный файл"); SetConString(); }
            this.Activate();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e) =>
            DataBase.CloseConnection();

        private void Login_btn_Click(object sender, System.EventArgs e)
        {
            if(extra.isTBEmptyOrNull(UserName_tb,Password_tb))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            if(!users.isRightPass(UserName_tb.Text, Password_tb.Text))
            {
                MessageBox.Show("Не верные данные!");
                return;
            }
            this.Hide();
            UserId = users.GetUserId(UserName_tb.Text);
            new MenuForm().Show();
        }

        private void Registration_btn_Click(object sender, System.EventArgs e)
        {
            this.Size = new System.Drawing.Size(626, 210);
            head_label.Text = "Регистрация";
            this.CenterToScreen();
            Login_btn.Visible = false;
            Registration_btn.Visible = false;
            extra.ClearTB(UserName_tb, Password_tb, Name_tb, SecondName_tb, ThirdName_tb);
        }

        private void EndReg_btn_Click(object sender, System.EventArgs e)
        {
            if(extra.isTBEmptyOrNull(UserName_tb, Password_tb, Name_tb, SecondName_tb, ThirdName_tb))
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            if(users.isUserExist(UserName_tb.Text))
            {
                MessageBox.Show("Такой пользователь уже есть!");
                return;
            }
            if (users.AddUser(UserName_tb.Text, Password_tb.Text, Name_tb.Text, SecondName_tb.Text, ThirdName_tb.Text, rjDatePicker1.Value.ToShortDateString(), "3") == 1)
            {
                MessageBox.Show("Успешно!");
                UserId = users.GetUserId(UserName_tb.Text);
            }
            else MessageBox.Show("Что-то пошло не так!");


            this.Size = new System.Drawing.Size(220, 210);
            head_label.Text = "Авторизация";
            this.CenterToScreen();
            Login_btn.Visible = true;
            Registration_btn.Visible = true;
            extra.ClearTB(UserName_tb, Password_tb, Name_tb, SecondName_tb, ThirdName_tb);
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
