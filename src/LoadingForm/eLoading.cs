using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoadingForm
{
    public delegate void RunActNoneReturn();
    public delegate object RunAct();
    public delegate TResult RunAct<TResult>();
    public delegate TResult RunAct<T1, TResult>(T1 t1);
    public delegate TResult RunAct<T1, T2, TResult>(T1 t1, T2 t2);
    public delegate TResult RunAct<T1, T2, T3, TResult>(T1 t1, T2 t2, T3 t3);
    public delegate TResult RunAct<T1, T2, T3, T4, TResult>(T1 t1, T2 t2, T3 t3, T4 t4);
    public delegate TResult RunAct<T1, T2, T3, T4, T5, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    public delegate TResult RunAct<T1, T2, T3, T4, T5, T6, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
    public delegate TResult RunMsgAct<TResult>(Action<string> cMsg, object[] inputs);

    public class ELoading
    {
        public static void Run(RunActNoneReturn act, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(new AsyncCallback(form.AsyncCallBack), null);
            });
            form.ShowDialog();
        }

        public static object Run(RunAct act, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return form.AsyncResult;
            }
            return null;
        }

        public static TResult Run<TResult>(RunAct<TResult> act, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, TResult>(RunAct<T1, TResult> act, T1 t1, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, T2, TResult>(RunAct<T1, T2, TResult> act, T1 t1, T2 t2, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, t2, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, T2, T3, TResult>(RunAct<T1, T2, T3, TResult> act, T1 t1, T2 t2, T3 t3, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, t2, t3, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, T2, T3, T4, TResult>(RunAct<T1, T2, T3, T4, TResult> act, T1 t1, T2 t2, T3 t3, T4 t4, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, t2, t3, t4, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, T2, T3, T4, T5, TResult>(RunAct<T1, T2, T3, T4, T5, TResult> act, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, t2, t3, t4, t5, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        public static TResult Run<T1, T2, T3, T4, T5, T6, TResult>(RunAct<T1, T2, T3, T4, T5, T6, TResult> act, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                act.BeginInvoke(t1, t2, t3, t4, t5, t6, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }

        /// <summary>
        /// 带有小标题的统一方法
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="msgAct">小标题的设定委托</param>
        /// <param name="ins">方法参数列表</param>
        /// <param name="title">大标题</param>
        /// <returns></returns>
        public static TResult RunWithMsg<TResult>(RunMsgAct<TResult> msgAct, object[] ins, string title = "", bool cancle = false)
        {
            lForm form = new lForm();
            if (!string.IsNullOrEmpty(title))
            {
                form.Title = title;
            }
            form.Cancle = cancle;
            form.AsyncCall = new Action(() =>
            {
                msgAct.BeginInvoke((str) => { form.childMsg = str; }, ins, new AsyncCallback(form.AsyncCallBack), null);
            });
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return (TResult)form.AsyncResult;
            }
            return default(TResult);
        }
    }
}
