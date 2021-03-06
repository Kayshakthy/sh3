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
    public partial class Choose_Any_DHCP_Reserv_Rule
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_Any_DHCP_Reserv_Rule_To_Delete(string argument1, string argument2)
        {
        	//argument1 - MAC Address, argument2- IP Address
        	
        	//Choose_the _DHCP_Reserv_Rule_To_Delete
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	//Report.Info(webDocument.GetHtml());
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']"); 
	     	IList<TrTag> totalDHCPReservList = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalDHCPReservList.Count;   
	     	Report.Info("Total Rows in the table :" + rulesCount.ToString());
//	     	string totalDHCPReservListStr = "Total Reserv list : "+rulesCount.ToString();
//	     	Report.Info("Active DHCP Reserv list ",totalDHCPReservListStr);    
	     	if(rulesCount == 0){
	     		Report.Failure("DHCP Reserv list ","There are no active rules to delete !!");
	     		TestSuite.Current.GetTestCase("Delete_Any_DHCP_Rule").Checked = false;
	     		return;
	     	}else{
			    int rowNum = 1;  
			    int delCheck = 0;
			    Boolean isMatch = false;
			    string macAddress="",macAddress1="",ipAddress="",ipAddress1="";
			    macAddress = argument1;
			    ipAddress = argument2;
			    Report.Info("MAC Address to Delete : " + macAddress);
			    Report.Info("IP Address tp delete: " + ipAddress);
			    foreach (var row in totalDHCPReservList)  
			    {  
			        Report.Info("Row: " + rowNum);     
			        Report.Info(row.GetInnerHtml().ToString());
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        if(cols.Count == 1){
			        	Report.Info("There are no active rules to delete " );
			        	TestSuite.Current.GetTestCase("Delete_Any_DHCP_Rule").Checked = false;
	     				return;
			        }
			        Report.Info(" There are " + rulesCount.ToString() + " DHCP Rules in the Reserv list !!! ");
			        int colNum = 1;
			        foreach(TdTag MacCol in cols){
//			        	Report.Info("MacCol: " + colNum);   
//			        	Report.Info("MacCol Info: "+MacCol.InnerText);	
			        	if(colNum == 1){
							//Report.Info(MacCol.InnerText);
							macAddress1 = MacCol.InnerText;
							Report.Info("MAC Address in the Reserv list : " + macAddress1);
			        	}else if (colNum == 2){
			        		ipAddress1 = MacCol.InnerText;
			        		Report.Info("IP Address in the Reserv list : " + ipAddress1);
			        	}else if (colNum == 3){
			        		// check if Mac address is matching
//			        		Report.Info("----------------- click delete checkbox ------");
			        		if(macAddress.Trim() == macAddress1.Trim()){
			        			isMatch = true;
			        			Report.Info("----------------- Rules Matches !!! ------");
			        			String newPath = "";
//			        			Report.Info("delCheck ", delCheck.ToString());
			        			newPath = MacCol.GetPath() + "/input[#'dhcpClientsTable-Delete-"+delCheck+"']";
			        			Ranorex.InputTag DHCPReservTableDeleteTag = newPath;
						        if (DHCPReservTableDeleteTag.Checked.ToString() == "False"){
						        	Report.Info("----------------- DHCPReservTableDeleteTag will be enabled now ---");
						        	Delay.Seconds(1);
						        	DHCPReservTableDeleteTag.PerformClick();
						        	Report.Screenshot("DHCPReserv_List",row.Element,true);
						        	Delay.Seconds(2);
						        }else{
									Report.Info(" DHCPReservTableDeleteTag is already Enabled ");
								}
			        			
			        			Report.Success("The following DHCP Reserv rule is deleted permanently !!!");
					        	Report.Screenshot("DHCPReserv_List",myTable.Element,false);
			        	
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
					Report.Info(" ===== This DHCP Rule does not exist =====");
					Delay.Seconds(1);
			        Report.Screenshot("DHCPReserv_List",myTable.Element,true);
			    }	     		
	     	}
        }

    }
}