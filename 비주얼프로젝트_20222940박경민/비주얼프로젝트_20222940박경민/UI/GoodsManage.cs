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

namespace 비주얼프로젝트_20222940박경민
{
    public partial class GoodsManage : Form
    {
        Goods goods = new Goods();
        const string fname = "goodsdata.csv";//기구 상태 csv파일로 저장하기
        
        public GoodsManage()
        {
            InitializeComponent();
        }

        public void formClear()
        {
            txtGoodsName.Clear(); //기구명 입력 후 공백처리
            txtGoodsNum.Clear(); //기구 갯수 입력 후 공백처리
            txtGoodsStatue.Clear();   //기구 상태 입력 후 공백처리
            txtGoodsName.Focus();   //커서를 Name 텍스트박스로 설정
        }

        //기구 추가하는 함수
        public void AddGoods(Goods goods)
        {
            string[] sitems = new string[] { goods.GoodsName, goods.GoodsNum, goods.GoodsStatue };
            //ListViewItem 객체 생성
            ListViewItem Ivi = new ListViewItem(sitems);
            listView1.Items.Add(Ivi); //데이터 등록
            listView1.EndUpdate(); //리스트뷰 종료 선언
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtGoodsName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtGoodsNum.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtGoodsStatue.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }

        }

        //기구 데이터 수정 버튼
        private void btnGoodsFix_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)  //listview에서 항목이 하나 이상 선택되면
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtGoodsName.Text; //기구명 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[1].Text = txtGoodsNum.Text;  //기구 갯수 입력 칸 수정 가능
                listView1.SelectedItems[0].SubItems[2].Text = txtGoodsStatue.Text; //기구 상태 입력 칸 수정 가능
            }
        }

        //기구 데이터 삭제 버튼
        private void btnGoodsClear_Click(object sender, EventArgs e) 
            {
                if (listView1.SelectedItems.Count > 0)//listView1의 항목중 하나가 선택되면
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]); //해당 정보 삭제 기능
                }
            }

        //기구 데이터 저장 버튼
        private void btnGoodsSave_Click(object sender, EventArgs e) 
            {
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);

            foreach (ListViewItem lvi in listView1.Items)
            {
                goods.GoodsName = lvi.SubItems[0].Text;
                goods.GoodsNum = lvi.SubItems[1].Text;
                goods.GoodsStatue = lvi.SubItems[2].Text;
                sw.WriteLine("{0}, {1}, {2}", goods.GoodsName, goods.GoodsNum, goods.GoodsStatue);
            }
            sw.Close();
            fs.Close();
        }

        //창닫기 버튼
        private void btnGoodsClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        //기구 데이터 리스트뷰에 등록
        private void btnEnter_Click(object sender, EventArgs e)
            {
                listView1.BeginUpdate(); //listview 업데이트 선업
                goods.GoodsName = txtGoodsName.Text.ToString();
                goods.GoodsNum = txtGoodsNum.Text.ToString();
                goods.GoodsStatue = txtGoodsStatue.Text.ToString();
                AddGoods(goods);
                formClear(); //입력 부분 공백으로 싹 다 초기화 시키기
            }


        private void GoodsManage_Load(object sender, EventArgs e)
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
                        string goodsdata = sr.ReadLine();
                        if (goodsdata == null) { break; }//멤버 데이터가 없으면 읽기 멈춤
                        string[] sitems = goodsdata.Split(',');
                        goods.GoodsName = sitems[0].ToString();
                        goods.GoodsNum = sitems[1].ToString();
                        goods.GoodsStatue= sitems[2].ToString();

                        AddGoods(goods);
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
    }
    }
