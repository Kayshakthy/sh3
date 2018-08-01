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
    public partial class Add_New_Port_Trigger_rule
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows = 0; 
        private void Init()
        {
            // Your recording specific initialization code goes here.
            
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            //Report.Screenshot("New Port Triggering Rule", myTable.Element,true);
  
            //highlight the new port triggering rule
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            //Report.Info("------Inside Init() Add_New_Port_Trigger_rule ------ TotalRows(init)----- : " ,TotalRows.ToString());
            Report.Info(" TotalRows(Before Add)",TotalRows.ToString());
        }

        public void Validate_ApplyAdd_Port_Triggering_Rule()
        {
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Add rule') on item 'WebDocument19216801.ApplyAddRule'.", repo.WebDocument19216801.ApplyAddRuleInfo);
            //Validate.Attribute(repo.WebDocument19216801.ApplyAddRuleInfo, "Value", "Add rule");
            
           // TestSuite.Current.GetTestCase("Clear_Port_Triggering_Configuration_Screen").Checked = false;	// by default do not execute this TC
            
            // validate all the port ranges
            
            //check if the Error objects are exist
			
			//Report.Info("Validation"," Start Looking for isInvalidRangeOfPorts");
			if(repo.WebDocumentIE.TheConfiguredPortRangeCannotContainInfo.Exists() || repo.WebDocumentIE.TriggerEndPortShouldBeLargerOrEquInfo.Exists()){
				//The configured port range cannot contain one of the following reserved ports (53, 135, 137, 139, 161 & 162)
				//TriggerEndPortShouldBeLargerOrEqual to TriggerStartPort 
				
				//Report.Info("validation"," Found TheConfiguredPortRangeCannotContainInfo or TriggerEndPortShouldBeLargerOrEquInfo");
				Ranorex.Report.Log(ReportLevel.Failure,"Found TheConfiguredPortRangeCannotContainInfo or TriggerEndPortShouldBeLargerOrEquInfo");
				repo.WebDocument19216801.BtnCancel.Click();	//click cancel button
          		return;
			}
			//Report.Info("There are NO TheConfiguredPortRangeCannotContainInfo");
			
          	//if (isInvalidRangeOfPorts1 || isInvalidRangeOfPorts2 || isInvalidRangeOfPorts3 || isInvalidRangeOfPorts ){
          	if (repo.WebDocumentIE.InvalidRangeOfPorts1Info.Exists() || repo.WebDocumentIE.TargetEndPortShouldBeLargerOrEquaInfo.Exists()){
          		//Ranorex.Report.Log(ReportLevel.Failure,"InvalidRangeOfPorts..The External ports are already used in another Rule !!");
          		
          		//Report.Screenshot();
          		//TestSuite.Current.GetTestCase("Clear_Port_Triggering_Configuration_Screen").Checked = true;
          		//Report.Info("validation"," Found InvalidRangeOfPorts1Info");
          		Ranorex.Report.Log(ReportLevel.Failure,"Found InvalidRangeOfPorts1Info or TargetEndPortShouldBeLargerOrEquaInfo");
          		repo.WebDocument19216801.BtnCancel.Click();	//click cancel button
          		return;
          	}else if(repo.WebDocumentIE.InvalidRangeOfPorts2Info.Exists() || repo.WebDocumentIE.TargetEndPortShouldBeLargerOrEquaInfo.Exists()){
          		//Target end port should be larger or equal than Target start port
          		Ranorex.Report.Log(ReportLevel.Failure,"InvalidRangeOfPorts or TargetEndPortShouldBeLargerOrEquaInfo..The External ports are already used in another Rule !!");
          		//Report.Info("validation"," Found InvalidRangeOfPorts2Info");
          		repo.WebDocument19216801.BtnCancel.Click();	//click cancel button
          		return;          		
          	}else if(repo.WebDocumentIE.InvalidRangeOfPorts3Info.Exists()){
          		Ranorex.Report.Log(ReportLevel.Failure,"InvalidRangeOfPorts..The External ports are already used in another Rule !!");
          		//Report.Info("validation"," Found InvalidRangeOfPorts3Info");
          		repo.WebDocument19216801.BtnCancel.Click();	//click cancel button
          		return;          		
          	}else if(repo.WebDocumentIE.InvalidRangeOfPortsInfo.Exists() || repo.WebDocumentIE.TargetEndPortShouldBeLargerOrEquaInfo.Exists()){
          		//Target end port should be larger or equal than Target start port
          		Ranorex.Report.Log(ReportLevel.Failure,"InvalidRangeOfPorts..The External ports are already used in another Rule !!");
          		//Report.Info("validation"," Found InvalidRangeOfPortsInfo");
          		repo.WebDocument19216801.BtnCancel.Click();	//click cancel button
          		return;          		
          	}
          	// write Code to check 21st Rule //
          	
			//Report.Info("Validation"," Nothing found for isInvalidRangeOfPorts");
			Ranorex.Report.Log(ReportLevel.Success,"New Port Triggering Added Successfully!!");
			//to display the result
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            //Report.Screenshot("New Port Triggering Rule", myTable.Element,true);
            
          
            //highlight the new port triggering rule
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            Report.Info("Total Rules",rowsCnt.ToString());
            
			int rowNum = 1;  

			foreach (var row in rows)  
			{  
				//Report.Info("<---This port triggering rule is disabled from the list--->");
				if(rowNum == rowsCnt){
					Report.Screenshot("PortTriggerRule",row.Element,true);
					break;
				}
				rowNum++;
			}
			
        }

        public void Add_New_PortTriggerRule()
        {
			//Ranorex.Report.Log(ReportLevel.Success,"New Port Triggering Added Successfully!!");
			
			//Code to display the result screen
			if(TotalRows <10){
				Delay.Seconds(20);
        	}else if(TotalRows >10 && TotalRows <20){
        		Delay.Seconds(30);
        	}else if(TotalRows >20 && TotalRows <30){
        		Delay.Seconds(40);
        	}else if(TotalRows >30){
        		Delay.Seconds(50);
        	}
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";

            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            //Report.Screenshot("New Port Triggering Rule", myTable.Element,true);
            
          
            //highlight the new port triggering rule
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            Report.Info("Total Rules(After Add)",rowsCnt.ToString());
            
			//int rowNum = 1;  
			
			if(TotalRows == 1 && TotalRows == rowsCnt ){		// no rows are added
            	//Report.Info("//-------------------- TotalRows == rowsCnt ------------------------// ");
            	Report.Info("//-------------------- TotalRows == 1 && TotalRows == rowsCnt--------// ");
            	
            	//TableTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'AddRule']/table");
               	//Report.Info("InValid... This PortTriggerRule cannot be added !");
				
               	//Report.Log(ReportLevel.Failure,"PortForwardingTable","Unable to add this new rule");
               	
               	/*
				Report.Failure("PortTriggerRule","Unable to add this new rule !!! ");
				Delay.Seconds(5);
				//errorTable.EnsureVisible();
				myTable.EnsureVisible();
				
				//Report.Screenshot("PortTriggerRule",errorTable.Element,false);
				Report.Screenshot("PortTriggerRule",myTable.Element,false);
				return;            	
				*/
				
            	int rowNum = 1; 
            	foreach (var row in rows){  
			            
					/**
					Report.Info("Row: " + rowNum); 
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        foreach(TdTag MacCol in cols){
			        	Report.Info(MacCol.InnerText.ToString());
			        }
			        **/
			       
					if(rowNum == rowsCnt){	//to get the last  added rule (row)
						Report.Info("//-------------------- rowNum == rowsCnt ------------------------// ");
						Mouse.ScrollWheel(10);
						row.EnsureVisible();
						IList<TdTag> cols = row.Find<TdTag>("./td");
						if(cols.Count == 1){
							Report.Failure("No new PortTriggerRule is added !!!");
							Delay.Seconds(1);
							//Report.Screenshot("PortTriggerRule",row.Element,true);
							Report.Screenshot("PortTriggerRule",myTable.Element,true);
						}else{
							Report.Success("Valid... New PortTriggerRule is added!");
							Delay.Seconds(1);
							//Report.Screenshot("PortTriggerRule",row.Element,true);
							Report.Screenshot("PortTriggerRule",myTable.Element,true);
						}
						break;
					}
					rowNum++;			       
            	}
            	
			}else if(TotalRows > 1 && TotalRows == rowsCnt ){	// no rows are added
				// unable to add this rule
				
				if(rowsCnt == 32){
					//Report.Success("PortTriggerRule"," There are already 32 rules, FWPortTrigTable is full !!! ");
					Report.Info(" Already 32 rules in the table !!! ");
					//return;
				}
				//bool rst=true;
				bool tblRst = false;
				//Report.Info("tblRst(before)",tblRst.ToString());
				tblRst = Validate.Attribute(repo.MessageFromWebpage.Text65535Info, "WindowText", "Table FWPortTrigTable is full","{2}",false);
				//Report.Info("tblRst(after)",tblRst.ToString());
            	
            	//if(rst == tblRst){
            	if(tblRst){
            		if(rowsCnt == 31){
	            		Report.Log(ReportLevel.Success,"Table FWPortTrigTable is full,  Adding 32nd Rule !!!");
	            		Report.Screenshot("PortTriggerRule",repo.MessageFromWebpage.MessageFromWebpage,true);
	            		Delay.Seconds(2);
	            		repo.MessageFromWebpage.ButtonOK.Click();	//Click OK Button
	            		return;
            		}else{
            			Delay.Seconds(2);
            			repo.MessageFromWebpage.ButtonOK.Click();	//Click OK Button 
            			string tabFull = "Unable to add this new rule after:  "+rowsCnt+ " rules";
            			throw new Ranorex.ValidationException(tabFull);
            			//Report.Failure("PortTriggerRule",tabFull);
            			//Ranorex.Validate.Fail(tabFull);// Method to mark a test case as failed and immediately exit the current module and test case iteration
            			//return;
            		}
            	}
            	/** else{
            		Report.Failure("PortTriggerRule","Unable to add this new rule because of the below reason!!! ");
            	} **/
            	
				Report.Failure("PortTriggerRule","Unable to add this new rule because of the below reasons !!! ");
				Delay.Seconds(5);
				//errorTable.EnsureVisible();
				myTable.EnsureVisible();
				
				//Report.Screenshot("PortTriggerRule",errorTable.Element,false);
				Report.Screenshot("PortTriggerRule",myTable.Element,false);
				return;   
				
			}else{
				int rowNum = 1;  
				foreach (var row in rows)  
				{  
					//Report.Info("<---This port triggering rule is disabled from the list--->");
					if(rowNum == rowsCnt){
						Report.Info("//-------------------- rowNum == rowsCnt ------------------------// ");
						//Report.Info(row.Element.Visible.ToString());
						//Report.Info(row.Element.Size.ToString());
						/*
							if(row.Element.Visible){// if true
								Report.Info("Valid... New PortTriggerRule is added!");
								Report.Screenshot("PortTriggerRule",row.Element,true);
							}else if(!row.Element.Visible){ //if false
								Report.Info("In Valid... This PortTriggerRule cannot be added !");
								Report.Log(ReportLevel.Failure,"PortTriggerRule","Unable to add this new rule");
								Report.Screenshot();
							}
						*/
						Mouse.ScrollWheel(10);
						row.EnsureVisible();
						Report.Info("Valid... New Port Triggering Rule is added!");
						Report.Screenshot("PortTriggering Rule",row.Element,true);					
						break;
					}
					rowNum++;
				}		//end of for-loop
			}	//end of if-else
        }

    }
}