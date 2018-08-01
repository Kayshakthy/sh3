/*
 * Created by Ranorex
 * User: AutoGateway
 * Date: 7/11/2017
 * Time: 10:17 AM
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

using System.IO;

namespace ArrisTest
{
    /// <summary>
    /// Description of list_of_ALL_test_cases.
    /// </summary>
    [TestModule("72FFE680-D839-4B6B-BD41-A81F2B104A7B", ModuleType.UserCode, 1)]
    public class list_of_ALL_test_cases : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public list_of_ALL_test_cases()
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
            this.testcases_list();
        }
        void testcases_list(){
        	TestSuite TS = (TestSuite)TestSuite.Current;
			IList<TestSuiteEntry> ss =TS.GetAllTestSuiteEntries();
			foreach(TestSuiteEntry x in ss)
			{
//				Report.Info("Type  : " + x.GetType().ToString());	//Added
				if(x.GetType()== typeof(TestCaseNode) && !x.DisplayName.Contains("Test Suite")){
      				// Report.Info(x.DisplayName);
   					Report.Info("TestCase Name  : " + x.DisplayName);	//Added
				}
				
			}
			
			//added on 11/07/17
			using (StreamWriter writer = new StreamWriter("TEST_CASE_LIST.txt"))
      		{
         		foreach(var testCase in TestSuite.Current.SelectedRunConfig.GetActiveTestCases())
         		{
           		 writer.WriteLine(testCase.Name);
         		}
      		}
			
        }
    }
}
