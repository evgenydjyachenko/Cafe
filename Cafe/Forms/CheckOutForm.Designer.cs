namespace Cafe.Forms
{
    partial class CheckOutForm
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
            this.components = new System.ComponentModel.Container();
            this.customerQueueListBox = new System.Windows.Forms.ListBox();
            this.customerOrderQueueLabel = new System.Windows.Forms.Label();
            this.acceptOrderButton = new System.Windows.Forms.Button();
            this.orderQueueListBox = new System.Windows.Forms.ListBox();
            this.waitOrderQueueLabel = new System.Windows.Forms.Label();
            this.customerTimer = new System.Windows.Forms.Timer(this.components);
            this.cookingTimer = new System.Windows.Forms.Timer(this.components);
            this.readyOrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerQueueListBox
            // 
            this.customerQueueListBox.FormattingEnabled = true;
            this.customerQueueListBox.ItemHeight = 20;
            this.customerQueueListBox.Location = new System.Drawing.Point(680, 12);
            this.customerQueueListBox.Name = "customerQueueListBox";
            this.customerQueueListBox.Size = new System.Drawing.Size(257, 664);
            this.customerQueueListBox.TabIndex = 0;
            this.customerQueueListBox.SelectedIndexChanged += new System.EventHandler(this.customerQueueListBox_SelectedIndexChanged);
            // 
            // customerOrderQueueLabel
            // 
            this.customerOrderQueueLabel.Location = new System.Drawing.Point(241, 12);
            this.customerOrderQueueLabel.Name = "customerOrderQueueLabel";
            this.customerOrderQueueLabel.Size = new System.Drawing.Size(433, 180);
            this.customerOrderQueueLabel.TabIndex = 1;
            this.customerOrderQueueLabel.Text = "Ваш заказ";
            this.customerOrderQueueLabel.Click += new System.EventHandler(this.customerOrderQueueLabel_Click);
            // 
            // acceptOrderButton
            // 
            this.acceptOrderButton.Location = new System.Drawing.Point(307, 195);
            this.acceptOrderButton.Name = "acceptOrderButton";
            this.acceptOrderButton.Size = new System.Drawing.Size(304, 104);
            this.acceptOrderButton.TabIndex = 2;
            this.acceptOrderButton.Text = "Принять заказ";
            this.acceptOrderButton.UseVisualStyleBackColor = true;
            this.acceptOrderButton.Click += new System.EventHandler(this.acceptOrderButton_Click);
            // 
            // orderQueueListBox
            // 
            this.orderQueueListBox.FormattingEnabled = true;
            this.orderQueueListBox.ItemHeight = 20;
            this.orderQueueListBox.Location = new System.Drawing.Point(12, 12);
            this.orderQueueListBox.Name = "orderQueueListBox";
            this.orderQueueListBox.Size = new System.Drawing.Size(223, 664);
            this.orderQueueListBox.TabIndex = 3;
            // 
            // waitOrderQueueLabel
            // 
            this.waitOrderQueueLabel.Location = new System.Drawing.Point(241, 496);
            this.waitOrderQueueLabel.Name = "waitOrderQueueLabel";
            this.waitOrderQueueLabel.Size = new System.Drawing.Size(433, 180);
            this.waitOrderQueueLabel.TabIndex = 1;
            this.waitOrderQueueLabel.Text = "Ждут заказа";
            // 
            // customerTimer
            // 
            this.customerTimer.Interval = 1000;
            this.customerTimer.Tick += new System.EventHandler(this.customerTimer_Tick);
            // 
            // cookingTimer
            // 
            this.cookingTimer.Interval = 1000;
            this.cookingTimer.Tick += new System.EventHandler(this.cookingTimer_Tick);
            // 
            // readyOrderLabel
            // 
            this.readyOrderLabel.AutoSize = true;
            this.readyOrderLabel.Location = new System.Drawing.Point(287, 356);
            this.readyOrderLabel.Name = "readyOrderLabel";
            this.readyOrderLabel.Size = new System.Drawing.Size(51, 20);
            this.readyOrderLabel.TabIndex = 4;
            this.readyOrderLabel.Text = "label1";
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 701);
            this.Controls.Add(this.readyOrderLabel);
            this.Controls.Add(this.orderQueueListBox);
            this.Controls.Add(this.acceptOrderButton);
            this.Controls.Add(this.waitOrderQueueLabel);
            this.Controls.Add(this.customerOrderQueueLabel);
            this.Controls.Add(this.customerQueueListBox);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerQueueListBox;
        private System.Windows.Forms.Label customerOrderQueueLabel;
        private System.Windows.Forms.Button acceptOrderButton;
        private System.Windows.Forms.ListBox orderQueueListBox;
        private System.Windows.Forms.Label waitOrderQueueLabel;
        private System.Windows.Forms.Timer customerTimer;
        private System.Windows.Forms.Timer cookingTimer;
        private System.Windows.Forms.Label readyOrderLabel;
    }
}