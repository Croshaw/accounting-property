
namespace accounting_property_source.Forms
{
    partial class EditPropertysForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PropertysName_tb = new System.Windows.Forms.TextBox();
            this.Types_cb = new System.Windows.Forms.ComboBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Edit_cb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(359, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PropertysName_tb
            // 
            this.PropertysName_tb.Location = new System.Drawing.Point(411, 27);
            this.PropertysName_tb.Name = "PropertysName_tb";
            this.PropertysName_tb.Size = new System.Drawing.Size(175, 20);
            this.PropertysName_tb.TabIndex = 1;
            // 
            // Types_cb
            // 
            this.Types_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Types_cb.FormattingEnabled = true;
            this.Types_cb.Location = new System.Drawing.Point(411, 74);
            this.Types_cb.Name = "Types_cb";
            this.Types_cb.Size = new System.Drawing.Size(175, 21);
            this.Types_cb.TabIndex = 2;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(411, 126);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(175, 29);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(411, 172);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(175, 29);
            this.Delete_btn.TabIndex = 4;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_cb
            // 
            this.Edit_cb.AutoSize = true;
            this.Edit_cb.Location = new System.Drawing.Point(411, 222);
            this.Edit_cb.Name = "Edit_cb";
            this.Edit_cb.Size = new System.Drawing.Size(110, 17);
            this.Edit_cb.TabIndex = 5;
            this.Edit_cb.Text = "Редактирование";
            this.Edit_cb.UseVisualStyleBackColor = true;
            this.Edit_cb.CheckedChanged += new System.EventHandler(this.Edit_cb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип:";
            // 
            // EditPropertysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit_cb);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Types_cb);
            this.Controls.Add(this.PropertysName_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditPropertysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имущество";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPropertysForm_FormClosing);
            this.Load += new System.EventHandler(this.EditPropertysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PropertysName_tb;
        private System.Windows.Forms.ComboBox Types_cb;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.CheckBox Edit_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}