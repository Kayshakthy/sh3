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
    public partial class Validate_WPS_PIN_Length
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_WPS_PIN()
        {
        	Delay.Seconds(5);
	        WebDocument webDocument = "/dom[@domain='192.168.0.1']";

			TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PriSecurityStatusTable']"); 
			IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");
			//Report.Info(" Total columns ",cols.Count.ToString());

			bool isValidPIN = true;
			foreach(TdTag col in cols)  
		    {
				Report.Info("WPS PIN Value",col.InnerText);
				Report.Info("WPS PIN Length",col.InnerText.Length.ToString());
				if(col.InnerText.Length < 8){
					isValidPIN = false;
				}
				break;
			}
			if(isValidPIN){
				Report.Success("Valid WPS PIN");
			}else{
				Report.Failure("Invalid WPS PIN");
			}
        	TableTag table_WPS_PIN = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PriSecurityStatusTable']");
        	Report.Screenshot("WPS_PIN_Length",table_WPS_PIN.Element,false);        	
        }

    }
}