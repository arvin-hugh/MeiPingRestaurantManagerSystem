namespace MeiPingRestaurantManagerSystem
{
    partial class frmSPXM
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
            this.lvList1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cboXMMC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCZ = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTJSPLB = new System.Windows.Forms.Button();
            this.btnXGSPLB = new System.Windows.Forms.Button();
            this.btnSCSPLB = new System.Windows.Forms.Button();
            this.btnSZ = new System.Windows.Forms.Button();
            this.btnTJSP = new System.Windows.Forms.Button();
            this.btnXGSP = new System.Windows.Forms.Button();
            this.btnSCSP = new System.Windows.Forms.Button();
            this.btnSCCD = new System.Windows.Forms.Button();
            this.btnDR = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnSPTC = new System.Windows.Forms.Button();
            this.btnDZSZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvList1
            // 
            this.lvList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvList1.GridLines = true;
            this.lvList1.HideSelection = false;
            this.lvList1.Location = new System.Drawing.Point(1, 12);
            this.lvList1.Name = "lvList1";
            this.lvList1.Size = new System.Drawing.Size(644, 208);
            this.lvList1.TabIndex = 0;
            this.lvList1.UseCompatibleStateImageBehavior = false;
            this.lvList1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类别编号";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类别名称";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所属档口";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "类别属性";
            this.columnHeader4.Width = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "按项目类别过滤:";
            // 
            // cboXMMC
            // 
            this.cboXMMC.FormattingEnabled = true;
            this.cboXMMC.Location = new System.Drawing.Point(121, 236);
            this.cboXMMC.Name = "cboXMMC";
            this.cboXMMC.Size = new System.Drawing.Size(121, 23);
            this.cboXMMC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "查找(简拼):";
            // 
            // txtCZ
            // 
            this.txtCZ.Location = new System.Drawing.Point(351, 236);
            this.txtCZ.Name = "txtCZ";
            this.txtCZ.Size = new System.Drawing.Size(117, 25);
            this.txtCZ.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 267);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(644, 243);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "项目编码";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "名称";
            this.columnHeader6.Width = 49;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "预设单价";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "单位成本";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "项目类别";
            this.columnHeader9.Width = 76;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "单位";
            this.columnHeader10.Width = 49;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "库存商品";
            this.columnHeader11.Width = 74;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "是否提成";
            this.columnHeader12.Width = 72;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "不打折";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "报警库存";
            this.columnHeader14.Width = 82;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "称重商品";
            this.columnHeader15.Width = 76;
            // 
            // btnTJSPLB
            // 
            this.btnTJSPLB.Location = new System.Drawing.Point(661, 13);
            this.btnTJSPLB.Name = "btnTJSPLB";
            this.btnTJSPLB.Size = new System.Drawing.Size(127, 23);
            this.btnTJSPLB.TabIndex = 6;
            this.btnTJSPLB.Text = "添加商品类别";
            this.btnTJSPLB.UseVisualStyleBackColor = true;
            // 
            // btnXGSPLB
            // 
            this.btnXGSPLB.Location = new System.Drawing.Point(661, 51);
            this.btnXGSPLB.Name = "btnXGSPLB";
            this.btnXGSPLB.Size = new System.Drawing.Size(127, 23);
            this.btnXGSPLB.TabIndex = 7;
            this.btnXGSPLB.Text = "修改商品类别";
            this.btnXGSPLB.UseVisualStyleBackColor = true;
            // 
            // btnSCSPLB
            // 
            this.btnSCSPLB.Location = new System.Drawing.Point(661, 89);
            this.btnSCSPLB.Name = "btnSCSPLB";
            this.btnSCSPLB.Size = new System.Drawing.Size(127, 23);
            this.btnSCSPLB.TabIndex = 8;
            this.btnSCSPLB.Text = "删除商品类别";
            this.btnSCSPLB.UseVisualStyleBackColor = true;
            // 
            // btnSZ
            // 
            this.btnSZ.Location = new System.Drawing.Point(661, 152);
            this.btnSZ.Name = "btnSZ";
            this.btnSZ.Size = new System.Drawing.Size(127, 23);
            this.btnSZ.TabIndex = 9;
            this.btnSZ.Text = "出品档口设置";
            this.btnSZ.UseVisualStyleBackColor = true;
            // 
            // btnTJSP
            // 
            this.btnTJSP.Location = new System.Drawing.Point(651, 267);
            this.btnTJSP.Name = "btnTJSP";
            this.btnTJSP.Size = new System.Drawing.Size(127, 23);
            this.btnTJSP.TabIndex = 10;
            this.btnTJSP.Text = "添加商品";
            this.btnTJSP.UseVisualStyleBackColor = true;
            // 
            // btnXGSP
            // 
            this.btnXGSP.Location = new System.Drawing.Point(651, 296);
            this.btnXGSP.Name = "btnXGSP";
            this.btnXGSP.Size = new System.Drawing.Size(127, 23);
            this.btnXGSP.TabIndex = 11;
            this.btnXGSP.Text = "修改商品";
            this.btnXGSP.UseVisualStyleBackColor = true;
            // 
            // btnSCSP
            // 
            this.btnSCSP.Location = new System.Drawing.Point(651, 325);
            this.btnSCSP.Name = "btnSCSP";
            this.btnSCSP.Size = new System.Drawing.Size(127, 23);
            this.btnSCSP.TabIndex = 12;
            this.btnSCSP.Text = "删除商品";
            this.btnSCSP.UseVisualStyleBackColor = true;
            // 
            // btnSCCD
            // 
            this.btnSCCD.Location = new System.Drawing.Point(651, 354);
            this.btnSCCD.Name = "btnSCCD";
            this.btnSCCD.Size = new System.Drawing.Size(127, 23);
            this.btnSCCD.TabIndex = 13;
            this.btnSCCD.Text = "生成菜单";
            this.btnSCCD.UseVisualStyleBackColor = true;
            // 
            // btnDR
            // 
            this.btnDR.Location = new System.Drawing.Point(651, 383);
            this.btnDR.Name = "btnDR";
            this.btnDR.Size = new System.Drawing.Size(127, 23);
            this.btnDR.TabIndex = 14;
            this.btnDR.Text = "导入";
            this.btnDR.UseVisualStyleBackColor = true;
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(651, 412);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(127, 23);
            this.btnDC.TabIndex = 15;
            this.btnDC.Text = "导出";
            this.btnDC.UseVisualStyleBackColor = true;
            // 
            // btnSPTC
            // 
            this.btnSPTC.Location = new System.Drawing.Point(651, 456);
            this.btnSPTC.Name = "btnSPTC";
            this.btnSPTC.Size = new System.Drawing.Size(127, 23);
            this.btnSPTC.TabIndex = 16;
            this.btnSPTC.Text = "商品提成";
            this.btnSPTC.UseVisualStyleBackColor = true;
            // 
            // btnDZSZ
            // 
            this.btnDZSZ.Location = new System.Drawing.Point(651, 485);
            this.btnDZSZ.Name = "btnDZSZ";
            this.btnDZSZ.Size = new System.Drawing.Size(127, 23);
            this.btnDZSZ.TabIndex = 17;
            this.btnDZSZ.Text = "打折设置";
            this.btnDZSZ.UseVisualStyleBackColor = true;
            // 
            // frmSPXM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnDZSZ);
            this.Controls.Add(this.btnSPTC);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.btnDR);
            this.Controls.Add(this.btnSCCD);
            this.Controls.Add(this.btnSCSP);
            this.Controls.Add(this.btnXGSP);
            this.Controls.Add(this.btnTJSP);
            this.Controls.Add(this.btnSZ);
            this.Controls.Add(this.btnSCSPLB);
            this.Controls.Add(this.btnXGSPLB);
            this.Controls.Add(this.btnTJSPLB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtCZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboXMMC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvList1);
            this.Name = "frmSPXM";
            this.Text = "商品信息设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboXMMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCZ;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button btnTJSPLB;
        private System.Windows.Forms.Button btnXGSPLB;
        private System.Windows.Forms.Button btnSCSPLB;
        private System.Windows.Forms.Button btnSZ;
        private System.Windows.Forms.Button btnTJSP;
        private System.Windows.Forms.Button btnXGSP;
        private System.Windows.Forms.Button btnSCSP;
        private System.Windows.Forms.Button btnSCCD;
        private System.Windows.Forms.Button btnDR;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnSPTC;
        private System.Windows.Forms.Button btnDZSZ;
    }
}