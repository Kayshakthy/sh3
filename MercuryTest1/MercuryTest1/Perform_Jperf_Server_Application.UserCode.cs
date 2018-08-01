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
    public partial class Perform_Jperf_Server_Application
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_Output()
        {
        	//check protocol type
        	Report.Info(this._Server_Protocol);
        	if(this._Server_Protocol == "UDP"){
        		TestSuite.Current.GetTestCase("Choose_Server_UDP").Checked = true;
        		TestSuite.Current.GetTestCase("Choose_Server_TCP").Checked = false;
        	}else if(this._Server_Protocol == "TCP"){
        		TestSuite.Current.GetTestCase("Choose_Server_TCP").Checked = true;
        		TestSuite.Current.GetTestCase("Choose_Server_UDP").Checked = false;
        	}
        	
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='bin/iperf.exe -s -P 0 -i 1 -p 22 -f k\n------------------------------------------------------------\nServer listening on TCP port 22\nTCP window size: 8.00 KByte (default)\n------------------------------------------------------------\n') on item 'JPerf202NetworkPerformanceMeasur.Output'.", repo.JPerf202NetworkPerformanceMeasur.OutputInfo);
            //Validate.Attribute(repo.JPerf202NetworkPerformanceMeasur.OutputInfo, "Text", "bin/iperf.exe -s -P 0 -i 1 -p 22 -f k\n------------------------------------------------------------\nServer listening on TCP port 22\nTCP window size: 8.00 KByte (default)\n------------------------------------------------------------\n");
            
            Delay.Seconds(10);
            string ServerResponse = repo.JPerf202NetworkPerformanceMeasur.Output.TextValue;
            //need to perform validation on the response 
            Report.Log(ReportLevel.Info,"Server Response",ServerResponse);
            
        }

    }
}