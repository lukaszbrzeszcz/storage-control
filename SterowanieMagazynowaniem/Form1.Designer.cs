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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_add_sector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_new_sector_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove_sector = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.list_from_distances = new System.Windows.Forms.ListBox();
            this.list_to_distances = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_from = new System.Windows.Forms.ComboBox();
            this.comboBox_to = new System.Windows.Forms.ComboBox();
            this.value_from = new System.Windows.Forms.TextBox();
            this.value_to = new System.Windows.Forms.TextBox();
            this.btn_add_from_distance = new System.Windows.Forms.Button();
            this.btn_add_to_distance = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.remove_dist_from = new System.Windows.Forms.Button();
            this.remove_dist_to = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 104);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 479);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sectors and Distances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_add_sector
            // 
            this.btn_add_sector.Location = new System.Drawing.Point(11, 267);
            this.btn_add_sector.Name = "btn_add_sector";
            this.btn_add_sector.Size = new System.Drawing.Size(158, 23);
            this.btn_add_sector.TabIndex = 7;
            this.btn_add_sector.Text = "Add Sector";
            this.btn_add_sector.UseVisualStyleBackColor = true;
            this.btn_add_sector.Click += new System.EventHandler(this.btn_add_sector_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // tb_new_sector_name
            // 
            this.tb_new_sector_name.Location = new System.Drawing.Point(69, 239);
            this.tb_new_sector_name.Name = "tb_new_sector_name";
            this.tb_new_sector_name.Size = new System.Drawing.Size(100, 22);
            this.tb_new_sector_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Sector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sectors List";
            // 
            // btn_remove_sector
            // 
            this.btn_remove_sector.Location = new System.Drawing.Point(6, 152);
            this.btn_remove_sector.Name = "btn_remove_sector";
            this.btn_remove_sector.Size = new System.Drawing.Size(217, 23);
            this.btn_remove_sector.TabIndex = 2;
            this.btn_remove_sector.Text = "Remove Sector";
            this.btn_remove_sector.UseVisualStyleBackColor = true;
            this.btn_remove_sector.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(415, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distances";
            // 
            // list_from_distances
            // 
            this.list_from_distances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_from_distances.FormattingEnabled = true;
            this.list_from_distances.ItemHeight = 20;
            this.list_from_distances.Location = new System.Drawing.Point(420, 91);
            this.list_from_distances.Name = "list_from_distances";
            this.list_from_distances.Size = new System.Drawing.Size(286, 104);
            this.list_from_distances.TabIndex = 9;
            // 
            // list_to_distances
            // 
            this.list_to_distances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_to_distances.FormattingEnabled = true;
            this.list_to_distances.ItemHeight = 20;
            this.list_to_distances.Location = new System.Drawing.Point(712, 91);
            this.list_to_distances.Name = "list_to_distances";
            this.list_to_distances.Size = new System.Drawing.Size(282, 104);
            this.list_to_distances.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(415, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(707, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "To";
            // 
            // comboBox_from
            // 
            this.comboBox_from.FormattingEnabled = true;
            this.comboBox_from.Location = new System.Drawing.Point(420, 306);
            this.comboBox_from.Name = "comboBox_from";
            this.comboBox_from.Size = new System.Drawing.Size(151, 24);
            this.comboBox_from.TabIndex = 13;
            // 
            // comboBox_to
            // 
            this.comboBox_to.FormattingEnabled = true;
            this.comboBox_to.Location = new System.Drawing.Point(712, 306);
            this.comboBox_to.Name = "comboBox_to";
            this.comboBox_to.Size = new System.Drawing.Size(151, 24);
            this.comboBox_to.TabIndex = 14;
            // 
            // value_from
            // 
            this.value_from.Location = new System.Drawing.Point(515, 350);
            this.value_from.Name = "value_from";
            this.value_from.Size = new System.Drawing.Size(56, 22);
            this.value_from.TabIndex = 15;
            this.value_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // value_to
            // 
            this.value_to.Location = new System.Drawing.Point(807, 350);
            this.value_to.Name = "value_to";
            this.value_to.Size = new System.Drawing.Size(56, 22);
            this.value_to.TabIndex = 16;
            this.value_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_add_from_distance
            // 
            this.btn_add_from_distance.Location = new System.Drawing.Point(420, 398);
            this.btn_add_from_distance.Name = "btn_add_from_distance";
            this.btn_add_from_distance.Size = new System.Drawing.Size(151, 23);
            this.btn_add_from_distance.TabIndex = 17;
            this.btn_add_from_distance.Text = "Add Distance";
            this.btn_add_from_distance.UseVisualStyleBackColor = true;
            this.btn_add_from_distance.Click += new System.EventHandler(this.btn_add_from_distance_Click);
            // 
            // btn_add_to_distance
            // 
            this.btn_add_to_distance.Location = new System.Drawing.Point(712, 398);
            this.btn_add_to_distance.Name = "btn_add_to_distance";
            this.btn_add_to_distance.Size = new System.Drawing.Size(151, 23);
            this.btn_add_to_distance.TabIndex = 18;
            this.btn_add_to_distance.Text = "Add Distance";
            this.btn_add_to_distance.UseVisualStyleBackColor = true;
            this.btn_add_to_distance.Click += new System.EventHandler(this.btn_add_to_distance_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(415, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(707, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(415, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "New Distances";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Distance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(738, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Distance";
            // 
            // remove_dist_from
            // 
            this.remove_dist_from.Location = new System.Drawing.Point(420, 201);
            this.remove_dist_from.Name = "remove_dist_from";
            this.remove_dist_from.Size = new System.Drawing.Size(217, 23);
            this.remove_dist_from.TabIndex = 24;
            this.remove_dist_from.Text = "Remove Distance";
            this.remove_dist_from.UseVisualStyleBackColor = true;
            this.remove_dist_from.Click += new System.EventHandler(this.remove_dist_from_Click);
            // 
            // remove_dist_to
            // 
            this.remove_dist_to.Location = new System.Drawing.Point(712, 201);
            this.remove_dist_to.Name = "remove_dist_to";
            this.remove_dist_to.Size = new System.Drawing.Size(217, 23);
            this.remove_dist_to.TabIndex = 25;
            this.remove_dist_to.Text = "Remove Distance";
            this.remove_dist_to.UseVisualStyleBackColor = true;
            this.remove_dist_to.Click += new System.EventHandler(this.remove_dist_to_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

