
namespace accounting_property_source.Forms
{
    partial class EditInvertalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Status_cb = new System.Windows.Forms.ComboBox();
            this.Prop_cb = new System.Windows.Forms.ComboBox();
            this.Edit_cb = new System.Windows.Forms.CheckBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetPropFilter_btn = new System.Windows.Forms.Button();
            this.ResetStatFilter_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PropFilter_cb = new System.Windows.Forms.ComboBox();
            this.StatusFilter_cb = new System.Windows.Forms.ComboBox();
            this.ResetDateFilt_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rjDatePicker3 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.rjDatePicker2 = new RJCodeAdvance.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.rjDatePicker1.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.rjDatePicker1.CustomFormat = "dd//mm//yy";
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(495, 333);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker1.TabIndex = 30;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(249, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Статус";
            // 
            // Status_cb
            // 
            this.Status_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.Status_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_cb.ForeColor = System.Drawing.Color.White;
            this.Status_cb.FormattingEnabled = true;
            this.Status_cb.Items.AddRange(new object[] {
            "Введение в эксплуатацию",
            "Списана",
            "Утилизация",
            "Ремонт"});
            this.Status_cb.Location = new System.Drawing.Point(252, 338);
            this.Status_cb.Name = "Status_cb";
            this.Status_cb.Size = new System.Drawing.Size(226, 28);
            this.Status_cb.TabIndex = 28;
            // 
            // Prop_cb
            // 
            this.Prop_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.Prop_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prop_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prop_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop_cb.ForeColor = System.Drawing.Color.White;
            this.Prop_cb.FormattingEnabled = true;
            this.Prop_cb.Location = new System.Drawing.Point(12, 338);
            this.Prop_cb.Name = "Prop_cb";
            this.Prop_cb.Size = new System.Drawing.Size(226, 28);
            this.Prop_cb.TabIndex = 27;
            // 
            // Edit_cb
            // 
            this.Edit_cb.AutoSize = true;
            this.Edit_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_cb.ForeColor = System.Drawing.Color.Coral;
            this.Edit_cb.Location = new System.Drawing.Point(507, 314);
            this.Edit_cb.Name = "Edit_cb";
            this.Edit_cb.Size = new System.Drawing.Size(124, 17);
            this.Edit_cb.TabIndex = 26;
            this.Edit_cb.Text = "Редактирование";
            this.Edit_cb.UseVisualStyleBackColor = true;
            this.Edit_cb.CheckedChanged += new System.EventHandler(this.Edit_cb_CheckedChanged);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(162, 383);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(226, 29);
            this.Delete_btn.TabIndex = 25;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(405, 383);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(226, 29);
            this.Add_btn.TabIndex = 24;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Tomato;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(609, 296);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Имущество";
            // 
            // ResetPropFilter_btn
            // 
            this.ResetPropFilter_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetPropFilter_btn.FlatAppearance.BorderSize = 0;
            this.ResetPropFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPropFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPropFilter_btn.ForeColor = System.Drawing.Color.White;
            this.ResetPropFilter_btn.Location = new System.Drawing.Point(938, 46);
            this.ResetPropFilter_btn.Name = "ResetPropFilter_btn";
            this.ResetPropFilter_btn.Size = new System.Drawing.Size(22, 28);
            this.ResetPropFilter_btn.TabIndex = 42;
            this.ResetPropFilter_btn.Text = "X";
            this.ResetPropFilter_btn.UseVisualStyleBackColor = false;
            this.ResetPropFilter_btn.Click += new System.EventHandler(this.ResetPropFilter_btn_Click);
            // 
            // ResetStatFilter_btn
            // 
            this.ResetStatFilter_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetStatFilter_btn.FlatAppearance.BorderSize = 0;
            this.ResetStatFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetStatFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetStatFilter_btn.ForeColor = System.Drawing.Color.White;
            this.ResetStatFilter_btn.Location = new System.Drawing.Point(938, 114);
            this.ResetStatFilter_btn.Name = "ResetStatFilter_btn";
            this.ResetStatFilter_btn.Size = new System.Drawing.Size(22, 28);
            this.ResetStatFilter_btn.TabIndex = 41;
            this.ResetStatFilter_btn.Text = "X";
            this.ResetStatFilter_btn.UseVisualStyleBackColor = false;
            this.ResetStatFilter_btn.Click += new System.EventHandler(this.ResetStatFilter_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(706, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Статус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(706, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Имущество:";
            // 
            // PropFilter_cb
            // 
            this.PropFilter_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.PropFilter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropFilter_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropFilter_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropFilter_cb.ForeColor = System.Drawing.Color.White;
            this.PropFilter_cb.FormattingEnabled = true;
            this.PropFilter_cb.Location = new System.Drawing.Point(706, 46);
            this.PropFilter_cb.Name = "PropFilter_cb";
            this.PropFilter_cb.Size = new System.Drawing.Size(226, 28);
            this.PropFilter_cb.TabIndex = 38;
            this.PropFilter_cb.SelectedIndexChanged += new System.EventHandler(this.PropFilter_cb_SelectedIndexChanged);
            // 
            // StatusFilter_cb
            // 
            this.StatusFilter_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.StatusFilter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusFilter_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusFilter_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusFilter_cb.ForeColor = System.Drawing.Color.White;
            this.StatusFilter_cb.FormattingEnabled = true;
            this.StatusFilter_cb.Items.AddRange(new object[] {
            "Введение в эксплуатацию",
            "Списана",
            "Утилизация",
            "Ремонт"});
            this.StatusFilter_cb.Location = new System.Drawing.Point(706, 114);
            this.StatusFilter_cb.Name = "StatusFilter_cb";
            this.StatusFilter_cb.Size = new System.Drawing.Size(226, 28);
            this.StatusFilter_cb.TabIndex = 37;
            this.StatusFilter_cb.SelectedIndexChanged += new System.EventHandler(this.StatusFilter_cb_SelectedIndexChanged);
            // 
            // ResetDateFilt_btn
            // 
            this.ResetDateFilt_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetDateFilt_btn.FlatAppearance.BorderSize = 0;
            this.ResetDateFilt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDateFilt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetDateFilt_btn.ForeColor = System.Drawing.Color.White;
            this.ResetDateFilt_btn.Location = new System.Drawing.Point(964, 174);
            this.ResetDateFilt_btn.Name = "ResetDateFilt_btn";
            this.ResetDateFilt_btn.Size = new System.Drawing.Size(22, 35);
            this.ResetDateFilt_btn.TabIndex = 36;
            this.ResetDateFilt_btn.Text = "X";
            this.ResetDateFilt_btn.UseVisualStyleBackColor = false;
            this.ResetDateFilt_btn.Click += new System.EventHandler(this.ResetDateFilt_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(792, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "__";
            // 
            // rjDatePicker3
            // 
            this.rjDatePicker3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker3.BorderSize = 0;
            this.rjDatePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker3.CalendarForeColor = System.Drawing.Color.White;
            this.rjDatePicker3.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.rjDatePicker3.CustomFormat = " ";
            this.rjDatePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker3.Location = new System.Drawing.Point(644, 174);
            this.rjDatePicker3.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker3.Name = "rjDatePicker3";
            this.rjDatePicker3.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker3.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker3.TabIndex = 34;
            this.rjDatePicker3.TextColor = System.Drawing.Color.White;
            this.rjDatePicker3.ValueChanged += new System.EventHandler(this.rjDatePicker3_ValueChanged);
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker2.CalendarForeColor = System.Drawing.Color.White;
            this.rjDatePicker2.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.rjDatePicker2.CustomFormat = " ";
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker2.Location = new System.Drawing.Point(826, 174);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker2.TabIndex = 33;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            this.rjDatePicker2.ValueChanged += new System.EventHandler(this.rjDatePicker2_ValueChanged);
            // 
            // EditInvertalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 431);
            this.Controls.Add(this.ResetPropFilter_btn);
            this.Controls.Add(this.ResetStatFilter_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PropFilter_cb);
            this.Controls.Add(this.StatusFilter_cb);
            this.Controls.Add(this.ResetDateFilt_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjDatePicker3);
            this.Controls.Add(this.rjDatePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status_cb);
            this.Controls.Add(this.Prop_cb);
            this.Controls.Add(this.Edit_cb);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditInvertalForm";
            this.Text = "EditInvertalForm";
            this.Load += new System.EventHandler(this.EditInvertalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Status_cb;
        private System.Windows.Forms.ComboBox Prop_cb;
        private System.Windows.Forms.CheckBox Edit_cb;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetPropFilter_btn;
        private System.Windows.Forms.Button ResetStatFilter_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PropFilter_cb;
        private System.Windows.Forms.ComboBox StatusFilter_cb;
        private System.Windows.Forms.Button ResetDateFilt_btn;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker3;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker2;
    }
}