namespace Cafe.Forms
{
    partial class AddDishForm
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
            this.dishNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dishPriceNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dishCookingTimeNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.addDishButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishPriceNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCookingTimeNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // dishNameTextBox
            // 
            this.dishNameTextBox.Location = new System.Drawing.Point(46, 69);
            this.dishNameTextBox.Name = "dishNameTextBox";
            this.dishNameTextBox.Size = new System.Drawing.Size(432, 26);
            this.dishNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новое блюдо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // dishPriceNumericUpDown1
            // 
            this.dishPriceNumericUpDown1.Location = new System.Drawing.Point(46, 189);
            this.dishPriceNumericUpDown1.Name = "dishPriceNumericUpDown1";
            this.dishPriceNumericUpDown1.Size = new System.Drawing.Size(177, 26);
            this.dishPriceNumericUpDown1.TabIndex = 2;
            // 
            // dishCookingTimeNumericUpDown2
            // 
            this.dishCookingTimeNumericUpDown2.Location = new System.Drawing.Point(301, 189);
            this.dishCookingTimeNumericUpDown2.Name = "dishCookingTimeNumericUpDown2";
            this.dishCookingTimeNumericUpDown2.Size = new System.Drawing.Size(177, 26);
            this.dishCookingTimeNumericUpDown2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время приготовления";
            // 
            // addDishButton
            // 
            this.addDishButton.Location = new System.Drawing.Point(46, 251);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(175, 90);
            this.addDishButton.TabIndex = 3;
            this.addDishButton.Text = "Добавить блюдо";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(303, 251);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 90);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отменить блюдо";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addDishButton);
            this.Controls.Add(this.dishCookingTimeNumericUpDown2);
            this.Controls.Add(this.dishPriceNumericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishNameTextBox);
            this.Name = "AddDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDishForm";
            ((System.ComponentModel.ISupportInitialize)(this.dishPriceNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishCookingTimeNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dishNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dishPriceNumericUpDown1;
        private System.Windows.Forms.NumericUpDown dishCookingTimeNumericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDishButton;
        private System.Windows.Forms.Button cancelButton;
    }
}