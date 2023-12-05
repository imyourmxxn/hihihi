using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;

namespace 비주얼프로젝트_20222940박경민
{
    public partial class MemManage : Form
    {
        //public MemManage()
        Member mem = new Member();
        const string fname = "memdata1.csv";//회원 인적사항 csv파일로 저장하기

        public MemManage()
        {
            InitializeComponent();
        }

        public void formClear()
        {
            txtName.Clear(); //이름 입력 후 공백처리
            txtBirth.Clear(); //생년월일 입력 후 공백처리
            txtTel.Clear();   //전화번호 입력 후 공백처리
            txtGender.Clear(); //성별 입력 후 공백처리
            txtName.Focus();   //커서를 Name 텍스트박스로 설정
        }

        public void AddMember(Member mem) //멤버 추가하는 함수
        {
            string[] sitems = new string[] {mem.Name, mem.Birth, mem.Tel, mem.Gender };
            //ListViewItem 객체 생성
            ListViewItem Ivi=new ListViewItem(sitems);
            listView1.Items.Add(Ivi); //데이터 등록
            listView1.EndUpdate(); //리스트뷰 종료 선언
            formClear();//입력 부분 공백으로 싹 다 초기화 시키기
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtBirth.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtTel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMemAdd_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate(); //listview 업데이트 선업
            mem.Name = txtName.Text.ToString();
            mem.Birth = txtBirth.Text.ToString();
            mem.Tel = txtTel.Text.ToString();
            mem.Gender = txtGender.Text.ToString();
            try  //예외처리 부분
            {
                if (txtName.Text == "")
                {
                    throw (new Exception("이름이 입력 되지 않았습니다."));
                }
                else if (txtBirth.Text == "")
                {
                    throw (new Exception("생년월일이 입력 되지 않았습니다."));
                }
                else if (txtTel.Text == "")
                {
                    throw (new Exception("전화번호가 입력되지 않았습니다."));
                }
                else if (txtGender.Text == "")
                {
                    throw (new Exception("성별이 입력되지 않았습니다."));
                }
                else
                {
                    AddMember(mem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void btnMemSearch_Click(object sender, EventArgs e)//회원정보검색
        //{

        //}

        private void btnMemdelete_Click(object sender, EventArgs e)//회원정보삭제
        {
            if (listView1.SelectedItems.Count > 0)//listView1의 항목중 하나가 선택되면
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); //해당 정보 삭제
            }
        }

        private void btnMemFix_Click(object sender, EventArgs e) //회원정보수정
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtBirth.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtTel.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtGender.Text;
            }
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFileSave_Click(object sender, EventArgs e)////파일처리
        {
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);

            foreach(ListViewItem lvi in listView1.Items)
            {
                mem.Name = lvi.SubItems[0].Text;
                mem.Birth= lvi.SubItems[1].Text;
                mem.Tel= lvi.SubItems[2].Text;
                mem.Gender= lvi.SubItems[3].Text;
                sw.WriteLine("{0}, {1}, {2}", mem.Name, mem.Birth, mem.Tel, mem.Gender);
            }
            sw.Close();
            fs.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //화면 닫기 문법
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MemManage_Load(object sender, EventArgs e)//파일처리_2
        {
            try
            {
                if (File.Exists(fname) == false)
                {//파일스트림 클래스 : 파일 읽고 쓰는 기능 제공
                 // 파일 생성과 열기
                    FileStream fs = new FileStream(fname, FileMode.OpenOrCreate);
                    fs.Close();
                }
                else
                {
                    FileStream fs = File.OpenRead(fname);//읽기용 파일스트림 생성
                    StreamReader sr = new StreamReader(fs); //바이트 기반 스트림 -> 파일 기반 스트림으로 변환

                    while (sr.EndOfStream == false)//EndOfStream 프로퍼티는 스트림 끝에 도달했는지 알려줌
                    {
                        string memdata1 = sr.ReadLine();
                        if (memdata1 == null) { break; }//멤버 데이터가 없으면 읽기 멈춤
                        string[] sitems = memdata1.Split(',');
                        mem.Name = sitems[0].ToString();
                        mem.Birth = sitems[1].ToString();
                        mem.Tel = sitems[2].ToString();
                        mem.Gender = sitems[3].ToString();
                        AddMember(mem);
                    }
                    sr.Close(); //파일 읽기 기능 닫기
                    fs.Close();//파일스트림 닫기
                }
            }
            catch(Exception ex1)
            {
                MessageBox.Show("에러 : "+ex1.ToString());
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(fname);//파일에 저장 버튼을 누르면 파일스트림 생성
            StreamWriter sw = new StreamWriter(fs); //파일스트림을 문자 방식의 파일스트림으로 변환하기

            foreach(ListViewItem lvi in listView1.Items)
            {
                mem.Name = lvi.SubItems[0].Text;
                mem.Birth= lvi.SubItems[1].Text;
                mem.Tel= lvi.SubItems[2].Text;
                mem.Gender= lvi.SubItems[3].Text;
                sw.WriteLine("{0], {1}, {2}, {3}", mem.Name, mem.Birth, mem.Tel, mem.Gender);//파일에 저장
            }
            sw.Close();//파일 쓰기 기능 닫기
            fs.Close();//파일스트림 닫기
        }
    }

}
