using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;

namespace ViewStateDemo.Windows_Event_ViewerDemo
{
    public class Logger
    {
        public static void Log(Exception exception)
        {

            // Create an instance of StringBuilder. This class is in System.Text namespace
            StringBuilder sbExceptionMessage = new StringBuilder();
            sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
            // Get the exception type
            sbExceptionMessage.Append(exception.GetType().Name);
            // Environment.NewLine writes new line character - \n
            sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
            sbExceptionMessage.Append("Message" + Environment.NewLine);
            // Get the exception message
            sbExceptionMessage.Append(exception.Message + Environment.NewLine + Environment.NewLine);
            sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
            // Get the exception stack trace
            sbExceptionMessage.Append(exception.StackTrace + Environment.NewLine + Environment.NewLine);

            // Retrieve inner exception if any
            Exception innerException = exception.InnerException;
            // If inner exception exists
            while (innerException != null)
            {
                sbExceptionMessage.Append("Exception Type" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.GetType().Name);
                sbExceptionMessage.Append(Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Message" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.Message + Environment.NewLine + Environment.NewLine);
                sbExceptionMessage.Append("Stack Trace" + Environment.NewLine);
                sbExceptionMessage.Append(innerException.StackTrace + Environment.NewLine + Environment.NewLine);

                // Retrieve inner exception if any
                innerException = innerException.InnerException;

            }
            
            string logProvider = ConfigurationManager.AppSettings["logProvider"];
             
             if(logProvider.ToLower() == "database")
             {
                 logToDb(sbExceptionMessage.ToString());
             }
             else if(logProvider.ToLower() == "windowsviewer")
             {
                 //logToWindowViewer(sbExceptionMessage.ToString());
                 //sendEmail(sbExceptionMessage.ToString());
             }

             
            
                       

        }

        public static void logToDb(string exception)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS1"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("spInsertMessage", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ExceptionMsg", exception);
            cmd.Parameters.Add(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //public static void logToWindowViewer(string exception)
        //{
        //    // If the Event log source exists
        //    if (EventLog.SourceExists("BrightTech.com"))
        //    {
        //        // Create an instance of the eventlog
        //        EventLog log = new EventLog("BrightTech");
        //        // set the source for the eventlog
        //        log.Source = "BrightTech.com";
        //        // Write the exception details to the event log as an error
        //        log.WriteEntry(exception, EventLogEntryType.Error);
        //    }
        //}

        //public static void sendEmail(string email)
        //{
        //    MailMessage mailMessage = new MailMessage("sumit753@gmail.com","sumit753@gmail.com");
        //    mailMessage.Body = email;
        //    mailMessage.Subject = "Exception Occurred in Asp.net Project";

        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
        //    smtp.Credentials = new System.Net.NetworkCredential()
        //    {
        //        UserName = "sumit753@gmail.com",
        //        Password = "7nokia_MICROMAX"
        //    };

        //    smtp.EnableSsl = true;
        //    smtp.Send(mailMessage);

        //}
    }
}
    
    
