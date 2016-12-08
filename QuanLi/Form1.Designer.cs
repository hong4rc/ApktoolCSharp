namespace QuanLi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnWorking = new System.Windows.Forms.Panel();
			this.lbStt = new System.Windows.Forms.Label();
			this.btnSA = new System.Windows.Forms.Button();
			this.btnRC = new System.Windows.Forms.Button();
			this.btnDC = new System.Windows.Forms.Button();
			this.btnIP = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lbStt);
			this.panel1.Controls.Add(this.btnSA);
			this.panel1.Controls.Add(this.btnRC);
			this.panel1.Controls.Add(this.btnDC);
			this.panel1.Controls.Add(this.btnIP);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 710);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pnWorking);
			this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel2.Location = new System.Drawing.Point(147, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(443, 642);
			this.panel2.TabIndex = 7;
			// 
			// pnWorking
			// 
			this.pnWorking.Cursor = System.Windows.Forms.Cursors.Default;
			this.pnWorking.Location = new System.Drawing.Point(3, 3);
			this.pnWorking.Name = "pnWorking";
			this.pnWorking.Size = new System.Drawing.Size(377, 576);
			this.pnWorking.TabIndex = 5;
			// 
			// lbStt
			// 
			this.lbStt.AutoSize = true;
			this.lbStt.Location = new System.Drawing.Point(19, 4);
			this.lbStt.Name = "lbStt";
			this.lbStt.Size = new System.Drawing.Size(19, 17);
			this.lbStt.TabIndex = 6;
			this.lbStt.Text = "m";
			// 
			// btnSA
			// 
			this.btnSA.Location = new System.Drawing.Point(22, 236);
			this.btnSA.Name = "btnSA";
			this.btnSA.Size = new System.Drawing.Size(109, 51);
			this.btnSA.TabIndex = 4;
			this.btnSA.Text = "Sign";
			this.btnSA.UseVisualStyleBackColor = true;
			this.btnSA.Click += new System.EventHandler(this.btnSA_Click);
			// 
			// btnRC
			// 
			this.btnRC.Location = new System.Drawing.Point(22, 179);
			this.btnRC.Name = "btnRC";
			this.btnRC.Size = new System.Drawing.Size(109, 51);
			this.btnRC.TabIndex = 3;
			this.btnRC.Text = "Recompile";
			this.btnRC.UseVisualStyleBackColor = true;
			this.btnRC.Click += new System.EventHandler(this.btnRC_Click);
			// 
			// btnDC
			// 
			this.btnDC.Location = new System.Drawing.Point(22, 122);
			this.btnDC.Name = "btnDC";
			this.btnDC.Size = new System.Drawing.Size(109, 51);
			this.btnDC.TabIndex = 2;
			this.btnDC.Text = "Decompile";
			this.btnDC.UseVisualStyleBackColor = true;
			this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
			// 
			// btnIP
			// 
			this.btnIP.Location = new System.Drawing.Point(22, 65);
			this.btnIP.Name = "btnIP";
			this.btnIP.Size = new System.Drawing.Size(109, 51);
			this.btnIP.TabIndex = 1;
			this.btnIP.Text = "Import";
			this.btnIP.UseVisualStyleBackColor = true;
			this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(631, 735);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Apktool";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnWorking;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.Panel panel2;
    }
}

