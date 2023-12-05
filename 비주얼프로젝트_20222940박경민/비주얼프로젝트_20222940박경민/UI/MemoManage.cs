using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비주얼프로젝트_20222940박경민
{
    public partial class MemoManage : Form
    {
        Memo memo = new Memo();
        const string fname = "memodata.csv"; //메모 내용 csv파일로 저장하기
        public MemoManage()
        {
            InitializeComponent();
        }

        public void formClear()
        {
            //txtMemoDate.Clear(); //날짜 선택 후 공백처리
            txtMemoContext.Clear(); //체중 입력 후 공백처리

            txtMemoContext.Focus();   //커서를 InbodyWeight 텍스트박스로 설정
        }

        public void AddMemo(Memo memo) //인바디 정보 추가하는 함수
        {
            string[] sitems = new string[] { memo.MemoDate, memo.MemoContext};
            //ListViewItem 객체 생성
            ListViewItem Ivi = new ListViewItem(sitems);
            listView1.Items.Add(Ivi); //데이터 등록
            listView1.EndUpdate(); //리스트뷰 종료 선언
            formClear();//입력 부분 공백으로 싹 다 초기화 시키기
        }


        private void btnMemoEnter_Click(object sender, EventArgs e) //입력 버튼
        {
            listView1.BeginUpdate(); //listview 업데이트 선업
            memo.MemoDate = txtMemoDate.Text.ToString();
            memo.MemoContext = txtMemoContext.Text.ToString();
            try  //예외처리 부분
            {
                if (txtMemoDate.Text == "")
                {
                    throw (new Exception("날짜 선택이 되지 않았습니다."));
                }
                else if (txtMemoContext.Text == "")
                {
                    throw (new Exception("메모 내용 입력이 되지 않았습니다."));
                }
                else
                {
                    AddMemo(memo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMemoFix_Click(object sender, EventArgs e)  //수정 버튼
        {
            if (listView1.SelectedItems.Count > 0)  //listview에서 항목이 하나 이상 선택되면
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtMemoDate.Text; //날짜 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[1].Text = txtMemoContext.Text;  //메모내용 입력 칸 수정 가능
            }
        }

        private void btnMemoDel_Click(object sender, EventArgs e)   //삭제 버튼
        {
            if (listView1.SelectedItems.Count > 0)//listView1의 항목중 하나가 선택되면
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); //해당 정보 삭제 기능
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMemoDate.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtMemoContext.Text = listView1.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void MemoManage_Load(object sender, EventArgs e)
        {
            txtMemoDate.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");

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
                        string memodata = sr.ReadLine();
                        if (memodata == null) { break; }//멤버 데이터가 없으면 읽기 멈춤
                        string[] sitems = memodata.Split(',');
                        memo.MemoDate = sitems[0].ToString();
                        memo.MemoContext = sitems[1].ToString();

                        AddMemo(memo);
                    }
                    sr.Close(); //파일 읽기 기능 닫기
                    fs.Close();//파일스트림 닫기
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("에러 : " + ex1.ToString());
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtMemoDate.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");
        }

        private void btnSaveFile_Click(object sender, EventArgs e) //저장 버튼
        {
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);
            
            foreach (ListViewItem lvi in listView1.Items)
            {
                memo.MemoDate = lvi.SubItems[0].Text;
                memo.MemoContext = lvi.SubItems[1].Text;
                sw.WriteLine("{0},{1}",memo.MemoDate,memo.MemoContext);
            }
            sw.Close();
            fs.Close();
        }
    }
}
