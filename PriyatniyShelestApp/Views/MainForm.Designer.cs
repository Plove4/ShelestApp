namespace PriyatniyShelestApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.FiltrcomboBox = new System.Windows.Forms.ComboBox();
            this.SortcomboBox = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.LogopictureBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 47);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1060, 418);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = global::PriyatniyShelestApp.Properties.Resources.Приятный_шелест1;
            this.LogopictureBox.Location = new System.Drawing.Point(3, 3);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(65, 56);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 0;
            this.LogopictureBox.TabStop = false;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchtextBox.Location = new System.Drawing.Point(59, 19);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(436, 29);
            this.SearchtextBox.TabIndex = 1;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // FiltrcomboBox
            // 
            this.FiltrcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrcomboBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrcomboBox.FormattingEnabled = true;
            this.FiltrcomboBox.Location = new System.Drawing.Point(501, 19);
            this.FiltrcomboBox.Name = "FiltrcomboBox";
            this.FiltrcomboBox.Size = new System.Drawing.Size(121, 30);
            this.FiltrcomboBox.TabIndex = 2;
            this.FiltrcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrcomboBox_SelectedIndexChanged);
            // 
            // SortcomboBox
            // 
            this.SortcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortcomboBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortcomboBox.FormattingEnabled = true;
            this.SortcomboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Размер скидки",
            "Приоритет агента"});
            this.SortcomboBox.Location = new System.Drawing.Point(628, 19);
            this.SortcomboBox.Name = "SortcomboBox";
            this.SortcomboBox.Size = new System.Drawing.Size(155, 30);
            this.SortcomboBox.TabIndex = 3;
            this.SortcomboBox.SelectedIndexChanged += new System.EventHandler(this.SortcomboBox_SelectedIndexChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(789, 21);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(149, 26);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "По возрастанию";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox);
            this.panel3.Controls.Add(this.SortcomboBox);
            this.panel3.Controls.Add(this.SearchtextBox);
            this.panel3.Controls.Add(this.FiltrcomboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(122, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 62);
            this.panel3.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 527);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form Shelest";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox SortcomboBox;
        private System.Windows.Forms.ComboBox FiltrcomboBox;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Panel panel3;
    }
}

