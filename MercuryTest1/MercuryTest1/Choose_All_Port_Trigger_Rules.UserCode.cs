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
    public partial class Choose_All_Port_Trigger_Rules
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        
        int TotalRows =0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
            Report.Info("Inside init() of  Choose_All_Port_Trigger_Rules  ");
            Delay.Seconds(40);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            //highlight the new port triggering rule
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;          
            //Report.Info(" TotalRows(Before Add)",TotalRows.ToString());
            
        }

        public void Choose_all_port_trigger_rules_to_delete()
        {	
        	//Implemented based on R2.4.2 (9.1.88S)
        	//click all port trigger rules
        	if(TotalRows <5){
        		Delay.Seconds(5);
        	}else if(TotalRows >=5 && TotalRows < 10){
        		Delay.Seconds(10);
        	}else if(TotalRows >=10 && TotalRows < 20){
        		Delay.Seconds(20);
        	}else{
        		Delay.Seconds(30);
        	}
        	//string localIP="",localStartPort="",localEndPort="",externalStartPort="",externalEndPort="";
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	 
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Port Triggering ",totalPortRules);
	     	bool isRuleExist=true;
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("Port Triggering ","There are no active port triggering rules to delete !!");
	     		//TestSuite.Current.GetTestCase("Delete_All_Port_Trigger_Rules").Checked = false;
	     		return;
	     	}else{
            
	            //walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				//Report.Info("Total colsCount",colsCount.ToString());
				int j=1;
				foreach(TdTag col in cols)  
		    	{
					//Report.Info(col.InnerText);
					col . MoveTo ();//Move the mouse onto the cell
					if(j == 1 && col.InnerText.StartsWith("No triggering rule!")){
						Report.Failure("Port Triggering ","There are no active port triggering rules to delete !!");
						//TestCase.Current.Equals("Delete_All_Port_Trigger_Rules");
						TestSuite.Current.GetTestCase("Delete_All_Port_Trigger_Rules").Checked = false;
						isRuleExist=false;
						//return;
						break;
					}
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
					else if (j ==7){
						
						//if((localIP==argument1) && (localStartPort== argument2)&& (localEndPort == argument3)&& (externalStartPort == argument4)&& (externalEndPort ==argument5) ){
							//Report.Info("---Check the delete box ---");
							//click the delete checkbox
							WebElement webElement = col.Element;
							Delay.Seconds(2);
							webElement.Click();
		        			//Report.Info("Clicked");
		        			Report.Screenshot("Delete PortTriggering",webElement,true);
		        			
						//}
						j=0;
					}
					j++;
				}	//end of foreach  
				if(isRuleExist){
					string finalRst = "The following " + rulesCount.ToString() +" PortTriggerRules are deleted from the table";
					Report.Log(ReportLevel.Success,finalRst);
				}else{
					Report.Log(ReportLevel.Failure,"There are no active rules to delete !!!");
				}
				Report.Screenshot("PortTriggerRule",myTable.Element,true);
	     	}	//end of if-else
        }

        public void Choose_all_port_triggering_rules_to_delete()
        {
        	//Implemented based on R3.5 (9.1.116J)
        	//click all port trigger rules
        	if(TotalRows <5){
        		Delay.Seconds(10);
        	}else if(TotalRows >=5 && TotalRows < 10){
        		Delay.Seconds(30);
        	}else if(TotalRows >=10 && TotalRows < 20){
        		Delay.Seconds(40);
        	}else{
        		Delay.Seconds(50);
        	}
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	 
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Port Triggering ",totalPortRules);
	     	bool isRuleExist=true;
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("Port Triggering ","There are no active port triggering rules to delete !!");
	     		//TestSuite.Current.GetTestCase("Delete_All_Port_Trigger_Rules").Checked = false;
	     		return;
	     	}else{
	     		            //walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				//Report.Info("Total colsCount",colsCount.ToString());
				int j=1;
				foreach(TdTag col in cols)  
		    	{
					//Report.Info(col.InnerText);
					col . MoveTo ();//Move the mouse onto the cell
					//if(j == 1 && col.InnerText.StartsWith("No triggering rule!")){	//9.1.116U
					if(j == 1 && col.InnerText.StartsWith("No triggering rule applied!")){	//9.1.116V (R3.7.1)
						Report.Failure("Port Triggering ","There are no active port triggering rules to delete !!");
						//TestCase.Current.Equals("Delete_All_Port_Trigger_Rules");
						TestSuite.Current.GetTestCase("Delete_All_Port_Trigger_Rules").Checked = false;
						isRuleExist=false;
						//return;
						break;
					}
					else if (j ==5){
						WebElement webElement = col.Element;
						Delay.Seconds(2);
						webElement.Click();
						//Report.Info("Clicked");
						Report.Screenshot("Delete PortTriggering",webElement,true);
						j=0;
					}
					j++;	
					
				}//end of foreach 
				if(isRuleExist){
					string finalRst = "The following " + rulesCount.ToString() +" PortTriggerRules are deleted from the table";
					Report.Log(ReportLevel.Success,finalRst);
				}else{
					Report.Log(ReportLevel.Failure,"There are no active rules to delete !!!");
				}
				Report.Screenshot("PortTriggerRule",myTable.Element,true);
				
	     	}//end of if-else
        	
        }

    }
}