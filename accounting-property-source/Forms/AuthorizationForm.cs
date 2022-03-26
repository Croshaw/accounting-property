using accounting_property_source.Classes;
using accounting_property_source.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace accounting_property_source
{
    public partial class AuthorizationForm : Form
    {
        //Для того, чтоб двигать форму за заголовок.
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Users users;
        private ExtraTools extra;

        public static string UserId = null;

        //Генерируем строку подключения для БД. Тут мы проверяем на наличее БД в корневом каталоге программы. Елси он существует, то мы просто в качестве строки подключения передаём его.
        //Если его нет, то выводится сообщение о том что БД нет, выберите путь вручную.Открывает диалоговое окно, где надо будет выбрать БД.При выборе: Отмена - программа закрывается; Ок- сгенерирует строку подключения.
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
        //Загрузка формы. Создаём экзэмляры классов. Инциализируем строку подключения. Пытаемся открыть Соединение с БД. Если не получается Переинициализируем строку подключения.
        private void AuthorizationForm_Load(object sender, System.EventArgs e)
        {
            users = new Users();
            extra = new ExtraTools();
            SetConString();
            try { DataBase.OpenConnection(); }
            catch { MessageBox.Show("Не правильный файл"); SetConString(); }
            this.Activate();
        }
        //При закрытии формы, соединение с БД закрывается.
        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e) =>
            DataBase.CloseConnection();

        //Событие клика по кнопке войти.
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

        //Событие клика по конпке Регистрация. Меняем размеры формы, для того, чтобы были видны друге TextBox.
        private void Registration_btn_Click(object sender, System.EventArgs e)
        {
            this.Size = new System.Drawing.Size(626, 210);
            head_label.Text = "Регистрация";
            this.CenterToScreen();
            Login_btn.Visible = false;
            Registration_btn.Visible = false;
            extra.ClearTB(UserName_tb, Password_tb, Name_tb, SecondName_tb, ThirdName_tb);
        }

        //Событие клика по кнопке Зарегистрироваться. Идут проверки для добавления нового пользователя в таблицу Users. И при успешном расскаде Форма меняет свой размер на прежний. 
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

        //Свернуть форму по нажатию кнопки
        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Закрыть форму
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Передвижение формы с зажатой мышкой по экрану.
        private void header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }
    }
}
