namespace Cafe
{
    partial class ManagerForm
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
            this.tellerListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tellerInfoLabel = new System.Windows.Forms.Label();
            this.rateNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tellerListBox
            // 
            this.tellerListBox.FormattingEnabled = true;
            this.tellerListBox.ItemHeight = 20;
            this.tellerListBox.Location = new System.Drawing.Point(12, 12);
            this.tellerListBox.Name = "tellerListBox";
            this.tellerListBox.Size = new System.Drawing.Size(471, 724);
            this.tellerListBox.TabIndex = 0;
            this.tellerListBox.SelectedIndexChanged += new System.EventHandler(this.tellerListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(585, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 222);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tellerInfoLabel
            // 
            this.tellerInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tellerInfoLabel.Location = new System.Drawing.Point(585, 237);
            this.tellerInfoLabel.Name = "tellerInfoLabel";
            this.tellerInfoLabel.Size = new System.Drawing.Size(325, 476);
            this.tellerInfoLabel.TabIndex = 2;
            this.tellerInfoLabel.Text = "label1";
            // 
            // rateNumericUpDown1
            // 
            this.rateNumericUpDown1.Location = new System.Drawing.Point(489, 12);
            this.rateNumericUpDown1.Name = "rateNumericUpDown1";
            this.rateNumericUpDown1.Size = new System.Drawing.Size(90, 26);
            this.rateNumericUpDown1.TabIndex = 3;
            // 
            // rateButton
            // 
            this.rateButton.Location = new System.Drawing.Point(489, 44);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(90, 47);
            this.rateButton.TabIndex = 4;
            this.rateButton.Text = "Оценить";
            this.rateButton.UseVisualStyleBackColor = true;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 745);
            this.Controls.Add(this.rateButton);
            this.Controls.Add(this.rateNumericUpDown1);
            this.Controls.Add(this.tellerInfoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tellerListBox);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tellerListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tellerInfoLabel;
        private System.Windows.Forms.NumericUpDown rateNumericUpDown1;
        private System.Windows.Forms.Button rateButton;
    }
}