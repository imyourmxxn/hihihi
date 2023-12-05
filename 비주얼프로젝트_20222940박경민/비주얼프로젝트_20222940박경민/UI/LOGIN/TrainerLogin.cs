using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string userId=txtId.Text;
            string userPwd=txtPwd.Text;

            if(userId == "pkm1562" && userPwd == "ilovecat")//로그인에 성공했을 시
            {
                //MessageBox.Show("로그인에 성공했습니다.", "로그인");
               
                Main mainpage = new Main(); //메인화면으로 넘어가서
                mainpage.Show();            //메인화면 띄우기
            }
           
            else if (userId != "pkm1562" && userPwd == "ilovecat") //아이디가 틀렸을 때
                {
                    MessageBox.Show("존재하지 않는 아이디입니다.", "오류"); //오류메세지 박스 띄우기

                }
                else if (userId == "pkm1562" && userPwd != "ilovecat") //비밀번호 틀렸을 때
                {
                    MessageBox.Show("비밀번호를 확인해주세요.", "오류"); //오류메세지 박스 띄우기
                }
                else
                {
                    MessageBox.Show("존재하지 않는 계정입니다.", "오류"); //존재하지 않는 계정일 때 오류메세지 박스 띄우기
                }
        }
    }
}
