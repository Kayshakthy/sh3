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
	public partial class Add_Device_To_MAC_List
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		int TotalRows =0,initColCount=0;
		private void Init()
		{
			// Your recording specific initialization code goes here.
			Delay.Seconds(20);
			WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
			webDocument1.WaitForDocumentLoaded();
			TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']");

			//highlight the new MACFiltering rule
			IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
			TotalRows = rows1.Count;
			Report.Info("------Inside Init()------ TotalRows" ,TotalRows.ToString());
			if(TotalRows ==1){
				foreach (var row in rows1){
					IList<TdTag> cols = row.Find<TdTag>("./td");
					string tempColCount = cols.Count.ToString();
					initColCount = Int32.Parse(tempColCount);
					Report.Info("initColCount : " + initColCount.ToString());
				}
			}
		}

		public void Validate_Devices_In_Wireless_List()
		{
			//This method is to check whether the MACFilter rules are addded successfully
			Delay.Seconds(30);
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";
			TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']");
			IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
			int rowsCnt = rows.Count;
			Report.Info("Total Rules(RowsCnt)",rowsCnt.ToString());
			if(TotalRows == 1 && TotalRows == rowsCnt){
				if(initColCount ==1){
					Report.Info("//-------------------- TotalRows == 1 && TotalRows == rowsCnt--------// ");
					int rowNum = 1;
					foreach (var row in rows){
						Report.Info("Row: " + rowNum);
						
						IList<TdTag> cols = row.Find<TdTag>("./td");
						int currentColCnt = cols.Count;
						Report.Info("currentColCnt : " + currentColCnt.ToString());
						foreach(TdTag MacCol in cols){
							Report.Info(MacCol.InnerText.ToString());
						}
						if((rowNum == rowsCnt) && (currentColCnt == 1)){
							Report.Failure("Unable to add the selected  device to the Wireless MAC Filtering list " );
							Report.Screenshot();
							break;
						}else if(rowNum == rowsCnt){	//to get the last  added rule (row)
							Report.Info("//-------------------- rowNum == rowsCnt ------------------------// ");
							Mouse.ScrollWheel(10);
							row.EnsureVisible();
							//Report.Info("Valid... New MAC Filtering Rule is added!");
							Report.Success("Valid... New MAC Filtering Rule is added!");
							Report.Screenshot("macAddressFilterTable",row.Element,true);
							break;
						}
						rowNum++;
					}
				}else{
					Report.Failure("Unable to add this Wireless MAC Filtering Rule " );
					Report.Screenshot();
				}
			}else if(TotalRows > 1 && TotalRows == rowsCnt ){		// no rows are added
				Report.Info("//-------------------- TotalRows == rowsCnt ------------------------// ");
				/*
				DivTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'errTip_MACAddress']");
				Report.Failure("macAddressFilterTable","Unable to add this new rule because of the below mentioned error!!! ");
				Delay.Seconds(5);
				errorTable.EnsureVisible();
				Report.Screenshot("macAddressFilterTable",errorTable.Element,true);
				return;
				 */
				//if(TotalRows >=32){
				//	Report.Failure("macAddressFilterTable","Maximum number devices (32) is already added for this band ");
				//	Delay.Seconds(5);
				//	Report.Screenshot();
				//	return;
				//}else{
				//}
				
				// if No.of 2.4GHz is equal to 32 or No.of 5GHz is equal to 32, if it is true  display filter full message else display error message
				if(rowsCnt>=32){
					Report.Info("The total number MAC filters are more than 32");
					this.Validate_MACAddressIsAlreadyInUse();
					Report.Screenshot();
				}else{
					DivTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'errTip_MACAddress']");
					//Device already in filter list
					Report.Failure("macAddressFilterTable","Unable to add this new rule because of the below mentioned error!!! ");
					Delay.Seconds(5);
					errorTable.EnsureVisible();
					Report.Screenshot("macAddressFilterTable",errorTable.Element,true);
					Report.Screenshot();
					return;
				}
				
			}else{		// there are difference in rows
				Report.Info("//-------------------- Rules are added -----------------//");
				int rowNum = 1;
				foreach (var row in rows)
				{
					if(rowNum == rowsCnt){	//to get the last  added rule (row)
						Report.Info("//-------------------- rowNum == rowsCnt ------------------------// ");
						Mouse.ScrollWheel(10);
						row.EnsureVisible();
						//Report.Info("Valid... New MAC Filtering Rule is added!");
						Report.Success("Valid... New MAC Filtering Rule is added!");
						Report.Screenshot("macAddressFilterTable",row.Element,true);
						Report.Screenshot();
						break;
					}
					rowNum++;
				}	//end of for-loop
			}	//end of if-else
		}	//end of method Validate_Devices_In_Wireless_List

		public void Validate_ButtonOK()
		{
			Report.Screenshot();
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (WindowText='OK') on item 'MessageFromWebpage.ButtonOK'.", repo.MessageFromWebpage.ButtonOKInfo);
			Validate.Attribute(repo.MessageFromWebpage.ButtonOKInfo, "WindowText", "OK");
			if(TotalRows == 32 || TotalRows == 63){
				Report.LogHtml(ReportLevel.Success,"WirelessFilter","MAC Filter table is Full for 2.4GHz or 5GHz frequency devices");
			}
			Report.Screenshot();
		}

        public void Validate_MACAddressIsAlreadyInUse()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='MAC address is already in use.') on item 'WebDocument19216801.MACAddressIsAlreadyInUse'.", repo.WebDocument19216801.MACAddressIsAlreadyInUseInfo);
            Validate.Attribute(repo.WebDocument19216801.MACAddressIsAlreadyInUseInfo, "InnerText", "MAC address is already in use.");
        }

	}
}