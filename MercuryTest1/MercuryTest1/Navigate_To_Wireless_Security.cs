﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Repository;

namespace ArrisTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Navigate_To_Wireless_Security recording.
    /// </summary>
    [TestModule("bc86af8d-1704-4b7c-ab6b-222153daefda", ModuleType.Recording, 1)]
    public partial class Navigate_To_Wireless_Security : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_Wireless_Security instance = new Navigate_To_Wireless_Security();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_Wireless_Security()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_Wireless_Security Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            //doDelay();
            //Delay.Milliseconds(0);
            
            //repo.WebDocument19216801.AdvancedSettings.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Home' at 23;8.", repo.WebDocument19216801.HomeInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Home.Click("23;8");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.AdvancedSettings.Click();
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Wireless.Click("43;16");
            Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.Security.Click("58;7");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security2' at 39;5.", repo.WebDocument19216801.Security2Info, new RecordItemIndex(7));
            //repo.WebDocument19216801.Security2.Click("39;5");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security2' at 46;5.", repo.WebDocument19216801.Security2Info, new RecordItemIndex(8));
            repo.WebDocument19216801.Security2.Click("46;5");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}