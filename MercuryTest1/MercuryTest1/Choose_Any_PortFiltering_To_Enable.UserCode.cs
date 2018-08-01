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
    public partial class Choose_Any_PortFiltering_To_Enable
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_Any_IP4Port_Filtering_To_Enable(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6, string argument7, string argument8)
        {
        	//choose P4Port_Filtering rules to enable
  
			Delay.Seconds(20);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'ipv4FilterTable']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            //Report.Info("Total rowsCnt",rowsCnt.ToString());
            Report.Info("Total Rules",rowsCnt.ToString());
            
            if(rowsCnt > 0){	//if there are any rules exist ?
            	Report.Info("There are  active IP4Port_Filtering rules to enable");
				int rowNum = 1;  
				//int enableCheck = 0;
				foreach (var row in rows)  
				{  
						var cells = row.FindDescendants<TdTag>(); 
						int colNum=1;
						string srcRangeIP="",dstRangeIP="",srcRange_Start_End_IP="",dstRange_Start_End_IP="",protocol="",srcPortRange_Start_End="",dstPortRange_Start_End="",srcPorts="",dstPorts="";
						//string srcRangeStart_IP="" , srcRangeEnd_IP="", dstRangeStart_IP="", dstRangeEnd_IP="";
						// string srcPortRange_Start="",srcPortRange_End="",dstPortRange_Start="",dstPortRange_End="";
						
						//Report.Info("cells count",cells.Count.ToString());	//count columns in a row
		
						foreach (var cell in cells)  
						{  
							//Report.Info("Cell: " + cell.InnerText);
							if(cells.Count ==1 && cell.InnerText.StartsWith("No triggering rule")){
								Report.Failure("There are no active IP4Port_Filtering to enable !!!");
								Report.Screenshot("IPv4 Port Filter ",myTable.Element,true);
								TestSuite.Current.GetTestCase("Apply_Changes_To_Any_IPv4Port_Filtering_Enable").Checked = false;
								break;
							}else{
								if(colNum==1){
									//Source address - combination of start and end IP
									IList<SpanTag> spanVals = cells[0].Find<SpanTag>("./span");
				        			//Report.Info("colNum1 span count :  "+spanVals.Count);
				        			foreach(SpanTag spanVal in spanVals){
				        				srcRangeIP = spanVal.InnerText;
				        				//Report.Info("srcRangeIP: " + srcRangeIP);
				        				//srcRangeStart_IP="";
				        				//srcRangeEnd_IP="";
				        				srcRange_Start_End_IP = argument1+"-"+argument2;
				        				//Report.Info(srcRange_Start_End_IP);
				        			}
									
								}else if(colNum==2){
									//Destination address - combination of start and end IP
									IList<SpanTag> spanVals = cells[1].Find<SpanTag>("./span");
									//Report.Info("colNum2 span count :  "+spanVals.Count);
									foreach(SpanTag spanVal in spanVals){
										dstRangeIP= spanVal.InnerText;
										//Report.Info("dstRangeIP: " + dstRangeIP);
										//dstRangeStart_IP="";
										//dstRangeEnd_IP="";
										dstRange_Start_End_IP=argument3+"-"+argument4;
										//Report.Info(dstRange_Start_End_IP);
									}
								}else if(colNum==3){
									//Protocol
									protocol = cell.InnerText;
									//Report.Info("protocol",protocol);
								}else if(colNum==4){
									//Source port - combination of start and end IP
									srcPorts = cell.InnerText;
									//Report.Info("srcPorts",srcPorts);
									//srcPortRange_Start="";
									//srcPortRange_End="";
									srcPortRange_Start_End = argument5+":"+argument6;
									//Report.Info(srcPortRange_Start_End);
									
								}else if(colNum==5){
									//Destination port
									dstPorts = cell.InnerText;
									//Report.Info("dstPorts",dstPorts);
									//dstPortRange_Start="";
									//dstPortRange_End="";
									dstPortRange_Start_End =argument7+":"+argument8;
									//Report.Info(dstPortRange_Start_End);
								}else if(colNum==6){
									//enabled or disabled?
									//Report.Info("Check for enabled or disabled? ");
									if(srcRangeIP == srcRange_Start_End_IP && dstRangeIP == dstRange_Start_End_IP && srcPorts == srcPortRange_Start_End && dstPorts == dstPortRange_Start_End ){
										Report.Success("This IP4Port_Filtering rule is exist in the list");
						        		IList<InputTag> inputVals = cells[5].Find<InputTag>("./input");
				        				//Report.Info("input count :  "+inputVals.Count);
				        		 		foreach(InputTag inputVal in inputVals){
				        					Ranorex.InputTag testTag = inputVal;
				        					//Report.Info(inputVal.GetPath().ToString());
				        					if(testTag.Checked.ToString() == "True"){		
			        							Report.Info(" pIP4Port_FilteringTableEnabledTag is already enabled ");
				        						//inputVal.Checked="False";
				           						Report.Log(ReportLevel.Success,"This IP4Port_Filtering rule is enabled");
				        						Delay.Seconds(1);
						        				Report.Screenshot("IP4Port_Filtering",row.Element,true);				        						
											}else{	//currently disabled
			        							Report.Info(" IP4Port_FilteringTableEnabledTag is currently disabled ");
				        						inputVal.PerformClick();
				        						Delay.Seconds(2);
				        						Report.Log(ReportLevel.Success,"This IP4Port_Filtering rule is successfully enabled");
						        				Report.Screenshot("IP4Port_Filtering",row.Element,true);					        						
				        					}
				        				}

									}
									
								}	//colNum==7				//Delete
				
							}//end of if-else
							colNum++;
						 }//end of for-loop column : cells
					rowNum++;	
				}
				Report.Info("// The following IP4Port_Filtering rule(s) are enabled from the list //");
				Report.Screenshot();

		    }else{
      	    	 Report.Failure("IPv4 Port Filter ","There are no active IP Port Filtering rules to Enable !!");
      	    	 Delay.Seconds(2);
	             Report.Screenshot("IPv4 Port Filter ",myTable.Element,true);
		     	 TestSuite.Current.GetTestCase("Apply_Changes_To_Any_IPv4Port_Filtering_Enable").Checked = false;
		     	 return;
            }        	
        }

    }
}