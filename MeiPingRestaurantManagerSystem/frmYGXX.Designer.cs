namespace MeiPingRestaurantManagerSystem
{
    partial class frmYGXX
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
            this.label1 = new System.Windows.Forms.Label();
            this.comDJ = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTJ = new System.Windows.Forms.Button();
            this.btnXG = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnDJ = new System.Windows.Forms.Button();
            this.btnSZ = new System.Windows.Forms.Button();
            this.btnGB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "按服务生等级过滤:";
            // 
            // comDJ
            // 
            this.comDJ.FormattingEnabled = true;
            this.comDJ.Location = new System.Drawing.Point(145, 15);
            this.comDJ.Name = "comDJ";
            this.comDJ.Size = new System.Drawing.Size(180, 23);
            this.comDJ.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 394);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "简拼";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "服务级别";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "联系方式";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "身份证号";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "计薪日期";
            this.columnHeader8.Width = 87;
            // 
            // btnTJ
            // 
            this.btnTJ.Location = new System.Drawing.Point(670, 76);
            this.btnTJ.Name = "btnTJ";
            this.btnTJ.Size = new System.Drawing.Size(118, 23);
            this.btnTJ.TabIndex = 3;
            this.btnTJ.Text = "添加服务生";
            this.btnTJ.UseVisualStyleBackColor = true;
            // 
            // btnXG
            // 
            this.btnXG.Location = new System.Drawing.Point(670, 120);
            this.btnXG.Name = "btnXG";
            this.btnXG.Size = new System.Drawing.Size(118, 23);
            this.btnXG.TabIndex = 4;
            this.btnXG.Text = "修改服务生";
            this.btnXG.UseVisualStyleBackColor = true;
            // 
            // btnSC
            // 
            this.btnSC.Location = new System.Drawing.Point(670, 161);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(118, 23);
            this.btnSC.TabIndex = 5;
            this.btnSC.Text = "删除服务生";
            this.btnSC.UseVisualStyleBackColor = true;
            // 
            // btnDJ
            // 
            this.btnDJ.Location = new System.Drawing.Point(670, 290);
            this.btnDJ.Name = "btnDJ";
            this.btnDJ.Size = new System.Drawing.Size(118, 23);
            this.btnDJ.TabIndex = 6;
            this.btnDJ.Text = "服务生等级";
            this.btnDJ.UseVisualStyleBackColor = true;
            // 
            // btnSZ
            // 
            this.btnSZ.Location = new System.Drawing.Point(670, 334);
            this.btnSZ.Name = "btnSZ";
            this.btnSZ.Size = new System.Drawing.Size(118, 23);
            this.btnSZ.TabIndex = 7;
            this.btnSZ.Text = "营销提成设置";
            this.btnSZ.UseVisualStyleBackColor = true;
            // 
            // btnGB
            // 
            this.btnGB.Location = new System.Drawing.Point(670, 400);
            this.btnGB.Name = "btnGB";
            this.btnGB.Size = new System.Drawing.Size(118, 23);
            this.btnGB.TabIndex = 8;
            this.btnGB.Text = "关闭";
            this.btnGB.UseVisualStyleBackColor = true;
            // 
            // frmYGXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGB);
            this.Controls.Add(this.btnSZ);
            this.Controls.Add(this.btnDJ);
            this.Controls.Add(this.btnSC);
            this.Controls.Add(this.btnXG);
            this.Controls.Add(this.btnTJ);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comDJ);
            this.Controls.Add(this.label1);
            this.Name = "frmYGXX";
            this.Text = "员工信息设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comDJ;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnTJ;
        private System.Windows.Forms.Button btnXG;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Button btnDJ;
        private System.Windows.Forms.Button btnSZ;
        private System.Windows.Forms.Button btnGB;
    }
}