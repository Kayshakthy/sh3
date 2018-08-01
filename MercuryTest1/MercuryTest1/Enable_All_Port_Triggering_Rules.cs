/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 18/02/2016
 * Time: 16:49
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
    /// Description of Enable_All_Port_Triggering_Rules.
    /// </summary>
    [TestModule("2B13260F-183E-4FE0-BF70-91BAF74F425D", ModuleType.UserCode, 1)]
    public class Enable_All_Port_Triggering_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_All_Port_Triggering_Rules()
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
            
            //this.Enable_All_PortTriggering_Rules();
            this.Enabling_All_Port_Triggering_Rules();// Enable All_PortTriggering_Rules
            
        }
        void Enable_All_PortTriggering_Rules(){
			
        	//identify the rules to Enable//
			//Implemented based R2.4.2 ( 9.1.88S)									

        	//Report.Info( "--------Inside Disable_All_Port_Trigger_Rule -------");
			Delay.Seconds(45);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
           // Report.Info("Total Rules",rowsCnt.ToString());
            bool isRules=false;
            if(rowsCnt > 0){
					int rowNum = 1;  
					//int c=0;
					foreach (var row in rows)  
					{  
		           					var cells = row.FindDescendants<TdTag>(); 
							        int colNum=1;
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
								           		//Report.Info("colNum",colNum.ToString());

									        	IList<InputTag> inputVals = cells[5].Find<InputTag>("./input");
						        				//Report.Info("input count :  "+inputVals.Count);
						        		 		foreach(InputTag inputVal in inputVals){
							        				Ranorex.InputTag testTag = inputVal;
							        				//Report.Info(inputVal.GetPath().ToString());
													if(testTag.Checked.ToString() == "False"){
							        															//False
							        						Report.Info(" portTriggeringTableEnabledTag is currently disabled ");
							        						inputVal.PerformClick();
							        						Delay.Seconds(5);
								        					Report.Log(ReportLevel.Success,"The following port triggering rule is enabled now");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);							        						
							        				}else{
							        						//True
							        						/**
							        						Report.Info(" portTriggeringTableEnabledTag is currently enabled ");
							        						inputVal.Checked="False";
							        						Delay.Seconds(5);
							        						Report.Log(ReportLevel.Success,"The following port triggering rule is disabled");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);
									        				**/
									        				Report.Info(" The following port triggering rule is already enabled ");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);
							        				}
						        					
						        				}//end of for-loop : InputTag								    			
								           }
								            colNum++;
								            
							            	//cell.click();
							           }//end of if-else "No triggering rule"
							           cell.MoveTo();
							        }//end of for-loop : cell

							        rowNum++; 
							        //Report.Info("rowNum:"+rowNum);
							        if(isRules){
							        	break;
							        	//return;
							        }
							       
		        } //end of ROWS : for-loop
				Report.Log(ReportLevel.Success,"The following port triggering rule(s) are disabled/enabled");
				Report.Screenshot("PortTriggerRule",myTable.Element,false);	
				//Report.Screenshot();
				
            }else{
            	Report.Failure("There are no active PortTriggerRule to disable !!!");
            	Report.Screenshot("PortTriggerRule",myTable.Element,false);
            } //end of IF-ELSE rowcount         	
        }
         void Enabling_All_Port_Triggering_Rules(){
        	//implemented based on R3.4 ( 9.1.116J) and later version
        	Report.Info( "--------Inside Enabling_All_Port_Triggering_Rules -------");

			Delay.Seconds(45);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
           // Report.Info("Total Rules",rowsCnt.ToString());
            bool isRules=false;
            if(rowsCnt > 0){
					int rowNum = 1;  
					//int c=0;
					foreach (var row in rows)  
					{  
		           					var cells = row.FindDescendants<TdTag>(); 
							        int colNum=1;
							        //string triggerStart="" , triggerEnd="", targetStart="", targetEnd="";
							        string triggerRange="",targetRange="";
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
							           }else{
								            if(colNum==1){
								            	//triggerRangeStartEndPort -->triggerRange
								            	triggerRange=cell.InnerText;
								            	//triggerStart = cell.InnerText;
								            	//triggerEnd= cell.InnerText; 
								            }else if(colNum==2){
								            	//targetRangeStartEndPort --> targetRange
								            	targetRange=cell.InnerText; 
								            	//targetStart = cell.InnerText; 
								            	//targetEnd= cell.InnerText;
								            }else if(colNum==4){
								           		//	enabled of disabled?	//
								           		Report.Info("colNum",colNum.ToString());

									        	IList<InputTag> inputVals = cells[3].Find<InputTag>("./input");
						        				//Report.Info("input count :  "+inputVals.Count);
						        		 		foreach(InputTag inputVal in inputVals){
							        				Ranorex.InputTag testTag = inputVal;
							        				//Report.Info(inputVal.GetPath().ToString());
													if(testTag.Checked.ToString() == "False"){
							        						//False
							        						Report.Info(" portTriggeringTableEnabledTag is currently disabled ");
							        						inputVal.PerformClick();
							        						Delay.Seconds(5);
								        					Report.Log(ReportLevel.Success,"The following port triggering rule is enabled now");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);							        						
							        				}else{
							        						//True
									        				Report.Info(" The following port triggering rule is already enabled ");
									        				Report.Screenshot("PortTriggerRule",row.Element,true);
							        				}
						        					
						        				}//end of for-loop : InputTag								    			
								           }
								            colNum++;
								            
							            	//cell.click();
							           }//end of if-else "No triggering rule"
							           cell.MoveTo();
							        }//end of for-loop : cell

							        rowNum++; 
							        //Report.Info("rowNum:"+rowNum);
							        if(isRules){
							        	break;
							        	//return;
							        }
							       
		        } //end of ROWS : for-loop
				Report.Log(ReportLevel.Success,"The following port triggering rule(s) are disabled/enabled");
				Delay.Seconds(10);
				Report.Screenshot("PortTriggerRule",myTable.Element,false);	
				//Report.Screenshot();
				
            }else{
            	Report.Failure("There are no active PortTriggerRule to disable !!!");
            	Report.Screenshot("PortTriggerRule",myTable.Element,false);
            } //end of IF-ELSE rowcount
            
        }
        
    }
}
