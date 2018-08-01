/*
 * Created by Ranorex
 * User: AutoGateway
 * Date: 6/6/2017
 * Time: 12:14 PM
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
    /// Description of Check_If_Enable_Checkbox_Visible_For_First_PF_Rule.
    /// </summary>
    [TestModule("4DC823B5-B351-4692-B4B6-E5FCBA316574", ModuleType.UserCode, 1)]
    public class Check_If_Enable_Checkbox_Visible_For_First_PF_Rule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_If_Enable_Checkbox_Visible_For_First_PF_Rule()
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
            this.Check_Checkbox_visibility();
        }
        void Check_Checkbox_visibility(){
        	Report.Info("Inside Check_Checkbox_visibility " );
        	Report.Info("Going to check the checkBox visibility");
        	Total_Port_Fwding_Rules tpfr = new Total_Port_Fwding_Rules();
        	int rulesCnt =  tpfr.pfRules_Count();
        	
        	Report.Info(" rulesCnt -------->> " + rulesCnt);
        	
        	//if there are no rules (or) if the first check box is not visible then skip the next 2 test cases
        	if(rulesCnt == -1){
        		// there are no rules
        	  	TestSuite.Current.GetTestCase("Select_First_Port_Forwarding_Rule_to_Disable").Checked = false;
        		TestSuite.Current.GetTestCase("Disable_First_Port_Forward_Rule").Checked = false;
        	}else if(rulesCnt > 0){	// if rulesCnt is 'zero' skip it
	        	TestSuite.Current.GetTestCase("Select_First_Port_Forwarding_Rule_to_Disable").Checked = false;
	        	TestSuite.Current.GetTestCase("Disable_First_Port_Forward_Rule").Checked = false;
        	}
        	
        }
    }
}
