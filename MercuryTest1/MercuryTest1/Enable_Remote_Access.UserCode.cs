﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

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
    public partial class Enable_Remote_Access
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
            Delay.Seconds(15);
        }

        public void Capture_Remote_Access_Settings()
        {
        	//capture the screenshot
        	/*
        	Delay.Seconds(5);
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            DivTag RemoteAccess_field = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'RemoteAccess_field']");
            */
           //Delay.Seconds(15);
           Report.Success("Remote_Access is Enabled Successfully !!!");
           Report.Screenshot("Remote_Access",repo.WebDocument19216801.FormHeader,true);
        		
        }

    }
}