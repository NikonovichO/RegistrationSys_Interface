namespace RegistrationSys_Interface
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kGSH_Avtocam_RegistrDataSet = new RegistrationSys_Interface.KGSH_Avtocam_RegistrDataSet();
            this.informationTableAdapter = new RegistrationSys_Interface.KGSH_Avtocam_RegistrDataSetTableAdapters.InformationTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.numUpDHours = new System.Windows.Forms.NumericUpDown();
            this.dTPickerFixPeriod = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxPeriodList = new System.Windows.Forms.ComboBox();
            this.chBoxFixPeriod = new System.Windows.Forms.CheckBox();
            this.chBoxDates = new System.Windows.Forms.CheckBox();
            this.btnSetPeriod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpTempr2 = new System.Windows.Forms.NumericUpDown();
            this.numUpTempr1 = new System.Windows.Forms.NumericUpDown();
            this.lbRangY = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chBoxUpdate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGSH_Avtocam_RegistrDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTempr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTempr1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.kGSH_Avtocam_RegistrDataSet;
            // 
            // kGSH_Avtocam_RegistrDataSet
            // 
            this.kGSH_Avtocam_RegistrDataSet.DataSetName = "KGSH_Avtocam_RegistrDataSet";
            this.kGSH_Avtocam_RegistrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.67097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.32903F));
            this.tableLayoutPanel1.Controls.Add(this.formsPlot1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.58064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41936F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1542, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // formsPlot1
            // 
            this.formsPlot1.BackColor = System.Drawing.SystemColors.Info;
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(5, 3);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1372, 426);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.MouseEnter += new System.EventHandler(this.formsPlot1_MouseEnter);
            this.formsPlot1.MouseLeave += new System.EventHandler(this.formsPlot1_MouseLeave);
            this.formsPlot1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1385, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.Size = new System.Drawing.Size(154, 518);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevios);
            this.panel1.Controls.Add(this.numUpDHours);
            this.panel1.Controls.Add(this.dTPickerFixPeriod);
            this.panel1.Controls.Add(this.cmbBoxPeriodList);
            this.panel1.Controls.Add(this.chBoxFixPeriod);
            this.panel1.Controls.Add(this.chBoxDates);
            this.panel1.Controls.Add(this.btnSetPeriod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numUpTempr2);
            this.panel1.Controls.Add(this.numUpTempr1);
            this.panel1.Controls.Add(this.lbRangY);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 86);
            this.panel1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPrint.Image = global::RegistrationSys_Interface.Properties.Resources.icons8_печать_241;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(680, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 28);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Печать";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoEllipsis = true;
            this.btnNext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(746, 53);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 24);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "След.";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrevios
            // 
            this.btnPrevios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPrevios.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevios.Image")));
            this.btnPrevios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevios.Location = new System.Drawing.Point(680, 53);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.Size = new System.Drawing.Size(68, 24);
            this.btnPrevios.TabIndex = 21;
            this.btnPrevios.Text = "Пред.";
            this.btnPrevios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevios.UseVisualStyleBackColor = false;
            this.btnPrevios.Visible = false;
            this.btnPrevios.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUpDHours
            // 
            this.numUpDHours.Location = new System.Drawing.Point(282, 58);
            this.numUpDHours.Name = "numUpDHours";
            this.numUpDHours.Size = new System.Drawing.Size(56, 21);
            this.numUpDHours.TabIndex = 20;
            this.numUpDHours.Visible = false;
            // 
            // dTPickerFixPeriod
            // 
            this.dTPickerFixPeriod.CustomFormat = "dd.MM.yy ";
            this.dTPickerFixPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerFixPeriod.Location = new System.Drawing.Point(190, 57);
            this.dTPickerFixPeriod.Name = "dTPickerFixPeriod";
            this.dTPickerFixPeriod.Size = new System.Drawing.Size(83, 21);
            this.dTPickerFixPeriod.TabIndex = 19;
            this.dTPickerFixPeriod.Visible = false;
            // 
            // cmbBoxPeriodList
            // 
            this.cmbBoxPeriodList.FormattingEnabled = true;
            this.cmbBoxPeriodList.Items.AddRange(new object[] {
            "последние сутки",
            "на дату",
            "последних N часов"});
            this.cmbBoxPeriodList.Location = new System.Drawing.Point(190, 30);
            this.cmbBoxPeriodList.Name = "cmbBoxPeriodList";
            this.cmbBoxPeriodList.Size = new System.Drawing.Size(149, 23);
            this.cmbBoxPeriodList.TabIndex = 18;
            this.cmbBoxPeriodList.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPeriodList_SelectedIndexChanged);
            // 
            // chBoxFixPeriod
            // 
            this.chBoxFixPeriod.AutoSize = true;
            this.chBoxFixPeriod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chBoxFixPeriod.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chBoxFixPeriod.Location = new System.Drawing.Point(190, 3);
            this.chBoxFixPeriod.Name = "chBoxFixPeriod";
            this.chBoxFixPeriod.Size = new System.Drawing.Size(123, 19);
            this.chBoxFixPeriod.TabIndex = 17;
            this.chBoxFixPeriod.Text = "Выбрать период";
            this.chBoxFixPeriod.UseVisualStyleBackColor = false;
            this.chBoxFixPeriod.CheckedChanged += new System.EventHandler(this.chBoxFixPeriod_CheckedChanged);
            // 
            // chBoxDates
            // 
            this.chBoxDates.AutoSize = true;
            this.chBoxDates.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chBoxDates.Location = new System.Drawing.Point(1, 3);
            this.chBoxDates.Name = "chBoxDates";
            this.chBoxDates.Size = new System.Drawing.Size(148, 19);
            this.chBoxDates.TabIndex = 16;
            this.chBoxDates.Text = "Период меду датами";
            this.chBoxDates.UseVisualStyleBackColor = false;
            this.chBoxDates.CheckedChanged += new System.EventHandler(this.chBoxDates_CheckedChanged);
            // 
            // btnSetPeriod
            // 
            this.btnSetPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetPeriod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSetPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetPeriod.Image = ((System.Drawing.Image)(resources.GetObject("btnSetPeriod.Image")));
            this.btnSetPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetPeriod.Location = new System.Drawing.Point(489, 51);
            this.btnSetPeriod.Name = "btnSetPeriod";
            this.btnSetPeriod.Size = new System.Drawing.Size(114, 28);
            this.btnSetPeriod.TabIndex = 3;
            this.btnSetPeriod.Text = "Установить";
            this.btnSetPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetPeriod.UseVisualStyleBackColor = false;
            this.btnSetPeriod.Click += new System.EventHandler(this.btnSetPeriod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(382, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(382, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "с";
            // 
            // numUpTempr2
            // 
            this.numUpTempr2.Location = new System.Drawing.Point(409, 60);
            this.numUpTempr2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpTempr2.Name = "numUpTempr2";
            this.numUpTempr2.Size = new System.Drawing.Size(53, 21);
            this.numUpTempr2.TabIndex = 13;
            this.numUpTempr2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numUpTempr1
            // 
            this.numUpTempr1.Location = new System.Drawing.Point(409, 32);
            this.numUpTempr1.Name = "numUpTempr1";
            this.numUpTempr1.Size = new System.Drawing.Size(53, 21);
            this.numUpTempr1.TabIndex = 12;
            this.numUpTempr1.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // lbRangY
            // 
            this.lbRangY.AutoSize = true;
            this.lbRangY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbRangY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRangY.Location = new System.Drawing.Point(382, 3);
            this.lbRangY.Name = "lbRangY";
            this.lbRangY.Size = new System.Drawing.Size(54, 17);
            this.lbRangY.TabIndex = 11;
            this.lbRangY.Text = "Шкала ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.chBoxUpdate);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(820, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 89);
            this.panel2.TabIndex = 10;
            // 
            // chBoxUpdate
            // 
            this.chBoxUpdate.AutoSize = true;
            this.chBoxUpdate.Location = new System.Drawing.Point(15, 8);
            this.chBoxUpdate.Name = "chBoxUpdate";
            this.chBoxUpdate.Size = new System.Drawing.Size(212, 19);
            this.chBoxUpdate.TabIndex = 10;
            this.chBoxUpdate.Text = "Включить обновление  графика";
            this.chBoxUpdate.UseVisualStyleBackColor = true;
            this.chBoxUpdate.CheckedChanged += new System.EventHandler(this.chBoxUpdate_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "с";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yy HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(25, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1557, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kGSH_Avtocam_RegistrDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTempr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTempr1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KGSH_Avtocam_RegistrDataSet kGSH_Avtocam_RegistrDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private KGSH_Avtocam_RegistrDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSetPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chBoxUpdate;
        private System.Windows.Forms.Label lbRangY;
        private System.Windows.Forms.NumericUpDown numUpTempr2;
        private System.Windows.Forms.NumericUpDown numUpTempr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBoxFixPeriod;
        private System.Windows.Forms.CheckBox chBoxDates;
        private System.Windows.Forms.ComboBox cmbBoxPeriodList;
        private System.Windows.Forms.DateTimePicker dTPickerFixPeriod;
        private System.Windows.Forms.NumericUpDown numUpDHours;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevios;
        private System.Windows.Forms.Button btnPrint;
    }
}