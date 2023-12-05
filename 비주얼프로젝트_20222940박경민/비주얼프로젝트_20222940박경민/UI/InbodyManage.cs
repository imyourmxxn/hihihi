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
    public partial class InbodyManage : Form
    {
        Inbody iby = new Inbody();
        const string fname = "inbodydata.csv"; //인바디 데이터 csv 파일로 저장
        public InbodyManage()
        {
            InitializeComponent();
        }

        public void formClear()
        {
            txtInbodyWeight.Clear(); //체중 입력 후 공백처리
            txtInbodyMuscle.Clear();   //골격근량 입력 후 공백처리
            txtInbodyFat.Clear(); //체지방량 입력 후 공백처리
            txtInbodyBmi.Clear(); //BMI지수 입력 후 공백처리
            txtInbodyFatRate.Clear();   //체지방률 입력 후 공백처리
            txtInbodyWeight.Focus();   //커서를 InbodyWeight 텍스트박스로 설정
        }

        public void AddInbody(Inbody iby) //인바디 정보 추가하는 함수
        {
            string[] sitems = new string[] { iby.InbodyDate, iby.InbodyWeight, iby.InbodyMuscle, iby.InbodyFat, iby.InbodyBmi,iby.InbodyFatRate };
            //ListViewItem 객체 생성
            ListViewItem Ivi = new ListViewItem(sitems);
            listView1.Items.Add(Ivi); //데이터 등록
            listView1.EndUpdate(); //리스트뷰 종료 선언
            formClear(); //입력 부분 공백으로 싹 다 초기화 시키기
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInbodyEnter_Click(object sender, EventArgs e) //입력 버튼
        {
            listView1.BeginUpdate(); //listview 업데이트 선업
            iby.InbodyDate = txtInbodyDate.Text.ToString();
            iby.InbodyWeight = txtInbodyWeight.Text.ToString();
            iby.InbodyMuscle = txtInbodyMuscle.Text.ToString();
            iby.InbodyFat = txtInbodyFat.Text.ToString();
            iby.InbodyBmi = txtInbodyBmi.Text.ToString();
            iby.InbodyFatRate = txtInbodyFatRate.Text.ToString();

            try //예외처리 클래스 따로 만들어서 해야한다캄 귀찮아죽겠노 ㅋㅋ
            {
                if (txtInbodyDate.Text == "")
                {
                    throw (new Exception("날짜 선택이 되지 않았습니다."));
                }
                else if (txtInbodyWeight.Text == "")
                {
                    throw (new Exception("체중 입력이 되지 않았습니다."));
                }
                else if (txtInbodyMuscle.Text == "")
                {
                    throw (new Exception("골격근량 입력이 되지 않았습니다."));
                }
                else if (txtInbodyFat.Text == "")
                {
                    throw (new Exception("체지방량 입력이 되지 않았습니다."));
                }
                else if (txtInbodyBmi.Text == "")
                {
                    throw (new Exception("BMI 입력이 되지 않았습니다."));
                }
                else if (txtInbodyFatRate.Text == "")
                {
                    throw (new Exception("체지방률 입력이 되지 않았습니다."));
                }
                else
                {
                    AddInbody(iby);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"오류",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnInbodyFix_Click(object sender, EventArgs e) //수정 버튼
        {
            if (listView1.SelectedItems.Count > 0)  //listview에서 항목이 하나 이상 선택되면
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtInbodyDate.Text; //날짜 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[1].Text = txtInbodyWeight.Text;  //체중 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[2].Text = txtInbodyMuscle.Text; //골격근량 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[3].Text = txtInbodyFat.Text; //체지방량 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[4].Text = txtInbodyBmi.Text;  //BMI지수 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[5].Text = txtInbodyFatRate.Text; //체지방률 입력 칸 수정 가
            }
        }

        private void btnInbodyDel_Click(object sender, EventArgs e)  //삭제 버튼
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
                txtInbodyDate.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtInbodyWeight.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtInbodyMuscle.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtInbodyFat.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtInbodyBmi.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtInbodyFatRate.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtInbodyDate.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");
        }

        private void InbodyManage_Load(object sender, EventArgs e)
        {
            txtInbodyDate.Text = monthCalendar1.SelectionStart.ToString("yyyy/MM/dd");

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
                        string inbodydata = sr.ReadLine();
                        if (inbodydata == null) { break; }//멤버 데이터가 없으면 읽기 멈춤
                        string[] sitems = inbodydata.Split(',');

                        iby.InbodyDate = sitems[0].ToString();
                        iby.InbodyWeight = sitems[1].ToString();
                        iby.InbodyMuscle = sitems[2].ToString();
                        iby.InbodyFat = sitems[3].ToString();
                        iby.InbodyBmi= sitems[4].ToString();
                        iby.InbodyFatRate= sitems[5].ToString();

                        AddInbody(iby);
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

        private void btnSaveFile_Click(object sender, EventArgs e) //저장 버튼
        {
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);

            foreach (ListViewItem lvi in listView1.Items)
            {
                iby.InbodyDate= lvi.SubItems[0].Text;
                iby.InbodyWeight = lvi.SubItems[1].Text;
                iby.InbodyMuscle = lvi.SubItems[2].Text;
                iby.InbodyFat= lvi.SubItems[3].Text;
                iby.InbodyBmi= lvi.SubItems[4].Text;
                iby.InbodyFatRate = lvi.SubItems[5].Text;

                sw.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",iby.InbodyDate,iby.InbodyWeight, iby.InbodyMuscle,iby.InbodyFat,iby.InbodyBmi, iby.InbodyFatRate);
            }
            sw.Close();
            fs.Close();
        }
    }
}
