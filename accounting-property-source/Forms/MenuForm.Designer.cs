
namespace accounting_property_source.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.svdoka_btn = new System.Windows.Forms.Button();
            this.Invent_btn = new System.Windows.Forms.Button();
            this.supply_btn = new System.Windows.Forms.Button();
            this.supplier_btn = new System.Windows.Forms.Button();
            this.prop_btn = new System.Windows.Forms.Button();
            this.types_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header_panel = new System.Windows.Forms.Panel();
            this.head_label = new System.Windows.Forms.Label();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.navbar_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.Color.Salmon;
            this.navbar_panel.Controls.Add(this.svdoka_btn);
            this.navbar_panel.Controls.Add(this.Invent_btn);
            this.navbar_panel.Controls.Add(this.supply_btn);
            this.navbar_panel.Controls.Add(this.supplier_btn);
            this.navbar_panel.Controls.Add(this.prop_btn);
            this.navbar_panel.Controls.Add(this.types_btn);
            this.navbar_panel.Controls.Add(this.button1);
            this.navbar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar_panel.Location = new System.Drawing.Point(0, 0);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(174, 336);
            this.navbar_panel.TabIndex = 0;
            // 
            // svdoka_btn
            // 
            this.svdoka_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.svdoka_btn.FlatAppearance.BorderSize = 0;
            this.svdoka_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svdoka_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.svdoka_btn.ForeColor = System.Drawing.Color.White;
            this.svdoka_btn.Location = new System.Drawing.Point(0, 267);
            this.svdoka_btn.Name = "svdoka_btn";
            this.svdoka_btn.Size = new System.Drawing.Size(174, 47);
            this.svdoka_btn.TabIndex = 7;
            this.svdoka_btn.Text = "Сводка";
            this.svdoka_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.svdoka_btn.UseVisualStyleBackColor = true;
            this.svdoka_btn.Click += new System.EventHandler(this.svdoka_btn_Click);
            // 
            // Invent_btn
            // 
            this.Invent_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Invent_btn.FlatAppearance.BorderSize = 0;
            this.Invent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Invent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Invent_btn.ForeColor = System.Drawing.Color.White;
            this.Invent_btn.Location = new System.Drawing.Point(0, 220);
            this.Invent_btn.Name = "Invent_btn";
            this.Invent_btn.Size = new System.Drawing.Size(174, 47);
            this.Invent_btn.TabIndex = 6;
            this.Invent_btn.Text = "Инвентаризация";
            this.Invent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Invent_btn.UseVisualStyleBackColor = true;
            this.Invent_btn.Click += new System.EventHandler(this.Invent_btn_Click);
            // 
            // supply_btn
            // 
            this.supply_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.supply_btn.FlatAppearance.BorderSize = 0;
            this.supply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supply_btn.ForeColor = System.Drawing.Color.White;
            this.supply_btn.Location = new System.Drawing.Point(0, 173);
            this.supply_btn.Name = "supply_btn";
            this.supply_btn.Size = new System.Drawing.Size(174, 47);
            this.supply_btn.TabIndex = 5;
            this.supply_btn.Text = "Поставки";
            this.supply_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supply_btn.UseVisualStyleBackColor = true;
            this.supply_btn.Click += new System.EventHandler(this.supply_btn_Click);
            // 
            // supplier_btn
            // 
            this.supplier_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_btn.FlatAppearance.BorderSize = 0;
            this.supplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplier_btn.ForeColor = System.Drawing.Color.White;
            this.supplier_btn.Location = new System.Drawing.Point(0, 126);
            this.supplier_btn.Name = "supplier_btn";
            this.supplier_btn.Size = new System.Drawing.Size(174, 47);
            this.supplier_btn.TabIndex = 4;
            this.supplier_btn.Text = "Поставщики";
            this.supplier_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplier_btn.UseVisualStyleBackColor = true;
            this.supplier_btn.Click += new System.EventHandler(this.suplies_btn_Click);
            // 
            // prop_btn
            // 
            this.prop_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.prop_btn.FlatAppearance.BorderSize = 0;
            this.prop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prop_btn.ForeColor = System.Drawing.Color.White;
            this.prop_btn.Location = new System.Drawing.Point(0, 79);
            this.prop_btn.Name = "prop_btn";
            this.prop_btn.Size = new System.Drawing.Size(174, 47);
            this.prop_btn.TabIndex = 3;
            this.prop_btn.Text = "Имущество";
            this.prop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prop_btn.UseVisualStyleBackColor = true;
            this.prop_btn.Click += new System.EventHandler(this.prop_btn_Click);
            // 
            // types_btn
            // 
            this.types_btn.BackColor = System.Drawing.Color.Salmon;
            this.types_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.types_btn.FlatAppearance.BorderSize = 0;
            this.types_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.types_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.types_btn.ForeColor = System.Drawing.Color.White;
            this.types_btn.Location = new System.Drawing.Point(0, 32);
            this.types_btn.Name = "types_btn";
            this.types_btn.Size = new System.Drawing.Size(174, 47);
            this.types_btn.TabIndex = 2;
            this.types_btn.Text = "Типы";
            this.types_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.types_btn.UseVisualStyleBackColor = false;
            this.types_btn.Click += new System.EventHandler(this.types_btn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 32);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Salmon;
            this.header_panel.Controls.Add(this.head_label);
            this.header_panel.Controls.Add(this.Minimize_btn);
            this.header_panel.Controls.Add(this.Exit_btn);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(174, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(587, 32);
            this.header_panel.TabIndex = 1;
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_panel_MouseDown);
            // 
            // head_label
            // 
            this.head_label.AutoSize = true;
            this.head_label.BackColor = System.Drawing.Color.Transparent;
            this.head_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head_label.ForeColor = System.Drawing.Color.White;
            this.head_label.Location = new System.Drawing.Point(0, 0);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(230, 29);
            this.head_label.TabIndex = 2;
            this.head_label.Text = "Выберите таблицу";
            this.head_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Location = new System.Drawing.Point(523, 0);
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
            this.Exit_btn.Location = new System.Drawing.Point(555, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(32, 32);
            this.Exit_btn.TabIndex = 0;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(174, 32);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(587, 304);
            this.main_panel.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 336);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.navbar_panel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button types_btn;
        private System.Windows.Forms.Button supplier_btn;
        private System.Windows.Forms.Button prop_btn;
        private System.Windows.Forms.Button supply_btn;
        private System.Windows.Forms.Button Invent_btn;
        private System.Windows.Forms.Button svdoka_btn;
    }
}