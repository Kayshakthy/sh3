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
    public partial class Add_Device_To_DHCP_List
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows=0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
            Delay.Seconds(15);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']"); //dhcpClientsTable
            //Report.Screenshot("New Port Triggering Rule", myTable.Element,true);
  
            //highlight the new port triggering rule
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            Report.Info("------Inside Init() of DHCP_Reservation_Add_Reservation -----  " );  
            Report.Info("TotalRows(Before):",TotalRows.ToString());
  
        }

        public void Validate_DHCP_Reserved_Rule()
        {
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']");
        	IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            Report.Info("Total Rules(RowsCnt) (After)",rowsCnt.ToString());
            
            if(TotalRows == 1 &&  TotalRows == rowsCnt ){
            	Report.Info("//-------------------- TotalRows == 1 && TotalRows == rowsCnt--------// ");
            	
            	int rowNum = 1; 
            	foreach (var row in rows){  
			        Report.Info("Row: " + rowNum);     
					
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        int colsCnt =cols.Count;
			        Report.Info("Total Columns (colsCnt) in this Row",colsCnt.ToString());
			        
			        /**
			        foreach(TdTag MacCol in cols){
			        	Report.Info(MacCol.InnerText.ToString());
			        }
			        **/
					if(rowNum == rowsCnt && colsCnt == 1){	//No reserved rule! 
						Report.Failure("DHCPClients","No reserved rule added !!! ");
						Delay.Seconds(5);
						myTable.EnsureVisible();
						Report.Screenshot("DHCPClients",myTable.Element,false);
						//break;
			        }else {	//to get the last  added rule (row)
						Report.Info("//-------------------- rowNum == rowsCnt & colsCnt != 1 ------------------------// ");
						Mouse.ScrollWheel(10);
						row.EnsureVisible();
						Report.Success("Valid... New DHCP Reserved Rule is added!");
						Report.Screenshot("DHCPClientsTable",row.Element,true);
						//break;
			        }
					rowNum++;			       
            	}	//end of for-loop
            }else if(TotalRows == rowsCnt  && TotalRows > 1 ){		// if no rows are added
            	Report.Info("//-------------------- TotalRows > 1 && TotalRows == rowsCnt ------------------------// ");
				Report.Failure("DHCPClients","Unable to add this new rule !!! ");
				Delay.Seconds(5);
				myTable.EnsureVisible();
				Report.Screenshot("DHCPClients",myTable.Element,false);
				return;  
            }else{		// difference in row number
            	int rowNum = 1;  
				foreach (var row in rows)  
				{  
					//Report.Info("<---This port triggering rule is disabled from the list--->");
					if(rowNum == rowsCnt){
						Report.Info("//-------------------- rowNum == rowsCnt ------------------------// ");
		            	Report.Info("//-------------------- Rules are added -----------------//");
						Mouse.ScrollWheel(10);
						row.EnsureVisible();
						Report.Info("Valid... New DHCP Reservation Rule is added!");
						Report.Screenshot("DHCPClientsTable",row.Element,true);					
						break;
					}
					rowNum++;
	           }// end of for-loop
        }//end of if-else
        }

    }
}