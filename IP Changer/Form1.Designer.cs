namespace IP_Changer
{
    partial class mainWindow
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
            this.labelNic = new System.Windows.Forms.Label();
            this.listNic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputNetmask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputGateway = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDNS1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDNS2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxDHCPIP = new System.Windows.Forms.CheckBox();
            this.checkboxDHCPDNS = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNic
            // 
            this.labelNic.AutoSize = true;
            this.labelNic.Location = new System.Drawing.Point(12, 9);
            this.labelNic.Name = "labelNic";
            this.labelNic.Size = new System.Drawing.Size(44, 13);
            this.labelNic.TabIndex = 0;
            this.labelNic.Text = "NIC List";
            // 
            // listNic
            // 
            this.listNic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listNic.FormattingEnabled = true;
            this.listNic.Location = new System.Drawing.Point(62, 6);
            this.listNic.Name = "listNic";
            this.listNic.Size = new System.Drawing.Size(177, 21);
            this.listNic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(77, 42);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(162, 20);
            this.inputIP.TabIndex = 3;
            // 
            // inputNetmask
            // 
            this.inputNetmask.Location = new System.Drawing.Point(77, 68);
            this.inputNetmask.Name = "inputNetmask";
            this.inputNetmask.Size = new System.Drawing.Size(162, 20);
            this.inputNetmask.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Netmask";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputGateway
            // 
            this.inputGateway.Location = new System.Drawing.Point(77, 94);
            this.inputGateway.Name = "inputGateway";
            this.inputGateway.Size = new System.Drawing.Size(162, 20);
            this.inputGateway.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gateway";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputDNS1
            // 
            this.inputDNS1.Location = new System.Drawing.Point(77, 137);
            this.inputDNS1.Name = "inputDNS1";
            this.inputDNS1.Size = new System.Drawing.Size(162, 20);
            this.inputDNS1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputDNS2
            // 
            this.inputDNS2.Location = new System.Drawing.Point(77, 163);
            this.inputDNS2.Name = "inputDNS2";
            this.inputDNS2.Size = new System.Drawing.Size(162, 20);
            this.inputDNS2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DNS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkboxDHCPIP
            // 
            this.checkboxDHCPIP.AutoSize = true;
            this.checkboxDHCPIP.Location = new System.Drawing.Point(28, 204);
            this.checkboxDHCPIP.Name = "checkboxDHCPIP";
            this.checkboxDHCPIP.Size = new System.Drawing.Size(69, 17);
            this.checkboxDHCPIP.TabIndex = 14;
            this.checkboxDHCPIP.Text = "DHCP IP";
            this.checkboxDHCPIP.UseVisualStyleBackColor = true;
            // 
            // checkboxDHCPDNS
            // 
            this.checkboxDHCPDNS.AutoSize = true;
            this.checkboxDHCPDNS.Location = new System.Drawing.Point(134, 204);
            this.checkboxDHCPDNS.Name = "checkboxDHCPDNS";
            this.checkboxDHCPDNS.Size = new System.Drawing.Size(82, 17);
            this.checkboxDHCPDNS.TabIndex = 15;
            this.checkboxDHCPDNS.Text = "DHCP DNS";
            this.checkboxDHCPDNS.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(28, 227);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(141, 227);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.ClientSize = new System.Drawing.Size(251, 264);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkboxDHCPDNS);
            this.Controls.Add(this.checkboxDHCPIP);
            this.Controls.Add(this.inputDNS2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDNS1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputGateway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNetmask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listNic);
            this.Controls.Add(this.labelNic);
            this.Name = "mainWindow";
            this.Text = "IP Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNic;
        private System.Windows.Forms.ComboBox listNic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.TextBox inputNetmask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputGateway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputDNS1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputDNS2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxDHCPIP;
        private System.Windows.Forms.CheckBox checkboxDHCPDNS;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
    }
}

