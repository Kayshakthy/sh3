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
    public partial class Choose_Any_5Ghz_Wireless_MAC_Filter_Device
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows1=0,TotalRows2=0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
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

        public void Choose_Any_5GHz_Wireless_MAC_Filtering_Device_To_Delete(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6, string argument7)
        {
        	//choose  any device to delete based on Device name and MAC addresses
        	//argument7 - device name, argument1- MAC 0  ....and argument6-MAC5
//        	Delay.Seconds(30);
        	if(TotalRows1 <=5 || TotalRows2<= 5){
        		Delay.Seconds(5);	// to load the pages
        	}else if((TotalRows1 >5 && TotalRows1 <=10) || ( TotalRows2 >5 && TotalRows2 <=10)){
        		Delay.Seconds(10);	// to load the pages
        	}else if((TotalRows1 >10 && TotalRows1 <=20) || ( TotalRows2 >10 && TotalRows2 <=20)){
        		Delay.Seconds(20);	// to load the pages
        	}else{
        		Delay.Seconds(30);	// to load the pages
        	}
        	
        	Report.Info("DeviceName: " + argument7 + " - " + " MAC: "+ argument1 +" : "  + argument2 +" : " +  argument3 + " : " + argument4 + " : " + argument5 +" : " + argument6);
        	
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	//Report.Info(webDocument.GetHtml());
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
            //Count the total no of IPv4 port Filter rules (rows)
	     	IList<TrTag> totalMACRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalMACRules.Count;   
	     	string totalMACFilterRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Active MAC  Filter Rules ",totalMACFilterRules);
	     	
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("MAC Filter ","There are no active rules to delete !!");
	     		TestSuite.Current.GetTestCase("Delete_Any_MAC_Filtering_Rules").Checked = false;
	     		return;
	     	}else if(rulesCount == 1){	// if there is only one row
	     		//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				if(colsCount > 1){	// if there is  only one row, many columns
					Report.Info(" Total column : " + colsCount.ToString());
					Report.Info(" There is  " + totalMACFilterRules + " Wireless Filter Rule to delete !!! ");
					int colNum = 1;	
				    int delCheck = 0;
				    Boolean isMatch = false;
				    string macAddress="",macAddress1="";
				    macAddress = argument1+":"+argument2+":"+argument3+":"+argument4+":"+argument5+":"+argument6;
				    Report.Info("MAC Address : " + macAddress);
			    
					foreach(TdTag col in cols)  
			    	{
						Report.Info("col: " + colNum);
			        	if(colNum == 2){
							//Report.Info(MacCol.InnerText);
							macAddress1 = col.InnerText;
							Report.Info("MAC Address1 : " + macAddress1);
						}else if (colNum == 3){
			        		if(macAddress == macAddress1){
			        			isMatch = true;
			        			Report.Info("----------------- Rules Matches !!! ------");
			        			String newPath = "";															
			        			newPath = col.GetPath() + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";	//fmChbx-macAddressFilterTable-Delete-0, macAddressFilterTable-Delete-0
			        			Ranorex.InputTag MACFilterTableDeleteTag = newPath;
						        if (MACFilterTableDeleteTag.Checked.ToString() == "False"){
						        	Report.Info("----------------- MACFilterTableDeleteTag was False ---");
						        	Delay.Seconds(5);
						        	MACFilterTableDeleteTag.PerformClick();
						        }else{
									Report.Info(" MACFilterTableDeleteTag is already Enabled ");
								}
			        			string rst = "The following MACFilter_Filtering rule is deleted permanently !!!";
								Report.Success(rst);
					        	Report.Screenshot("MACFilter_Filtering",myTable.Element,true);
			        		}							
						}
						colNum++;
					}//end of for loop-col
				}else{	// if there is only one row, one column
					Report.Info(" Total column : " + colsCount.ToString());
					foreach(TdTag col in cols)  
			    	{
						string noFilterStr = col.InnerText.ToString();
						Report.Info(noFilterStr);
//						if(noFilterStr.StartsWith("No filtering")){	//No filtering device!
						if(noFilterStr.StartsWith("You have not selected a device to filter")){	//You have not selected a device to filter
				     		Report.Failure("MAC Filter Devices ","There are no devie to delete !!");
				     		TestSuite.Current.GetTestCase("Delete_Any_5GHz_Wireless_MAC_Filter_Device").Checked = false;
				     		return;						
						}else{
							Report.Info(" There are " + rulesCount.ToString() + " MAC Filter Rule to delete  !!! ");
							//check if the rule is matching the condition
						}
					}					
					
				}
	     		
	     	}else{// if there are many rows
	     		//Report.Info(" There are " + totalMACFilterRules + " MAC Filter Rules to delete !!! ");
	     		Report.Info(" There are " + rulesCount.ToString() + " MAC Filter Rule(s) to delete !!! ");
			    int rowNum = 1;  
			    int delCheck = 0;
			    Boolean isMatch = false;
			    string macAddress="",macAddress1="";
			    macAddress = argument1+":"+argument2+":"+argument3+":"+argument4+":"+argument5+":"+argument6;
			    Report.Info("MAC Address : " + macAddress);
			    foreach (var row in totalMACRules)  
			    {  
			       // Report.Info("Row: " + rowNum);     
			        //Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        int colNum = 1;

			        foreach(TdTag MacCol in cols){
			        	//Report.Info("MacCol: " + colNum);   
			        	//Report.Info("MacCol Info: "+MacCol.InnerText);	
			        	if(colNum == 2){
							//Report.Info(MacCol.InnerText);
							macAddress1 = MacCol.InnerText;
							Report.Info("MAC Address1 : " + macAddress1);
						}else if (colNum == 3){
			        		// check if Mac address is matching
			        		//Report.Info("----------------- click delete checkbox ------");
			        		if(macAddress == macAddress1){
			        			isMatch = true;
			        			Report.Info("----------------- Rule Exist !!! ------");
			        			String newPath = "";															
			        			newPath = MacCol.GetPath() + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";	
			        							//fmChbx-macAddressFilterTable-Delete-0, macAddressFilterTable-Delete-0
			        							//dom[@domain='192.168.0.1']//b[#'fmChbx-macAddressFilterTable-Delete-1']
//			        			Report.Info("newPath :" + newPath);
			        			
			        			Report.Info("--------- newPath orginal ---->> " + newPath);
			        							
//			        			newPath = "/dom[@page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.100.1/?wifi_settings&mid=WirelessPrimary']//tbody[#'macAddressFilterTable_body']/tr[1]/td[3]/" + "/input[#'macAddressFilterTable-Delete-"+delCheck+"']";
//			        			newPath = "/dom[@page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?wifi_settings&mid=WirelessPrimary']/"+ "/input[#'macAddressFilterTable-Delete-"+delCheck+"']"; 	//original working statement
			        			
//			        			newPath = "/dom[@caption='Hub 3.0' and @page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?wifi_settings&mid=WirelessSecurity']//input[#'macAddressFilterTable-Delete-31']";		//added on 17/10/17 for code -116.400
			        			newPath = "/dom[@caption='Hub 3.0' and @page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?wifi_settings&mid=WirelessSecurity']//input[#'macAddressFilterTable-Delete-"+delCheck+"']";	//added on 17/10/17 for code -116.400
			        				
			        			Report.Info("--------- newPath modified ---->> " + newPath);
			        			// The above code is added to test on Windows10 platform - 23Feb2017
			        			
			        			Ranorex.InputTag MACFilterTableDeleteTag = newPath;
						        if (MACFilterTableDeleteTag.Checked.ToString() == "False"){
						        	Report.Info("----------------- MACFilterTableDeleteTag was False ---");
						        	Delay.Seconds(5);
						        	MACFilterTableDeleteTag.PerformClick();
						        	Delay.Seconds(3);
						        }else{
									Report.Info(" MACFilterTableDeleteTag is already Enabled ");
								}
			        			string rst = "The following MACFilter_Filtering rule is deleted permanently !!!";
								Report.Success(rst);
					        	Report.Screenshot("MACFilter_Filtering",row.Element,true);
					              	
			        		}
			        	}
			        	colNum++;
			        }	// end of for-loop (column)
			        if(isMatch){
				    	break;
				    }
			        rowNum++;
			        delCheck++;	//counter to select delete checkbox
			        	
			    }	//end of for-loop (row)
			    if((rowNum-1) == rulesCount  && !isMatch){	//if rule does not exist
			    	TestSuite.Current.GetTestCase("Delete_Any_5GHz_Wireless_MAC_Filter_Device").Checked = false;
					Report.Info(" ===== This Rule does not exist =====");
					Delay.Seconds(1);
			        Report.Screenshot("MAC_Filtering_Devices",myTable.Element,true);
			    }			   
	     	}           	
        }

    }
}