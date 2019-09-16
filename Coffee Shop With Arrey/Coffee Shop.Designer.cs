namespace Coffee_Shop_With_Arrey
{
    partial class Home_UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.contactlvl = new System.Windows.Forms.Label();
            this.Headlvl = new System.Windows.Forms.Label();
            this.contacttextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.ordercombox = new System.Windows.Forms.ComboBox();
            this.orderlvl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.namelvl = new System.Windows.Forms.Label();
            this.addlvl = new System.Windows.Forms.Label();
            this.qusntitylvl = new System.Windows.Forms.Label();
            this.showrichbox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nametextbox);
            this.panel1.Controls.Add(this.contactlvl);
            this.panel1.Controls.Add(this.Headlvl);
            this.panel1.Controls.Add(this.contacttextbox);
            this.panel1.Controls.Add(this.addresstextbox);
            this.panel1.Controls.Add(this.quantitytextbox);
            this.panel1.Controls.Add(this.ordercombox);
            this.panel1.Controls.Add(this.orderlvl);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.namelvl);
            this.panel1.Controls.Add(this.addlvl);
            this.panel1.Controls.Add(this.qusntitylvl);
            this.panel1.Location = new System.Drawing.Point(37, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 403);
            this.panel1.TabIndex = 20;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(235, 61);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(157, 22);
            this.nametextbox.TabIndex = 5;
            // 
            // contactlvl
            // 
            this.contactlvl.AutoSize = true;
            this.contactlvl.Location = new System.Drawing.Point(42, 104);
            this.contactlvl.Name = "contactlvl";
            this.contactlvl.Size = new System.Drawing.Size(82, 17);
            this.contactlvl.TabIndex = 2;
            this.contactlvl.Text = "Contact No ";
            // 
            // Headlvl
            // 
            this.Headlvl.AutoSize = true;
            this.Headlvl.Location = new System.Drawing.Point(17, 0);
            this.Headlvl.Name = "Headlvl";
            this.Headlvl.Size = new System.Drawing.Size(142, 17);
            this.Headlvl.TabIndex = 0;
            this.Headlvl.Text = "Customer information";
            // 
            // contacttextbox
            // 
            this.contacttextbox.Location = new System.Drawing.Point(235, 104);
            this.contacttextbox.Name = "contacttextbox";
            this.contacttextbox.Size = new System.Drawing.Size(157, 22);
            this.contacttextbox.TabIndex = 6;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(235, 152);
            this.addresstextbox.Multiline = true;
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(157, 22);
            this.addresstextbox.TabIndex = 7;
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.Location = new System.Drawing.Point(235, 296);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(157, 22);
            this.quantitytextbox.TabIndex = 8;
            // 
            // ordercombox
            // 
            this.ordercombox.FormattingEnabled = true;
            this.ordercombox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Reguler-80"});
            this.ordercombox.Location = new System.Drawing.Point(235, 255);
            this.ordercombox.Name = "ordercombox";
            this.ordercombox.Size = new System.Drawing.Size(157, 24);
            this.ordercombox.TabIndex = 10;
            this.ordercombox.Text = "Select Item";
            // 
            // orderlvl
            // 
            this.orderlvl.AutoSize = true;
            this.orderlvl.Location = new System.Drawing.Point(42, 255);
            this.orderlvl.Name = "orderlvl";
            this.orderlvl.Size = new System.Drawing.Size(49, 17);
            this.orderlvl.TabIndex = 11;
            this.orderlvl.Text = "Order ";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebtn.Location = new System.Drawing.Point(277, 354);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // namelvl
            // 
            this.namelvl.AutoSize = true;
            this.namelvl.Location = new System.Drawing.Point(42, 61);
            this.namelvl.Name = "namelvl";
            this.namelvl.Size = new System.Drawing.Size(113, 17);
            this.namelvl.TabIndex = 1;
            this.namelvl.Text = "Customar Name ";
            // 
            // addlvl
            // 
            this.addlvl.AutoSize = true;
            this.addlvl.Location = new System.Drawing.Point(42, 152);
            this.addlvl.Name = "addlvl";
            this.addlvl.Size = new System.Drawing.Size(64, 17);
            this.addlvl.TabIndex = 3;
            this.addlvl.Text = "Address ";
            // 
            // qusntitylvl
            // 
            this.qusntitylvl.AutoSize = true;
            this.qusntitylvl.Location = new System.Drawing.Point(42, 296);
            this.qusntitylvl.Name = "qusntitylvl";
            this.qusntitylvl.Size = new System.Drawing.Size(65, 17);
            this.qusntitylvl.TabIndex = 4;
            this.qusntitylvl.Text = "Quantity ";
            // 
            // showrichbox
            // 
            this.showrichbox.Location = new System.Drawing.Point(515, 48);
            this.showrichbox.Name = "showrichbox";
            this.showrichbox.Size = new System.Drawing.Size(233, 403);
            this.showrichbox.TabIndex = 21;
            this.showrichbox.Text = "";
            // 
            // Home_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showrichbox);
            this.Name = "Home_UI";
            this.Text = "Sales UI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label contactlvl;
        private System.Windows.Forms.Label Headlvl;
        private System.Windows.Forms.TextBox contacttextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.ComboBox ordercombox;
        private System.Windows.Forms.Label orderlvl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label namelvl;
        private System.Windows.Forms.Label addlvl;
        private System.Windows.Forms.Label qusntitylvl;
        private System.Windows.Forms.RichTextBox showrichbox;
    }
}

