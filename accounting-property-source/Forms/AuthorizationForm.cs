using accounting_property_source.Classes;
using System.Windows.Forms;

namespace accounting_property_source
{
    public partial class AuthorizationForm : Form
    {
        private Users users;
        private ExtraTools extra;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, System.EventArgs e)
        {
            users = new Users();
            extra = new ExtraTools();
            if (string.IsNullOrEmpty(DataBase.ConnectionString))
            {
                MessageBox.Show("Не можем обнаружить БД. Выберите путь вручную!");
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    DataBase.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ofd.FileName;
            }
            DataBase.OpenConnection();
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
        }

        private void Registration_btn_Click(object sender, System.EventArgs e)
        {
            this.Size = new System.Drawing.Size(636, 241);
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
            if (users.AddUser(UserName_tb.Text, Password_tb.Text, Name_tb.Text, SecondName_tb.Text, ThirdName_tb.Text, BirhDate_dtp.Value.ToShortDateString(), "3") == 1)
                MessageBox.Show("Успешно!");
            else MessageBox.Show("Что-то пошло не так!");


            this.Size = new System.Drawing.Size(233, 235);
            this.CenterToScreen();
            Login_btn.Visible = true;
            Registration_btn.Visible = true;
            extra.ClearTB(UserName_tb, Password_tb, Name_tb, SecondName_tb, ThirdName_tb);
        }
    }
}
