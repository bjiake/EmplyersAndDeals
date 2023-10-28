namespace lab1
{
    partial class FormMain
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
            this.rbEmployer = new System.Windows.Forms.RadioButton();
            this.rbSeeker = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbEmployer
            // 
            this.rbEmployer.AutoSize = true;
            this.rbEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEmployer.Location = new System.Drawing.Point(37, 56);
            this.rbEmployer.Name = "rbEmployer";
            this.rbEmployer.Size = new System.Drawing.Size(119, 20);
            this.rbEmployer.TabIndex = 1;
            this.rbEmployer.TabStop = true;
            this.rbEmployer.Text = "Работодатель";
            this.rbEmployer.UseVisualStyleBackColor = true;
            // 
            // rbSeeker
            // 
            this.rbSeeker.AutoSize = true;
            this.rbSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSeeker.Location = new System.Drawing.Point(37, 82);
            this.rbSeeker.Name = "rbSeeker";
            this.rbSeeker.Size = new System.Drawing.Size(102, 20);
            this.rbSeeker.TabIndex = 2;
            this.rbSeeker.TabStop = true;
            this.rbSeeker.Text = "Соискатель";
            this.rbSeeker.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите тип пользователя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(37, 146);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(96, 33);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Начать";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAdmin.Location = new System.Drawing.Point(37, 108);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(60, 20);
            this.rbAdmin.TabIndex = 5;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Бюро";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 206);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSeeker);
            this.Controls.Add(this.rbEmployer);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEmployer;
        private System.Windows.Forms.RadioButton rbSeeker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}

