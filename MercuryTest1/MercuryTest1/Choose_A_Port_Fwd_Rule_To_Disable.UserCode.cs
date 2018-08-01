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
    public partial class Choose_A_Port_Fwd_Rule_To_Disable
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_Port_fwd_rule_to_disable(string argument1, string argument2, string argument3, string argument4, string argument5)
        {
        	//Implemented based on firmware 9.1.88T or before
        	//Report.Info( "--------Inside Delete_A_Port_Fwd_Rule-------");
        	//Report.Info( argument1 + "=="+argument2+ "=="+argument3+ "=="+argument4+ "=="+argument5);
        	string localIP="",localStartPort="",localEndPort="",externalStartPort="",externalEndPort="";
        	Delay.Seconds(15);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); //R3.11
//            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");  //As per R3.5 (9.1.116J)
            IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");//count the rows
	     	int rulesCount = totalRules.Count;
            if(rulesCount == 0){
				Report.Failure("Port Forwarding ","There are no active Port Forwarding rules to Disable !!");
	     		TestSuite.Current.GetTestCase("Disable_A_Port_Forward_Rule").Checked = false;
	     		return;
	     	}else{
	            //walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				bool isRuleExist=false;
				String portFwdRule ="";
				int j=1,colsCount = cols.Count;
				Report.Info("Total colsCount",colsCount.ToString());

				foreach(TdTag col in cols)  
		    	{
					//Report.Info(j.ToString());
					//Report.Info(col.InnerText);
					if(j==1){
						//Ip Address
						localIP = col.InnerText;
						j++;
					}else if(j==2){
						//Local start port
						localStartPort = col.InnerText;
						j++;
					}else if(j==3){
						//Local end port
						localEndPort = col.InnerText;
						j++;
					}else if(j==4){
						//External start port
						externalStartPort = col.InnerText;
						j++;
					}else if(j==5){
						//External end port
						externalEndPort = col.InnerText;
						j++;
					}else if(j==6){
						//protocol
						j++;
					}else if (j ==7){
					//if(j == 7 || j == 15 || j == 23) {
						//perfrom validation
						if((localIP==argument1) && (localStartPort== argument2)&& (localEndPort == argument3)&& (externalStartPort == argument4)&& (externalEndPort ==argument5) )
						{	//Enable or Disable ?	//click the disable checkbox
				
							//WebElement webElement = col.Element;
							//webElement.Click();
		        			//Report.Info("Clicked");
		        			
							IList<InputTag> inputVals = col.Find<InputTag>("./input");
							//Report.Info("input count :  "+inputVals.Count);
							foreach(InputTag inputVal in inputVals)
							{	//check or uncheck checkbo
								Ranorex.InputTag testTag = inputVal;
								//Report.Info(inputVal.GetPath().ToString());
								if(testTag.Checked.ToString() == "False"){
																		//False - Currently DISABLED
									//Report.Info(" portForwardingTableEnabledTag is already disabled ! ");
									//inputVal.PerformClick();
									//inputVal.Checked="True";
									Report.Log(ReportLevel.Success,"This port forwarding rule is already disabled !!!");
									Delay.Seconds(2);
									Report.Screenshot("PortForwardingRule",col.Element,true);
								}else if(testTag.Checked.ToString() == "True"){
																		//True - Currently ENABLED
									Report.Info(" portForwardingTableEnabledTag is currently enabled and it will be disabled soon..!!! ");
									//inputVal.DoubleClick();
									inputVal.Checked="False";
									Report.Log(ReportLevel.Success,"This port forwarding rule is disabled");
									Delay.Seconds(2);
									Report.Screenshot("PortForwardingRule",col.Element,true);
								}
								
							}//end of  InputTag : for-loop
							/**
							portFwdRule = "localIP :: "+ localIP + "||"+"localStartPort :: "+localStartPort+"||"+"localEndPort :: "+localEndPort+ "||"+"externalStartPort :: "+externalStartPort + "||"+"externalEndPort :: "+externalEndPort;
							Report.Log(ReportLevel.Success,"portFwdRule",portFwdRule);
							//Report.Info("<---This port forwarding rule is deleted from the list--->");
							Report.Log(ReportLevel.Success,"portFwdRule","This port forwarding rule is disabled from the list");
							**/
							isRuleExist = true;
		        			break;
						}//end of if-else
						j++;
					}else if(j==8){
						//delete
						j=1;
					}
				}//end of for-loop :TdTag
				if(!isRuleExist){
					portFwdRule = "localIP :: "+ argument1 + "||"+"localStartPort :: "+argument2+"||"+"localEndPort :: "+argument3+ "||"+"externalStartPort :: "+argument4 + "||"+"externalEndPort :: "+argument5;
					Report.Log(ReportLevel.Failure,"portFwdRule",portFwdRule);
					Report.Log(ReportLevel.Failure,"portFwdRule","This port forwarding rule does not exist");
				}	
            }//end of if-else:rulesCount
				
        }

        public void Choose_Port_forwarding_rule_to_disable(string argument1, string argument2, string argument3, string argument4, string argument5)
        {
        	//Implemented based on R3.5(9.1.116J) GUI
        	//argument1- LocalIP,argument2-Localstart,argument3-Localend,argument4-Externalstart,argument5-ExternalEnd
        	string localIP="",localPortRange="",local_Start_End_Port_Range="",externalPortRange="",external_Start_End_Port_Range ="";
            Delay.Seconds(15);
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); //R3.11
//            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");  //As per R3.5 (9.1.116J)
            
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	//Report.Info("Port Forwarding ",totalPortRules);
	     	
	     	if(rulesCount > 0){
	     		Report.Info("Total Rules",totalPortRules);
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				bool isRuleExist=false;
				String portFwdRule ="";
				int j=1,colsCount = cols.Count;
				Report.Info("Total colsCount",colsCount.ToString());

				foreach(TdTag col in cols)  
		    	{
					Report.Info(col.InnerText);
				
					if(j==1){	//Ip Address
						localIP = col.InnerText;
						j++;
					}else if(j==2){		//Local Port range
						//Local start & end port
						//localStartPort = col.InnerText;
						localPortRange=col.InnerText;
						local_Start_End_Port_Range = argument2+"-"+argument3;
						j++;
					}else if(j==3){	//External start & end port
						//externalStartPort = col.InnerText;
						externalPortRange=col.InnerText;
						external_Start_End_Port_Range = argument4+"-"+argument5;
						j++;
					}else if(j==4){	//protocol
						j++;
					}else if(j==5){		//enable or disable ?
						//Report.Info("Enable or Disable ?");
						if((localIP==argument1) && (localPortRange== local_Start_End_Port_Range)&& (externalPortRange == external_Start_End_Port_Range) )
						{	
							IList<InputTag> inputVals = col.Find<InputTag>("./input");
							//Report.Info("input count :  "+inputVals.Count);
							foreach(InputTag inputVal in inputVals){
								Ranorex.InputTag testTag = inputVal;
								Report.Info(inputVal.GetPath().ToString());
								if(testTag.Checked.ToString() == "True"){
									Report.Info(" portForwardingTableEnabledTag is currently enabled ");
									inputVal.Checked="False";
									Delay.Seconds(10);
									Report.Log(ReportLevel.Success,"This port forwarding rule is disabled now...");
									Report.Screenshot("PortForwardingRule",col.Element,true);
								}else{
									//Report.Info(" portForwardingTableEnabledTag is currently disabled ");
									Delay.Seconds(10);
									Report.Log(ReportLevel.Success,"This port forwarding rule is already disabled !!!");
									Report.Screenshot("PortForwardingRule",col.Element,true);
								}
								
							}//end of for-loop : InputTag
							isRuleExist = true;
		        			break;
							
						}//end of if-else : 
						j++;//increment the column
					}else if(j==6){		//delete check box
						j=1;
					}
	     		 
	     		}//end of for-loop :TdTag
				if(!isRuleExist){
					portFwdRule = "localIP :: "+ argument1 + "||"+"localStartPort :: "+argument2+"||"+"localEndPort :: "+argument3+ "||"+"externalStartPort :: "+argument4 + "||"+"externalEndPort :: "+argument5;
					Report.Log(ReportLevel.Failure,"portFwdRule",portFwdRule);
					Report.Log(ReportLevel.Failure,"portFwdRule","This port forwarding rule does not exist");
				}					
	     	}else{
				Report.Failure("Port Forwarding ","There are no active Port Forwarding rules to Disable !!");
	     		//TestSuite.Current.GetTestCase("Apply_Port_Forward_Changes_Disable_All").Checked = false;
	     		TestSuite.Current.GetTestCase("Disable_Any_Port_Forward_Rule").Checked = false;
	     		return;
	     	}
        	
        }

    }
}