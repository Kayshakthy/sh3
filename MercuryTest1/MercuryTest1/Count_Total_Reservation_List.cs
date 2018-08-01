/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 03/02/2016
 * Time: 11:54
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
    /// Description of Count_Total_Reservation_List.
    /// </summary>
    [TestModule("DDA43830-7042-43D3-BCE5-DC2DA5A809EF", ModuleType.UserCode, 1)]
    public class Count_Total_Reservation_List : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Count_Total_Reservation_List()
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
            
            Count_Reservation_Lists();
        }
        void Count_Reservation_Lists(){
        	//Report.Info("-----");
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']");
        	IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            Report.Info("Total Reservation_List",rowsCnt.ToString());
            if(rowsCnt == 32){
            	 Report.Info("Total Reservation_List",rowsCnt.ToString());
            	 TestSuite.Current.GetTestCase("DHCP_Reservation_Add_Rule1").Checked = true;
            }else if(rowsCnt < 32){
            	 //Report.Info("Total No of Reservation_List is less than 32");
            	 Report.Failure("Total No of Reservation_List is less than 32");
            	 TestSuite.Current.GetTestCase("DHCP_Reservation_Add_Rule1").Checked = false;
            }else{
            	//Report.Info("Total No of Reservation_List is more than 32");
            	Report.Failure("Total No of Reservation_List is more than 32");
            	TestSuite.Current.GetTestCase("DHCP_Reservation_Add_Rule1").Checked = false;
            }
        }
    }
}
