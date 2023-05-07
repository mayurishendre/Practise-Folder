
namespace TwoListbox
{
    partial class frmlistbox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbox1 = new System.Windows.Forms.ListBox();
            this.lstbox2 = new System.Windows.Forms.ListBox();
            this.btnForwar = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbox1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbox2);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(625, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 300);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second List";
            // 
            // lstbox1
            // 
            this.lstbox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox1.FormattingEnabled = true;
            this.lstbox1.ItemHeight = 20;
            this.lstbox1.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Green",
            "Indigo",
            "Orange",
            "Brown",
            "Violet",
            "black",
            "White"});
            this.lstbox1.Location = new System.Drawing.Point(19, 40);
            this.lstbox1.Name = "lstbox1";
            this.lstbox1.Size = new System.Drawing.Size(310, 244);
            this.lstbox1.TabIndex = 0;
            // 
            // lstbox2
            // 
            this.lstbox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox2.FormattingEnabled = true;
            this.lstbox2.ItemHeight = 20;
            this.lstbox2.Location = new System.Drawing.Point(16, 40);
            this.lstbox2.Name = "lstbox2";
            this.lstbox2.Size = new System.Drawing.Size(337, 224);
            this.lstbox2.TabIndex = 0;
            // 
            // btnForwar
            // 
            this.btnForwar.Location = new System.Drawing.Point(441, 63);
            this.btnForwar.Name = "btnForwar";
            this.btnForwar.Size = new System.Drawing.Size(100, 38);
            this.btnForwar.TabIndex = 3;
            this.btnForwar.Text = ">";
            this.btnForwar.UseVisualStyleBackColor = true;
            this.btnForwar.Click += new System.EventHandler(this.btnForwar_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(441, 119);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 50);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(441, 190);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(441, 262);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(100, 46);
            this.btnBackward.TabIndex = 6;
            this.btnBackward.Text = "<<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmlistbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnForwar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmlistbox";
            this.Text = "List Box Swapping";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstbox2;
        private System.Windows.Forms.Button btnForwar;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnClose;
    }
}

