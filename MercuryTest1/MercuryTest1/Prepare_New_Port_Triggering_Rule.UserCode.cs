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
    public partial class Prepare_New_Port_Triggering_Rule
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void New_Port_Triggering_Rule(string argument1, string argument2)
        {
		// argument1 - protocol			
        	
		Report.Info("Protocol :"+argument1);
        //Report.Info(" Inside Populate_Port_Triggering_Combo_Boxes  " + "proto : "+argument1 + ": Enabled?:"+argument2);
        
        WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        
        Ranorex.SelectTag protocolTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//select[#'Protocol']");
       // Report.Info(protocolTag.GetInnerHtml().ToString());
		foreach(Ranorex.OptionTag optTag in protocolTag.Find(".//option"))
		{	//TO SELECT THE PROTOCOL
     		//Console.WriteLine(optTag.InnerText);
     		Report.Info(optTag.InnerText);
     		if(optTag.InnerText == argument1){
     			Report.Info("argument1 matching:: "+argument1 );
     			   // OptionTag option = "//rxpath/to/option";  
    				//option.Selected = true;  
    				optTag.Selected = true;
    				break;
     		}
		}

        	// argument2 - Enabled or Disabled
        	Report.Info("RuleStatus : "+argument2);
			//Ranorex.SelectTag enableTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//select[#'Enabled']");
	        Ranorex.SelectTag enableTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'tr_Enabled']/select[@id='Enabled']");
	        //Report.Info(enableTag.GetInnerHtml().ToString());
			foreach(Ranorex.OptionTag optTag in enableTag.Find(".//option"))
			{		//TO enable/disable  PORT TRIGGER RULE
	     		//Console.WriteLine(optTag.InnerText);
	     		Report.Info(optTag.InnerText);
	     		if(optTag.InnerText == argument2){
	     			//Report.Info("argument2 matching:: "+argument2 );
	    				optTag.Selected = true;
	    				break;
	     		}
			}
			
		
        }

    }
}