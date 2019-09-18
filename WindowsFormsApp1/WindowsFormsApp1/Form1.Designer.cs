namespace WindowsFormsApp1
{
    partial class CoffeShop
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
            this.contactnumber = new System.Windows.Forms.Label();
            this.customernameTextBox = new System.Windows.Forms.TextBox();
            this.customername = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactnumber
            // 
            this.contactnumber.AutoSize = true;
            this.contactnumber.Location = new System.Drawing.Point(40, 62);
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.Size = new System.Drawing.Size(84, 13);
            this.contactnumber.TabIndex = 0;
            this.contactnumber.Text = "Contact Number";
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Location = new System.Drawing.Point(187, 12);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Size = new System.Drawing.Size(156, 20);
            this.customernameTextBox.TabIndex = 1;
            // 
            // customername
            // 
            this.customername.AutoSize = true;
            this.customername.Location = new System.Drawing.Point(40, 12);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(82, 13);
            this.customername.TabIndex = 2;
            this.customername.Text = "Customer Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(40, 122);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 3;
            this.address.Text = "Address";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(40, 184);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(33, 13);
            this.order.TabIndex = 4;
            this.order.Text = "Order";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(40, 248);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "Quantity";
            this.quantity.Click += new System.EventHandler(this.label5_Click);
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(187, 62);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(156, 20);
            this.contactTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(187, 122);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(156, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot"});
            this.orderComboBox.Location = new System.Drawing.Point(187, 176);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(156, 21);
            this.orderComboBox.TabIndex = 8;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(187, 241);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(156, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(321, 361);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 10;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(510, 32);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(237, 282);
            this.richTextBox.TabIndex = 11;
            this.richTextBox.Text = "";
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(433, 361);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(77, 23);
            this.showbutton.TabIndex = 12;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // CoffeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.order);
            this.Controls.Add(this.address);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.customernameTextBox);
            this.Controls.Add(this.contactnumber);
            this.Controls.Add(this.orderComboBox);
            this.Name = "CoffeShop";
            this.Text = "CoffeShop";
            this.Load += new System.EventHandler(this.CoffeShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactnumber;
        private System.Windows.Forms.TextBox customernameTextBox;
        private System.Windows.Forms.Label customername;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button showbutton;
    }
}

