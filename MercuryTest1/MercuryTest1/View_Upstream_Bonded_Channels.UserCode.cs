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
    public partial class View_Upstream_Bonded_Channels
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void View_UpstreamBonded_Channels()
        {
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'UpstremChannel']"); 
	     	IList<TrTag> totalChannel = myTable.Find<TrTag>("./tbody//tr");
	     	int rowsCount = totalChannel.Count;   
	     	string totalRowsCnt = "Total Rows : "+rowsCount.ToString();
	     	Report.Info("Total Items ",totalRowsCnt);   
	     	
	     	Report.Screenshot("UpstreamBonded_Channels Status",myTable.Element);
	     	Delay.Seconds(2);            	
        }

    }
}