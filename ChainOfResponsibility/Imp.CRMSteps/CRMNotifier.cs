using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Text;
using Base.Interface;

namespace Imp.CRMSteps
{
    public class CRMNotifier : ICRMStep
    {
        private ICRMStep successor;
        private SmtpClient smtpClient;

        public CRMNotifier(Hashtable table, ICRMStep next)
        {
            successor = next;
            CreateSMTPClient();
        }
        public void RaiseRequest(CRMData data)
        {
            Console.WriteLine("\nNew Request Raised.. Sending Emails.. ");
            string emailBody = FormatEmail(data);
            SendMail(emailBody, data);
            successor?.RaiseRequest(data);
        }

        public CRMData GetStatus(string trackingId)
        {
            return successor != null ? successor.GetStatus(trackingId) : null;
        }

        public void EscalateIssue(string trackingId, CRMData data)
        {
            // Send Escalation Mail
            SendEscalationMail(data);
            successor?.EscalateIssue(trackingId, data);
        }

        private void SendEscalationMail(CRMData data)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("\n\nNEW CRM Request Raised");
            builder.AppendLine(string.Format("\t{0}:{1}", "TrackingID", data.TrackingId));
            builder.AppendLine(string.Format("\t{0}:{1}", "Date Raised", data.DateRaised));
            builder.AppendLine(string.Format("\t{0}:{1}", "TYPE", data.CRMType));
            builder.AppendLine(string.Format("\t{0}:{1}", "Department", data.OrgDept));
            builder.AppendLine(string.Format("\t{0}:{1}", "Status", data.CRMStatus));
            builder.AppendLine(string.Format("\t{0}:{1}", "Description", data.RequestDescription));

            string body = builder.ToString();

            // Send email to all
            var mailMessage = new MailMessage
            {
                From = new MailAddress("email"),
                Subject = string.Format("{0} Escalating REQUEST RAISED WITH ID {1} BY {2}", data.CRMStatus, data.TrackingId, data.RaisedBy),
                Body = body,
                IsBodyHtml = false,
            };
            mailMessage.To.Add(data.OrgDept.DeptEscalationEmailId);
            mailMessage.CC.Add(data.RaisedByEmail);
            mailMessage.CC.Add(data.OrgDept.ContactEmailId);

            smtpClient.Send(mailMessage);

        }

        private string FormatEmail(CRMData data)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("\n*****NEW CRM Request Raised******");
            builder.AppendLine(string.Format("\t{0}: {1}", "TrackingID", data.TrackingId));
            builder.AppendLine(string.Format("\t{0}: {1}", "Date Raised", data.DateRaised));
            builder.AppendLine(string.Format("\t{0}: {1}", "TYPE", data.CRMType));
            builder.AppendLine(string.Format("\t{0}: {1}", "Department", data.OrgDept.Name));
            builder.AppendLine(string.Format("\t{0}: {1}", "Status", data.CRMStatus));
            builder.AppendLine(string.Format("\t{0}: {1}", "Description", data.RequestDescription));

            string temp = builder.ToString();
            Console.WriteLine(temp);
            return temp;
        }

        private void SendMail(string emailBody, CRMData data)
        {
            try
            {
                // Send email to all
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("email"),
                    Subject = string.Format("{0} REQUEST RAISED WITH ID {1} BY {2}", data.CRMStatus, data.TrackingId, data.RaisedBy),
                    Body = emailBody,
                    IsBodyHtml = false,
                };
                mailMessage.CC.Add(data.RaisedByEmail);
                mailMessage.To.Add(data.OrgDept.ContactEmailId);

                smtpClient.Send(mailMessage);
            }
            catch(Exception ex)
            {

            }
        }

        private void CreateSMTPClient()
        {
            smtpClient = new SmtpClient("smtp.ORGNAME.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("senderemail", "senderpassword"),
                EnableSsl = true,
            };
        }
    }
}
