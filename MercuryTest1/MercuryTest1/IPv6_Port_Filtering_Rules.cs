/*
 * Created by Ranorex
 * User: AutoGateway
 * Date: 6/26/2017
 * Time: 3:47 PM
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
    /// Description of IPv6_Port_Filtering_Rules.
    /// </summary>
    [TestModule("4CF372A5-2E03-4470-B63D-9FA3BFEE4600", ModuleType.UserCode, 1)]
    public class IPv6_Port_Filtering_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IPv6_Port_Filtering_Rules()
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
            this.Count_Ipv6_PortFiltering_Rules();
        }
        void Count_Ipv6_PortFiltering_Rules()
        {
        	//count total number of port triggering rules
        	Report.LogHtml(ReportLevel.Info,"TestCase","<b>IPv6_PortFiltering Count</b>");
        	int TotalRows =0;
        	Delay.Seconds(60);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'ipv6FilterTable']"); 

            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            Ranorex.Report.Success(" Total Number of Rows in the table : " + TotalRows.ToString());
            //Report.Info(" Ipv4_PortFiltering_Rules",TotalRows.ToString());
           // Report.Info(" IP_PortFilter",Total_Rules);
           
            //Ranorex.Report.Failure("Failure Message");
            //Report.LogHtml(ReportLevel.Info, "Link", "<a href='http://www.ranorex.com/'>Visit www.ranorex.com</a>");
//            Report.LogHtml(ReportLevel.Info, "Link", "<a href='http://www.virginmedia.com/'>Visit www.virginmedia.com</a>");
          	//<b>and this is bold text</b>
            int j=1;
            bool isRuleExist=true;  
			String Total_Rules = "";            
             if(TotalRows > 0){
            	IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td");
            	Ranorex.Report.Info( " Total cols : " + cols.Count.ToString());
            	foreach(TdTag col in cols)  
		    	{
//            		Report.Info(" col value : " + col.InnerText.ToString());
            		if(j == 1 && TotalRows == 1 && col.InnerText.ToString().StartsWith("No filtering rule applied!")){
						isRuleExist=false;
						//return;
						Report.Info(" There are no active IPv6 and Port Filtering rules ");  
						TotalRows = -1;
						break;
            		}else{
            			Total_Rules = "Totally, There are "+TotalRows.ToString() + "  Rules";
//             			Ranorex.Report.Success(Total_Rules);
            			isRuleExist=true;
            			break;
            		}
            		
            	}
            	if(isRuleExist){
//            		Report.Info(" Total Rules",TotalRows.ToString());
					Report.Info( Total_Rules);
//					Report.Info(" Total IPv6 and Port Filtering Rules : " + TotalRows.ToString());
            	}
          	}
          	
        }
        
    }
}
