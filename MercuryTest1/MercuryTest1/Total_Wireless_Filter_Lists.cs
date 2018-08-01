/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 02/08/2016
 * Time: 16:06
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
    /// Description of Total_Wireless_Filter_Lists.
    /// </summary>
    [TestModule("656159FF-F886-4124-9683-8133C1414B83", ModuleType.UserCode, 1)]
    public class Total_Wireless_Filter_Lists : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Total_Wireless_Filter_Lists()
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
//            this.Count_Wireless_Filtering_Lists();
//			string radioType = "5GHz";	//2.4GHz
//			int wirelessRatioTypeCount = this.Count_Wireless_Filtering_Lists(radioType);
			this.Count_Wireless_Filtering();
        }
        public void Count_Wireless_Filtering()
        {
        	//count total number of Wireless MAC filtering rules
        	int TotalRows =0;
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            Delay.Seconds(40);
            //TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
			TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            int Wireless_5GHz_MAC=0, Wireless_2GHz_MAC=0;
//            if it is just 1 row  need to check if it is an invalid filter
            if(TotalRows == 1){
            	IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td"); 
				foreach(TdTag MacCol in cols) {
					//Report.Info("Column",j.ToString());
					Report.Info(MacCol.InnerText);
					if(MacCol.InnerText.ToString().StartsWith("You have not selected")){	//No reserved rule! --R3.8
//						You have not selected a device to filter. Please select a device from the attached devices list.
						//Report.Info("No DHCP filtering rule exists !!!");
						//return Wireless_5GHz_MAC;	
//	     				Report.Failure("Wireless_Filter ","There are no Wireless_Filters  !!");
	     				Report.Success("Wireless_Filter ","There are no Wireless_Filters  !!");
	     				return;
					}else{
						Report.Info("Wireless_Filter",TotalRows.ToString());
						break;
					}
            	}
			}else{
//			  int Wireless_5GHz_MAC=0, Wireless_2GHz_MAC=0;
//            Report.Info("DHCP_Resv Rule(s) ",rowsCnt.ToString());	
              Report.Info("Total Wireless_MAC_Filter:  "+TotalRows.ToString());
              //count 5GHz,2GHz filters separetly
              int rowNum = 1;
              string WirelessRadioType="";
              bool isSuccess = true;
              foreach (var row in rows1){
              	IList<TdTag> cols = row.Find<TdTag>("./td");
              	int colNum = 1;
//              	Report.Info("rowNum: " + rowNum);
              	foreach(TdTag MacCol in cols){
//              		Report.Info("colNum: " + colNum);
//              		Report.Info("Col1 Info: "+MacCol.InnerText);
              		if(colNum ==3){
//              			Report.Info(MacCol.GetInnerHtml().ToString());
              			IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
//              			Report.Info("span count :  "+spanVals.Count);
              			
              			foreach(SpanTag spanVal in spanVals){
              				WirelessRadioType = spanVal.InnerText;
//              				Report.Info("WirelessRadioType : " + WirelessRadioType);
              			}
              			//WirelessRadioType = MacCol.InnerText.Trim();
              			if((WirelessRadioType.StartsWith("5GHz")) || (WirelessRadioType.StartsWith("5 GHz"))){
              				Wireless_5GHz_MAC ++;
              			}else if(WirelessRadioType.StartsWith("2.4GHz") || (WirelessRadioType.StartsWith("2.4 GHz"))){
              				Wireless_2GHz_MAC ++;
              			}else{
              				isSuccess = false;
              				Report.Info("Wireless_5GHz_MAC : " + Wireless_5GHz_MAC + " Wireless_2GHz_MAC : " + Wireless_2GHz_MAC);
              				Report.Failure("WirelessRadioType is neither 5GHz nor 2.4GHz ");
              			}
              		}
              		colNum++;
              	}	// end of COLUMN for-loop
              	rowNum++;
              }	//end of ROW for-loop
              if(isSuccess){
					Report.Success("Wireless_5GHz_MAC Filter : " + Wireless_5GHz_MAC + "<====> "+ "Wireless_2.4GHz_MAC Filter : "+ Wireless_2GHz_MAC);
              }else{
              		Report.Failure("WirelessRadioType is neither 5GHz nor 2.4GHz ");
              }
        	}//end of IF_ELSE        	
        }
        public int Count_Wireless_Filtering_Lists(string wirelessRadioType)
        {
        	//count total number of Wireless MAC filtering rules
        	Report.Info("---- inside Count_Wireless_Filtering_Lists --- ");
        	int TotalRows =0;
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            Delay.Seconds(40);
            //TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
			TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 
													//	/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            int Wireless_5GHz_MAC=0, Wireless_2GHz_MAC=0;
            bool isSuccess = true;
            Report.Info("Total Wireless_MAC_Filter:  "+TotalRows.ToString());
            if(TotalRows == 1){
            	IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td"); 
				foreach(TdTag MacCol in cols) {
            		Report.Info(MacCol.InnerText);
					if(MacCol.InnerText.ToString().StartsWith("You have not selected")){
            			return 0;
            		}else{
            			return 1;
            		}
            	}
            	return 0;
            }else{
            	Report.Info("Total Wireless_MAC_Filter:  "+TotalRows.ToString());
            	int rowNum = 1;
            	string WirelessRadioType="";
            	foreach (var row in rows1){
            		IList<TdTag> cols = row.Find<TdTag>("./td");
            		int colNum = 1;
            		//              	Report.Info("rowNum: " + rowNum);
            		foreach(TdTag MacCol in cols){
            			//              		Report.Info("colNum: " + colNum);
            			//              		Report.Info("Col1 Info: "+MacCol.InnerText);
            			if(colNum ==3){
            				//              			Report.Info(MacCol.GetInnerHtml().ToString());
            				IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
            				//              			Report.Info("span count :  "+spanVals.Count);
            				
            				foreach(SpanTag spanVal in spanVals){
            					WirelessRadioType = spanVal.InnerText;
            					//              				Report.Info("WirelessRadioType : " + WirelessRadioType);
            				}
            				//WirelessRadioType = MacCol.InnerText.Trim();
            				if((WirelessRadioType.StartsWith("5GHz"))|| (WirelessRadioType.StartsWith("5 GHz"))){
            					Wireless_5GHz_MAC ++;
            					isSuccess = true;
            				}else if((WirelessRadioType.StartsWith("2.4GHz")) || (WirelessRadioType.StartsWith("2.4 GHz"))){
            					Wireless_2GHz_MAC ++;
            					isSuccess = true;
            				}else{
            					isSuccess = false;
            					//Report.Failure("WirelessRadioType is neither 5GHz nor 2.4GHz ");
            					Wireless_5GHz_MAC = 0; Wireless_2GHz_MAC = 0;
            					break;
            				}
            			}
            			colNum++;
            		}	// end of COLUMN for-loop
            		rowNum++;
            	}	//end of ROW for-loop
            	//return 0;
            	if(isSuccess){
            		Report.Info("Wireless_5GHz_MAC Filter : " + Wireless_5GHz_MAC + "<====> "+ "Wireless_2.4GHz_MAC Filter : "+ Wireless_2GHz_MAC);
            		if((wirelessRadioType.StartsWith("5GHz")) || (wirelessRadioType.StartsWith("5 GHz"))){
            			return Wireless_5GHz_MAC;
            		}else if((wirelessRadioType.StartsWith("2.4GHz")) || (wirelessRadioType.StartsWith("2.4 GHz"))){
            			return Wireless_2GHz_MAC;
            		}else{
            			return 0;
            		}
            		
            	}else{
            		Report.Info("WirelessRadioType is neither 5GHz nor 2.4GHz ");
            		if((wirelessRadioType.StartsWith("5GHz")) || (wirelessRadioType.StartsWith("5 GHz"))){
            			return Wireless_5GHz_MAC;
            		}else if((wirelessRadioType.StartsWith("2.4GHz")) || (wirelessRadioType.StartsWith("2.4 GHz"))){
            			return Wireless_2GHz_MAC;
            		}else{
            			return 0;
            		}
            		
            	}
            }	//end of IF_ELSE

			
        }
    }
}
