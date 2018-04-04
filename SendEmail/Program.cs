using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SendEmail
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MailMessage mailObject = new MailMessage();
            //设置发件人
            mailObject.From = new MailAddress("wenqq2_flydog16@163.com");
            //设置收件人
            mailObject.To.Add(new MailAddress("wenqq2_flydog16@163.com"));
            //设置邮件主题
            mailObject.SubjectEncoding = Encoding.UTF8;
            mailObject.Subject = "mike测试邮件";

            mailObject.BodyEncoding = Encoding.UTF8;//编码
            mailObject.Body = "我是mike，这是一个测试邮件";
            mailObject.Priority = MailPriority.High;

            //创建一个发送邮件的对像 服务地址和端口
            SmtpClient smtpClient = new SmtpClient("smtp.163.com", 25);
            //帐号密码一定要正确
            smtpClient.Credentials = new NetworkCredential("wenqq2_flydog16", "aa593650");
            smtpClient.Send(mailObject);
            Console.WriteLine("发送完毕！");

        }
    }
}
