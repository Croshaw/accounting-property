
namespace accounting_property_source
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName_tb = new System.Windows.Forms.TextBox();
            this.Password_tb = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Registration_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.SecondName_tb = new System.Windows.Forms.TextBox();
            this.ThirdName_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EndReg_btn = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            this.head_label = new System.Windows.Forms.Label();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName_tb
            // 
            this.UserName_tb.BackColor = System.Drawing.Color.LightSalmon;
            this.UserName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.UserName_tb.ForeColor = System.Drawing.Color.White;
            this.UserName_tb.Location = new System.Drawing.Point(24, 65);
            this.UserName_tb.Name = "UserName_tb";
            this.UserName_tb.Size = new System.Drawing.Size(176, 22);
            this.UserName_tb.TabIndex = 0;
            // 
            // Password_tb
            // 
            this.Password_tb.BackColor = System.Drawing.Color.LightSalmon;
            this.Password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Password_tb.ForeColor = System.Drawing.Color.White;
            this.Password_tb.Location = new System.Drawing.Point(24, 126);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.PasswordChar = '*';
            this.Password_tb.Size = new System.Drawing.Size(176, 22);
            this.Password_tb.TabIndex = 1;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(24, 168);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Войти";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Registration_btn
            // 
            this.Registration_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.Registration_btn.FlatAppearance.BorderSize = 0;
            this.Registration_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Registration_btn.ForeColor = System.Drawing.Color.White;
            this.Registration_btn.Location = new System.Drawing.Point(105, 168);
            this.Registration_btn.Name = "Registration_btn";
            this.Registration_btn.Size = new System.Drawing.Size(95, 23);
            this.Registration_btn.TabIndex = 3;
            this.Registration_btn.Text = "Регистрация";
            this.Registration_btn.UseVisualStyleBackColor = false;
            this.Registration_btn.Click += new System.EventHandler(this.Registration_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // Name_tb
            // 
            this.Name_tb.BackColor = System.Drawing.Color.LightSalmon;
            this.Name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Name_tb.ForeColor = System.Drawing.Color.White;
            this.Name_tb.Location = new System.Drawing.Point(225, 65);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(176, 22);
            this.Name_tb.TabIndex = 6;
            // 
            // SecondName_tb
            // 
            this.SecondName_tb.BackColor = System.Drawing.Color.LightSalmon;
            this.SecondName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.SecondName_tb.ForeColor = System.Drawing.Color.White;
            this.SecondName_tb.Location = new System.Drawing.Point(426, 65);
            this.SecondName_tb.Name = "SecondName_tb";
            this.SecondName_tb.Size = new System.Drawing.Size(176, 22);
            this.SecondName_tb.TabIndex = 7;
            // 
            // ThirdName_tb
            // 
            this.ThirdName_tb.BackColor = System.Drawing.Color.LightSalmon;
            this.ThirdName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThirdName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ThirdName_tb.ForeColor = System.Drawing.Color.White;
            this.ThirdName_tb.Location = new System.Drawing.Point(225, 126);
            this.ThirdName_tb.Name = "ThirdName_tb";
            this.ThirdName_tb.Size = new System.Drawing.Size(176, 22);
            this.ThirdName_tb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(222, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(423, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(222, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(423, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата рождения:";
            // 
            // EndReg_btn
            // 
            this.EndReg_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.EndReg_btn.FlatAppearance.BorderSize = 0;
            this.EndReg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndReg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndReg_btn.ForeColor = System.Drawing.Color.White;
            this.EndReg_btn.Location = new System.Drawing.Point(219, 168);
            this.EndReg_btn.Name = "EndReg_btn";
            this.EndReg_btn.Size = new System.Drawing.Size(188, 31);
            this.EndReg_btn.TabIndex = 14;
            this.EndReg_btn.Text = "Зарегестрироваться";
            this.EndReg_btn.UseVisualStyleBackColor = false;
            this.EndReg_btn.Click += new System.EventHandler(this.EndReg_btn_Click);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Salmon;
            this.header_panel.Controls.Add(this.head_label);
            this.header_panel.Controls.Add(this.Minimize_btn);
            this.header_panel.Controls.Add(this.Exit_btn);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(220, 32);
            this.header_panel.TabIndex = 15;
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_MouseDown);
            // 
            // head_label
            // 
            this.head_label.AutoSize = true;
            this.head_label.BackColor = System.Drawing.Color.Transparent;
            this.head_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head_label.ForeColor = System.Drawing.Color.White;
            this.head_label.Location = new System.Drawing.Point(0, 0);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(141, 25);
            this.head_label.TabIndex = 2;
            this.head_label.Text = "Авторизация";
            this.head_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Location = new System.Drawing.Point(156, 0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.Minimize_btn.TabIndex = 1;
            this.Minimize_btn.Text = "—";
            this.Minimize_btn.UseVisualStyleBackColor = true;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(188, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(32, 32);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.rjDatePicker1.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(426, 118);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(176, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker1.TabIndex = 23;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(220, 210);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.EndReg_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThirdName_tb);
            this.Controls.Add(this.SecondName_tb);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.UserName_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_tb;
        private System.Windows.Forms.TextBox Password_tb;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Registration_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.TextBox SecondName_tb;
        private System.Windows.Forms.TextBox ThirdName_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EndReg_btn;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit_btn;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
    }
}

