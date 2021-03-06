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
    public partial class Add_Device_To_MAC_List1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        int TotalRows =0;
        private void Init()
        {
            // Your recording specific initialization code goes here.
            Delay.Seconds(15);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']"); 

            //highlight the new MACFiltering rule
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            Report.Info("------Inside Init()------ TotalRows" ,TotalRows.ToString());               
        }

        public void Validate_Devices_In_Wireless_List1()
        {
			//This method is to check whether the MACFilter rules are addded successfully
        	Delay.Seconds(15);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']");
        	IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            Report.Info("Total Rules(RowsCnt)",rowsCnt.ToString());
            if(TotalRows == 1 && TotalRows == rowsCnt){
            	Report.Info("//-------------------- TotalRows == 1 && TotalRows == rowsCnt--------// ");
            	int rowNum = 1; 
            	
          
            	foreach (var row in rows){  
			        //Report.Info("Row: " + rowNum);     
					/*
			        IList<TdTag> cols = row.Find<TdTag>("./td");
			        foreach(TdTag MacCol in cols){
			        	Report.Info(MacCol.InnerText.ToString());
			        }
			        */
					if(rowNum == rowsCnt){	//to get the last  added rule (row)
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
            }else if(TotalRows > 1 && TotalRows == rowsCnt ){		// no rows are added
            	Report.Info("//-------------------- TotalRows>1 and  TotalRows== rowsCnt ------------------------// ");
            	/*
            	TableTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'AddFilterRule']/table");
				Report.Failure("macFilterTable","Unable to add this new rule !!! ");
				Delay.Seconds(5);
				errorTable.EnsureVisible();
				Report.Screenshot("macFilterTable",errorTable.Element,false);
				*/
				//DivTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'AddFilterRule']");
				DivTag errorTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'errTip_MACAddress']");
				Report.Failure("macAddressFilterTable","Unable to add this new rule because of the below mentioned error!!! ");
				Delay.Seconds(5);
				errorTable.EnsureVisible();
				Report.Screenshot("macAddressFilterTable",errorTable.Element,true);				
				return;
				
            }else{		// difference in rows
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
						break;
					}
					rowNum++;
				}	//end of for-loop
            }	//end of if-else
        }	//end of 

    }
}