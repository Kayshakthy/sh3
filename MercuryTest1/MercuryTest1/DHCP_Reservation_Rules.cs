/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 20/05/2016
 * Time: 10:10
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
    /// Description of DHCP_Reservation_Rules.
    /// </summary>
    [TestModule("46BC4284-8538-4656-8E9D-909D78B57696", ModuleType.UserCode, 1)]
    public class DHCP_Reservation_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DHCP_Reservation_Rules()
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
            this.DHCP_Reserve_Rules();
        }
        void DHCP_Reserve_Rules(){
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";        	
        	webDocument.WaitForDocumentLoaded();
            Delay.Seconds(30);
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']");
        	//	/dom[@domain='192.168.0.1']//table[#'dhcpClientsTable']

        	IList<TrTag> rows = myTable.Find<TrTag>("./tbody//tr");
            int rowsCnt = rows.Count;
            //if it is just 1 row  need to check if it is an invalid filter - No reserved rule!
            if(rowsCnt == 1){
            	IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td"); 
				foreach(TdTag MacCol in cols) {
					//Report.Info("Column",j.ToString());
					Report.Info(MacCol.InnerText);
					if(MacCol.InnerText.ToString().StartsWith("No reserved rule")){	//No reserved rule! --R3.7
						//Report.Info("No DHCP filtering rule exists !!!");
	     				Report.Success("DHCP Filter ","There are No DHCP rule exists  !!");
	     				return;	
					}else{
						break;
					}
            	}
            }
            Report.Info("DHCP_Resv Rule(s) ",rowsCnt.ToString());	
        }
    }
}
