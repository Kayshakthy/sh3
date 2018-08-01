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

//added on 04/08/17, to use IPAddress class
using System.Net;
using System.Globalization;

namespace ArrisTest
{
	public partial class Verify_Device_Connection_Status_Information_IPv6
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void Verify_Device_Info_IPv6(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6)
		{
			//Standard specification compliant : argument1
			//Hardware version : argument2
			//Software version : argument3
			//Cable modem serial number : argument4
			//Network access : argument5
			//Cable MAC address : argument6
			Report.Info(" INSIDE  Verify_Device_Info_IPv6   ");
			Duration newDuration = new Duration(240000);
			repo.WebDocument19216801.DivButtonsInfo.WaitForExists(newDuration);
			
			//-----  Hub3.0 device info ----//
			//Hardware version, software ver,Cable Mac,cable modem serial number, system up time, netork access
			
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";
			webDocument.WaitForDocumentLoaded();
//			Report.Info(webDocument.GetHtml());
			TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'Hub 3.0 device information']/table");
			//Count the total no of rows
			IList<TrTag> totalDeviceRows = myTable.Find<TrTag>("./tbody//tr");
			int rulesCount = totalDeviceRows.Count;
			string totalDeviceInfoRows = rulesCount.ToString() + " : Rows :";
			Report.Info(" Hub 3.0 device information ",totalDeviceInfoRows);
			
			if(rulesCount == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("Device Info ","There are no active Hub 3.0 device information !!");
				return;
			}else{
				Report.Info(" There are " + totalDeviceInfoRows + " in Hub 3.0 device information !!! ");
				int rowNum = 1;
				string devInfo = "",devInfoCol1 = "",deviceInfo="", devInfoSubstr = "";
				foreach (var row in totalDeviceRows)
				{
					Report.Info("Row: " + rowNum);
//					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
					int colNum = 1;
					foreach(TdTag MacCol in cols){
//						Report.Info("MacCol: " + colNum);
						if(colNum ==1){
							devInfoCol1 = MacCol.InnerText;
							//Report.Info("Col1 Info: "+MacCol.InnerText);
							//Report.Info("Col1 Info: " + devInfoCol1);
						}if(colNum ==2){
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							foreach(SpanTag spanVal in spanVals){
								devInfo = spanVal.InnerText;
								if(devInfo.Length > 0){
									devInfoSubstr = devInfo.Substring(1,devInfo.Length-1);	// for validation purpose
								}else{
									//blank
									devInfoSubstr = "";
								}
								//Report.Info(  "	devInfoSubstr 	" + devInfoSubstr);
							}
							//Report.Info("Col2 Info: "+devInfo);
							deviceInfo =  devInfoCol1 + "		" + devInfo;
							//Report.Info( devInfoCol1 + "		" + devInfo);
							Report.Info(deviceInfo);
							//Report.LogHtml(ReportLevel.Info, "deviceInfo", "<a>deviceInfo</a>");
							
							//perform Hub 3.0 device information validation here
							//Standard specification compliant : DOCSIS 3.0
							//Hardware version : 10
							//Software version : 9.1.116V
							//Cable MAC address : C0:05:C2:00:24:1B
							//Cable modem serial number : AAAP51770041
							//System up time : 0 days 17h:38m:47s
							//Network access : Allowed
							if(rowNum == 1 ){
								//Standard specification compliant
								if(devInfoSubstr.Length == 0){
									Report.Failure("	Standard specification compliant  is BLANK 	");
								}else if(devInfoSubstr.Trim().Equals(argument1.Trim())){
									Report.Success(  "	Standard specification compliant  	" + " PASS");
								}else{
									Report.Failure("	Standard specification compliant  	" + " FAIL");
								}
							}else if (rowNum == 2){
								//Hardware Version
								if(devInfoSubstr.Length == 0){
									Report.Failure("	Hardware Version  is BLANK 	");
								}else if(devInfoSubstr.Trim() == argument2.Trim() ){
									Report.Success(  "	Hardware Version  	" + " PASS");
								}else{
									Report.Failure("	Hardware Version  	" + " FAIL");
								}
							}else if (rowNum == 3){
								//Software Version
								if(devInfoSubstr.Length == 0){
									Report.Failure("	Software Version  is BLANK 	");
								}else if(devInfoSubstr.Trim() == argument3.Trim() ){
									Report.Success(  "	Software Version  	" + " PASS");
								}else{
									Report.Failure("	Software Version  	" + " FAIL");
								}
							}else if (rowNum == 4){
								//MAC Address - C0:05:C2:00:24:1B
								if(devInfoSubstr.Length == 0){
									Report.Failure("	MAC Address  is BLANK 	");
								}else if(devInfoSubstr.Trim() == argument6.Trim() ){
									Report.Success(  "	MAC Address  	" + " PASS");
								}else{
									Report.Failure("	MAC Address  	" + " FAIL");
								}
							}else if(rowNum == 5){
								//Cable modem serial number
								if(devInfoSubstr.Length == 0){
									Report.Failure("	Cable modem serial number  is BLANK 	");
								}else if(devInfoSubstr.Trim() == argument4.Trim() ){
									Report.Success(  "	Cable modem serial number  	" + " PASS");
								}else{
									//validate Cable modem serial number
									Report.Failure(  "	Cable modem serial number  	" + " FAIL");
								}
							}else if (rowNum == 6){
								//System up time
								if(devInfoSubstr.Length == 0){
									Report.Failure("	System uptime  is BLANK 	");
								}else{
									//Validate system time format
									//Report.Info("Need to Validate system time format");
									//Report.Failure("	System up time  	" + " FAIL");
								}
							}else if(rowNum == 7) {
								//Network access
								if(devInfoSubstr.Length == 0){
									Report.Failure("	Network access  is BLANK 	");
								}else if(devInfoSubstr.Trim() == argument5.Trim() ){
									Report.Success(  "	Network access  	" + " PASS");
								}else{
									Report.Failure("	Network access  	" + " FAIL");
								}
							}
							
						}
						colNum++;
					}// end of COLUMN for-loop
					rowNum++;
				}//end of totalDeviceRows for-loop
			}//end if IF-ELSE
			
			
			//-------------------------- WANIPSettingInfo - MAC Address ------------------------------//
			
			// /dom[@page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?device_status&mid=Info']//div[#'WANIPSettingInfo}}']/table
			//MAC address
			TableTag myTable3 = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'WANIPSettingInfo}}']/table");
			//Count the total no of rows
			IList<TrTag> totalDeviceRows3 = myTable3.Find<TrTag>("./tbody//tr");
			int rulesCount3 = totalDeviceRows3.Count;
			string totalDeviceInfoRows3 = rulesCount3.ToString() + " : Rows :";
			Report.Info(" Hub 3.0 WANIPSettingInfo  ",totalDeviceInfoRows3);
			if(rulesCount3 == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("Device Info ","There are no WAN IP information !!");
				return;
			}else{
				Report.Info(" There are " + totalDeviceInfoRows3 + " in Hub 3.0 WANIPSettingInfo !!! ");
				int rowNum3 = 1;
				string WANIPInfo3 = "",WANIPInfoCol3 = "",WANInfo3="",WANIPInfoSubstr3 ="" ;
				foreach (var row in totalDeviceRows3)
				{
					Report.Info("Row: " + rowNum3);
					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
					//Report.Info(" Total Column ", cols.Count.ToString());
					int colNum3 = 1;
					foreach(TdTag MacCol in cols)
					{
						Report.Info("MacCol: " + colNum3);
						if(colNum3 == 1){
							WANIPInfoCol3 = MacCol.InnerText;
							Report.Info("Col1 Info: "+WANIPInfoCol3);
						}else if(colNum3 == 2){
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							foreach(SpanTag spanVal in spanVals){
								WANIPInfo3 = spanVal.InnerText;
								WANIPInfoSubstr3 = WANIPInfo3.Substring(1,WANIPInfo3.Length-1);	// for validation purpose
//								Report.Info(  "	WANIPInfoSubstr 	" + WANIPInfoSubstr1);
							}
							WANInfo3 = WANIPInfoCol3 + "		" + WANIPInfo3;
							Report.Info(WANInfo3);
							if(rowNum3 == 1){
								//MAC Address - C0:05:C2:CF:14:9D
								if(WANIPInfoSubstr3.Length == 0){
									Report.Failure("	MAC Address  is BLANK 	");
								}else if(WANIPInfoSubstr3.Trim() != argument6.Trim() ){
									Report.Success(  "	MAC Address  	" + " PASS");
								}else{
									Report.Failure("	MAC Address  	" + " FAIL");
								}
							}
						}
						colNum3++;
						
					}// end of COLUMN for-loop
					rowNum3++;
					
				}//end of ROW for-loop : totalDeviceRows4
				
			}//end if IF-ELSE	: WAN IP settings -Info
			
			
			
			//------------------------------------- WAN IP settings - IPv6 Info -----------------------------------------------------//
			
			// IPv6 address, default gateway,IPv6 lease time, IPv6 lease expire, IPv6 DNS server
			TableTag myTable1 = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'WANIPv6Info']/table");
			//Count the total no of rows
			IList<TrTag> totalDeviceRows1 = myTable1.Find<TrTag>("./tbody//tr");
			int rulesCount1 = totalDeviceRows1.Count;
			string totalDeviceInfoRows1 = rulesCount1.ToString() + " : Rows :";
			Report.Info(" Hub 3.0 WAN IPv6 information  ",totalDeviceInfoRows1);
			
			if(rulesCount1 == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("Device Info ","There are no WAN IP information !!");
				return;
			}else{
				Report.Info(" There are " + totalDeviceInfoRows1 + " in Hub 3.0 WAN IPv6 information !!! ");
				int rowNum1 = 1;
				string WANIPInfo1 = "",WANIPInfoCol1 = "",WANInfo1="",WANIPInfoSubstr1 ="" ;
				foreach (var row in totalDeviceRows1)
				{
					Report.Info("Row: " + rowNum1);
					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
					//Report.Info(" Total Column ", cols.Count.ToString());
					int colNum1 = 1;
					foreach(TdTag MacCol in cols)
					{
						Report.Info("MacCol: " + colNum1);
						if(colNum1 == 1){
							WANIPInfoCol1 = MacCol.InnerText;
							Report.Info("Col1 Info: "+WANIPInfoCol1);
						}else if(colNum1 == 2){
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							foreach(SpanTag spanVal in spanVals){
								WANIPInfo1 = spanVal.InnerText;
								WANIPInfoSubstr1 = WANIPInfo1.Substring(1,WANIPInfo1.Length-1);	// for validation purpose
//								Report.Info(  "	WANIPInfoSubstr 	" + WANIPInfoSubstr1);
							}
							WANInfo1 = WANIPInfoCol1 + "		" + WANIPInfo1;
							Report.Info("WANInfo1  : " + WANInfo1);
							
//							Row: 1 		IPv6 address
//							Row: 2		IPv6 default gateway
//							Row: 3		IPv6 lease time
//							Row: 4 		IPv6 lease expire
//							Row: 5 		IPv6 DNS servers
							if(rowNum1 == 1 || rowNum1 == 2 || rowNum1 == 5 ){
								Report.Info(" To check IPv6 address type ");
							}else if(rowNum1 == 3){		//IPv6 lease time
								if(WANIPInfoSubstr1.Length == 0){
									Report.Failure("	InValid IPv6 lease time 	");
								}else{
									Report.Success(" Valid IPv6 lease time  ");
								}
							}else if(rowNum1 == 4){		//IPv6 lease expire
								//2017-08-10 11:56:40.00
								if(WANIPInfoSubstr1.Length == 0){
									Report.Failure("	InValid IPv6 lease expire 	");
								}else{
									Boolean CheckDateTime = CheckDateTimeValid(WANIPInfoSubstr1.Trim()); //calling CheckDateTimeValid()
									if(CheckDateTime){
										Report.Success("  Valid IPv6 lease expire  ");
									}else{
										Report.Failure("  InValid IPv6 lease expire ");
									}
								}
							}
						}
						colNum1++;
						
					}// end of COLUMN for-loop
					rowNum1++;
					
				}//end of ROW for-loop : totalDeviceRows1
			}//end if IF-ELSE	: WAN IP settings - IPv6 Info
			
			
			//-------------------------- WAN IP settings - IPv4 Info ------------------------------------------//
			//MAC address, IPv4 address, default gateway,IPv4 lease time, IPv4 lease expire, IPv4 DNS server
			
			TableTag myTable2 = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'WANIPv4Info']/table");
			//Count the total no of rows
			IList<TrTag> totalDeviceRows2 = myTable2.Find<TrTag>("./tbody//tr");
			int rulesCount2 = totalDeviceRows2.Count;
			string totalDeviceInfoRows2 = rulesCount2.ToString() + " : Rows :";
			Report.Info(" Hub 3.0 WAN IP information  ",totalDeviceInfoRows2);
			
			if(rulesCount2 == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("Device Info ","There are no WAN IP information !!");
				return;
			}else{
				Report.Info(" There are " + totalDeviceInfoRows2 + " in Hub 3.0 WANIPv4 information !!! ");
				int rowNum2 = 1;
				string WANIPInfo2 = "",WANIPInfoCol2 = "",WANInfo2="",WANIPInfoSubstr2 ="" ;
				foreach (var row in totalDeviceRows2)
				{
					Report.Info("Row: " + rowNum2);
//					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
					//Report.Info(" Total Column ", cols.Count.ToString());
					int colNum2 = 1;
					foreach(TdTag MacCol in cols){
						Report.Info("MacCol: " + colNum2);
						if(colNum2 == 1){
							WANIPInfoCol2 = MacCol.InnerText;
							//Report.Info("Col1 Info: "+MacCol.InnerText);
							//Report.Info("Col1 Info: "+WANIPInfoCol1);
						}else if(colNum2 == 2){
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							foreach(SpanTag spanVal in spanVals){
								WANIPInfo2 = spanVal.InnerText;
								WANIPInfoSubstr2 = WANIPInfo2.Substring(1,WANIPInfo2.Length-1);	// for validation purpose
								//Report.Info(  "	WANIPInfoSubstr 	" + WANIPInfoSubstr);
							}
							Report.Info("Col2 Info: "+ WANIPInfo2);
							WANInfo2 = WANIPInfoCol2 + "		" + WANIPInfo2;
							//Report.Info( WANIPInfoCol1 + "		" + WANIPInfo);
							Report.Info("WANInfo2 : " + WANInfo2);
							//Report.LogHtml(ReportLevel.Info, "WANInfo", "<a>WANInfo</a>");
							
							//perform WAN IP Settings validation here
							
							//IPv4 address : 80.2.153.121
							//Default gateway : 80.2.153.97
							//IPv4 lease time : 0 days 19h:24m:26s
							//IPv4 lease expire : 2016-07-01 04:09:29.00
							//IPv4 DNS servers : 194.168.4.100
							if(rowNum2 == 1 || rowNum2 == 2 || rowNum2 == 5 ){
								//IP Address Validation
								if(WANIPInfoSubstr2.Length == 0){
									Report.Failure("	InValid IP Address 	");
								}else{
									Boolean CheckIPAddress = CheckIPAddressValid(WANIPInfoSubstr2.Trim());//Calling CheckIPAddressValid()
									if(CheckIPAddress){
										Report.Success("Valid IP Address");
									}else{
										Report.Failure("InValid IP Address....It is : " + WANIPInfoSubstr2 );
									}
								}
							}else if(rowNum2 == 3){
								//IPv4 lease time validation
								if(WANIPInfoSubstr2.Length == 0){
									Report.Failure("	InValid IPv4 lease time 	");
								}else{
									/*
			        				Boolean CheckDateTime = CheckDateTimeValid(WANIPInfoSubstr.Trim()); //calling CheckDateTimeValid()
      								if(CheckDateTime){
				        				Report.Success("  Valid IPv4 lease time  ");
				        			}else{
				        				Report.Failure("  InValid IPv4 lease time ");
				        			}
									 */
									Report.Success(" Valid IPv4 lease time  ");
								}
							}else if(rowNum2 == 4){
								//string input = "2016-07-15 09:21:27.00";	//"???"
								if(WANIPInfoSubstr2.Length == 0){
									Report.Failure("	InValid IPv4 lease expire 	");
								}else{
									Boolean CheckDateTime = CheckDateTimeValid(WANIPInfoSubstr2.Trim()); //calling CheckDateTimeValid()
									//Boolean CheckDateTime = CheckDateTimeValid("???");
									if(CheckDateTime){
										Report.Success("  Valid IPv4 lease expire  ");
									}else{
										Report.Failure("  InValid IPv4 lease expire ");
									}
								}
							}//end of rowNum1 IF-ELSE
						}
						colNum2++;
						
					}// end of COLUMN for-loop
					rowNum2++;
					
				}//end of ROW for-loop : totalDeviceRows1
			}//end if IF-ELSE	: WAN IP settings - IPv6 Info
			
			
			//---------------------------------------------  WANDSLiteInfo --------------------------------------------------------//
			//	/dom[@page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?device_status&mid=Info']//div[#'WANDSLiteInfo']/table
			
			TableTag myTable4 = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'WANDSLiteInfo']/table");
			//Count the total no of rows
			IList<TrTag> totalDeviceRows4 = myTable4.Find<TrTag>("./tbody//tr");
			int rulesCount4 = totalDeviceRows4.Count;
			string totalDeviceInfoRows4 = rulesCount4.ToString() + " : Rows :";
			Report.Info(" Hub 3.0 WANDSLiteInfo  ",totalDeviceInfoRows4);
			if(rulesCount4 == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("Device Info ","There are no WANDSLiteInfo !!");
				return;
			}else{
				Report.Info(" There are " + totalDeviceInfoRows4 + " in Hub 3.0 WANDSLiteInfo !!! ");
				int rowNum4 = 1;
				string WANIPInfo4 = "",WANIPInfoCol4 = "",WANInfo4="",WANIPInfoSubstr4 ="" ;
				foreach (var row in totalDeviceRows4)
				{
					Report.Info("Row: " + rowNum4);
					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
					//Report.Info(" Total Column ", cols.Count.ToString());
					int colNum4 = 1;
					foreach(TdTag MacCol in cols){
						Report.Info("MacCol: " + colNum4);
						colNum4++;
						
					}// end of COLUMN for-loop
					rowNum4++;
					
				}//end of ROW for-loop : totalDeviceRows4
			}//end if IF-ELSE	: WANDSLiteInfo
			
		}
		// Validate IP Address
		public Boolean CheckIPAddressValid(String strIP)
		{
			//string addrString = "192.168.0.1";
			string addrString = strIP;
			IPAddress address;
			if (IPAddress.TryParse(addrString, out address)) {
				//Valid IP, with address containing the IP
				return true;
			} else {
				//Invalid IP
				return false;
			}

		}
		// to va;lidate date/time
		public Boolean CheckDateTimeValid(String strDateTime)
		{
			string input = strDateTime;
			System.DateTime dateTime;
			if (System.DateTime.TryParse(input, out dateTime))
			{
				return true;
			}else{
				return false;
			}
		}

	}
}