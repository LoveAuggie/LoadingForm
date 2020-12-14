using LoadingForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime now = DateTime.Now;

        private void button1_Click(object sender, EventArgs e)
        {
            now = DateTime.Now;
            var re = ELoading.Run(Test);
            MessageBox.Show(re);
        }

        private string Test()
        {
            System.Threading.Thread.Sleep(3000);
            return now.ToString("HH:mm:ss.fff") + " - " + DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var re = ELoading.RunWithMsg((actMsg, ins) =>
            {
                actMsg("获取V1的值...");
                var o1 = ins[0].ToString();
                System.Threading.Thread.Sleep(2000);

                actMsg("获取V2的值...");
                var o2 = ins[1].ToString();
                System.Threading.Thread.Sleep(2000);

                actMsg("计算结果...");
                var result = o1 + o2;
                System.Threading.Thread.Sleep(2000);

                return result;
            }, new object[] { "1", "2" },title:"计算示例小标题...");

            MessageBox.Show(re);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var re = ELoading.RunWithMsg((actMsg, ins) =>
            {
                actMsg("获取V1的值...");
                var o1 = ins[0].ToString();
                System.Threading.Thread.Sleep(2000);

                actMsg("获取V2的值...");
                var o2 = ins[1].ToString();
                System.Threading.Thread.Sleep(2000);

                actMsg("计算结果...");
                var result = o1 + o2;
                System.Threading.Thread.Sleep(2000);

                return result;
            }, new object[] { "1", "2" }, cancle: true);

            MessageBox.Show(re);
        }
    }
}
