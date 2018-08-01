/*
 * Created by Ranorex
 * User: KiruShakthy
 * Date: 11/4/2015
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace ArrisTest
{
    /// <summary>
    /// Description of MailLogger.
    /// </summary>
    [TestModule("5405AF8A-C3FC-4D3B-AC5A-CA3304B44BE1", ModuleType.UserCode, 1)]
    public class MailLogger : IReportLogger
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MailLogger()
        {
            // Do not delete - a parameterless constructor is required!
        }
        public MailLogger(string from, string to, string subject)
		{
        	/*
    			mail = new MailMessage(from, to);
    			mail.Subject = subject;
    			*/
		}

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
      /*  void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    	*/
		public bool PreFilterMessages {
			get {
				throw new NotImplementedException();
			}
		}
    	
		public void Start()
		{
			throw new NotImplementedException();
		}
    	
		public void End()
		{
			throw new NotImplementedException();
			/*
			    try
			    {
			    	
			        //SmtpClient smtpClient = new SmtpClient(Host, Port);
			        //smtpClient.Send(mail);
			        
			    }
			    catch (Exception ex)
			    {
			        Console.WriteLine(ex);
			    }
			*/
		}
    	
		public void LogText(ReportLevel level, string category, string message, bool escape, IDictionary<string, string> metaInfos)
		{
			throw new NotImplementedException();
		}
		
    	public void LogText(ReportLevel level, string category, string message, bool escape)
		{
    		/*
    		mail.Body += string.Format("[{0}][{1, -7}][{2}]: {3}n",
        		GetTimeStamp(), level, category, message);
        		*/
		}
		public void LogData(ReportLevel level, string category, string message, object data, IDictionary<string, string> metaInfos)
		{
			throw new NotImplementedException();
		}
    }
}
