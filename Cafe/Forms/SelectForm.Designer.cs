namespace Cafe.Forms
{
    partial class SelectForm
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
            this.checkOutButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminFormButton = new System.Windows.Forms.Button();
            this.managerFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(255, 69);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(268, 94);
            this.checkOutButton.TabIndex = 0;
            this.checkOutButton.Text = "Касса";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // adminFormButton
            // 
            this.adminFormButton.Location = new System.Drawing.Point(255, 169);
            this.adminFormButton.Name = "adminFormButton";
            this.adminFormButton.Size = new System.Drawing.Size(268, 94);
            this.adminFormButton.TabIndex = 0;
            this.adminFormButton.Text = "Панель управления";
            this.adminFormButton.UseVisualStyleBackColor = true;
            this.adminFormButton.Click += new System.EventHandler(this.adminFormButton_Click);
            // 
            // managerFormButton
            // 
            this.managerFormButton.Location = new System.Drawing.Point(260, 269);
            this.managerFormButton.Name = "managerFormButton";
            this.managerFormButton.Size = new System.Drawing.Size(263, 96);
            this.managerFormButton.TabIndex = 2;
            this.managerFormButton.Text = "Управление персоналом";
            this.managerFormButton.UseVisualStyleBackColor = true;
            this.managerFormButton.Click += new System.EventHandler(this.managerFormButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerFormButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adminFormButton);
            this.Controls.Add(this.checkOutButton);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adminFormButton;
        private System.Windows.Forms.Button managerFormButton;
    }
}