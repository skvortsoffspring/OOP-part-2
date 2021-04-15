using System;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    public interface INotice
    {
        void SendEmail();
        void SendSms();
    }

    internal class NoticeVip : INotice
    {
        private string msgVip = Form1._sending.messageVip.Text;
                public void SendEmail()
                {
                    Form1._sending.OutBox.Text += $"Сообщение: \"{msgVip}\" VIP клиенту" + Environment.NewLine;
                }
        
                public void SendSms()
                {
                    Form1._sending.OutBox.Text += $"Сообщение \"{msgVip}\" SMS сервиса VIP клиенту"  + Environment.NewLine;;
                }
            }

    internal class NoticeNormal : INotice
    {
        private string msgNormal = Form1._sending.MessageNormal;

        public void SendEmail()
        {
            Form1._sending.OutBox.Text += $"Сообщение \"{msgNormal}\" отправлено на почту"  + Environment.NewLine;;
        }

        public void SendSms()
        {
            Form1._sending.OutBox.Text += $"Сообщение \"{msgNormal}\" отправлено посредством SMS сервиса клиенту" + Environment.NewLine;;
        }

    }

}