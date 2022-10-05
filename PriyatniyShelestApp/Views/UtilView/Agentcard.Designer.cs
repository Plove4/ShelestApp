namespace PriyatniyShelestApp.Views.UtilView
{
    partial class Agentcard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgentpictureBox = new System.Windows.Forms.PictureBox();
            this.AgentTypeAndName = new System.Windows.Forms.Label();
            this.AgentSales = new System.Windows.Forms.Label();
            this.AgentPhone = new System.Windows.Forms.Label();
            this.AgentPriority = new System.Windows.Forms.Label();
            this.AgentDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgentpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentpictureBox
            // 
            this.AgentpictureBox.Image = global::PriyatniyShelestApp.Properties.Resources.picture;
            this.AgentpictureBox.Location = new System.Drawing.Point(12, 12);
            this.AgentpictureBox.Name = "AgentpictureBox";
            this.AgentpictureBox.Size = new System.Drawing.Size(227, 174);
            this.AgentpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgentpictureBox.TabIndex = 0;
            this.AgentpictureBox.TabStop = false;
            // 
            // AgentTypeAndName
            // 
            this.AgentTypeAndName.AutoSize = true;
            this.AgentTypeAndName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentTypeAndName.Location = new System.Drawing.Point(261, 23);
            this.AgentTypeAndName.Name = "AgentTypeAndName";
            this.AgentTypeAndName.Size = new System.Drawing.Size(63, 28);
            this.AgentTypeAndName.TabIndex = 1;
            this.AgentTypeAndName.Text = "label1";
            // 
            // AgentSales
            // 
            this.AgentSales.AutoSize = true;
            this.AgentSales.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentSales.Location = new System.Drawing.Point(261, 62);
            this.AgentSales.Name = "AgentSales";
            this.AgentSales.Size = new System.Drawing.Size(63, 28);
            this.AgentSales.TabIndex = 2;
            this.AgentSales.Text = "label1";
            // 
            // AgentPhone
            // 
            this.AgentPhone.AutoSize = true;
            this.AgentPhone.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentPhone.Location = new System.Drawing.Point(261, 102);
            this.AgentPhone.Name = "AgentPhone";
            this.AgentPhone.Size = new System.Drawing.Size(63, 28);
            this.AgentPhone.TabIndex = 3;
            this.AgentPhone.Text = "label1";
            // 
            // AgentPriority
            // 
            this.AgentPriority.AutoSize = true;
            this.AgentPriority.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentPriority.Location = new System.Drawing.Point(261, 142);
            this.AgentPriority.Name = "AgentPriority";
            this.AgentPriority.Size = new System.Drawing.Size(63, 28);
            this.AgentPriority.TabIndex = 4;
            this.AgentPriority.Text = "label1";
            // 
            // AgentDiscount
            // 
            this.AgentDiscount.AutoSize = true;
            this.AgentDiscount.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgentDiscount.Location = new System.Drawing.Point(852, 12);
            this.AgentDiscount.Name = "AgentDiscount";
            this.AgentDiscount.Size = new System.Drawing.Size(63, 28);
            this.AgentDiscount.TabIndex = 5;
            this.AgentDiscount.Text = "label1";
            // 
            // Agentcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.AgentDiscount);
            this.Controls.Add(this.AgentPriority);
            this.Controls.Add(this.AgentPhone);
            this.Controls.Add(this.AgentSales);
            this.Controls.Add(this.AgentTypeAndName);
            this.Controls.Add(this.AgentpictureBox);
            this.Name = "Agentcard";
            this.Size = new System.Drawing.Size(927, 206);
            ((System.ComponentModel.ISupportInitialize)(this.AgentpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgentpictureBox;
        private System.Windows.Forms.Label AgentTypeAndName;
        private System.Windows.Forms.Label AgentSales;
        private System.Windows.Forms.Label AgentPhone;
        private System.Windows.Forms.Label AgentPriority;
        private System.Windows.Forms.Label AgentDiscount;
    }
}
