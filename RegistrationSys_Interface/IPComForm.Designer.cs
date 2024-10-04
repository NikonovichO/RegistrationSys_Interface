namespace RegistrationSys_Interface
{
    partial class IPComForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPComForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.panelAddEdit = new System.Windows.Forms.Panel();
            this.chBWork = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lpIPadress = new System.Windows.Forms.Label();
            this.lbCom = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ipAdressControl1 = new RegistrationSys_Interface.IPAdressControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Window;
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnAdd1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 28);
            this.panelMenu.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(67, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(35, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd1.Image")));
            this.btnAdd1.Location = new System.Drawing.Point(3, 2);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(26, 23);
            this.btnAdd1.TabIndex = 0;
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddEdit.Controls.Add(this.chBWork);
            this.panelAddEdit.Controls.Add(this.button4);
            this.panelAddEdit.Controls.Add(this.button3);
            this.panelAddEdit.Controls.Add(this.lpIPadress);
            this.panelAddEdit.Controls.Add(this.lbCom);
            this.panelAddEdit.Controls.Add(this.numericUpDown1);
            this.panelAddEdit.Controls.Add(this.ipAdressControl1);
            this.panelAddEdit.Location = new System.Drawing.Point(35, 81);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(194, 89);
            this.panelAddEdit.TabIndex = 2;
            this.panelAddEdit.Visible = false;
            // 
            // chBWork
            // 
            this.chBWork.AutoSize = true;
            this.chBWork.Location = new System.Drawing.Point(11, 63);
            this.chBWork.Margin = new System.Windows.Forms.Padding(4);
            this.chBWork.Name = "chBWork";
            this.chBWork.Size = new System.Drawing.Size(76, 19);
            this.chBWork.TabIndex = 7;
            this.chBWork.Text = "Включен";
            this.chBWork.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(171, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(133, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lpIPadress
            // 
            this.lpIPadress.AutoSize = true;
            this.lpIPadress.Location = new System.Drawing.Point(8, 32);
            this.lpIPadress.Name = "lpIPadress";
            this.lpIPadress.Size = new System.Drawing.Size(55, 15);
            this.lpIPadress.TabIndex = 3;
            this.lpIPadress.Text = "IPAdress";
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(8, 5);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(33, 15);
            this.lbCom.TabIndex = 2;
            this.lbCom.Text = "Com";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(76, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown1.TabIndex = 1;
            // 
            // ipAdressControl1
            // 
            this.ipAdressControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipAdressControl1.Location = new System.Drawing.Point(71, 26);
            this.ipAdressControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ipAdressControl1.Name = "ipAdressControl1";
            this.ipAdressControl1.Size = new System.Drawing.Size(122, 31);
            this.ipAdressControl1.StrigIP = null;
            this.ipAdressControl1.TabIndex = 0;
            // 
            // IPComForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 236);
            this.Controls.Add(this.panelAddEdit);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IPComForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPComForm";
            this.Activated += new System.EventHandler(this.IPComForm_Activated);
            this.Load += new System.EventHandler(this.IPComForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Panel panelAddEdit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lpIPadress;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private IPAdressControl ipAdressControl1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chBWork;
    }
}