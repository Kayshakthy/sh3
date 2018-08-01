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
    public partial class Select_All_IP_Port_Filter_To_Enable
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Select_Ipv4_Port_Filter_To_Enable()
        {
        	
			// code to select all the rows in IP Port Filter table
        	
        	Report.Info("---inside Select_Ipv4_Port_Filter_To_Enable --- ");
        	
        	Delay.Seconds(40);
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            //Report.Info(webDocument.GetHtml());
            
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'ipv4FilterTable']"); 
            
            //Count the total no of IPv4 port Filter rules (rows)
	     	IList<TrTag> totalIPv4Rules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalIPv4Rules.Count;   
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("IPv4 Port Filter ",totalPortRules);
	     	
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("IPv4 Port Filter ","There are no active IP Port rules to Enable !!");
	     		TestSuite.Current.GetTestCase("Enable_All_IPv4Port_Filtering_Rules").Checked = false;
	     		return;
	     	}else{
	     		
	     		Report.Info(" There are " + rulesCount.ToString() + " IPv4 Port Filter Rules to Enable !!! ");
	     		
	     		IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				Report.Info("Total colsCount",colsCount.ToString());
				int j=1;
				int delCount = 0;
				int delCheck = 0;
				int rowCount=1;
				foreach(TdTag MacCol in cols) {
					//Report.Info("------Row : ",rowCount.ToString());
					//Report.Info("---------Column : ",j.ToString());
					//Report.Info(MacCol.InnerText);
					if (j == 6){	//enable or disable ?
						//Report.Info("---Checking  enabled box ---");
						 String newPath = "";
						 //newPath = MacCol.GetPath() + "/input[#'ipv4FilterTable-Enabled-"+delCheck+"']";
						 newPath ="/dom[@domain='192.168.0.1']//input[#'ipv4FilterTable-Enabled-"+delCheck+"']";
						 Ranorex.InputTag IP4PortFilterTableEnabledTag = newPath;
						if (IP4PortFilterTableEnabledTag.Checked.ToString() == "False"){
						 	// IP4PortFilterTableEnabledTag is  disabled ?
				        	//Report.Info("----------------- IP4PortFilterTableEnabledTag was false ---");
				        	//Delay.Seconds(1);
				        	//IP4PortFilterTableEnabledTag.Checked = "True";	//check the checkbox to enable
				        	IP4PortFilterTableEnabledTag.PerformClick();
				        	Delay.Seconds(1);
					        string rst = "The following MACFilter_Filtering rule is enabled permanently !!!";
							Report.Success(rst);				        	
				        }else{
						 	//IP4PortFilterTableEnabledTag is already enabled
							Report.Info(" IP4PortFilterTableEnabledTag is already enabled ");
						}
						Delay.Seconds(1);
			        	//Report.Screenshot("MACFilter_Filtering",macAddress.Element,true);
			        	Report.Screenshot("Ip4PortFilter_Filtering",MacCol.Element,true);
						delCount++;
						delCheck++;						 
					}
					if(j==7){	//delete checkbox?
						j=0;
						rowCount++;
					}
					j++;
				}//end of for-loop
				if(delCount == rulesCount){
					// to check whether it selected all rows for enable
					string rst = "The following "+ rulesCount.ToString() + " IP4 Port Filtering rules are enabled permanently !!!";
					Report.Success(rst);
					Delay.Seconds(1);
					Report.Screenshot("Ip4PortFilter_Filtering",myTable.Element,true);	
				}else{
					Report.Info(" All IP4 Port Filtering rules are not enabled !!! ");
				}				
			
	     	}	//end of if-else
        }

    }
}