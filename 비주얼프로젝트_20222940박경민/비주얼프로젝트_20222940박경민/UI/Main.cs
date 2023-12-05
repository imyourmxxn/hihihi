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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConectMemManage_Click(object sender, EventArgs e)
        {
            MemManage memManage = new MemManage();
            memManage.Show();

        }

        private void btnConectGoodsManage_Click(object sender, EventArgs e)
        {
            GoodsManage goodsManage = new GoodsManage();
            goodsManage.Show();
        }

        private void btnConnectMemo_Click(object sender, EventArgs e)
        {
            MemoManage memo = new MemoManage();
            memo.Show();
        }

        private void btnConnectWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectInbody_Click(object sender, EventArgs e)
        {
            InbodyManage inbody= new InbodyManage();
            inbody.Show();
        }
    }
}
