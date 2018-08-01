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

//added on 24/07/17
using System.Net;
using System.Globalization;

namespace ArrisTest
{
	public partial class Choose_Attached_DHCPv6_Device_To_Add
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void Choose_Attached_DHCPv6_Device_To_Reserved_List(string argument1, string argument2, string argument3, string argument4, string argument5, string argument6, string argument7)
		{
			//choose IPv6 devices to reserve
			////choose device from the attached list
			//This method is to select any MAC filter rules to delete
			//argument1 - MAC Address1, argument2- MAC Address2
			//argument3 - MAC Address3, argument4 - MAC Address4
			//argument5 - MAC Address5, argument6 - MAC Address6
			//argument7 - Device Name
			
			Delay.Seconds(30);	// to load the pages
			WebDocument webDocument = "/dom[@domain='192.168.0.1']";
			webDocument.WaitForDocumentLoaded();
			//Report.Info(webDocument.GetHtml());

			//DHCP lease table
			
			TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'AttachedDevicesTable']");
			//Count the total no of IPv4 port Filter rules (rows)
			IList<TrTag> totalDHCPClients = myTable.Find<TrTag>("./tbody//tr");	//Row
			int rulesCount = totalDHCPClients.Count;
			string totalDHCPAttached = "Total Rules : "+rulesCount.ToString();
			Report.Info("Active Attached Devices ",totalDHCPAttached);
			
			if(rulesCount == 0){
				//Mouse.ScrollWheel(150);
				Report.Failure("DHCP List","There are no devices to add !!");
				return;
			}else{
				//if there any rules? then choose appropriate radio button
				Report.Info(" There are " + rulesCount.ToString() + " devices attached to this router  !!! ");
				int rowNum = 1;
				//int addCheck = 1;
				Boolean isMatch = false, isMacAddressMatch=false;
				string macAddress="",macAddress1="",IPAddress="", devName="", Wifi_Freq="";
				string IPAddressSubStr = "";
				macAddress = argument1+":"+argument2+":"+argument3+":"+argument4+":"+argument5+":"+argument6;

				foreach (var row in totalDHCPClients)
				{
					Report.Info("Row : " + rowNum);
//					Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");	//column
					Report.Info(" Total Columns in the Row : ",cols.Count.ToString());
					
					int colNum = 1;
					String radiobuttonPath = "";
//					Ranorex.InputTag MACFilterAttachedDeviceTag = null;
//					String newPath = "";
					foreach(TdTag MacCol in cols){
						//1- Radiobutton, 2-Device name,3-MAC address,4-IP Address,5-Lease time,6-Connected to
						Report.Info("MacCol: " + colNum);
//						Report.Info("MacCol Info: "+MacCol.InnerText);
						
						if(colNum == 1){
							radiobuttonPath = MacCol.GetPath().ToString();
						}else if (colNum == 2){
							devName=MacCol.InnerText;
							Report.Info("devName : " + devName);
						}else if(colNum == 3){	//MAC Address
							
							IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							//Report.Info("span count :  "+spanVals.Count);
							foreach(SpanTag spanVal in spanVals){
								macAddress1 = spanVal.InnerText;
								if(macAddress == macAddress1){
									Report.Info(" The device with MAC Address -  " + macAddress1 + "  - is attached to the Hub");
//									Report.Info(" Wifi_Freq  : ",Wifi_Freq);
//									Report.Info("Device Name : ", devName);
//									Report.Info("MAC Address to Add :", macAddress1);
									isMacAddressMatch = true;
									/*
//									isMatch = true;
									String newPath = "";
									int radVal = rowNum -1;
									newPath = radiobuttonPath + "/input[@name='attachedDevicesGroup' and @type='radio' and @value='"+radVal+"']";
									Ranorex.InputTag MACFilterAttachedDeviceTag = newPath;
//									MACFilterAttachedDeviceTag = newPath;
									Report.Info("MACFilterAttachedDeviceTag PATH :  ", newPath);
									
//									Delay.Seconds(1);
									MACFilterAttachedDeviceTag.PerformClick();	//MACFilterAttachedDeviceTag.Checked = "True";
									//MACFilterAttachedDeviceTag.TagValue ="2";
									Delay.Seconds(1);
//									string rst = "The following DHCP Client is added to the reserved list !!!";Report.Success(rst);
									Report.Success("The following DHCP Client is added to the reserved list !!!");
									Report.Screenshot("DHCP_Reserved_List",MacCol.Element,true);
									//Report.Screenshot("DHCP_Reserved_List",row.Element,true);
									//break;
									*/
								}
							} 
						}else if (colNum == 4){	//Ip Address
							IPAddress=MacCol.InnerText;
							//check if the IP Address is IPv6 type,if yes then click the radio button
							Report.Info(" IPAddress : " + IPAddress);
//							Report.Info(" IPAddress length : " + IPAddress.Length);
							if(IPAddress.Length <= 0){
								Report.Failure("InValid IPv4/v6 Address");

							}else if(IPAddress.Length > 0){
								Report.Info(" IPAddressLength : " + IPAddress.Length);
								IPAddressSubStr = IPAddress.Substring(0,IPAddress.Length -3);
								Report.Info("IPAddressSubStr : " + IPAddressSubStr);
							}
							//parse the IPv4 address
							Boolean CheckIPAddress = this.CheckIPv4AddressValid(IPAddressSubStr.Trim());
							
							if(CheckIPAddress){
								Report.Success("Valid IP v4/v6 Address");
								int isIPv4 = IPAddressSubStr.IndexOf('.');
//								Report.Info(isIPv4.ToString());
								
								if(isIPv4 == -1){// it is IPv6
									if(isMacAddressMatch){
										isMatch = true;
										Report.Info("It is IPv6 ");
										//choose the device and add to the reserve list
										String newPath = "";
										int radVal = rowNum -1;
										newPath = radiobuttonPath + "/input[@name='attachedDevicesGroup' and @type='radio' and @value='"+radVal+"']";
										Ranorex.InputTag MACFilterAttachedDeviceTag = newPath;
										Report.Info("MACFilterAttachedDeviceTag PATH :  ", newPath);
										Delay.Seconds(1);
										MACFilterAttachedDeviceTag.Click();
										MACFilterAttachedDeviceTag.PerformClick();
										Delay.Seconds(2);
										Report.Screenshot("DHCPv6_Reserved_List",MacCol.Element,true);
										Report.Success("The DHCPv6 Client is added to the reserved list !!!");
									}
									
								}else{
									Report.Info("It is IPv4 ");
								}
							}else{
								//IPAddress is v6
								Report.Failure("InValid IPv4/v6 Address");
								
							}
							

							
						}else if (colNum == 6){	// frequency connected to
							//IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
							//foreach(SpanTag spanVal in spanVals){
								//Wifi_Freq = spanVal.InnerText;
							//}
							Wifi_Freq = MacCol.InnerText;
//							Report.Info("Wifi_Freq : " + Wifi_Freq);
							/*
							if(isMatch){
								break;
							} */
						}
						
						colNum++;
					}	//end of forloop - cols
					if(isMatch){	//is device attached and radio button clicked ??
						Report.Info("Wifi_Frequency : ",Wifi_Freq);
						if(Wifi_Freq.Trim().StartsWith("Wi-Fi 2.4G")){
							Report.Info("This device is connected to  WI-FI 2.4G");
							//choose the device  and click radio button
								break;
						}else if(Wifi_Freq.Trim().StartsWith("Wi-Fi 5G")){
							Report.Info("This device is connected to  WI-FI 5G");
								break;
						}else if(Wifi_Freq.Trim().StartsWith("Ethernet")){
							Report.Info("This device is connected to  Ethernet");
								break;
						}else{
							Report.Info("This device is NOT connected to  WI-FI 2.4G /WI-FI 5G");
								break;
						}
						//break;
					}
					
					rowNum++;
					
				}	//end of forloop - totalDHCPClients
				
				if(!isMatch){
					string rst ="The device : " + devName + "("+ macAddress + ")"+ " does not  exist in the attached list ";
					Report.Failure("DHCPv6_Reserved_List",rst);
					TestSuite.Current.GetTestCase("Add_Device_To_DHCPv6_Reserved_List").Checked = false;	//Add_Device_To_DHCP_Reserved_List
				}else{
					TestSuite.Current.GetTestCase("Add_Device_To_DHCPv6_Reserved_List").Checked = true;	//Add_Device_To_DHCP_Reserved_List
					
				}
				
			}//end of if-else
		}//end of method
		        // Validate IP Address
        public Boolean CheckIPv4AddressValid(String strIP)
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

        }//end of method

	}
}