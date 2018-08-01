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
    public partial class Rename_Wireless_Device_Name
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_Wireless_Device_To_Rename(string argument1, string argument2)
        {
        	Report.Info ( " ===== Wireless_Device_To_Rename  === " + argument1);
        	
        	//		/dom[@domain='192.168.0.1']//table[#'wireless_Device']
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'wireless_Device']"); 
            
            //count the rows
            IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            //Report.Info("Total rowsCnt",rowsCnt.ToString());
            Report.Info("Total Rows",rowsCnt.ToString());
			if(rowsCnt == 0){
	     		//Mouse.ScrollWheel(150);
	     		Report.Failure("Device Rename ","There are no connected wireless devices to rename !!");
	     		TestSuite.Current.GetTestCase("Verify_Renamed_Wireless_Device_Name_In_Home_Screen").Checked = false;
	     		return;
	     	}else{
            	//Choose_Wireless_Device_For_Rename
            	int rowNum = 1;  
            	Boolean isMatch = false;
				foreach (var row in rows)  
			    {  
			        Report.Info("Row: " + rowNum);     
//			        Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        int colCnt = cols.Count;
			        //Report.Info(" Total Columns(Devices)  : ",colCnt.ToString());
			        if(colCnt > 0){
		     		  		Report.Info(" There are " + colCnt.ToString() + " devices attached to this router  !!! ");
		     		}			        
			        int colNum = 1;
			        String devicePath = "";	        
			        foreach(TdTag MacCol in cols){
			        	Report.Info(" MacCol: " + colNum);
			        	//Report.Info("MacCol Info: "+MacCol.InnerText);
//			        	Report.Info(MacCol.GetInnerHtml().ToString());
		        	
			        	IList<PTag> pVals = MacCol.Find<PTag>("./p");
			        	Report.Info(" pVals count  : ",pVals.Count.ToString());
			        	foreach(PTag pVal in pVals){
			        		string deviceName = pVal.InnerText.Trim();
			        		Report.Info(" Device Name " + deviceName);
			        		if(argument1.Trim() == deviceName.Trim()){
				        		Report.Info("This device name needs to be changed");
				        		//devicePath = MacCol.GetPath().ToString();
				        		//Report.Info("devicePath",devicePath);
				        		devicePath = MacCol.GetPath() + "/p[@innertext='"+deviceName+"']";
//				        		/dom[@domain='192.168.0.1']//table[#'wireless_Device']/?/?/tr/td[2]/p[@innertext='android-fc4d149c99a46022']
//				        		newPath = col.GetPath() + "/input[#'ipv4FilterTable-Delete-"+delCheck+"']";	
//				        		newPath = radiobuttonPath + "/input[@name='attachedDevicesGroup' and @type='radio' and @value='"+radVal+"']";
				        		Report.Info("devicePath",devicePath);
				        		Ranorex.PTag DeviceRenameTag = devicePath;
				        		Delay.Seconds(5);
				        		DeviceRenameTag.DoubleClick();
				        		DeviceRenameTag.PerformClick();
				        		//input the new friendly ( argument2) and press "Apply" button
				        		repo.WebDocumentIE.FriendlyName.Value=argument2;
//								/dom[@browsername='IE']//table[#'wireless_Device']//td/input[@type='button']
				        		String wireless_Device_applyButton_Path = "/dom[@browsername='IE']//table[#'wireless_Device']//td/input[@type='button']";
				        		Ranorex.InputTag wireless_Device = wireless_Device_applyButton_Path;
				        		wireless_Device.DoubleClick();
				        		wireless_Device.PerformClick();
				        		Delay.Seconds(5);
				        		Report.Info("---------------before click -------------");
				        				repo.WebDocument19216801.WarningWizardFrame0.Button29.Click();	//added on 09/05/18 to click YES button in  the popup window 9.1.1802.600
				        		Report.Info("----------------after click -----------------");
				        		isMatch=true;
				        		break;
				        	}
			        		 
			        	}
			        				        		
			        	colNum ++;
			        }
			        rowNum ++;
				}
				if((rowNum-1) == rowsCnt  && !isMatch){	//if device does not exist
					    Report.Info(" ===== This device does not exist =====");
					    //Delay.Seconds(1);
			        	//Report.Screenshot("Device Rename",myTable.Element,true);
			        	//Report.Screenshot();
			   }
            }        	
        }

    }
}