namespace 비주얼프로젝트_20222940박경민
{
    partial class MemManage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupMemEnroll = new System.Windows.Forms.GroupBox();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColMemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMemBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMemTele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMemGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMemFix = new System.Windows.Forms.Button();
            this.btnMemdelete = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.groupMemEnroll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "생년월일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "성별";
            // 
            // groupMemEnroll
            // 
            this.groupMemEnroll.Controls.Add(this.btnMemAdd);
            this.groupMemEnroll.Controls.Add(this.txtGender);
            this.groupMemEnroll.Controls.Add(this.txtTel);
            this.groupMemEnroll.Controls.Add(this.txtBirth);
            this.groupMemEnroll.Controls.Add(this.txtName);
            this.groupMemEnroll.Controls.Add(this.label1);
            this.groupMemEnroll.Controls.Add(this.label4);
            this.groupMemEnroll.Controls.Add(this.label2);
            this.groupMemEnroll.Controls.Add(this.label3);
            this.groupMemEnroll.Location = new System.Drawing.Point(49, 48);
            this.groupMemEnroll.Name = "groupMemEnroll";
            this.groupMemEnroll.Size = new System.Drawing.Size(328, 196);
            this.groupMemEnroll.TabIndex = 4;
            this.groupMemEnroll.TabStop = false;
            this.groupMemEnroll.Text = "<회원등록>";
            this.groupMemEnroll.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.Location = new System.Drawing.Point(230, 156);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMemAdd.TabIndex = 8;
            this.btnMemAdd.Text = "회원추가";
            this.btnMemAdd.UseVisualStyleBackColor = true;
            this.btnMemAdd.Click += new System.EventHandler(this.btnMemAdd_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(97, 105);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(153, 21);
            this.txtGender.TabIndex = 7;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(97, 81);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(153, 21);
            this.txtTel.TabIndex = 6;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(97, 57);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(153, 21);
            this.txtBirth.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 21);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnFileSave);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnMemFix);
            this.groupBox1.Controls.Add(this.btnMemdelete);
            this.groupBox1.Location = new System.Drawing.Point(398, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "<회원 검색, 삭제, 수정>";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(375, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(204, 350);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(75, 23);
            this.btnFileSave.TabIndex = 8;
            this.btnFileSave.Text = "파일에저장";
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColMemName,
            this.ColMemBirth,
            this.ColMemTele,
            this.ColMemGender});
            this.listView1.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 224);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColMemName
            // 
            this.ColMemName.Text = "이름";
            // 
            // ColMemBirth
            // 
            this.ColMemBirth.Text = "생년월일";
            this.ColMemBirth.Width = 84;
            // 
            // ColMemTele
            // 
            this.ColMemTele.Text = "전화번호";
            this.ColMemTele.Width = 137;
            // 
            // ColMemGender
            // 
            this.ColMemGender.Text = "성별";
            // 
            // btnMemFix
            // 
            this.btnMemFix.Location = new System.Drawing.Point(210, 279);
            this.btnMemFix.Name = "btnMemFix";
            this.btnMemFix.Size = new System.Drawing.Size(75, 24);
            this.btnMemFix.TabIndex = 2;
            this.btnMemFix.Text = "수정";
            this.btnMemFix.UseVisualStyleBackColor = true;
            this.btnMemFix.Click += new System.EventHandler(this.btnMemFix_Click);
            // 
            // btnMemdelete
            // 
            this.btnMemdelete.Location = new System.Drawing.Point(294, 279);
            this.btnMemdelete.Name = "btnMemdelete";
            this.btnMemdelete.Size = new System.Drawing.Size(75, 23);
            this.btnMemdelete.TabIndex = 1;
            this.btnMemdelete.Text = "삭제";
            this.btnMemdelete.UseVisualStyleBackColor = true;
            this.btnMemdelete.Click += new System.EventHandler(this.btnMemdelete_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(15, 279);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "파일에저장";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // MemManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupMemEnroll);
            this.Name = "MemManage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MemManage_Load);
            this.groupMemEnroll.ResumeLayout(false);
            this.groupMemEnroll.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupMemEnroll;
        private System.Windows.Forms.Button btnMemAdd;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColMemName;
        private System.Windows.Forms.ColumnHeader ColMemBirth;
        private System.Windows.Forms.ColumnHeader ColMemTele;
        private System.Windows.Forms.ColumnHeader ColMemGender;
        private System.Windows.Forms.Button btnMemFix;
        private System.Windows.Forms.Button btnMemdelete;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveFile;
    }
}

