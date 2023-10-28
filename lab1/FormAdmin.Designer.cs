namespace lab1
{
    partial class FormAdmin
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
            this.btCalculate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEmployer = new System.Windows.Forms.Button();
            this.btSeeker = new System.Windows.Forms.Button();
            this.btDeals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCalculate.Location = new System.Drawing.Point(258, 106);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(115, 27);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Расчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(131, 106);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 27);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Назад";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEmployer
            // 
            this.btEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEmployer.Location = new System.Drawing.Point(62, 60);
            this.btEmployer.Name = "btEmployer";
            this.btEmployer.Size = new System.Drawing.Size(130, 23);
            this.btEmployer.TabIndex = 28;
            this.btEmployer.Text = "Работодатели";
            this.btEmployer.UseVisualStyleBackColor = true;
            this.btEmployer.Click += new System.EventHandler(this.btEmployer_Click);
            // 
            // btSeeker
            // 
            this.btSeeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSeeker.Location = new System.Drawing.Point(198, 60);
            this.btSeeker.Name = "btSeeker";
            this.btSeeker.Size = new System.Drawing.Size(130, 23);
            this.btSeeker.TabIndex = 29;
            this.btSeeker.Text = "Соискатели";
            this.btSeeker.UseVisualStyleBackColor = true;
            this.btSeeker.Click += new System.EventHandler(this.btSeeker_Click);
            // 
            // btDeals
            // 
            this.btDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDeals.Location = new System.Drawing.Point(334, 60);
            this.btDeals.Name = "btDeals";
            this.btDeals.Size = new System.Drawing.Size(130, 23);
            this.btDeals.TabIndex = 30;
            this.btDeals.Text = "Сделки";
            this.btDeals.UseVisualStyleBackColor = true;
            this.btDeals.Click += new System.EventHandler(this.btDeals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Выбор таблицы";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeals);
            this.Controls.Add(this.btSeeker);
            this.Controls.Add(this.btEmployer);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCalculate);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEmployer;
        private System.Windows.Forms.Button btSeeker;
        private System.Windows.Forms.Button btDeals;
        private System.Windows.Forms.Label label1;
    }
}