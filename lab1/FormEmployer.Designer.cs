namespace lab1
{
    partial class FormEmployer
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbTypeOfAction = new System.Windows.Forms.Label();
            this.lbAddres = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTypeOfActivity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(12, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название";
            // 
            // lbTypeOfAction
            // 
            this.lbTypeOfAction.AutoSize = true;
            this.lbTypeOfAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeOfAction.Location = new System.Drawing.Point(12, 86);
            this.lbTypeOfAction.Name = "lbTypeOfAction";
            this.lbTypeOfAction.Size = new System.Drawing.Size(154, 20);
            this.lbTypeOfAction.TabIndex = 1;
            this.lbTypeOfAction.Text = "Вид деятельности";
            // 
            // lbAddres
            // 
            this.lbAddres.AutoSize = true;
            this.lbAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddres.Location = new System.Drawing.Point(12, 120);
            this.lbAddres.Name = "lbAddres";
            this.lbAddres.Size = new System.Drawing.Size(57, 20);
            this.lbAddres.TabIndex = 2;
            this.lbAddres.Text = "Адрес";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumber.Location = new System.Drawing.Point(12, 155);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(59, 20);
            this.lbNumber.TabIndex = 3;
            this.lbNumber.Text = "Номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите данные";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(172, 51);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(140, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbTypeOfActivity
            // 
            this.tbTypeOfActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeOfActivity.Location = new System.Drawing.Point(172, 86);
            this.tbTypeOfActivity.Name = "tbTypeOfActivity";
            this.tbTypeOfActivity.Size = new System.Drawing.Size(140, 22);
            this.tbTypeOfActivity.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddress.Location = new System.Drawing.Point(172, 120);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(140, 22);
            this.tbAddress.TabIndex = 7;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new System.Drawing.Point(172, 148);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(140, 22);
            this.tbNumber.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(172, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ввести данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(12, 194);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 38);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Назад";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 276);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbTypeOfActivity);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbAddres);
            this.Controls.Add(this.lbTypeOfAction);
            this.Controls.Add(this.lbName);
            this.Name = "FormEmployer";
            this.Text = "FormEmployer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTypeOfAction;
        private System.Windows.Forms.Label lbAddres;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTypeOfActivity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCancel;
    }
}