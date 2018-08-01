/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 19/09/2016
 * Time: 14:58
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
    /// Description of Count_5GHz_Wireless_MAC_Filter_List.
    /// </summary>
    [TestModule("5F1F32E5-5B6F-4B51-8EC6-A482E10CBC54", ModuleType.UserCode, 1)]
    public class Count_5GHz_Wireless_MAC_Filter_List : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Count_5GHz_Wireless_MAC_Filter_List()
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
            this.Wireless_5GHz_MAC_Filter_Count();
        }
        public void Wireless_5GHz_MAC_Filter_Count(){
        	Total_Wireless_Filter_Lists total_Wireless_Filter_Lists = new Total_Wireless_Filter_Lists();
        	int wirelessRadioTypeCnt = total_Wireless_Filter_Lists.Count_Wireless_Filtering_Lists("5GHz");
        	Report.Info("5GHz WirelessRadioType Count	:  " +wirelessRadioTypeCnt);
        	if(wirelessRadioTypeCnt < 32){
        		TestSuite.Current.GetTestCase("Add_33rd_Device_To_5GHz_Wireless_Primary").Checked = false;
        		Report.Failure("5GHz WirelessRadioType Count	:  " + wirelessRadioTypeCnt);
        	}else if(wirelessRadioTypeCnt == 0){
        		TestSuite.Current.GetTestCase("Add_33rd_Device_To_5GHz_Wireless_Primary").Checked = false;
        		Report.Failure("Different Wireless Radio Type is present");
        	}
        }
    }
}
