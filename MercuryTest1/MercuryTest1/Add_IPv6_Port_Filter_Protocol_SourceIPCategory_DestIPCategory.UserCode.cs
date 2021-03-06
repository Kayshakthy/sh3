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
    public partial class Add_IPv6_Port_Filter_Protocol_SourceIPCategory_DestIPCategory
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_IPv6_Port_Filter_Protocol_SourceIP_DestIPCategory(string argument1, string argument2, string argument3)
        {
			//select combo box values for protocol, sourceIP, Dest IP
        	//argument1 - protocol, 
        	//argument2 - SourceIP group category
        	//argument3 - DestinationIP group category
        	
//        	Report.Info("------------Inside Update_Combo_Boxes_For_IPv6Filtering_Rule------------- ");
        	Report.Info("------------ Inside Choose_IPv6_Port_Filter_Protocol_SourceIP_DestIPCategory  ------------ ");
        	Report.Info("Protocol(argument1) : "+argument1);
//        	Report.Info("Source IP Group(argument2) : "+argument2);
//			Report.Info("Destination IP Category(argument3) : "+argument3);
			
			Delay.Seconds(5);
	        WebDocument webDocument = "/dom[@domain='192.168.0.1']";
	        
	        //choose protocol
	        Ranorex.SelectTag IPv4protocolTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//select[#'IPv6ProtocolGrp']");
	        Report.Info(IPv4protocolTag.GetInnerHtml().ToString());
	        foreach(Ranorex.OptionTag optTag in IPv4protocolTag.Find(".//option"))
			{	//TO SELECT THE PROTOCOL
	        	if(optTag.InnerText == argument1){
	    				optTag.Selected = true;
	    				//Delay.Seconds(1);
	    				break;	        		
	        	}
	        }
	        Report.Info("Source IP Group(argument2) : "+argument2);
        	//choose source IP group
        	Ranorex.SelectTag IPv6SrcIPGrpTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//select[#'IPv6SrcIPGrp']");
        	Report.Info(IPv6SrcIPGrpTag.GetInnerHtml().ToString());
        	foreach(Ranorex.OptionTag optTag in IPv6SrcIPGrpTag.Find(".//option"))
			{		//TO enable/disable  PORT TRIGGER RULE
        		
	        	if(optTag.InnerText == argument2){
	    				optTag.Selected = true;
	    				//Delay.Seconds(1);
		    			//check Source IP Group
		    			if((argument2 == "single") || (argument2 == "Single")){	// if it is single source Source IP
		    				TestSuite.Current.GetTestCase("Input_Single_SourceIPv6").Checked = true;
		    				TestSuite.Current.GetTestCase("Input_Range_SourceIPv6").Checked = false;
		    			}else if((argument2=="range") || (argument2=="Range")){	//if it is  range source IP
		    				TestSuite.Current.GetTestCase("Input_Range_SourceIPv6").Checked = true;
		    				TestSuite.Current.GetTestCase("Input_Single_SourceIPv6").Checked = false;
		    			}	    				
	    				break;	        		
	        	}      		
        		
        	}
        	Report.Info("Destination IP Category(argument3) : "+argument3);
        	//choose destination Ip group
        	Ranorex.SelectTag IPv6DestIPGrpTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//select[#'IPv6DestIPGrp']");
        	Report.Info(IPv6DestIPGrpTag.GetInnerHtml().ToString());
        	foreach(Ranorex.OptionTag optTag in IPv6DestIPGrpTag.Find(".//option"))
			{		//TO enable/disable  PORT TRIGGER RULE
	        	if(optTag.InnerText == argument3){
	    				optTag.Selected = true;
	    				//Delay.Seconds(1);
		    			//check Source IP Group
		    			if((argument3=="single") || (argument3 == "Single")){	// if it is single source Source IP
		    				TestSuite.Current.GetTestCase("Input_Single_DestIPv6").Checked = true;
		    				TestSuite.Current.GetTestCase("Input_Range_DestIPv6").Checked = false;
		    			}else if((argument3=="range") || (argument3 == "Range")){	//if it is  range source IP
		    				TestSuite.Current.GetTestCase("Input_Range_DestIPv6").Checked = true;
		    				TestSuite.Current.GetTestCase("Input_Single_DestIPv6").Checked = false;
		    			}	    				
	    				break;	        		
	        	}         		
        	}
        	Report.Screenshot();
        	
        }

    }
}