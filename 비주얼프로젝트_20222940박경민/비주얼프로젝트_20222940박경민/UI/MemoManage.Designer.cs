namespace 비주얼프로젝트_20222940박경민
{
    partial class MemoManage
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemoDate = new System.Windows.Forms.TextBox();
            this.btnMemoEnter = new System.Windows.Forms.Button();
            this.btnMemoFix = new System.Windows.Forms.Button();
            this.btnMemoDel = new System.Windows.Forms.Button();
            this.txtMemoContext = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("굴림", 10F);
            this.monthCalendar1.Location = new System.Drawing.Point(469, 28);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(356, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "날짜 선택";
            // 
            // txtMemoDate
            // 
            this.txtMemoDate.Font = new System.Drawing.Font("굴림", 10F);
            this.txtMemoDate.Location = new System.Drawing.Point(103, 49);
            this.txtMemoDate.Name = "txtMemoDate";
            this.txtMemoDate.Size = new System.Drawing.Size(93, 23);
            this.txtMemoDate.TabIndex = 2;
            // 
            // btnMemoEnter
            // 
            this.btnMemoEnter.Font = new System.Drawing.Font("굴림", 10F);
            this.btnMemoEnter.Location = new System.Drawing.Point(338, 47);
            this.btnMemoEnter.Name = "btnMemoEnter";
            this.btnMemoEnter.Size = new System.Drawing.Size(75, 23);
            this.btnMemoEnter.TabIndex = 3;
            this.btnMemoEnter.Text = "입력";
            this.btnMemoEnter.UseVisualStyleBackColor = true;
            this.btnMemoEnter.Click += new System.EventHandler(this.btnMemoEnter_Click);
            // 
            // btnMemoFix
            // 
            this.btnMemoFix.Font = new System.Drawing.Font("굴림", 10F);
            this.btnMemoFix.Location = new System.Drawing.Point(257, 145);
            this.btnMemoFix.Name = "btnMemoFix";
            this.btnMemoFix.Size = new System.Drawing.Size(75, 23);
            this.btnMemoFix.TabIndex = 4;
            this.btnMemoFix.Text = "수정";
            this.btnMemoFix.UseVisualStyleBackColor = true;
            this.btnMemoFix.Click += new System.EventHandler(this.btnMemoFix_Click);
            // 
            // btnMemoDel
            // 
            this.btnMemoDel.Font = new System.Drawing.Font("굴림", 10F);
            this.btnMemoDel.Location = new System.Drawing.Point(338, 145);
            this.btnMemoDel.Name = "btnMemoDel";
            this.btnMemoDel.Size = new System.Drawing.Size(75, 23);
            this.btnMemoDel.TabIndex = 5;
            this.btnMemoDel.Text = "삭제";
            this.btnMemoDel.UseVisualStyleBackColor = true;
            this.btnMemoDel.Click += new System.EventHandler(this.btnMemoDel_Click);
            // 
            // txtMemoContext
            // 
            this.txtMemoContext.Font = new System.Drawing.Font("굴림", 10F);
            this.txtMemoContext.Location = new System.Drawing.Point(32, 89);
            this.txtMemoContext.Name = "txtMemoContext";
            this.txtMemoContext.Size = new System.Drawing.Size(381, 23);
            this.txtMemoContext.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("굴림", 10F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 215);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 160);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "메모 내용";
            this.columnHeader3.Width = 506;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMemoContext);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btnMemoDel);
            this.groupBox1.Controls.Add(this.txtMemoDate);
            this.groupBox1.Controls.Add(this.btnMemoFix);
            this.groupBox1.Controls.Add(this.btnMemoEnter);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 391);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "𝙈𝙚𝙢𝙤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "날짜 선택";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("굴림", 10F);
            this.btnSaveFile.Location = new System.Drawing.Point(176, 145);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 9;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // MemoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 475);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemoManage";
            this.Text = "날짜 선택";
            this.Load += new System.EventHandler(this.MemoManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemoDate;
        private System.Windows.Forms.Button btnMemoEnter;
        private System.Windows.Forms.Button btnMemoFix;
        private System.Windows.Forms.Button btnMemoDel;
        private System.Windows.Forms.TextBox txtMemoContext;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveFile;
    }
}