namespace lab1
{
    partial class FormSeeker
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbQualification = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbMain = new System.Windows.Forms.Label();
            this.lbQualifitacion = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbTypeOfActivity = new System.Windows.Forms.TextBox();
            this.lbTypeOfAction = new System.Windows.Forms.Label();
            this.tbOtherData = new System.Windows.Forms.TextBox();
            this.lbOtherData = new System.Windows.Forms.Label();
            this.tbEstimatedSalary = new System.Windows.Forms.TextBox();
            this.lbEstimatedSalary = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(177, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ввести данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbQualification
            // 
            this.tbQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQualification.Location = new System.Drawing.Point(177, 155);
            this.tbQualification.Name = "tbQualification";
            this.tbQualification.Size = new System.Drawing.Size(140, 22);
            this.tbQualification.TabIndex = 18;
            this.tbQualification.TextChanged += new System.EventHandler(this.tbQualification_TextChanged);
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(177, 120);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(140, 22);
            this.tbMiddleName.TabIndex = 17;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(177, 86);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(140, 22);
            this.tbLastName.TabIndex = 16;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.Location = new System.Drawing.Point(177, 51);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(140, 22);
            this.tbFirstName.TabIndex = 15;
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMain.Location = new System.Drawing.Point(80, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(176, 25);
            this.lbMain.TabIndex = 14;
            this.lbMain.Text = "Введите данные";
            // 
            // lbQualifitacion
            // 
            this.lbQualifitacion.AutoSize = true;
            this.lbQualifitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQualifitacion.Location = new System.Drawing.Point(17, 155);
            this.lbQualifitacion.Name = "lbQualifitacion";
            this.lbQualifitacion.Size = new System.Drawing.Size(124, 20);
            this.lbQualifitacion.TabIndex = 13;
            this.lbQualifitacion.Text = "Квалификация";
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMiddleName.Location = new System.Drawing.Point(17, 120);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(83, 20);
            this.lbMiddleName.TabIndex = 12;
            this.lbMiddleName.Text = "Отчество";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLastName.Location = new System.Drawing.Point(17, 86);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(81, 20);
            this.lbLastName.TabIndex = 11;
            this.lbLastName.Text = "Фамилия";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFirstName.Location = new System.Drawing.Point(17, 53);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(40, 20);
            this.lbFirstName.TabIndex = 10;
            this.lbFirstName.Text = "Имя";
            // 
            // tbTypeOfActivity
            // 
            this.tbTypeOfActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeOfActivity.Location = new System.Drawing.Point(177, 191);
            this.tbTypeOfActivity.Name = "tbTypeOfActivity";
            this.tbTypeOfActivity.Size = new System.Drawing.Size(140, 22);
            this.tbTypeOfActivity.TabIndex = 21;
            // 
            // lbTypeOfAction
            // 
            this.lbTypeOfAction.AutoSize = true;
            this.lbTypeOfAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTypeOfAction.Location = new System.Drawing.Point(17, 191);
            this.lbTypeOfAction.Name = "lbTypeOfAction";
            this.lbTypeOfAction.Size = new System.Drawing.Size(154, 20);
            this.lbTypeOfAction.TabIndex = 20;
            this.lbTypeOfAction.Text = "Вид деятельности";
            // 
            // tbOtherData
            // 
            this.tbOtherData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtherData.Location = new System.Drawing.Point(177, 226);
            this.tbOtherData.Name = "tbOtherData";
            this.tbOtherData.Size = new System.Drawing.Size(140, 22);
            this.tbOtherData.TabIndex = 23;
            // 
            // lbOtherData
            // 
            this.lbOtherData.AutoSize = true;
            this.lbOtherData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOtherData.Location = new System.Drawing.Point(17, 226);
            this.lbOtherData.Name = "lbOtherData";
            this.lbOtherData.Size = new System.Drawing.Size(111, 20);
            this.lbOtherData.TabIndex = 22;
            this.lbOtherData.Text = "Иные данные";
            // 
            // tbEstimatedSalary
            // 
            this.tbEstimatedSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEstimatedSalary.Location = new System.Drawing.Point(177, 260);
            this.tbEstimatedSalary.Name = "tbEstimatedSalary";
            this.tbEstimatedSalary.Size = new System.Drawing.Size(140, 22);
            this.tbEstimatedSalary.TabIndex = 25;
            // 
            // lbEstimatedSalary
            // 
            this.lbEstimatedSalary.AutoSize = true;
            this.lbEstimatedSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEstimatedSalary.Location = new System.Drawing.Point(17, 260);
            this.lbEstimatedSalary.Name = "lbEstimatedSalary";
            this.lbEstimatedSalary.Size = new System.Drawing.Size(124, 20);
            this.lbEstimatedSalary.TabIndex = 24;
            this.lbEstimatedSalary.Text = "Ожидаемое з.п";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(21, 309);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 38);
            this.btCancel.TabIndex = 26;
            this.btCancel.Text = "Назад";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 359);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbEstimatedSalary);
            this.Controls.Add(this.lbEstimatedSalary);
            this.Controls.Add(this.tbOtherData);
            this.Controls.Add(this.lbOtherData);
            this.Controls.Add(this.tbTypeOfActivity);
            this.Controls.Add(this.lbTypeOfAction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbQualification);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.lbQualifitacion);
            this.Controls.Add(this.lbMiddleName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "FormSeeker";
            this.Text = "FormSeeker";
            this.Load += new System.EventHandler(this.FormSeeker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbQualification;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label lbQualifitacion;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbTypeOfActivity;
        private System.Windows.Forms.Label lbTypeOfAction;
        private System.Windows.Forms.TextBox tbOtherData;
        private System.Windows.Forms.Label lbOtherData;
        private System.Windows.Forms.TextBox tbEstimatedSalary;
        private System.Windows.Forms.Label lbEstimatedSalary;
        private System.Windows.Forms.Button btCancel;
    }
}