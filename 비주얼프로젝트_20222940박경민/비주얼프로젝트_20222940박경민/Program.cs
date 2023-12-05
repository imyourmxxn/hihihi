using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비주얼프로젝트_20222940박경민
{
    public class Goods
    {
        public string GoodsName { get; set; }
        public string GoodsNum { get; set; }
        public string GoodsStatue { get; set; }
    }

    public class Memo
    {
        public string MemoDate { get; set; }
        public string MemoContext { get; set; }
    }

    public class Member
    {
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Tel { get; set; }
        public string Gender { get; set; }
    }
}
public class Inbody
    {
        public string InbodyDate { get; set; }
        public string InbodyWeight { get; set; }
        public string InbodyMuscle { get; set; }
        public string InbodyFat { get; set; }
        public string InbodyBmi { get; set; }
        public string InbodyFatRate { get; set; }
    }
    class Human
    {

    }
    class Trainer : Human
    {

    }

    class Customer : Human
    {

    }

    class 
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrainerLogin());
        }
    }
}
