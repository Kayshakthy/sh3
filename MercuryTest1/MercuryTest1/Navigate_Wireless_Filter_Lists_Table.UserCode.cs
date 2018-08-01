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
    public partial class Navigate_Wireless_Filter_Lists_Table
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Check_Wireless_Filtering_Lists()
        {
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	//Report.Info(webDocument.GetHtml());
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
            //Count the total no of IPv4 port Filter rules (rows)
	     	IList<TrTag> totalMACRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalMACRules.Count;   
	     	string totalMACFilterRules = " "+rulesCount.ToString();
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
				string Wireless_radio="";
				if(colsCount > 1){	// if there is only  one row, many columns
					Report.Info(" Total column : " + colsCount.ToString());
					Report.Info(" There is  " + totalMACFilterRules + " Wireless Filter Rule  !!! ");
					int colNum = 1;
					foreach(TdTag col in cols)  
			    	{
						Report.Info("col: " + colNum);  
						if(colNum >=1 && colNum <= 2){
							string noFilterStr = col.InnerText.ToString();
							Report.Info(noFilterStr);
						}else if(colNum == 3){
							Report.Info(" 3rd Column ");
								IList<SpanTag> spanVals = col.Find<SpanTag>("./span");
				        		//Report.Info("span count :  "+spanVals.Count);
				        		foreach(SpanTag spanVal in spanVals){
				        			Wireless_radio  = spanVal.InnerText;
				        			Report.Info("Wireless_radio  : " + Wireless_radio );
				        		 }
								 //Report.Info("Wireless_radio",Wireless_radio);
								 Report.LogHtml(ReportLevel.Info,Wireless_radio,"<b>Wireless_radio frequency</b>");	
								 //if(Wireless_radio.StartsWith("Invalid Value")){
								 if(Wireless_radio.Trim().StartsWith("2.4GHz") || Wireless_radio.Trim().StartsWith("5GHz")){
								 	Report.LogHtml(ReportLevel.Success,Wireless_radio,"<b>Valid Wireless_radio frequency</b>");	
								 	break;
								 }else{
								 	Report.LogHtml(ReportLevel.Failure,Wireless_radio,"<b>Invalid Wireless_radio frequency</b>");	
								 	break;								 	
								 }
						}
						colNum++;
					}					
				}else{	// if there is only one row, one column
					Report.Info(" Total column : " + colsCount.ToString());
					foreach(TdTag col in cols)  
			    	{
						string noFilterStr = col.InnerText.ToString();
						Report.Info(noFilterStr);
						if(noFilterStr.StartsWith("No filtering")){	//No filtering device!
				     		Report.Failure("Wireless Filter","There are no wireless filters !!");
				     		//TestSuite.Current.GetTestCase("Delete_Any_MAC_Filtering_Rules").Checked = false;
				     		return;						
						}else if(noFilterStr.StartsWith("You have not selected")){
							//You have not selected a device to filter. Please select a device from the attached devices list.
							Report.Failure("Wireless Filter","There are no wireless filters !!");
						}
					}						
				} //end of IF-ELSE
	
	     	}else{// if there are many rows
	     		Report.Info(" There are " + totalMACFilterRules + " Wireless Filter Rules  !!! ");
			    int rowNum = 1;  
				string Wireless_radio="";
			    Boolean isMatch = false;
			    foreach (var row in totalMACRules)
			    { 
			        Report.Info("Row: " + rowNum);     
			        //Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        int colNum = 1;
			        foreach(TdTag col in cols){
			        	//Report.Info("col: " + colNum);   
			        	//Report.Info("col Info: "+col.InnerText);	
 
						if(colNum >=1 && colNum <= 2){
							string noFilterStr = col.InnerText.ToString();
							Report.Info(noFilterStr);
						}else if(colNum == 3){
							//Report.Info(" 3rd Column ");
								IList<SpanTag> spanVals = col.Find<SpanTag>("./span");
				        		//Report.Info("span count :  "+spanVals.Count);
				        		foreach(SpanTag spanVal in spanVals){
				        			Wireless_radio  = spanVal.InnerText;
				        			Report.Info("Wireless_radio  : " + Wireless_radio );
				        		 }
								 //Report.Info("Wireless_radio",Wireless_radio);
								 Report.LogHtml(ReportLevel.Info,Wireless_radio,"<b>Wireless_radio frequency</b>");	
								 //if(Wireless_radio.StartsWith("Invalid Value")){
								 if((Wireless_radio.Trim().StartsWith("2.4GHz")) || (Wireless_radio.Trim().StartsWith("2.4 GHz")) || (Wireless_radio.Trim().StartsWith("5GHz")) || (Wireless_radio.Trim().StartsWith("5 GHz"))){
								 	Report.LogHtml(ReportLevel.Success,Wireless_radio,"<b>Valid Wireless_radio frequency</b>");	
								 }else{
								 	Report.LogHtml(ReportLevel.Failure,Wireless_radio,"<b>Invalid Wireless_radio frequency</b>");	
								 	isMatch = true;
								 	break;
								 }
						}
						colNum++;
			        }// end of for-loop (column-MacCol)
			        if(isMatch){
				    	break;
				    }
			        rowNum++;
			    	
			    }//end of for-loop (row-totalMACRules)
			    
			    if((rowNum-1) == rulesCount  && !isMatch){	//if all wireless_radio entries are OK ?
					Report.Info(" ===== All are Valid Wireless_radio frequencies  =====");
					Delay.Seconds(1);
			        Report.Screenshot("Wireless_Filter_list",myTable.Element,true);
			    }			    
	     	}//end of IF-ELSE
        }

    }
}