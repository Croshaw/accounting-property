using accounting_property_source.Classes;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace accounting_property_source.Forms
{
    public partial class MenuForm : Form
    {
        //Для того, чтоб двигать форму за заголовок.
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Button currentBtn;
        Form activeForm;

        //Активируем кнопку. В качестве параметра передаётся sender из событий по нажатию кнопок. Далее идут проверки. В конечном итоге currentBtn присвают sender и далее ей меняют цвет.
        void ActiveButton(object btnSender)
        {
            if(btnSender != null)
                if (currentBtn != (Button)btnSender)
                {
                    if (currentBtn != null)
                    {
                        currentBtn.BackColor = Color.Salmon;
                    }
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.Tomato;
                    head_label.Text = currentBtn.Text;
                }
        }

        //Открывает дочернию форму внутри другой формы. Передаём форму и Sender, активируем кнопку и производим настройку дочерний формы, для корректного отображения.
        void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(childForm);
            this.Width = navbar_panel.Width + childForm.Width;
            if (childForm.Height > 336) this.Height = childForm.Height + header_panel.Height;
            else this.Height = 336;
            childForm.BringToFront();
            childForm.Show();
        }

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.CloseConnection(); Environment.Exit(0);
        }

        private void header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Открываем дочернии формы
        private void types_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TypesPropertyForm(), sender);
        }

        private void prop_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditPropertysForm(), sender);
        }

        private void suplies_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditSupplierForm(), sender);
        }

        private void supply_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditSupplyForm(), sender);
        }

        private void Invent_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditInvertalForm(), sender);
        }

        private void svdoka_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SvodkaForm(), sender);
        }
    }
}
