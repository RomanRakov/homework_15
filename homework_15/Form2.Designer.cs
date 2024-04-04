namespace homework_15
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.pet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Карточка гостя";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(38, 83);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(46, 20);
            this.FIO.TabIndex = 33;
            this.FIO.Text = "ФИО";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateofbirth.Location = new System.Drawing.Point(38, 128);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(118, 20);
            this.dateofbirth.TabIndex = 34;
            this.dateofbirth.Text = "Дата рождения";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(38, 216);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(244, 20);
            this.days.TabIndex = 35;
            this.days.Text = "Продолжительность пребывания";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment.Location = new System.Drawing.Point(38, 172);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(62, 20);
            this.payment.TabIndex = 36;
            this.payment.Text = "Оплата";
            // 
            // pet
            // 
            this.pet.AutoSize = true;
            this.pet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pet.Location = new System.Drawing.Point(38, 261);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(221, 22);
            this.pet.TabIndex = 37;
            this.pet.Text = "Путешествует с животными";
            this.pet.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.days);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label FIO;
        internal System.Windows.Forms.Label dateofbirth;
        internal System.Windows.Forms.Label days;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.CheckBox pet;
    }
}