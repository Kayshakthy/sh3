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
    public partial class Allow_Add_Device_To_Mac_List
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        

        private void Init()
        {
              // Your recording specific initialization code goes here. 
        }

        public void Choose_Attached_Devices_To_Add_2_4GHz_Primary(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6, string argument7)
        {
        	////choose device from the attached list
			//This method is to select any MAC filter rules to add
        	//argument1 - MAC Address0, argument2- MAC Address1
        	//argument3 - MAC Address2, argument4 - MAC Address3
        	//argument5 - MAC Address4, argument6 - MAC Address5
        	//argument7 - Access Mode
        	
        	Delay.Seconds(30);	// to load the pages
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	//Report.Info(webDocument.GetHtml());
        	
        	// choose the Access Mode 	//BssAccessModeGrp
        	//Radio Button Options --> 1-DisableWMACFilter, 2-AllowAllDevices,3-DenyAllDevices
        	String AccessModeGrpPath = "";
        	if(argument7=="Disable"){
        		Report.Info("It is DISABLE");
	        	AccessModeGrpPath = "/dom[@domain='192.168.0.1']//input[@name='BssAccessModeGrp' and @type='radio' and @value='1']";// Disable
				Ranorex.InputTag BssAccessModeGrpTag = AccessModeGrpPath;
				Delay.Seconds(1);
				BssAccessModeGrpTag.PerformClick();	        			
				Delay.Seconds(1);    	        	
        	}else if(argument7=="Allow"){
        		Report.Info("It is ALLOW");
 				AccessModeGrpPath = "/dom[@domain='192.168.0.1']//input[@name='BssAccessModeGrp' and @type='radio' and @value='2']";// Allow
				Ranorex.InputTag BssAccessModeGrpTag = AccessModeGrpPath;
				Delay.Seconds(1);
				BssAccessModeGrpTag.PerformClick();	        			
				Delay.Seconds(1);     				
        	}else if(argument7=="Deny"){
        		Report.Info("It is DENY");
				AccessModeGrpPath = "/dom[@domain='192.168.0.1']//input[@name='BssAccessModeGrp' and @type='radio' and @value='3']";// Deny
				Ranorex.InputTag BssAccessModeGrpTag = AccessModeGrpPath;
				Delay.Seconds(1);
				BssAccessModeGrpTag.PerformClick();	        			
				Delay.Seconds(1);    				
        	}
     	
        	//
        	
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'AttachedDevicesTable']"); 
            //Count the total no of IPv4 port Filter rules (rows)
	     	IList<TrTag> totalMACRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalMACRules.Count;   
	     	string totalMACFilterRules = "Total Rows : "+rulesCount.ToString();
	     	//Report.Info("Active Attached Devices ",totalMACFilterRules);
	     	
	     	if(rulesCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("MAC Filter ","There are no devices to add !!");
	     		//TestSuite.Current.GetTestCase("Delete_Any_MAC_Filtering_Rules").Checked = false;
	     		return;
	     	}else{
	     		
	     		if(rulesCount > 1){
	     		  		Report.Info(" There are " + rulesCount.ToString() + " devices attached to this router  !!! ");
	     		}
			    int rowNum = 1;  
			    //int addCheck = 1;
			    Boolean isMatch = false;
			    string macAddress="",macAddress1="", devName="", Wifi_Freq="";
			    macAddress = argument1+":"+argument2+":"+argument3+":"+argument4+":"+argument5+":"+argument6;
			    
				foreach (var row in totalMACRules)  
			    {  
			        //Report.Info("Row: " + rowNum);     
			        //Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        //Report.Info(" Total Columns in the Row : ",cols.Count.ToString());
			        int colNum = 1;
			        String radiobuttonPath = "";
			        
			        foreach(TdTag MacCol in cols){
			        	//Report.Info("MacCol: " + colNum);   
			        	//Report.Info("MacCol Info: "+MacCol.InnerText);
			        	//Report.Info(MacCol.GetInnerHtml().ToString());
			        	if(colNum == 1){
			        		
			        		if(MacCol.InnerText.StartsWith("No attached devices.")){	//9.1.116v(R3.7.1)
			        			// check  for string " No attached devices."
								Report.Failure("Wireless MAC","There are no devices attached to the Hub 3.0 !!");
								TestSuite.Current.GetTestCase("Add_Device_To_MAC_Address_List").Checked = false;
								//isRuleExist=false;
								return;
								//break;
						
			        		}else{
			        			Report.Info(" There are " + rulesCount.ToString() + " devices attached to this router  !!! "); //this needs to be displayed only once
			        			
			        			//if there any rules? then choose appropriate radio button
				        		radiobuttonPath = MacCol.GetPath().ToString();	//radio button
				        		
				        		//Report.Info(MacCol.GetInnerHtml().ToString());
				        		//Report.Info(radiobuttonPath);
				        		//Report.Info("Radio button Path:",radiobuttonPath);
			        		}
			        	} else if (colNum == 2){
			        		IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
			        		foreach(SpanTag spanVal in spanVals){
			        			devName = spanVal.InnerText;
			        		}
			        	}else if (colNum == 4){
			        		// WIFi frequency connected to
			        		IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
			        		foreach(SpanTag spanVal in spanVals){
			        			Wifi_Freq = spanVal.InnerText;
			        		}
			        	}else if(colNum == 3){
			        		
							//Report.Info(MacCol.InnerText);
							//Report.Info(MacCol.GetInnerHtml().ToString());
							//macAddress1 = MacCol.InnerText;
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
			        		//Report.Info("span count :  "+spanVals.Count);
			        		 foreach(SpanTag spanVal in spanVals){
			        			macAddress1 = spanVal.InnerText;
			        			
			        			//Report.Info("devName : ", devName);
			        			//Report.Info("MAC Address to Add : " + macAddress);
			        			//Report.Info("MAC Address1 : " + macAddress1);
			        			
			        			if(macAddress == macAddress1){
			        				Report.Info("//--------------- MAC address  exist in attached device list------//");
			        				Report.Info("//---------------  Wifi_Freq -----",Wifi_Freq);
			        				macAddress1 = spanVal.InnerText;
			        				
				        			Report.Info("Device Name ", devName);
				        			Report.Info("MAC Address to Add ", macAddress);
				        			//Report.Info("MAC Address1 : " + macAddress1);
			        			
									isMatch = true;
				        			String newPath = "";
				        			//Report.Info("radiobuttonPath : ",radiobuttonPath.ToString());
				        			
				        			//newPath = radiobuttonPath + "/input[#'attachedDevicesGroup']";
				        			
				        			//newPath = "/dom[@domain='192.168.0.1']//tbody[#'AttachedDevicesTable_body']//input[@name='attachedDevicesGroup']";
				        			//newPath = radiobuttonPath + "/input[@name='attachedDevicesGroup' and @type='radio' and @value='2' ]";
				        			int radVal = rowNum -1;
				        			newPath = radiobuttonPath + "/input[@name='attachedDevicesGroup' and @type='radio' and @value='"+radVal+"']";
				        				
				        			// newPath ="/dom[@domain='192.168.0.1']//input[#'ipv4FilterTable-Enabled-"+delCheck+"']";
				        			 
				        			Ranorex.InputTag MACFilterAttachedDeviceTag = newPath;
				        			
				        			Delay.Seconds(1);
				        			//MACFilterAttachedDeviceTag.Checked = "True";
				        			MACFilterAttachedDeviceTag.PerformClick();
				        			//MACFilterAttachedDeviceTag.TagValue ="2";
				        			Delay.Seconds(1);
				        			
				        			/*
							        if (MACFilterTableDeleteTag.Checked.ToString() == "False"){
							        	Delay.Seconds(1);
							        	MACFilterTableDeleteTag.PerformClick();
							        }else{
										Report.Info(" MACFilterTableDeleteTag is already Enabled ");
									}
									*/
				        			string rst = "The following MACFilter_Filtering rule is deleted permanently !!!";
									Report.Success(rst);
						        	//Report.Screenshot("MACFilter_Filtering",MacCol.Element,true);
						        	Report.Screenshot("MAC Filter_List",row.Element,true);
					        		break;
			        			}
			        			
			        		 }	//end of SpanTag for-loop
			        		
					
						}
			        	colNum++;
			        }//TdTag for-end loop
  
			      if(isMatch){
						Report.Info("Wifi_Freq",Wifi_Freq);
			        	if(Wifi_Freq.Trim()==" WI-FI 2.4G"){
			        		Report.Info("This device is connected to  WI-FI 2.4G");
			        		//choose the device  and click radio button
			        		break;
			        	}else{
			        		Report.Info("This device is NOT connected to  WI-FI 2.4G");
			        		break;
			        	}			        	
				    	//break;
				  }
			      rowNum++;
			      //addCheck++;	//counter to select add checkbox
				} //ROW for-end loop
				
				//Report.Info("rowNum :: ",rowNum.ToString());
				if(!isMatch){
					//Report.Info(" Device does not  exist in the attached list ");

			        //Report.Info("devName : ", devName);
			        //Report.Info("MAC Address to Add : " + macAddress);
			        
					string rst ="The device : " + devName + "("+ macAddress + ")"+ " does not  exist in the attached list ";
					//Report.Failure("MAC Filter List"," This device does not  exist in the attached list ");
					
					Report.Failure("MAC Filter List",rst);
					TestSuite.Current.GetTestCase("Add_Device_To_MAC_Address_List").Checked = false;	//Add_Device_To_MAC_Address_List
				
				}else{
					TestSuite.Current.GetTestCase("Add_Device_To_MAC_Address_List").Checked = true;	//Add_Device_To_MAC_Address_List
					
				}			    
	     	}	//end of if-else
        }

        public void Choose_Filter_Option(string argument1)
        {
        	//TODO
        	
        }

    }
}