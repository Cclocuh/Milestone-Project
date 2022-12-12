namespace Inventory_Managment
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outPutBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuantitygroupBox = new System.Windows.Forms.GroupBox();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.cbDellInspiron = new System.Windows.Forms.CheckBox();
            this.cbChromebook = new System.Windows.Forms.CheckBox();
            this.cbHpEnvy = new System.Windows.Forms.CheckBox();
            this.cbMac = new System.Windows.Forms.CheckBox();
            this.BrandGroupBox = new System.Windows.Forms.GroupBox();
            this.brandListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateOrderedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.QuantitygroupBox.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.BrandGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(95, 981);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 47);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search ";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.outPutBox);
            this.panel1.Location = new System.Drawing.Point(63, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 265);
            this.panel1.TabIndex = 9;
            // 
            // outPutBox
            // 
            this.outPutBox.FormattingEnabled = true;
            this.outPutBox.ItemHeight = 25;
            this.outPutBox.Location = new System.Drawing.Point(21, 38);
            this.outPutBox.Name = "outPutBox";
            this.outPutBox.Size = new System.Drawing.Size(1224, 179);
            this.outPutBox.TabIndex = 0;
            this.outPutBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.QuantitygroupBox);
            this.panel2.Controls.Add(this.ItemsGroupBox);
            this.panel2.Controls.Add(this.BrandGroupBox);
            this.panel2.Location = new System.Drawing.Point(212, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 312);
            this.panel2.TabIndex = 10;
            // 
            // QuantitygroupBox
            // 
            this.QuantitygroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.QuantitygroupBox.Controls.Add(this.rbFour);
            this.QuantitygroupBox.Controls.Add(this.rbThree);
            this.QuantitygroupBox.Controls.Add(this.rbTwo);
            this.QuantitygroupBox.Controls.Add(this.rbOne);
            this.QuantitygroupBox.Location = new System.Drawing.Point(670, 42);
            this.QuantitygroupBox.Name = "QuantitygroupBox";
            this.QuantitygroupBox.Size = new System.Drawing.Size(200, 244);
            this.QuantitygroupBox.TabIndex = 2;
            this.QuantitygroupBox.TabStop = false;
            this.QuantitygroupBox.Text = "Quantity";
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(18, 192);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(49, 29);
            this.rbFour.TabIndex = 3;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(18, 139);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(49, 29);
            this.rbThree.TabIndex = 2;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(18, 90);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(49, 29);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(18, 42);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(49, 29);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.ItemsGroupBox.Controls.Add(this.cbDellInspiron);
            this.ItemsGroupBox.Controls.Add(this.cbChromebook);
            this.ItemsGroupBox.Controls.Add(this.cbHpEnvy);
            this.ItemsGroupBox.Controls.Add(this.cbMac);
            this.ItemsGroupBox.Location = new System.Drawing.Point(367, 42);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(200, 244);
            this.ItemsGroupBox.TabIndex = 1;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // cbDellInspiron
            // 
            this.cbDellInspiron.AutoSize = true;
            this.cbDellInspiron.Location = new System.Drawing.Point(26, 192);
            this.cbDellInspiron.Name = "cbDellInspiron";
            this.cbDellInspiron.Size = new System.Drawing.Size(158, 29);
            this.cbDellInspiron.TabIndex = 3;
            this.cbDellInspiron.Text = "Dell-Inspiron";
            this.cbDellInspiron.UseVisualStyleBackColor = true;
            // 
            // cbChromebook
            // 
            this.cbChromebook.AutoSize = true;
            this.cbChromebook.Location = new System.Drawing.Point(26, 139);
            this.cbChromebook.Name = "cbChromebook";
            this.cbChromebook.Size = new System.Drawing.Size(160, 29);
            this.cbChromebook.TabIndex = 2;
            this.cbChromebook.Text = "Chromebook";
            this.cbChromebook.UseVisualStyleBackColor = true;
            // 
            // cbHpEnvy
            // 
            this.cbHpEnvy.AutoSize = true;
            this.cbHpEnvy.Location = new System.Drawing.Point(26, 90);
            this.cbHpEnvy.Name = "cbHpEnvy";
            this.cbHpEnvy.Size = new System.Drawing.Size(122, 29);
            this.cbHpEnvy.TabIndex = 1;
            this.cbHpEnvy.Text = "HP-Envy";
            this.cbHpEnvy.UseVisualStyleBackColor = true;
            // 
            // cbMac
            // 
            this.cbMac.AutoSize = true;
            this.cbMac.Location = new System.Drawing.Point(26, 42);
            this.cbMac.Name = "cbMac";
            this.cbMac.Size = new System.Drawing.Size(79, 29);
            this.cbMac.TabIndex = 0;
            this.cbMac.Text = "Mac";
            this.cbMac.UseVisualStyleBackColor = true;
            // 
            // BrandGroupBox
            // 
            this.BrandGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.BrandGroupBox.Controls.Add(this.brandListBox);
            this.BrandGroupBox.Location = new System.Drawing.Point(73, 42);
            this.BrandGroupBox.Name = "BrandGroupBox";
            this.BrandGroupBox.Size = new System.Drawing.Size(200, 244);
            this.BrandGroupBox.TabIndex = 0;
            this.BrandGroupBox.TabStop = false;
            this.BrandGroupBox.Text = "Brand";
            // 
            // brandListBox
            // 
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.ItemHeight = 25;
            this.brandListBox.Items.AddRange(new object[] {
            "Apple",
            "",
            "Hewlett-Packard",
            "",
            "Google",
            "",
            "Dell"});
            this.brandListBox.Location = new System.Drawing.Point(6, 42);
            this.brandListBox.Name = "brandListBox";
            this.brandListBox.Size = new System.Drawing.Size(174, 179);
            this.brandListBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(12, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 138);
            this.panel3.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(419, 224);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 31);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(419, 76);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(191, 31);
            this.txtProductID.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(800, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(175, 31);
            this.txtLastName.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(800, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1312, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 33);
            this.comboBox2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1238, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 31);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // DateOrderedLabel
            // 
            this.DateOrderedLabel.AutoSize = true;
            this.DateOrderedLabel.Location = new System.Drawing.Point(1037, 79);
            this.DateOrderedLabel.Name = "DateOrderedLabel";
            this.DateOrderedLabel.Size = new System.Drawing.Size(153, 25);
            this.DateOrderedLabel.TabIndex = 18;
            this.DateOrderedLabel.Text = "Date Ordered :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1037, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payment Method :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(661, 79);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(118, 25);
            this.LastNameLabel.TabIndex = 20;
            this.LastNameLabel.Text = "Lastname :";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(260, 222);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(119, 25);
            this.FirstNameLabel.TabIndex = 23;
            this.FirstNameLabel.Text = "Firstname :";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(260, 74);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(124, 25);
            this.productIDLabel.TabIndex = 22;
            this.productIDLabel.Text = "Product ID :";
            this.productIDLabel.Click += new System.EventHandler(this.productIDlabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(683, 982);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(179, 46);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(972, 982);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(209, 47);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // addItemsButton
            // 
            this.addItemsButton.Location = new System.Drawing.Point(376, 982);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(212, 46);
            this.addItemsButton.TabIndex = 26;
            this.addItemsButton.Text = "Add items";
            this.addItemsButton.UseVisualStyleBackColor = true;
            this.addItemsButton.Click += new System.EventHandler(this.addItemsbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1056);
            this.Controls.Add(this.addItemsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateOrderedLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Inventory Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.QuantitygroupBox.ResumeLayout(false);
            this.QuantitygroupBox.PerformLayout();
            this.ItemsGroupBox.ResumeLayout(false);
            this.ItemsGroupBox.PerformLayout();
            this.BrandGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox outPutBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox QuantitygroupBox;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.GroupBox BrandGroupBox;
        private System.Windows.Forms.ListBox brandListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.CheckBox cbDellInspiron;
        private System.Windows.Forms.CheckBox cbChromebook;
        private System.Windows.Forms.CheckBox cbHpEnvy;
        private System.Windows.Forms.CheckBox cbMac;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateOrderedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addItemsButton;
    }
}

