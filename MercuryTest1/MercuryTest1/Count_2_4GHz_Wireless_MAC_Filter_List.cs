/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 19/09/2016
 * Time: 16:34
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
    /// Description of Count_2_4GHz_Wireless_MAC_Filter_List.
    /// </summary>
    [TestModule("7E28439A-9178-4FD4-AA7A-6798DE185CCE", ModuleType.UserCode, 1)]
    public class Count_2_4GHz_Wireless_MAC_Filter_List : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Count_2_4GHz_Wireless_MAC_Filter_List()
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
            this.Wireless_2_4GHz_MAC_Filter_Count();
        }
        public void Wireless_2_4GHz_MAC_Filter_Count(){
        	Total_Wireless_Filter_Lists total_Wireless_Filter_Lists = new Total_Wireless_Filter_Lists();
        	int wirelessRadioTypeCnt = total_Wireless_Filter_Lists.Count_Wireless_Filtering_Lists("2.4GHz");
        	Report.Info("2.4GHz WirelessRadioType Count	:  " +wirelessRadioTypeCnt);
        	if(wirelessRadioTypeCnt < 32){
        		TestSuite.Current.GetTestCase("Add_33rd_Device_To_2.4GHz_Wireless_Primary").Checked = false;
        		Report.Failure("2.4GHz WirelessRadioType Count	:  " + wirelessRadioTypeCnt);
        	}else if(wirelessRadioTypeCnt == 0){
        		TestSuite.Current.GetTestCase("Add_33rd_Device_To_2.4GHz_Wireless_Primary").Checked = false;
        		Report.Failure("Different Wireless Radio Type is present");
        	}
        }
    }
}
