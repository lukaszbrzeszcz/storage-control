﻿namespace SterowanieMagazynowaniem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.remove_dist_to = new System.Windows.Forms.Button();
            this.remove_dist_from = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add_to_distance = new System.Windows.Forms.Button();
            this.btn_add_from_distance = new System.Windows.Forms.Button();
            this.value_to = new System.Windows.Forms.TextBox();
            this.value_from = new System.Windows.Forms.TextBox();
            this.comboBox_to = new System.Windows.Forms.ComboBox();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list_to_distances = new System.Windows.Forms.ListBox();
            this.list_from_distances = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_sector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_new_sector_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove_sector = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.medicinesListBox = new System.Windows.Forms.ListBox();
            this.removeOrderBtn = new System.Windows.Forms.Button();
            this.generateOrderBtn = new System.Windows.Forms.Button();
            this.ordersListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.line_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nWorkers = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.t0 = new System.Windows.Forms.NumericUpDown();
            this.tk = new System.Windows.Forms.NumericUpDown();
            this.lambd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.medicineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(4, 34);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 42);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 574);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.remove_dist_to);
            this.tabPage1.Controls.Add(this.remove_dist_from);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btn_add_to_distance);
            this.tabPage1.Controls.Add(this.btn_add_from_distance);
            this.tabPage1.Controls.Add(this.value_to);
            this.tabPage1.Controls.Add(this.value_from);
            this.tabPage1.Controls.Add(this.comboBox_to);
            this.tabPage1.Controls.Add(this.comboBox_from);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.list_to_distances);
            this.tabPage1.Controls.Add(this.list_from_distances);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_add_sector);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_new_sector_name);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_remove_sector);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.ImageIndex = 3;
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1057, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sectors and Distances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // remove_dist_to
            // 
            this.remove_dist_to.Location = new System.Drawing.Point(534, 163);
            this.remove_dist_to.Margin = new System.Windows.Forms.Padding(2);
            this.remove_dist_to.Name = "remove_dist_to";
            this.remove_dist_to.Size = new System.Drawing.Size(163, 19);
            this.remove_dist_to.TabIndex = 25;
            this.remove_dist_to.Text = "Remove Distance";
            this.remove_dist_to.UseVisualStyleBackColor = true;
            this.remove_dist_to.Click += new System.EventHandler(this.remove_dist_to_Click);
            // 
            // remove_dist_from
            // 
            this.remove_dist_from.Location = new System.Drawing.Point(315, 163);
            this.remove_dist_from.Margin = new System.Windows.Forms.Padding(2);
            this.remove_dist_from.Name = "remove_dist_from";
            this.remove_dist_from.Size = new System.Drawing.Size(163, 19);
            this.remove_dist_from.TabIndex = 24;
            this.remove_dist_from.Text = "Remove Distance";
            this.remove_dist_from.UseVisualStyleBackColor = true;
            this.remove_dist_from.Click += new System.EventHandler(this.remove_dist_from_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Distance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 287);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Distance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(311, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "New Distances";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(530, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(311, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "From";
            // 
            // btn_add_to_distance
            // 
            this.btn_add_to_distance.Location = new System.Drawing.Point(534, 323);
            this.btn_add_to_distance.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_to_distance.Name = "btn_add_to_distance";
            this.btn_add_to_distance.Size = new System.Drawing.Size(113, 19);
            this.btn_add_to_distance.TabIndex = 18;
            this.btn_add_to_distance.Text = "Add Distance";
            this.btn_add_to_distance.UseVisualStyleBackColor = true;
            this.btn_add_to_distance.Click += new System.EventHandler(this.btn_add_to_distance_Click);
            // 
            // btn_add_from_distance
            // 
            this.btn_add_from_distance.Location = new System.Drawing.Point(315, 323);
            this.btn_add_from_distance.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_from_distance.Name = "btn_add_from_distance";
            this.btn_add_from_distance.Size = new System.Drawing.Size(113, 19);
            this.btn_add_from_distance.TabIndex = 17;
            this.btn_add_from_distance.Text = "Add Distance";
            this.btn_add_from_distance.UseVisualStyleBackColor = true;
            this.btn_add_from_distance.Click += new System.EventHandler(this.btn_add_from_distance_Click);
            // 
            // value_to
            // 
            this.value_to.Location = new System.Drawing.Point(605, 284);
            this.value_to.Margin = new System.Windows.Forms.Padding(2);
            this.value_to.Name = "value_to";
            this.value_to.Size = new System.Drawing.Size(43, 20);
            this.value_to.TabIndex = 16;
            this.value_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // value_from
            // 
            this.value_from.Location = new System.Drawing.Point(386, 284);
            this.value_from.Margin = new System.Windows.Forms.Padding(2);
            this.value_from.Name = "value_from";
            this.value_from.Size = new System.Drawing.Size(43, 20);
            this.value_from.TabIndex = 15;
            this.value_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_to
            // 
            this.comboBox_to.FormattingEnabled = true;
            this.comboBox_to.Location = new System.Drawing.Point(534, 249);
            this.comboBox_to.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_to.Name = "comboBox_to";
            this.comboBox_to.Size = new System.Drawing.Size(114, 21);
            this.comboBox_to.TabIndex = 14;
            // 
            // comboBox_from
            // 
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Location = new System.Drawing.Point(315, 249);
            this.comboBox_from.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(114, 21);
            this.comboBox_from.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(530, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(311, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "From";
            // 
            // list_to_distances
            // 
            this.list_to_distances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_to_distances.FormattingEnabled = true;
            this.list_to_distances.ItemHeight = 16;
            this.list_to_distances.Location = new System.Drawing.Point(534, 74);
            this.list_to_distances.Margin = new System.Windows.Forms.Padding(2);
            this.list_to_distances.Name = "list_to_distances";
            this.list_to_distances.Size = new System.Drawing.Size(212, 84);
            this.list_to_distances.TabIndex = 10;
            // 
            // list_from_distances
            // 
            this.list_from_distances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_from_distances.FormattingEnabled = true;
            this.list_from_distances.ItemHeight = 16;
            this.list_from_distances.Location = new System.Drawing.Point(315, 74);
            this.list_from_distances.Margin = new System.Windows.Forms.Padding(2);
            this.list_from_distances.Name = "list_from_distances";
            this.list_from_distances.Size = new System.Drawing.Size(216, 84);
            this.list_from_distances.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(311, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distances";
            // 
            // btn_add_sector
            // 
            this.btn_add_sector.Location = new System.Drawing.Point(8, 217);
            this.btn_add_sector.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_sector.Name = "btn_add_sector";
            this.btn_add_sector.Size = new System.Drawing.Size(118, 19);
            this.btn_add_sector.TabIndex = 7;
            this.btn_add_sector.Text = "Add Sector";
            this.btn_add_sector.UseVisualStyleBackColor = true;
            this.btn_add_sector.Click += new System.EventHandler(this.btn_add_sector_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // tb_new_sector_name
            // 
            this.tb_new_sector_name.Location = new System.Drawing.Point(52, 194);
            this.tb_new_sector_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_new_sector_name.Name = "tb_new_sector_name";
            this.tb_new_sector_name.Size = new System.Drawing.Size(76, 20);
            this.tb_new_sector_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Sector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sectors List";
            // 
            // btn_remove_sector
            // 
            this.btn_remove_sector.Location = new System.Drawing.Point(4, 124);
            this.btn_remove_sector.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_sector.Name = "btn_remove_sector";
            this.btn_remove_sector.Size = new System.Drawing.Size(163, 19);
            this.btn_remove_sector.TabIndex = 2;
            this.btn_remove_sector.Text = "Remove Sector";
            this.btn_remove_sector.UseVisualStyleBackColor = true;
            this.btn_remove_sector.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1057, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medicines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sectorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.medicinesListBox);
            this.tabPage3.Controls.Add(this.removeOrderBtn);
            this.tabPage3.Controls.Add(this.generateOrderBtn);
            this.tabPage3.Controls.Add(this.ordersListBox);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1057, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // medicinesListBox
            // 
            this.medicinesListBox.FormattingEnabled = true;
            this.medicinesListBox.Location = new System.Drawing.Point(206, 6);
            this.medicinesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.medicinesListBox.Name = "medicinesListBox";
            this.medicinesListBox.Size = new System.Drawing.Size(832, 498);
            this.medicinesListBox.TabIndex = 5;
            // 
            // removeOrderBtn
            // 
            this.removeOrderBtn.Location = new System.Drawing.Point(6, 436);
            this.removeOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.removeOrderBtn.Name = "removeOrderBtn";
            this.removeOrderBtn.Size = new System.Drawing.Size(150, 28);
            this.removeOrderBtn.TabIndex = 4;
            this.removeOrderBtn.Text = "Remove Order";
            this.removeOrderBtn.UseVisualStyleBackColor = true;
            this.removeOrderBtn.Click += new System.EventHandler(this.removeOrderBtn_Click);
            // 
            // generateOrderBtn
            // 
            this.generateOrderBtn.Location = new System.Drawing.Point(6, 404);
            this.generateOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.generateOrderBtn.Name = "generateOrderBtn";
            this.generateOrderBtn.Size = new System.Drawing.Size(150, 28);
            this.generateOrderBtn.TabIndex = 3;
            this.generateOrderBtn.Text = "Generate Order";
            this.generateOrderBtn.UseVisualStyleBackColor = true;
            this.generateOrderBtn.Click += new System.EventHandler(this.generateOrderBtn_Click);
            // 
            // ordersListBox
            // 
            this.ordersListBox.FormattingEnabled = true;
            this.ordersListBox.Location = new System.Drawing.Point(5, 6);
            this.ordersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ordersListBox.Name = "ordersListBox";
            this.ordersListBox.Size = new System.Drawing.Size(151, 394);
            this.ordersListBox.TabIndex = 2;
            this.ordersListBox.SelectedIndexChanged += new System.EventHandler(this.ordersListBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.line_chart);
            this.tabPage4.Controls.Add(this.textBoxOutput);
            this.tabPage4.Controls.Add(this.runBtn);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.lambd);
            this.tabPage4.Controls.Add(this.tk);
            this.tabPage4.Controls.Add(this.t0);
            this.tabPage4.Controls.Add(this.limit);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.nWorkers);
            this.tabPage4.ImageIndex = 0;
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1057, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Algorithm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // line_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.line_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.line_chart.Legends.Add(legend1);
            this.line_chart.Location = new System.Drawing.Point(200, 6);
            this.line_chart.Name = "line_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.line_chart.Series.Add(series1);
            this.line_chart.Size = new System.Drawing.Size(851, 294);
            this.line_chart.TabIndex = 6;
            this.line_chart.Text = "chart2";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutput.Location = new System.Drawing.Point(22, 306);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(1029, 212);
            this.textBoxOutput.TabIndex = 5;
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runBtn.Location = new System.Drawing.Point(94, 243);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(84, 33);
            this.runBtn.TabIndex = 4;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Limit of Medicines";
            // 
            // limit
            // 
            this.limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.limit.Location = new System.Drawing.Point(124, 38);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(54, 26);
            this.limit.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Number of Workers";
            // 
            // nWorkers
            // 
            this.nWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nWorkers.Location = new System.Drawing.Point(124, 6);
            this.nWorkers.Name = "nWorkers";
            this.nWorkers.Size = new System.Drawing.Size(54, 26);
            this.nWorkers.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a4.png");
            this.imageList1.Images.SetKeyName(1, "a1.png");
            this.imageList1.Images.SetKeyName(2, "a2.png");
            this.imageList1.Images.SetKeyName(3, "a3.png");
            // 
            // t0
            // 
            this.t0.DecimalPlaces = 5;
            this.t0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.t0.Location = new System.Drawing.Point(73, 115);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(105, 26);
            this.t0.TabIndex = 2;
            // 
            // tk
            // 
            this.tk.DecimalPlaces = 5;
            this.tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tk.Location = new System.Drawing.Point(73, 147);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(105, 26);
            this.tk.TabIndex = 2;
            // 
            // lambd
            // 
            this.lambd.DecimalPlaces = 5;
            this.lambd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lambd.Location = new System.Drawing.Point(73, 179);
            this.lambd.Name = "lambd";
            this.lambd.Size = new System.Drawing.Size(105, 26);
            this.lambd.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "T0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tk";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "lambda";
            // 
            // medicineIdDataGridViewTextBoxColumn
            // 
            this.medicineIdDataGridViewTextBoxColumn.DataPropertyName = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.HeaderText = "MedicineId";
            this.medicineIdDataGridViewTextBoxColumn.Name = "medicineIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sectorDataGridViewTextBoxColumn
            // 
            this.sectorDataGridViewTextBoxColumn.DataPropertyName = "Sector";
            this.sectorDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.sectorDataGridViewTextBoxColumn.Name = "sectorDataGridViewTextBoxColumn";
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(SterowanieMagazynowaniem.Medicine);
            // 
            // medicineBindingSource1
            // 
            this.medicineBindingSource1.DataSource = typeof(SterowanieMagazynowaniem.Medicine);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(SterowanieMagazynowaniem.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 596);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_remove_sector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_new_sector_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_sector;
        private System.Windows.Forms.ListBox list_from_distances;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_to_distances;
        private System.Windows.Forms.Button btn_add_to_distance;
        private System.Windows.Forms.Button btn_add_from_distance;
        private System.Windows.Forms.TextBox value_to;
        private System.Windows.Forms.TextBox value_from;
        private System.Windows.Forms.ComboBox comboBox_to;
        private System.Windows.Forms.ComboBox comboBox_from;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button remove_dist_to;
        private System.Windows.Forms.Button remove_dist_from;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource medicineBindingSource1;
        private System.Windows.Forms.ListBox ordersListBox;
        private System.Windows.Forms.Button removeOrderBtn;
        private System.Windows.Forms.Button generateOrderBtn;
        private System.Windows.Forms.ListBox medicinesListBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown limit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nWorkers;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart line_chart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown lambd;
        private System.Windows.Forms.NumericUpDown tk;
        private System.Windows.Forms.NumericUpDown t0;
    }
}

