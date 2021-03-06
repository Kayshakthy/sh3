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
    public partial class Select_All_IPv6_Port_Filtering_Rules
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows1=0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            Delay.Seconds(60);
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'ipv6FilterTable']"); 
            //count the rows
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows1 = rows1.Count;
//            Report.Info("IPv6 Port Filter(init) ",TotalRows1.ToString());
        }

        public void Select_Ipv6_Port_Rules(string argument1)
        {
 			// code to select all the rows in IPv6 Port Filter table
        	
        	//Report.Info("---inside choose_all_ipport_filter_rules_to_delete --- ");
        	string selectOption = argument1;
        	Report.Info(selectOption);
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            webDocument.WaitForDocumentLoaded();
            Report.Info(TotalRows1.ToString());
        	if(TotalRows1 <=5 ){
        		Delay.Seconds(10);	// to load the pages
        	}else if((TotalRows1 >5 && TotalRows1 <=10) ){
        		Delay.Seconds(15);	// to load the pages
        	}else if((TotalRows1 >10 && TotalRows1 <=20) ){
        		Delay.Seconds(20);	// to load the pages
        	}else{
        		Delay.Seconds(60);	// to load the pages
        	}  
            //Report.Info(webDocument.GetHtml());
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'ipv6FilterTable']"); 
            //Count the total no of IPv6 port Filter rules (rows)
	     	IList<TrTag> totalIPv6Rules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalIPv6Rules.Count;   
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("IPv6 Port Filter ",totalPortRules);
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("IPv6 Port Filter ","There are no active rules to delete !!");
	     		if(selectOption == "DELETE"){
	     			TestSuite.Current.GetTestCase("Delete_All_IPv6Port_Filtering_Rules").Checked = false;
	     		}else if(selectOption == "DISABLE"){
		     		TestSuite.Current.GetTestCase("Disable_All_IPv6Port_Filtering_Rules").Checked = false;
	     		}else if(selectOption == "ENABLE"){
	     			TestSuite.Current.GetTestCase("Enable_All_IPv6Port_Filtering_Rules").Checked = false;
	     		}
	     		return;
	     	}else{
	     		//Report.Info(" Rules are there to delete !!! ");
	     		//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
//				Report.Info("Total colsCount",colsCount.ToString());
				int j=1;
				int delCount =0;	//for delete
				int delCheck = 0;	//for disable
				bool noFilterRule=false;
				foreach(TdTag ipv6Col in cols) {
//					Report.Info(ipv6Col.InnerText);
//					Report.Info("j(before IF)   : " + j);
					if(colsCount == 1 && ipv6Col.InnerText.StartsWith("No filtering rule applied!") ){	
						Report.Info("There are No filtering rule to Delete");
						noFilterRule=true;
						break;
						//return;
					}else if(j == 3){
			        		//Protocol
			        		if(ipv6Col.InnerText.ToString() != null){
			        			String protocol = ipv6Col.InnerText.ToString();
//			        			Report.Info("----------------- Protocol : " + protocol);
			        		}
					}else if((j == 7) && (selectOption == "DISABLE")){
						Report.Info("---Check for  DISABLE  ---");
						//Report.Info("---Checking  enabled box ---");
						 String newPath = "";
						 //newPath = MacCol.GetPath() + "/input[#'ipv4FilterTable-Enabled-"+delCheck+"']";
						 newPath ="/dom[@domain='192.168.0.1']//input[#'ipv6FilterTable-Enabled-"+delCheck+"']";
						 Ranorex.InputTag IP6PortFilterTableEnabledTag = newPath;
						if (IP6PortFilterTableEnabledTag.Checked.ToString() == "True"){
						 	// IP4PortFilterTableEnabledTag is already Enabled
				        	Report.Info("----------------- IP6PortFilterTableEnabledTag was True ---");
				        	IP6PortFilterTableEnabledTag.Checked = "False";	//uncheck the checkbox to disable
				        	Delay.Seconds(1);
					        string rst = "The following IPv6PortFilter_Filtering rule is disabled now !!!";
							Report.Success(rst);				        	
			        	
				        }else{
						 	//IP4PortFilterTableEnabledTag.PerformClick();	//to enable
						 	//IP4PortFilterTableEnabledTag is already disabled
							Report.Info(" IPv6PortFilterTableEnabledTag is already disabled ");
						}
			        	//Report.Screenshot("MACFilter_Filtering",macAddress.Element,true);
			        	Report.Screenshot("IPv6PortFilter_Filtering",ipv6Col.Element,true);
			        	Delay.Seconds(1);
						//j=0;
						delCount++;
						delCheck++;						
						
					}else if((j == 7) && (selectOption == "ENABLE")){
						Report.Info("---Check for  ENABLE  ---");
						 //Report.Info("---Checking  enabled box ---");
						 String newPath = "";
						 //newPath = MacCol.GetPath() + "/input[#'ipv4FilterTable-Enabled-"+delCheck+"']";
						 newPath ="/dom[@domain='192.168.0.1']//input[#'ipv6FilterTable-Enabled-"+delCheck+"']";
						 Ranorex.InputTag IP6PortFilterTableEnabledTag = newPath;
						if (IP6PortFilterTableEnabledTag.Checked.ToString() == "False"){
						 	// IP6PortFilterTableEnabledTag is  disabled ?
				        	//Report.Info("----------------- IP6PortFilterTableEnabledTag was false ---");
				        	//Delay.Seconds(1);
				        	//IP6PortFilterTableEnabledTag.Checked = "True";	//check the checkbox to enable
				        	IP6PortFilterTableEnabledTag.PerformClick();
				        	Delay.Seconds(1);
					        string rst = "The following IP6PortFilter_Filtering rule is enabled permanently !!!";
							Report.Success(rst);				        	
				        }else{
						 	//IP6PortFilterTableEnabledTag is already enabled
							Report.Info(" IP6PortFilterTableEnabledTag is already enabled ");
						}
						Delay.Seconds(1);
			        	Report.Screenshot("Ip6PortFilter_Filtering",ipv6Col.Element,true);
						delCount++;
						delCheck++;							
					}else if ((j == 8) && (selectOption == "DELETE")){
						Report.Info("---Check for  delete  ---");
						WebElement webElement = ipv6Col.Element;
						Delay.Seconds(2);
						webElement.Click();
						Report.Screenshot("Delete Ipv6_Port",webElement,true);
						//j=0;
						delCount++;
					}else if(j == 9){	//inbound or outbound
						j=0;
					}
//					Report.Info("j(after IF)   : " + j);
					j++;

				}
				if(noFilterRule){
					return;
				}
				if(delCount == rulesCount){
					// to check whether it selected all rows for deletion/disable
					string rst="" ;
					if(selectOption == "DELETE"){
						rst = "The following "+ rulesCount.ToString() + " IPv6Port_Filtering rules are deleted permanently !!!";
					}else if(selectOption == "DISABLE"){
						rst = "The following "+ rulesCount.ToString() + " IPv6Port_Filtering rules are disabled permanently !!!";
					}
					Report.Success(rst);
					Report.Screenshot("IPv6Port_Filtering",myTable.Element,true);	
					//Report.Screenshot("Delete PortFwd",webElement,true);
				}else{
					if(selectOption == "DELETE"){
						Report.Info(" All rows are not deleted !!! ");
					}else if(selectOption == "DISABLE"){
						Report.Info(" All rows are not disabled !!! ");
					}
				}
	     	}
        }

    }
}