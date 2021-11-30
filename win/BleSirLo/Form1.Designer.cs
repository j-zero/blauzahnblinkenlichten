namespace BleSirLo
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
            this.ScanBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.WriteBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DevicesComboBox = new System.Windows.Forms.ComboBox();
            this.Response = new System.Windows.Forms.RichTextBox();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.ServiceTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CharacteristicsTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScanBtn
            // 
            this.ScanBtn.Location = new System.Drawing.Point(259, 12);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(77, 21);
            this.ScanBtn.TabIndex = 0;
            this.ScanBtn.Text = "Scan";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(342, 12);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(63, 21);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // WriteBtn
            // 
            this.WriteBtn.Location = new System.Drawing.Point(209, 97);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(47, 23);
            this.WriteBtn.TabIndex = 2;
            this.WriteBtn.Text = "Write";
            this.WriteBtn.UseVisualStyleBackColor = true;
            this.WriteBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(262, 97);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(50, 23);
            this.ReadBtn.TabIndex = 3;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // DevicesComboBox
            // 
            this.DevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DevicesComboBox.FormattingEnabled = true;
            this.DevicesComboBox.Location = new System.Drawing.Point(118, 12);
            this.DevicesComboBox.Name = "DevicesComboBox";
            this.DevicesComboBox.Size = new System.Drawing.Size(135, 21);
            this.DevicesComboBox.TabIndex = 4;
            this.DevicesComboBox.SelectedIndexChanged += new System.EventHandler(this.DevicesComboBox_SelectedIndexChanged);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(12, 153);
            this.Response.Name = "Response";
            this.Response.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Response.Size = new System.Drawing.Size(753, 333);
            this.Response.TabIndex = 5;
            this.Response.Text = "";
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(16, 99);
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(187, 20);
            this.InputTxtBox.TabIndex = 6;
            // 
            // ServiceTxtBox
            // 
            this.ServiceTxtBox.Location = new System.Drawing.Point(117, 38);
            this.ServiceTxtBox.Name = "ServiceTxtBox";
            this.ServiceTxtBox.Size = new System.Drawing.Size(219, 20);
            this.ServiceTxtBox.TabIndex = 7;
            this.ServiceTxtBox.Text = "4fafc201-1fb5-459e-8fcc-c5c9c331914b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Characteristics";
            // 
            // CharacteristicsTxtBox
            // 
            this.CharacteristicsTxtBox.Location = new System.Drawing.Point(117, 63);
            this.CharacteristicsTxtBox.Name = "CharacteristicsTxtBox";
            this.CharacteristicsTxtBox.Size = new System.Drawing.Size(219, 20);
            this.CharacteristicsTxtBox.TabIndex = 10;
            this.CharacteristicsTxtBox.Text = "beb5483e-36e1-4688-b7f5-ea07361b26a8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 498);
            this.Controls.Add(this.CharacteristicsTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTxtBox);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.DevicesComboBox);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.WriteBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.ScanBtn);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button WriteBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.ComboBox DevicesComboBox;
        private System.Windows.Forms.RichTextBox Response;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.TextBox ServiceTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CharacteristicsTxtBox;
    }
}

