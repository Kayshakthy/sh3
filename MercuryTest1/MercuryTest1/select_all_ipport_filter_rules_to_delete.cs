/*
 * Created by Ranorex
 * User: KiruShakthy
 * Date: 12/11/2015
 * Time: 1:50 PM
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
    /// Description of Select_all_ipport_filter_rules_to_delete.
    /// </summary>
    [TestModule("65656760-2052-4463-935A-46759C20A615", ModuleType.UserCode, 1)]
    public class Select_all_ipport_filter_rules_to_delete : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_all_ipport_filter_rules_to_delete()
        {
            // Do not delete - a parameterless constructor is required!
            
	     	//choose_all_ipport_filter_rules_to_delete();
	     	
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
        }

        	
        }
    }