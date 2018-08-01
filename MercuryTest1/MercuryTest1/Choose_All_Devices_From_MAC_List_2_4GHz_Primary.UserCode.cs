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
    public partial class Choose_All_Devices_From_MAC_List_2_4GHz_Primary
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows1=0,TotalRows2=0;
        private void Init()
        {
            // Your recording specific initialization code goes here
            Delay.Seconds(5);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
            TableTag myTable2 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'AttachedDevicesTable']"); 
            //count the rows
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            IList<TrTag> rows2 = myTable2.Find<TrTag>("./tbody//tr");
            TotalRows1 = rows1.Count;
            TotalRows2= rows2.Count;            
        }

        public void Choose_All_Devices_From_MAC_List_To_Delete_2_4GHz_Primary()
        {
        	//delete all devices that belongs to 2_4GHz_Primary
        	if(TotalRows1 <=5 || TotalRows2<= 5){
        		Delay.Seconds(5);	// to load the pages
        	}else if((TotalRows1 >5 && TotalRows1 <=10) || ( TotalRows2 >5 && TotalRows2 <=10)){
        		Delay.Seconds(10);	// to load the pages
        	}else if((TotalRows1 >10 && TotalRows1 <=20) || ( TotalRows2 >10 && TotalRows2 <=20)){
        		Delay.Seconds(20);	// to load the pages
        	}else{
        		Delay.Seconds(30);	// to load the pages
        	}        	
        	//Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	//Report.Info(webDocument.GetHtml());
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
            //Count the total no of IPv4 port Filter rules (rows)
	     	IList<TrTag> totalMACListDevices = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalMACListDevices.Count;   
	     	string totalMACFilterDevices = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Active Devices ",totalMACFilterDevices);
	     	
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("MAC Filter Devices ","There are no devie to delete !!");
	     		TestSuite.Current.GetTestCase("Delete_All_Devices_From_MAC_Filter_List_2_4GHz_Pmry_Wireless").Checked = false;
	     		return;
	     	}else if(rulesCount == 1){
	     		//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count,colCnt=1,delCheck = 0;;
				string noFilterStr = null;
				//Report.Info("colsCount",colsCount.ToString());
				string Wireless_radio="";
				foreach(TdTag col in cols)  
		    	{
					if(colsCount == 1){	////No filtering device!
						noFilterStr = col.InnerText.ToString();
						//Report.Info(noFilterStr.ToString());
						//if(noFilterStr.StartsWith("No filtering")){	
						if(noFilterStr.StartsWith("You have not selected a device to filter. Please select a device from the attached devices list.")){
				     		Report.Failure("MAC Filter Devices ","There are no devie to delete !!");
				     		TestSuite.Current.GetTestCase("Delete_All_Devices_From_MAC_Filter_List_2_4GHz_Pmry_Wireless").Checked = false;
				     		return;						
						}
					}else{	//only one rule exist
							//Report.Info("Only one MAC Filter rule exist,now !!!");
							if(colCnt == 3){
								IList<SpanTag> spanVals = col.Find<SpanTag>("./span");
				        		//Report.Info("span count :  "+spanVals.Count);
				        		
				        		 foreach(SpanTag spanVal in spanVals){
				        			Wireless_radio  = spanVal.InnerText;
				        			Report.Info("Wireless_radio  : " + Wireless_radio );
				        		 }
								 //Report.Info("Wireless_radio",Wireless_radio);
								 Report.LogHtml(ReportLevel.Info,Wireless_radio,"<b>Wireless_radio frequency</b>");
							}
							else if (colCnt == 4){
								if(Wireless_radio == "2.4GHz"){
									//Report.Info("----------------- click delete checkbox ------");
									String newPath = "",colPath="";	
					        		colPath = col.GetPath().ToString();	
					        		Report.Info("colpath -->"+colPath);
					        		newPath = colPath + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";	
					        		Ranorex.InputTag MACFilterTableDeleteTag = newPath;
					        		if (MACFilterTableDeleteTag.Checked.ToString() == "False"){
					        			//Report.Info("----------------- MACFilterTableDeleteTag was False ---");
					        			Delay.Seconds(1);
					        			MACFilterTableDeleteTag.Click();
					        			MACFilterTableDeleteTag.PerformClick();
					        			MACFilterTableDeleteTag.Checked = "Checked";
					        			Delay.Seconds(1);
					        		}else{
					        			Report.Info(" MACFilterTableDeleteTag is already checked  ");
					        		}
					        		string rst = "The following MACFilter_Filtering rule is deleted permanently !!!";
					        		Report.Success(rst);
					        		Report.Screenshot("MACFilter_Filtering",col.Element,true);
								}else{
									Report.Info(" Different wireless radio frequency(5GHz) devices are added in the list ! ");
								}	
							}
							colCnt++;
					}	//end of if-else
				}	//end of forloop:TdTag
	     	}else{
	     		Report.Info(" There are " + rulesCount.ToString() + " MAC filter list !!! ");
	     		
	     		int rowNum = 1;  
			    int delCheck = 0;
			    
			    foreach (var row in totalMACListDevices)  
			    { 
			    	 Report.Info("Row: " + rowNum);  
		     		//walkthrough the column values
					//IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
					IList<TdTag> cols = row.Find<TdTag>("./td");
					int colsCount = cols.Count;
//					Report.Info("Total colsCount",colsCount.ToString());
					int j=1;	//column number
					string Wireless_radio="";
					foreach(TdTag col in cols)  
			    	{
//						Report.Info("col number: " + j);
						//Report.Info("col.InnerText",col.InnerText);
						/*
						if(j==3){
							//Wireless radio
							//Wireless_radio = col.InnerText;
							String wirelessRadioPath = "";	
							wirelessRadioPath = col.GetPath().ToString();
							Report.Info("wirelessRadioPath",wirelessRadioPath);
							//find span tag
						}else **/
						if(j == 3){
								//Wireless_radio = col.InnerText;
							IList<SpanTag> spanVals = col.Find<SpanTag>("./span");
			        		//Report.Info("span count :  "+spanVals.Count);
			        		
			        		 foreach(SpanTag spanVal in spanVals){
			        			Wireless_radio  = spanVal.InnerText;
			        			Report.Info("Wireless_radio  : " + Wireless_radio );
			        		 }
							 //Report.Info("Wireless_radio",Wireless_radio);
//							 Report.LogHtml(ReportLevel.Info,Wireless_radio,"<b>Wireless_radio frequency</b>");
						}
						else if (j == 4){
							if((Wireless_radio == "2.4GHz") || (Wireless_radio == "2.4 GHz")){	//updated on 17/10/17  based on SON code - 116.400
								/*
								WebElement webElement = col.Element;
								Delay.Seconds(2);
								webElement.Click();
								Report.Screenshot("Delete MACFilterDevices",webElement,true);
			        			Report.Info("Delete Checkbox Clicked");
			        			j=0;
			        			*/
		        				//Delay.Seconds(5);
				        		//Report.Info("----------------- click delete checkbox ------");
				        		//Report.Info("Wireless_radio",Wireless_radio);
				        		//if(macAddress == macAddress1){
				        			//isMatch = true;
				        			//Report.Info("----------------- Rules Matches !!! ------");
				        			String newPath = "",colPath="";	
				        			colPath = col.GetPath().ToString();
				        			//Report.Info("col Path ", colPath);
				        			//newPath = col.GetPath() + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";	//fmChbx-macAddressFilterTable-Delete-0
				        																						//macAddressFilterTable-Delete-0
				        			newPath = colPath + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";	
				        			
				        			//newPath = "/dom[@domain='192.168.0.1']//input[#'macAddressFilterTable-"+delCheck+"']";
				        														//dom[@domain='192.168.0.1']//input[#'macAddressFilterTable-Delete-0']
				        			//Report.Info("newPath ", newPath);
				        			Ranorex.InputTag MACFilterTableDeleteTag = newPath;
							        if (MACFilterTableDeleteTag.Checked.ToString() == "False"){
							        	Report.Info("----------------- MACFilterTableDeleteTag was False ---");
							        	Delay.Seconds(1);
							        	MACFilterTableDeleteTag.Click();
							        	MACFilterTableDeleteTag.PerformClick();
							        	MACFilterTableDeleteTag.Checked = "Checked";
							        	Delay.Seconds(1);
							        }else{
										Report.Info(" MACFilterTableDeleteTag is already marked for deletion ");
									}
				        			string rst = "The following MACFilter_Filtering rule is deleted permanently !!!";
									Report.Success(rst);
						        	Report.Screenshot("MACFilter_Filtering",col.Element,true);

				        	
				        		//	}	        			
		        			
							}else{
								Report.Info(" Different wireless radio frequency ");
							}	//end of IF-ELSE : Wireless_radio frequency
						}
						j++;	//column number
					}	//end of foreach - column
					rowNum++;
			        delCheck++;	//counter to select delete checkbox
	     	}	//end of foreach - row
				TestSuite.Current.GetTestCase("Delete_All_Devices_From_MAC_Filter_List_2_4GHz_Pmry_Wireless").Checked = true;
		    }	//end of if-else
        }	//end of function

    }
}