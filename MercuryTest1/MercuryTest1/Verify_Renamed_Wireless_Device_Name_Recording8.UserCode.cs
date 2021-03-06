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
    public partial class Verify_Renamed_Wireless_Device_Name_Recording8
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_Renamed_Wireless_Connected_Device_Name(string argument1, string argument2)
        {
        	Delay.Seconds(20);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']"; 
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'AttachedDevicesTable']"); //R3.8
     		Report.Screenshot("Devices Connected",myTable.Element,true);	// print the devices table
     	
	     	//Count the rows(total no of devices)
	     	IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
	     	int rowsCount = rows.Count;
	     	Report.Info("Total Devices Connected",rowsCount.ToString());
			if(rowsCount == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("Device Rename ","There are no connected wireless devices to rename !!");
	     		
	     		return;
	     	}else{
	     		int rowNum = 1;  
            	Boolean isWirelessMatch = false,isEthernetMatch=false;
            	int wirelessCnt=0,ethernetCnt=0;
				foreach (var row in rows)  
			    {  
			        Report.Info("Row: " + rowNum);     
			        Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        int colCnt = cols.Count;
			        int colNum = 1;
   					string deviceName="", connectionType = "";
			        foreach(TdTag MacCol in cols){			
			        	Report.Info("MacCol: " + colNum);
			        	Report.Info("MacCol Info: "+MacCol.InnerText);
			        	Report.Info(MacCol.GetInnerHtml().ToString());
			        	
			        	//column1 - device name
			        	//column5 - Wi-Fi 2.4G _VM0365087_2G  / Wi-Fi 5G _VM0365087_5G / Ethernet 
			        	if(colNum ==1){
			        		deviceName = MacCol.InnerText.Trim();
			        	}else if(colNum == 5){
			        		connectionType = MacCol.InnerText.Trim();
			        		if(argument2.Trim() == deviceName){
			        			Report.Info("connectionType  : " + connectionType);
//			        			if(connectionType.StartsWith("Wi-Fi")){
//			        			if(connectionType.StartsWith("Wireless frequency")){	//added on 02/11/17 to test code 9.1.116.600
			        			if((connectionType.StartsWith("Wi-Fi")) || (connectionType.StartsWith("Wireless frequency") )){		// 	added on 15/01/18 to test code 9.1.116.604
				        			Report.Info("Rename Wireless Connected  Device Name  is Successfull");
				        			isWirelessMatch = true;
				        			wirelessCnt++;
				        			//break;
			        			}else{
			        				Report.Info("Ethernet  Device Name ");
			        				isEthernetMatch = true;
			        				ethernetCnt++;
			        			}
			        		}//end of IF-deviceName
			        	}//end of if-else : column5
			        	
			        	colNum++;
			        }
			        rowNum++;
				}
				if(isWirelessMatch){
					Report.Info("wirelessCnt",wirelessCnt.ToString());
					if(wirelessCnt ==1){
						Report.Success("Rename Wireless Connected  Device Name  is Successfull");
					}else{
						Report.Failure("More than one Wireless Connected  Device Renamed");
					}
					
				}else if(isEthernetMatch){
					Report.Info("ethernetCnt",ethernetCnt.ToString());
					if(ethernetCnt ==1){
						Report.Failure("One  Ethernet Connected  Device Name  is Renamed instead of Wireless Device");
					}else{
						Report.Failure("More than one Ethernet Connected  Device Renamed instead of one(1) Wireless Device");
					}
				}
				Report.Screenshot();
	     	}	//end of IF-ELSE
				
     	
        }

    }
}