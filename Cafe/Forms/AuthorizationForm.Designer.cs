namespace Cafe.Forms
{
    partial class AuthorizationForm
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
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_Button = new System.Windows.Forms.Button();
            this.registration_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login_TextBox
            // 
            this.login_TextBox.Location = new System.Drawing.Point(161, 132);
            this.login_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_TextBox.Name = "login_TextBox";
            this.login_TextBox.Size = new System.Drawing.Size(410, 26);
            this.login_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(161, 235);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(410, 26);
            this.password_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // enter_Button
            // 
            this.enter_Button.Location = new System.Drawing.Point(253, 270);
            this.enter_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enter_Button.Name = "enter_Button";
            this.enter_Button.Size = new System.Drawing.Size(194, 80);
            this.enter_Button.TabIndex = 4;
            this.enter_Button.Text = "Войти";
            this.enter_Button.UseVisualStyleBackColor = true;
            this.enter_Button.Click += new System.EventHandler(this.enter_Button_Click);
            // 
            // registration_LinkLabel
            // 
            this.registration_LinkLabel.AutoSize = true;
            this.registration_LinkLabel.Location = new System.Drawing.Point(268, 354);
            this.registration_LinkLabel.Name = "registration_LinkLabel";
            this.registration_LinkLabel.Size = new System.Drawing.Size(169, 20);
            this.registration_LinkLabel.TabIndex = 5;
            this.registration_LinkLabel.TabStop = true;
            this.registration_LinkLabel.Text = "Зарегистрироваться";
            this.registration_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkLabel_LinkClicked);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 544);
            this.Controls.Add(this.registration_LinkLabel);
            this.Controls.Add(this.enter_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter_Button;
        private System.Windows.Forms.LinkLabel registration_LinkLabel;
    }
}

