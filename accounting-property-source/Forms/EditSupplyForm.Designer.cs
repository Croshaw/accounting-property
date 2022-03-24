
namespace accounting_property_source.Forms
{
    partial class EditSupplyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit_cb = new System.Windows.Forms.CheckBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Org_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjDatePicker1 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.Prop_cb = new System.Windows.Forms.ComboBox();
            this.rjDatePicker2 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.rjDatePicker3 = new RJCodeAdvance.RJControls.RJDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetDateFilt_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PropFilter_cb = new System.Windows.Forms.ComboBox();
            this.OrgFilter_cb = new System.Windows.Forms.ComboBox();
            this.ResetPropFilter_btn = new System.Windows.Forms.Button();
            this.ResetOrgFilter_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Tomato;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 297);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Edit_cb
            // 
            this.Edit_cb.AutoSize = true;
            this.Edit_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_cb.ForeColor = System.Drawing.Color.Coral;
            this.Edit_cb.Location = new System.Drawing.Point(507, 314);
            this.Edit_cb.Name = "Edit_cb";
            this.Edit_cb.Size = new System.Drawing.Size(124, 17);
            this.Edit_cb.TabIndex = 16;
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
            this.Delete_btn.TabIndex = 15;
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
            this.Add_btn.TabIndex = 14;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Org_cb
            // 
            this.Org_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.Org_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Org_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Org_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Org_cb.ForeColor = System.Drawing.Color.White;
            this.Org_cb.FormattingEnabled = true;
            this.Org_cb.Location = new System.Drawing.Point(12, 338);
            this.Org_cb.Name = "Org_cb";
            this.Org_cb.Size = new System.Drawing.Size(226, 28);
            this.Org_cb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Организация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(249, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Поставка:";
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
            this.rjDatePicker1.Location = new System.Drawing.Point(495, 333);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker1.TabIndex = 22;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // Prop_cb
            // 
            this.Prop_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.Prop_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prop_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prop_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prop_cb.ForeColor = System.Drawing.Color.White;
            this.Prop_cb.FormattingEnabled = true;
            this.Prop_cb.Location = new System.Drawing.Point(252, 338);
            this.Prop_cb.Name = "Prop_cb";
            this.Prop_cb.Size = new System.Drawing.Size(226, 28);
            this.Prop_cb.TabIndex = 18;
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
            this.rjDatePicker2.Location = new System.Drawing.Point(819, 175);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker2.TabIndex = 23;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            this.rjDatePicker2.ValueChanged += new System.EventHandler(this.rjDatePicker2_ValueChanged);
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
            this.rjDatePicker3.Location = new System.Drawing.Point(637, 175);
            this.rjDatePicker3.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker3.Name = "rjDatePicker3";
            this.rjDatePicker3.Size = new System.Drawing.Size(136, 35);
            this.rjDatePicker3.SkinColor = System.Drawing.Color.LightSalmon;
            this.rjDatePicker3.TabIndex = 24;
            this.rjDatePicker3.TextColor = System.Drawing.Color.White;
            this.rjDatePicker3.ValueChanged += new System.EventHandler(this.rjDatePicker3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(785, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "__";
            // 
            // ResetDateFilt_btn
            // 
            this.ResetDateFilt_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetDateFilt_btn.FlatAppearance.BorderSize = 0;
            this.ResetDateFilt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDateFilt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetDateFilt_btn.ForeColor = System.Drawing.Color.White;
            this.ResetDateFilt_btn.Location = new System.Drawing.Point(957, 175);
            this.ResetDateFilt_btn.Name = "ResetDateFilt_btn";
            this.ResetDateFilt_btn.Size = new System.Drawing.Size(22, 35);
            this.ResetDateFilt_btn.TabIndex = 26;
            this.ResetDateFilt_btn.Text = "X";
            this.ResetDateFilt_btn.UseVisualStyleBackColor = false;
            this.ResetDateFilt_btn.Click += new System.EventHandler(this.ResetDateFilt_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(699, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Поставка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(699, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Организация:";
            // 
            // PropFilter_cb
            // 
            this.PropFilter_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.PropFilter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropFilter_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropFilter_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropFilter_cb.ForeColor = System.Drawing.Color.White;
            this.PropFilter_cb.FormattingEnabled = true;
            this.PropFilter_cb.Location = new System.Drawing.Point(699, 115);
            this.PropFilter_cb.Name = "PropFilter_cb";
            this.PropFilter_cb.Size = new System.Drawing.Size(226, 28);
            this.PropFilter_cb.TabIndex = 28;
            this.PropFilter_cb.SelectedIndexChanged += new System.EventHandler(this.PropFilter_cb_SelectedIndexChanged);
            // 
            // OrgFilter_cb
            // 
            this.OrgFilter_cb.BackColor = System.Drawing.Color.LightSalmon;
            this.OrgFilter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrgFilter_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrgFilter_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgFilter_cb.ForeColor = System.Drawing.Color.White;
            this.OrgFilter_cb.FormattingEnabled = true;
            this.OrgFilter_cb.Location = new System.Drawing.Point(699, 47);
            this.OrgFilter_cb.Name = "OrgFilter_cb";
            this.OrgFilter_cb.Size = new System.Drawing.Size(226, 28);
            this.OrgFilter_cb.TabIndex = 27;
            this.OrgFilter_cb.SelectedIndexChanged += new System.EventHandler(this.OrgFilter_cb_SelectedIndexChanged);
            // 
            // ResetPropFilter_btn
            // 
            this.ResetPropFilter_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetPropFilter_btn.FlatAppearance.BorderSize = 0;
            this.ResetPropFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPropFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPropFilter_btn.ForeColor = System.Drawing.Color.White;
            this.ResetPropFilter_btn.Location = new System.Drawing.Point(931, 115);
            this.ResetPropFilter_btn.Name = "ResetPropFilter_btn";
            this.ResetPropFilter_btn.Size = new System.Drawing.Size(22, 28);
            this.ResetPropFilter_btn.TabIndex = 31;
            this.ResetPropFilter_btn.Text = "X";
            this.ResetPropFilter_btn.UseVisualStyleBackColor = false;
            this.ResetPropFilter_btn.Click += new System.EventHandler(this.ResetPropFilter_btn_Click);
            // 
            // ResetOrgFilter_btn
            // 
            this.ResetOrgFilter_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.ResetOrgFilter_btn.FlatAppearance.BorderSize = 0;
            this.ResetOrgFilter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetOrgFilter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetOrgFilter_btn.ForeColor = System.Drawing.Color.White;
            this.ResetOrgFilter_btn.Location = new System.Drawing.Point(931, 47);
            this.ResetOrgFilter_btn.Name = "ResetOrgFilter_btn";
            this.ResetOrgFilter_btn.Size = new System.Drawing.Size(22, 28);
            this.ResetOrgFilter_btn.TabIndex = 32;
            this.ResetOrgFilter_btn.Text = "X";
            this.ResetOrgFilter_btn.UseVisualStyleBackColor = false;
            this.ResetOrgFilter_btn.Click += new System.EventHandler(this.ResetOrgFilter_btn_Click);
            // 
            // EditSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 443);
            this.Controls.Add(this.ResetOrgFilter_btn);
            this.Controls.Add(this.ResetPropFilter_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PropFilter_cb);
            this.Controls.Add(this.OrgFilter_cb);
            this.Controls.Add(this.ResetDateFilt_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjDatePicker3);
            this.Controls.Add(this.rjDatePicker2);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prop_cb);
            this.Controls.Add(this.Org_cb);
            this.Controls.Add(this.Edit_cb);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditSupplyForm";
            this.Text = "EditSupplyForm";
            this.Load += new System.EventHandler(this.EditSupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Edit_cb;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.ComboBox Org_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.ComboBox Prop_cb;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker2;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetDateFilt_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PropFilter_cb;
        private System.Windows.Forms.ComboBox OrgFilter_cb;
        private System.Windows.Forms.Button ResetPropFilter_btn;
        private System.Windows.Forms.Button ResetOrgFilter_btn;
    }
}