
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
            this.Property_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Property_btn
            // 
            this.Property_btn.Location = new System.Drawing.Point(35, 12);
            this.Property_btn.Name = "Property_btn";
            this.Property_btn.Size = new System.Drawing.Size(249, 63);
            this.Property_btn.TabIndex = 0;
            this.Property_btn.Text = "Имущество";
            this.Property_btn.UseVisualStyleBackColor = true;
            this.Property_btn.Click += new System.EventHandler(this.Property_btn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 175);
            this.Controls.Add(this.Property_btn);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Property_btn;
    }
}