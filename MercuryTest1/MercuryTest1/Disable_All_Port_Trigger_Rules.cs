/*
 * Created by Ranorex
 * User: KiruShakthy
 * Date: 11/27/2015
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
    /// <summary>
    /// Description of Disable_All_Port_Trigger_Rules.
    /// </summary>
    [TestModule("A9B74B01-7B92-43D8-AD7B-7DB0AEA763B2", ModuleType.UserCode, 1)]
    public class Disable_All_Port_Trigger_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Disable_All_Port_Trigger_Rules()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            Report.Info("inside Run() of Disable_All_Port_Trigger_Rules()");
            //this.disable_all_trigger_rules();
            this.disable_all_port_trigger_rules(); //disable_all_port_trigger_rules
        }
        void disable_all_trigger_rules(){
        	//implemented based on R2.4.2(9.1.88S)
        	//identify the rules to disable
        	//Report.Info( "--------Inside Disable_All_Port_Trigger_Rule -------");
			//string triggerRangeStartPort="",triggerRangeEndPort="",targetRangeStartPort="",targetRangeEndPort="";
			Delay.Seconds(40);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            //Report.Info("Total rowsCnt",rowsCnt.ToString());
           // Report.Info("Total Rules",rowsCnt.ToString());
            bool isRules=false;
            if(rowsCnt > 0){
					int rowNum = 1;  
					//int c=0;
					foreach (var row in rows)  
					{  
		           					var cells = row.FindDescendants<TdTag>(); 
							        int colNum=1;
							        //int enableCheck = 0;
							        string triggerStart="" , triggerEnd="", targetStart="", targetEnd="";
							        //Report.Info("Cell[0]: " + cells[0].InnerText);//No Trigger rules
							        //Report.Info(""+cells.Count.ToString());
							        foreach (var cell in cells)  
							        {  
							           //Report.Info("Cell: " + cell.InnerText);  //No triggering rule!
							           if(cells.Count ==1 && cell.InnerText.StartsWith("No triggering rule")){
							           		Report.Failure("There are no active PortTriggerRule to disable !!!");
            								Report.Screenshot("PortTriggerRule",myTable.Element,true);
            								isRules = true;
            								TestSuite.Current.GetTestCase("Apply_Port_Triggering_Changes").Checked = false;
            								break;
            								//return;
							           }else{
								            if(colNum==1){
								            	//triggerRangeStartPort
								            	triggerStart = cell.InnerText;
								            }else if(colNum==2){
								            	//triggerRangeEndPort
								            	triggerEnd= cell.InnerText; 
								            }else if(colNum==3){
								            	//targetRangeStartPort
								            	targetStart = cell.InnerText; 
								            }else if(colNum==4){
								            	//targetRangeEndPort
								            	targetEnd = cell.InnerText;
								           }else if(colNum==5){
								           		//	enabled of disabled?	//
								           		//Report.Info(cell.GetInnerHtml().ToString());
								           		//Report.Info("colNum",colNum.ToString());
								           		//Report.Info(cells[5].GetInnerHtml().ToString());
								           		
								           		//WebElement webElement = cells[5].Element;
								           		//webElement.Click();
								           		//cells[5].Click();
								           		//Report.Info("Width:  " + cells[5]);
								    			//Delay.Seconds(2);

									        	IList<InputTag> inputVals = cells[5].Find<InputTag>("./input");
						        				//Report.Info("input count :  "+inputVals.Count);
						        		 		foreach(InputTag inputVal in inputVals){
							        				Ranorex.InputTag testTag = inputVal;
							        				//Report.Info(inputVal.GetPath().ToString());
							        				if(testTag.Checked.ToString() == "True"){
							        						//Report.Info(" portTriggeringTableEnabledTag is currently enabled ");
							        						inputVal.Checked="False";
							        						Delay.Seconds(5);
							        						Report.Log(ReportLevel.Success,"The following port triggering rule is disabled now...");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);
							        				}else{
							        						//Report.Info(" portTriggeringTableEnabledTag is currently disabled ");
							        						/*
							        						inputVal.PerformClick();
							        						Delay.Seconds(5);
							        						*/
								        					Report.Log(ReportLevel.Success,"The following port triggering rule is already disabled !!!");
								 	        				Report.Screenshot("PortTriggerRule",row.Element,true);							        						
							        				}
						        					
						        				}//end of for-loop	
						        				
								    			/*
					        					String newPath = "";
									        	newPath ="/dom[@domain='192.168.0.1']//input[#'portTriggeringTable-Enabled-"+enableCheck+"']";
									        	Ranorex.InputTag portTriggringTableEnabledTag = newPath;
												if(portTriggringTableEnabledTag.Checked.ToString() == "True"){
													// portTriggeringTableEnabledTag is already Enabled
													Report.Info("-----------------portTriggeringTableEnabledTag  is checked---");
													Delay.Seconds(1);
													portTriggringTableEnabledTag.Checked="";	//uncheck the checkbox to disable
													portTriggringTableEnabledTag.Checked="False";
													portTriggringTableEnabledTag.PerformClick();
												}else{
									        		Report.Info("-----------------portTriggeringTableEnabledTag  is unchecked---");
													//portTriggeringTableEnabledTag is already disabled
													Report.Info(" portTriggeringTableEnabledTag is already disabled ");
													Delay.Seconds(1);
													portTriggringTableEnabledTag.Checked="checked";
													portTriggringTableEnabledTag.Checked="True";
													portTriggringTableEnabledTag.PerformClick();
												}	
									        	*/
									        	//Report.Info("<---This port triggering rule is disabled --->");
	
								           }else if(colNum==6){
							           			//delete button
							           			//Report.Info("colNum",colNum.ToString());
							           			//Report.Info(cells[6].GetInnerHtml().ToString());
							           		}
								            colNum++;
								            
							            	//cell.click();
							           }//end of if-else "No triggering rule"
							           cell.MoveTo();
							        }//end of for-loop : cell
							        //enableCheck++;
							        rowNum++; 
							        //Report.Info("rowNum:"+rowNum);
							        if(isRules){
							        	break;
							        	//return;
							        }
		        } //end of for-loop : row
				if(!isRules){	
					Report.Log(ReportLevel.Success,"The following port triggering rule(s) are disabled/enabled");
					Delay.Seconds(1);
					Report.Screenshot("PortTriggerRule",myTable.Element,false);	
					//Report.Screenshot();
				}
            }else{
            	Report.Failure("There are no active PortTriggerRule to disable !!!");
            	Delay.Seconds(1);
            	Report.Screenshot("PortTriggerRule",myTable.Element,false);
            }            
        }

        void disable_all_port_trigger_rules(){
        	//implemented based on R3.5(9.1.116J) and latesr versions
			Delay.Seconds(45);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            //Report.Info("Total rowsCnt",rowsCnt.ToString());
           // Report.Info("Total Rules",rowsCnt.ToString());
            bool isRules=false;
            if(rowsCnt > 0){
            	int rowNum = 1;  
					//int c=0;
					foreach (var row in rows)  
					{  
		           					var cells = row.FindDescendants<TdTag>(); 
							        int colNum=1;
							        //int enableCheck = 0;
							        //string triggerStart="" , triggerEnd="", targetStart="", targetEnd="";
							        //Report.Info("Cell[0]: " + cells[0].InnerText);//No Trigger rules
							        //Report.Info(""+cells.Count.ToString());
							        foreach (var cell in cells)  
							        {  
							           //Report.Info("Cell: " + cell.InnerText);  //No triggering rule!
							           if(cells.Count ==1 && cell.InnerText.StartsWith("No triggering rule")){
							           		Report.Failure("There are no active PortTriggerRule to disable !!!");
            								Report.Screenshot("PortTriggerRule",myTable.Element,true);
            								isRules = true;
            								TestSuite.Current.GetTestCase("Apply_Port_Triggering_Changes").Checked = false;
            								break;
            								//return;
							           }else{
								            if(colNum==1){
								            	//triggerRangeStartEndPort
								            	//triggerStart = cell.InnerText;
								            	//triggerEnd= cell.InnerText; 
								            }else if(colNum==2){
								            	//targetRangeStartEndPort
								            	//targetStart = cell.InnerText; 
								            	//targetEnd = cell.InnerText;
								            }else if(colNum==4){
								           		//	enabled of disabled?	//
								           		//Report.Info(cell.GetInnerHtml().ToString());
								           		//Report.Info("colNum",colNum.ToString());
								           		//Report.Info(cells[5].GetInnerHtml().ToString());

									        	IList<InputTag> inputVals = cells[3].Find<InputTag>("./input");
						        				//Report.Info("input count :  "+inputVals.Count);
						        		 		foreach(InputTag inputVal in inputVals){
							        				Ranorex.InputTag testTag = inputVal;
							        				//Report.Info(inputVal.GetPath().ToString());
							        				if(testTag.Checked.ToString() == "True"){
							        						//Report.Info(" portTriggeringTableEnabledTag is currently enabled ");
							        						inputVal.Checked="False";
							        						Delay.Seconds(5);
							        						Report.Log(ReportLevel.Success,"The following port triggering rule is disabled now...");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);
							        				}else{
							        						//Report.Info(" portTriggeringTableEnabledTag is currently disabled ");

								        					Report.Log(ReportLevel.Success,"The following port triggering rule is already disabled !!!");
								 	        				Report.Screenshot("PortTriggerRule",row.Element,true);							        						
							        				}
						        					
						        				}//end of for-loop	
						        		
									        	//Report.Info("<---This port triggering rule is disabled --->");
	
								           }
								            colNum++;
								            
							            	//cell.click();
							           }//end of if-else "No triggering rule"
							           cell.MoveTo();
							        }//end of for-loop : cell
							        //enableCheck++;
							        rowNum++; 
							        //Report.Info("rowNum:"+rowNum);
							        if(isRules){
							        	break;
							        	//return;
							        }
		        } //end of for-loop : row
				if(!isRules){	
					Report.Log(ReportLevel.Success,"The following port triggering rule(s) are disabled/enabled");
					Delay.Seconds(10);
					Report.Screenshot("PortTriggerRule",myTable.Element,false);	
					//Report.Screenshot();
				}
            	
            }else{
            	Report.Failure("There are no active PortTriggerRule to disable !!!");
            	Delay.Seconds(1);
            	Report.Screenshot("PortTriggerRule",myTable.Element,false);
            }
        }
    }
}
