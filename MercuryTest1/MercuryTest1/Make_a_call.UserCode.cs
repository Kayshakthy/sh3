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
    public partial class Make_a_call
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void DoDelay()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.");
            Delay.Duration(60000, false);
        }

        public void Mouse_Click_ButtonRun()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SageInstruments960CProgramFiles.ButtonRun' at 40;16.", repo.SageInstruments960CProgramFiles.ButtonRunInfo);
            
            int n = 0;
            while (n < 5)
            {
            repo.SageInstruments960CProgramFiles.ButtonRun.Click("40;16");
            DoDelay();
            n++;
            }
        }

    }
}