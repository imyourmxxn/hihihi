namespace 비주얼프로젝트_20222940박경민
{
    partial class GoodsManage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoodsFix = new System.Windows.Forms.Button();
            this.btnGoodsClear = new System.Windows.Forms.Button();
            this.btnGoodsClose = new System.Windows.Forms.Button();
            this.btnGoodsSave = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsStatue = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "기구명";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "갯수";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "상태";
            this.columnHeader3.Width = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoodsFix);
            this.groupBox1.Controls.Add(this.btnGoodsClear);
            this.groupBox1.Controls.Add(this.btnGoodsClose);
            this.groupBox1.Controls.Add(this.btnGoodsSave);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txtGoodsNum);
            this.groupBox1.Controls.Add(this.txtGoodsStatue);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(429, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "<기구 관리>";
            // 
            // btnGoodsFix
            // 
            this.btnGoodsFix.Location = new System.Drawing.Point(137, 233);
            this.btnGoodsFix.Name = "btnGoodsFix";
            this.btnGoodsFix.Size = new System.Drawing.Size(59, 23);
            this.btnGoodsFix.TabIndex = 11;
            this.btnGoodsFix.Text = "수정";
            this.btnGoodsFix.UseVisualStyleBackColor = true;
            this.btnGoodsFix.Click += new System.EventHandler(this.btnGoodsFix_Click);
            // 
            // btnGoodsClear
            // 
            this.btnGoodsClear.Location = new System.Drawing.Point(207, 233);
            this.btnGoodsClear.Name = "btnGoodsClear";
            this.btnGoodsClear.Size = new System.Drawing.Size(59, 23);
            this.btnGoodsClear.TabIndex = 10;
            this.btnGoodsClear.Text = "삭제";
            this.btnGoodsClear.UseVisualStyleBackColor = true;
            this.btnGoodsClear.Click += new System.EventHandler(this.btnGoodsClear_Click);
            // 
            // btnGoodsClose
            // 
            this.btnGoodsClose.Location = new System.Drawing.Point(207, 262);
            this.btnGoodsClose.Name = "btnGoodsClose";
            this.btnGoodsClose.Size = new System.Drawing.Size(59, 23);
            this.btnGoodsClose.TabIndex = 9;
            this.btnGoodsClose.Text = "창닫기";
            this.btnGoodsClose.UseVisualStyleBackColor = true;
            this.btnGoodsClose.Click += new System.EventHandler(this.btnGoodsClose_Click);
            // 
            // btnGoodsSave
            // 
            this.btnGoodsSave.Location = new System.Drawing.Point(137, 262);
            this.btnGoodsSave.Name = "btnGoodsSave";
            this.btnGoodsSave.Size = new System.Drawing.Size(59, 23);
            this.btnGoodsSave.TabIndex = 8;
            this.btnGoodsSave.Text = "저장";
            this.btnGoodsSave.UseVisualStyleBackColor = true;
            this.btnGoodsSave.Click += new System.EventHandler(this.btnGoodsSave_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(207, 89);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(59, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "등록";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(70, 65);
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(129, 21);
            this.txtGoodsNum.TabIndex = 5;
            // 
            // txtGoodsStatue
            // 
            this.txtGoodsStatue.Location = new System.Drawing.Point(70, 91);
            this.txtGoodsStatue.Name = "txtGoodsStatue";
            this.txtGoodsStatue.Size = new System.Drawing.Size(129, 21);
            this.txtGoodsStatue.TabIndex = 4;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(70, 40);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(129, 21);
            this.txtGoodsName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "상태";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "갯수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "기구명";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(54, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "운동 기구 관리";
            // 
            // GoodsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 442);
            this.Controls.Add(this.groupBox2);
            this.Name = "GoodsManage";
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.GoodsManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGoodsFix;
        private System.Windows.Forms.Button btnGoodsClear;
        private System.Windows.Forms.Button btnGoodsClose;
        private System.Windows.Forms.Button btnGoodsSave;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsStatue;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}