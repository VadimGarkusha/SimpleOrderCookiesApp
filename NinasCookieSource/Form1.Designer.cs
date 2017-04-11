namespace NinasCookieSource
{
    partial class Form1
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCookieType = new System.Windows.Forms.Label();
            this.lblAmountOfCookies = new System.Windows.Forms.Label();
            this.lsbTypeOfCookies = new System.Windows.Forms.ListBox();
            this.lsbAmountOfCookies = new System.Windows.Forms.ListBox();
            this.mnthcalSelectedDate = new System.Windows.Forms.MonthCalendar();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(2, 12);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Final Price:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(123, 15);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(298, 19);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "Choose type and amount of cookies";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Cookie Source";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCookieType
            // 
            this.lblCookieType.AutoSize = true;
            this.lblCookieType.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookieType.Location = new System.Drawing.Point(33, 55);
            this.lblCookieType.Name = "lblCookieType";
            this.lblCookieType.Size = new System.Drawing.Size(165, 22);
            this.lblCookieType.TabIndex = 1;
            this.lblCookieType.Text = "Type of Cookies";
            // 
            // lblAmountOfCookies
            // 
            this.lblAmountOfCookies.AutoSize = true;
            this.lblAmountOfCookies.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfCookies.Location = new System.Drawing.Point(277, 55);
            this.lblAmountOfCookies.Name = "lblAmountOfCookies";
            this.lblAmountOfCookies.Size = new System.Drawing.Size(191, 22);
            this.lblAmountOfCookies.TabIndex = 2;
            this.lblAmountOfCookies.Text = "Amount of Cookies";
            // 
            // lsbTypeOfCookies
            // 
            this.lsbTypeOfCookies.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTypeOfCookies.FormattingEnabled = true;
            this.lsbTypeOfCookies.ItemHeight = 19;
            this.lsbTypeOfCookies.Location = new System.Drawing.Point(37, 81);
            this.lsbTypeOfCookies.Name = "lsbTypeOfCookies";
            this.lsbTypeOfCookies.Size = new System.Drawing.Size(221, 80);
            this.lsbTypeOfCookies.TabIndex = 7;
            this.lsbTypeOfCookies.SelectedIndexChanged += new System.EventHandler(this.lsbTypeOfCookies_SelectedIndexChanged);
            // 
            // lsbAmountOfCookies
            // 
            this.lsbAmountOfCookies.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbAmountOfCookies.FormattingEnabled = true;
            this.lsbAmountOfCookies.ItemHeight = 19;
            this.lsbAmountOfCookies.Location = new System.Drawing.Point(281, 81);
            this.lsbAmountOfCookies.Name = "lsbAmountOfCookies";
            this.lsbAmountOfCookies.Size = new System.Drawing.Size(221, 80);
            this.lsbAmountOfCookies.TabIndex = 8;
            this.lsbAmountOfCookies.SelectedIndexChanged += new System.EventHandler(this.lsbAmountOfCookies_SelectedIndexChanged);
            // 
            // mnthcalSelectedDate
            // 
            this.mnthcalSelectedDate.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnthcalSelectedDate.Location = new System.Drawing.Point(141, 208);
            this.mnthcalSelectedDate.Name = "mnthcalSelectedDate";
            this.mnthcalSelectedDate.TabIndex = 9;
            this.mnthcalSelectedDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mnthcalSelectedDate_DateChanged);
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDate.Location = new System.Drawing.Point(137, 177);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(133, 22);
            this.lblChooseDate.TabIndex = 10;
            this.lblChooseDate.Text = "Choose date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Arrival date:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(133, 50);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(111, 19);
            this.lblArrivalDate.TabIndex = 12;
            this.lblArrivalDate.Text = "Choose date";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(37, 471);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(464, 52);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Make order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblArrivalDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPriceValue);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(37, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 83);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(538, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.mnthcalSelectedDate);
            this.Controls.Add(this.lsbAmountOfCookies);
            this.Controls.Add(this.lsbTypeOfCookies);
            this.Controls.Add(this.lblAmountOfCookies);
            this.Controls.Add(this.lblCookieType);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Ninas Cookie Source";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCookieType;
        private System.Windows.Forms.Label lblAmountOfCookies;
        private System.Windows.Forms.ListBox lsbTypeOfCookies;
        private System.Windows.Forms.ListBox lsbAmountOfCookies;
        private System.Windows.Forms.MonthCalendar mnthcalSelectedDate;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

