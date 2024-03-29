﻿
namespace FinalProjectGUIDraft
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotalInfo = new System.Windows.Forms.Label();
            this.lblReceiptNumbers = new System.Windows.Forms.Label();
            this.lblcustomerName = new System.Windows.Forms.Label();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.gbxYourOrder = new System.Windows.Forms.GroupBox();
            this.lstItemsOrdered = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateInfo = new System.Windows.Forms.Label();
            this.lblReceiptNumInfo = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTaxInfo = new System.Windows.Forms.Label();
            this.lblTipInfo = new System.Windows.Forms.Label();
            this.lblGrandTotalInfo = new System.Windows.Forms.Label();
            this.lblMethodPymtInfo = new System.Windows.Forms.Label();
            this.lblCustNameInfo = new System.Windows.Forms.Label();
            this.btnSaveReceipt = new System.Windows.Forms.Button();
            this.lblResetPrompt = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxYourOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblMethodPayment.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodPayment.Location = new System.Drawing.Point(733, 387);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(194, 30);
            this.lblMethodPayment.TabIndex = 17;
            this.lblMethodPayment.Text = "Method of Payment:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(803, 350);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(120, 30);
            this.lblGrandTotal.TabIndex = 16;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Transparent;
            this.lblTip.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(882, 314);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(44, 30);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Tip:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(877, 276);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(49, 30);
            this.lblTax.TabIndex = 14;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotalInfo
            // 
            this.lblSubtotalInfo.AutoSize = true;
            this.lblSubtotalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalInfo.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalInfo.Location = new System.Drawing.Point(837, 238);
            this.lblSubtotalInfo.Name = "lblSubtotalInfo";
            this.lblSubtotalInfo.Size = new System.Drawing.Size(89, 30);
            this.lblSubtotalInfo.TabIndex = 13;
            this.lblSubtotalInfo.Text = "Subtotal:";
            // 
            // lblReceiptNumbers
            // 
            this.lblReceiptNumbers.AutoSize = true;
            this.lblReceiptNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptNumbers.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumbers.Location = new System.Drawing.Point(824, 180);
            this.lblReceiptNumbers.Name = "lblReceiptNumbers";
            this.lblReceiptNumbers.Size = new System.Drawing.Size(104, 30);
            this.lblReceiptNumbers.TabIndex = 18;
            this.lblReceiptNumbers.Text = "Receipt #:";
            // 
            // lblcustomerName
            // 
            this.lblcustomerName.AutoSize = true;
            this.lblcustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblcustomerName.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerName.Location = new System.Drawing.Point(264, 124);
            this.lblcustomerName.Name = "lblcustomerName";
            this.lblcustomerName.Size = new System.Drawing.Size(155, 30);
            this.lblcustomerName.TabIndex = 19;
            this.lblcustomerName.Text = "Customer Name:";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurantName.Font = new System.Drawing.Font("AR ESSENCE", 45.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(155, 35);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(538, 74);
            this.lblRestaurantName.TabIndex = 22;
            this.lblRestaurantName.Text = "Delicioso E-Ristorante";
            // 
            // gbxYourOrder
            // 
            this.gbxYourOrder.BackColor = System.Drawing.Color.Transparent;
            this.gbxYourOrder.Controls.Add(this.lstItemsOrdered);
            this.gbxYourOrder.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxYourOrder.Location = new System.Drawing.Point(268, 170);
            this.gbxYourOrder.Name = "gbxYourOrder";
            this.gbxYourOrder.Size = new System.Drawing.Size(439, 542);
            this.gbxYourOrder.TabIndex = 24;
            this.gbxYourOrder.TabStop = false;
            this.gbxYourOrder.Text = "Your Order";
            // 
            // lstItemsOrdered
            // 
            this.lstItemsOrdered.FormattingEnabled = true;
            this.lstItemsOrdered.ItemHeight = 30;
            this.lstItemsOrdered.Location = new System.Drawing.Point(21, 57);
            this.lstItemsOrdered.Name = "lstItemsOrdered";
            this.lstItemsOrdered.Size = new System.Drawing.Size(400, 424);
            this.lstItemsOrdered.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(801, 124);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 30);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date:";
            // 
            // lblDateInfo
            // 
            this.lblDateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInfo.Location = new System.Drawing.Point(865, 124);
            this.lblDateInfo.Name = "lblDateInfo";
            this.lblDateInfo.Size = new System.Drawing.Size(189, 23);
            this.lblDateInfo.TabIndex = 27;
            this.lblDateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceiptNumInfo
            // 
            this.lblReceiptNumInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiptNumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNumInfo.Location = new System.Drawing.Point(934, 182);
            this.lblReceiptNumInfo.Name = "lblReceiptNumInfo";
            this.lblReceiptNumInfo.Size = new System.Drawing.Size(120, 23);
            this.lblReceiptNumInfo.TabIndex = 28;
            this.lblReceiptNumInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(934, 238);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(120, 23);
            this.lblSubTotal.TabIndex = 29;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxInfo
            // 
            this.lblTaxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxInfo.Location = new System.Drawing.Point(934, 275);
            this.lblTaxInfo.Name = "lblTaxInfo";
            this.lblTaxInfo.Size = new System.Drawing.Size(120, 23);
            this.lblTaxInfo.TabIndex = 30;
            this.lblTaxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipInfo
            // 
            this.lblTipInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipInfo.Location = new System.Drawing.Point(934, 314);
            this.lblTipInfo.Name = "lblTipInfo";
            this.lblTipInfo.Size = new System.Drawing.Size(120, 23);
            this.lblTipInfo.TabIndex = 31;
            this.lblTipInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotalInfo
            // 
            this.lblGrandTotalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalInfo.Location = new System.Drawing.Point(934, 350);
            this.lblGrandTotalInfo.Name = "lblGrandTotalInfo";
            this.lblGrandTotalInfo.Size = new System.Drawing.Size(120, 23);
            this.lblGrandTotalInfo.TabIndex = 32;
            this.lblGrandTotalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMethodPymtInfo
            // 
            this.lblMethodPymtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMethodPymtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodPymtInfo.Location = new System.Drawing.Point(934, 389);
            this.lblMethodPymtInfo.Name = "lblMethodPymtInfo";
            this.lblMethodPymtInfo.Size = new System.Drawing.Size(120, 23);
            this.lblMethodPymtInfo.TabIndex = 33;
            this.lblMethodPymtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustNameInfo
            // 
            this.lblCustNameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNameInfo.Location = new System.Drawing.Point(436, 124);
            this.lblCustNameInfo.Name = "lblCustNameInfo";
            this.lblCustNameInfo.Size = new System.Drawing.Size(145, 23);
            this.lblCustNameInfo.TabIndex = 34;
            this.lblCustNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveReceipt
            // 
            this.btnSaveReceipt.BackColor = System.Drawing.Color.Green;
            this.btnSaveReceipt.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReceipt.Location = new System.Drawing.Point(861, 35);
            this.btnSaveReceipt.Name = "btnSaveReceipt";
            this.btnSaveReceipt.Size = new System.Drawing.Size(193, 37);
            this.btnSaveReceipt.TabIndex = 35;
            this.btnSaveReceipt.Text = "Exit";
            this.btnSaveReceipt.UseVisualStyleBackColor = false;
            this.btnSaveReceipt.Click += new System.EventHandler(this.btnSaveReceipt_Click);
            // 
            // lblResetPrompt
            // 
            this.lblResetPrompt.AutoSize = true;
            this.lblResetPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblResetPrompt.Font = new System.Drawing.Font("AR ESSENCE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPrompt.Location = new System.Drawing.Point(837, 75);
            this.lblResetPrompt.Name = "lblResetPrompt";
            this.lblResetPrompt.Size = new System.Drawing.Size(253, 30);
            this.lblResetPrompt.TabIndex = 36;
            this.lblResetPrompt.Text = "And reset electronic menu.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(755, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 749);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResetPrompt);
            this.Controls.Add(this.btnSaveReceipt);
            this.Controls.Add(this.lblCustNameInfo);
            this.Controls.Add(this.lblMethodPymtInfo);
            this.Controls.Add(this.lblGrandTotalInfo);
            this.Controls.Add(this.lblTipInfo);
            this.Controls.Add(this.lblTaxInfo);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblReceiptNumInfo);
            this.Controls.Add(this.lblDateInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gbxYourOrder);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblcustomerName);
            this.Controls.Add(this.lblReceiptNumbers);
            this.Controls.Add(this.lblMethodPayment);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotalInfo);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxYourOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotalInfo;
        private System.Windows.Forms.Label lblReceiptNumbers;
        private System.Windows.Forms.Label lblcustomerName;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.GroupBox gbxYourOrder;
        public System.Windows.Forms.ListBox lstItemsOrdered;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblDateInfo;  //made public
        public System.Windows.Forms.Label lblReceiptNumInfo; //made public
        public System.Windows.Forms.Label lblSubTotal; //made public
        public System.Windows.Forms.Label lblTaxInfo; //made public
        public System.Windows.Forms.Label lblTipInfo; //made public
        public System.Windows.Forms.Label lblGrandTotalInfo; //made public
        public System.Windows.Forms.Label lblMethodPymtInfo; //made public
        public System.Windows.Forms.Label lblCustNameInfo; // made Public // Lee
        private System.Windows.Forms.Button btnSaveReceipt;
        private System.Windows.Forms.Label lblResetPrompt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}