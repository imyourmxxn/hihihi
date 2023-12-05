using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 비주얼프로젝트_20222940박경민.UI;

namespace 비주얼프로젝트_20222940박경민
{
    public partial class TrainerLogin : Form
    {
        public TrainerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) //로그인 버튼 클릭 시
        {
            if (checkBox1.Checked == false)
            {
                bool login = false;
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(@"user_login.csv");
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] data = line.Split(',');
                        if (data[1] == txtId.Text && data[2] == txtPwd.Text)
                        {
                            MessageBox.Show("로그인에 성공했습니다.", "로그인");
                            login = true;
                            break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!login)
                {
                    MessageBox.Show("로그인에 실패하였습니다.", "오류");
                }
                else
                {
                    UserMain user_mainpage = new UserMain();
                    user_mainpage.Show();
                    this.Hide();
                }
            }
            else
            {
                bool login = false;
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(@"admin_login.csv");
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();
                        string[] data = line.Split(',');
                        if (data[1] == txtId.Text && data[2] == txtPwd.Text)
                        {
                            MessageBox.Show("로그인에 성공했습니다.", "로그인");
                            login = true;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!login)
                {
                    MessageBox.Show("로그인에 실패하였습니다.", "오류");
                }
                else
                {
                    User_Main user_mainpage = new User_Main();
                    user_mainpage.Show();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register rg = new register();
            rg.ShowDialog();
        }
    }
}
