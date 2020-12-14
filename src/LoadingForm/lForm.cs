using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingForm
{
    public partial class lForm : Form
    {
        public lForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string childMsg
        {
            get { return label2.Text; }
            set
            {
                this.Invoke(new Action(() => { label2.Text = value; }));

            }
        }

        public bool Cancle
        {
            get { return btnCancle.Visible; }
            set { btnCancle.Visible = value; }
        }

        private void lForm_Shown(object sender, EventArgs e)
        {
            if (AsyncCall == null)
                this.DialogResult = DialogResult.Cancel;
            else
                AsyncCall.Invoke();
        }

        internal Action AsyncCall;

        internal object AsyncResult;

        internal void AsyncCallBack(IAsyncResult iar)
        {
            try
            {
                var ar = iar as AsyncResult;
                if (ar == null)
                    this.DialogResult = DialogResult.None;
                else
                {
                    dynamic d = ar.AsyncDelegate as dynamic;
                    this.AsyncResult = d.EndInvoke(iar);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
