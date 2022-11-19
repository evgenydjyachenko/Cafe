namespace Cafe
{
    partial class RegistrationForm
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
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.lastName_TextBox = new System.Windows.Forms.TextBox();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registration_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(37, 70);
            this.login_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(300, 26);
            this.login_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(37, 148);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(300, 26);
            this.password_TextBox.TabIndex = 1;
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Location = new System.Drawing.Point(37, 230);
            this.firstName_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(300, 26);
            this.firstName_TextBox.TabIndex = 2;
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.Location = new System.Drawing.Point(37, 319);
            this.lastName_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Size = new System.Drawing.Size(300, 26);
            this.lastName_TextBox.TabIndex = 3;
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(37, 410);
            this.email_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(300, 26);
            this.email_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Кассир"});
            this.comboBox1.Location = new System.Drawing.Point(415, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите роль:";
            // 
            // registration_Button
            // 
            this.registration_Button.Location = new System.Drawing.Point(37, 480);
            this.registration_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registration_Button.Name = "registration_Button";
            this.registration_Button.Size = new System.Drawing.Size(300, 105);
            this.registration_Button.TabIndex = 12;
            this.registration_Button.Text = "Регистрация";
            this.registration_Button.UseVisualStyleBackColor = true;
            this.registration_Button.Click += new System.EventHandler(this.registration_Button_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 630);
            this.Controls.Add(this.registration_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.lastName_TextBox);
            this.Controls.Add(this.firstName_TextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox firstName_TextBox;
        private System.Windows.Forms.TextBox lastName_TextBox;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registration_Button;
    }
}