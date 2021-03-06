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
    public partial class Choose_All_Port_Forwarding_Rules
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows = 0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
            Report.Info("---inside init - Choose_All_Port_Forwarding_Rules() ---");
            Delay.Seconds(45);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
//            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portForwardingTable']"); //as per 9.1.116BA (3.11)
            ///dom[@domain='192.168.0.1']//table[#'portTriggeringTable']
            //highlight the new port triggering rule
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            Report.Info(" TotalRows(Before Add)",TotalRows.ToString());                 
        }

        public void Choose_all_port_fwd_rules_to_delete()
        {
        	//choose all port forwarding rules
        	//string localIP="",localStartPort="",localEndPort="",externalStartPort="",externalEndPort="";
        	
        	Delay.Seconds(30);
        	
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            
            //IList<TableTag> Tb = webDocument.FindChildren<TableTag>();
            //Report.Info(Tb.Count.ToString());
            
            //Report.Info(webDocument.GetHtml());
            
            
            //TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); 
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");  //As per R3.5 (9.1.116J)

			//Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	 
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Port Forwarding ",totalPortRules);
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("Port Forwarding ","There are no active rules to delete !!");
	     		TestSuite.Current.GetTestCase("Delete_All_Port_Forward_Rules").Checked = false;
	     		return;
	     	}
            
            //walkthrough the column values
			IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
			int colsCount = cols.Count;
			Report.Info("Total colsCount",colsCount.ToString());
			int j=1;
			foreach(TdTag col in cols)  
	    	{
				//Report.Info(col.InnerText);
				/*
				if(j==1){
					//Ip Address
					localIP = col.InnerText;
				}else if(j==2){
					//Local start port
					localStartPort = col.InnerText;
				}else if(j==3){
					//Local end port
					localEndPort = col.InnerText;
				}else if(j==4){
					//External start port
					externalStartPort = col.InnerText;
				}else if(j==5){
					//External end port
					externalEndPort = col.InnerText;
				}
				*/
				if (j ==6){
					
					//if((localIP==argument1) && (localStartPort== argument2)&& (localEndPort == argument3)&& (externalStartPort == argument4)&& (externalEndPort ==argument5) ){
						//Report.Info("---Check the delete box ---");
						//click the delete checkbox
						WebElement webElement = col.Element;
						Delay.Seconds(2);
						webElement.Click();
						Report.Screenshot("Delete PortFwd",webElement,true);
	        			Report.Info("Delete Checkbox Clicked");
					//}
					j=0;
				}
				j++;
			}	//end of foreach
        }

        public void Choose_all_port_forward_rules_to_delete()
        {	//Implemented based on R3.5 ( 9.1.116J) 
            //Delay.Seconds(15);
            Report.Info("inside Choose_all_port_forward_rules_to_delete");
            Report.Info(" TotalRows : " + TotalRows);
            if(TotalRows <10){
				Delay.Seconds(30);
        	}else if(TotalRows >10 && TotalRows <20){
        		Delay.Seconds(40);
        	}else if(TotalRows >20 && TotalRows <30){
        		Delay.Seconds(50);
        	}else if(TotalRows >30){
        		Delay.Seconds(60);
        	}            
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            webDocument.WaitForDocumentLoaded();
            //TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); 
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portForwardingTable']");  //As per R3.5 (9.1.116J)
            
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	//Report.Info("Port Forwarding ",totalPortRules);
	     	bool isRuleExist=true;
	     	if(rulesCount > 0){
	     		//Report.Info("Total Rules",totalPortRules);
	     		// is there are any active rules ??
		     	//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				int j=1;
				//Report.Info("Total colsCount",colsCount.ToString());
				foreach(TdTag col in cols)  
		    	{  
					Report.Info("Column #",j.ToString());
		        	//Report.Info("Column Value",col.InnerText); 
					//if(j == 1 && col.InnerText.StartsWith("No forwarding rule!")){	//9.1.116u
		        	if(j == 1 && col.InnerText.StartsWith("No forwarding rule applied!")){	//9.1.116v(R3.7.1)
//						Report.Failure("PortForwardingRule","There are no active port forwarding rules to delete !!");
						Report.Success("PortForwardingRule","There are no active port forwarding rules to delete !!");
						TestSuite.Current.GetTestCase("Delete_All_Port_Forward_Rules").Checked = false;
						isRuleExist=false;
						//return;
						break;
					}		        	
					if(j==6){
		        		//delete ?
		        		//Report.Info("Deleting this port forward rule ?");
		        		IList<InputTag> inputVals = col.Find<InputTag>("./input");
		        		//Report.Info("input count :  "+inputVals.Count);
		        		foreach(InputTag inputVal in inputVals){
		        			Ranorex.InputTag testTag = inputVal;
		        			Report.Info(inputVal.GetPath().ToString());
		        			if(testTag.Checked.ToString() == "False"){
		        				Report.Info(" portForwardingTableDeleteTag is currently  not seleted to delete");
		        				//inputVal.Checked="True";
		        				inputVal.PerformClick();
		        				Delay.Seconds(5);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is  selected for deletion...");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}else{
		        				//Report.Info(" portForwardingTableEnabledTag is currently enabled ");
							    //inputVal.PerformClick();
							    Delay.Seconds(5);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is already selected for deletion !!!");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}
		        			
		        		}//end of for-loop : InputTag
		        		j=0;;//reselt the column
		        	}
		        	j++; 
		        	
				}// end of FOR-LOOP :TdTag
				
				//Report.Log(ReportLevel.Success,"The following port forwarding rule(s) are deleted");

				if(isRuleExist){
					string finalRst = "The following " + rulesCount.ToString() +" Port Forwarding Rules are deleted from the table";
					//Report.Log(ReportLevel.Success,finalRst);
					Report.Success(finalRst);
				}else{
					//Report.Log(ReportLevel.Failure,"There are no active rules to delete !!!");
//					Report.Failure("There are no active rules to delete !!!");
					Report.Success("There are no active rules to delete !!!");
				}
				Delay.Seconds(1);
				//Report.Screenshot();
				Report.Screenshot("PortForwardingRule",myTable.Element,true);
				
        	}else{
				Report.Failure("Port Forwarding ","There are no active Port Forwarding rules to Delete !!");
	     		TestSuite.Current.GetTestCase("Delete_All_Port_Forward_Rules").Checked = false;
	     		return;
        	}// end of if-else             	
        }
		
    }
}