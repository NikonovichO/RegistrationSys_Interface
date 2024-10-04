namespace RegistrationSys_Interface
{
    partial class DevicesListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesListForm));
            this.kGSH_Avtocam_RegistrDataSet = new RegistrationSys_Interface.KGSH_Avtocam_RegistrDataSet();
            this.kGSHAvtocamRegistrDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter = new RegistrationSys_Interface.KGSH_Avtocam_RegistrDataSetTableAdapters.DevicesTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.devicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modbusadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWorkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kGSH_Avtocam_RegistrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGSHAvtocamRegistrDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kGSH_Avtocam_RegistrDataSet
            // 
            this.kGSH_Avtocam_RegistrDataSet.DataSetName = "KGSH_Avtocam_RegistrDataSet";
            this.kGSH_Avtocam_RegistrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kGSHAvtocamRegistrDataSetBindingSource
            // 
            this.kGSHAvtocamRegistrDataSetBindingSource.DataSource = this.kGSH_Avtocam_RegistrDataSet;
            this.kGSHAvtocamRegistrDataSetBindingSource.Position = 0;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.kGSHAvtocamRegistrDataSetBindingSource;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94012F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.52994F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.52994F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modbusadressDataGridViewTextBoxColumn,
            this.namedeviceDataGridViewTextBoxColumn,
            this.isWorkDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.devicesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.Size = new System.Drawing.Size(728, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // devicesBindingSource1
            // 
            this.devicesBindingSource1.DataMember = "Devices";
            this.devicesBindingSource1.DataSource = this.kGSHAvtocamRegistrDataSetBindingSource;
            // 
            // modbusadressDataGridViewTextBoxColumn
            // 
            this.modbusadressDataGridViewTextBoxColumn.DataPropertyName = "modbus_adress";
            this.modbusadressDataGridViewTextBoxColumn.FillWeight = 300F;
            this.modbusadressDataGridViewTextBoxColumn.HeaderText = "Номер ";
            this.modbusadressDataGridViewTextBoxColumn.Name = "modbusadressDataGridViewTextBoxColumn";
            this.modbusadressDataGridViewTextBoxColumn.ToolTipText = "Номер вулканизатора (совпадает с номером устройства передачи данных)";
            // 
            // namedeviceDataGridViewTextBoxColumn
            // 
            this.namedeviceDataGridViewTextBoxColumn.DataPropertyName = "name_device";
            this.namedeviceDataGridViewTextBoxColumn.HeaderText = "Название";
            this.namedeviceDataGridViewTextBoxColumn.Name = "namedeviceDataGridViewTextBoxColumn";
            this.namedeviceDataGridViewTextBoxColumn.Width = 300;
            // 
            // isWorkDataGridViewCheckBoxColumn
            // 
            this.isWorkDataGridViewCheckBoxColumn.DataPropertyName = "IsWork";
            this.isWorkDataGridViewCheckBoxColumn.HeaderText = "Активен";
            this.isWorkDataGridViewCheckBoxColumn.Name = "isWorkDataGridViewCheckBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDell);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(4, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 31);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(42, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            // 
            // btnDell
            // 
            this.btnDell.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDell.Image = ((System.Drawing.Image)(resources.GetObject("btnDell.Image")));
            this.btnDell.Location = new System.Drawing.Point(80, 3);
            this.btnDell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(30, 30);
            this.btnDell.TabIndex = 17;
            this.btnDell.UseVisualStyleBackColor = false;
            this.btnDell.Visible = false;
            // 
            // DevicesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DevicesListForm";
            this.Text = "Список устройств";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kGSH_Avtocam_RegistrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGSHAvtocamRegistrDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kGSHAvtocamRegistrDataSetBindingSource;
        private KGSH_Avtocam_RegistrDataSet kGSH_Avtocam_RegistrDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private KGSH_Avtocam_RegistrDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource devicesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modbusadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isWorkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDell;
    }
}