using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 비주얼프로젝트_20222940박경민
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.Focus();
            this.ActiveControl = txtUserName;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] data = {txtUserName.Text, txtUserId.Text,txtUserPwd.Text,txtUserBirth.Text,txtUserGender.Text,txtUserTel.Text,txtUserEmail.Text};
            WriteToCSV(chkTrainer.Checked,data);
        }

       private void WriteToCSV(bool check, string[] data)
        {
            try
            {
                System.IO.StreamWriter file;
                if (check)
                {
                    file = new System.IO.StreamWriter(@"admin_login.csv");
                }
                else
                {
                    file = new System.IO.StreamWriter(@"user_login.csv");
                }
                file.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", data[0], data[1], data[2], data[3], data[4], data[5], data[6]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(MessageBox.Show("회원가입을 환영합니다.", "알림",MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
