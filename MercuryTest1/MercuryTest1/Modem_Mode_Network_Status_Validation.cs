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
    ///The Modem_Mode_Network_Status_Validation recording.
    /// </summary>
    [TestModule("c8bec592-123e-4392-b1d9-e2e586fa0ba7", ModuleType.Recording, 1)]
    public partial class Modem_Mode_Network_Status_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Modem_Mode_Network_Status_Validation instance = new Modem_Mode_Network_Status_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Modem_Mode_Network_Status_Validation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Modem_Mode_Network_Status_Validation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RouterStatusTabs.Downstream' at 31;23.", repo.WebDocument1921681001.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(0));
            repo.WebDocument1921681001.RouterStatusTabs.Downstream.Click("31;23");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RouterStatusTabs.Upstream' at 42;23.", repo.WebDocument1921681001.RouterStatusTabs.UpstreamInfo, new RecordItemIndex(2));
            repo.WebDocument1921681001.RouterStatusTabs.Upstream.Click("42;23");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RouterStatusTabs.Configuration' at 65;23.", repo.WebDocument1921681001.RouterStatusTabs.ConfigurationInfo, new RecordItemIndex(4));
            repo.WebDocument1921681001.RouterStatusTabs.Configuration.Click("65;23");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RouterStatusTabs.NetworkLog' at 61;17.", repo.WebDocument1921681001.RouterStatusTabs.NetworkLogInfo, new RecordItemIndex(6));
            repo.WebDocument1921681001.RouterStatusTabs.NetworkLog.Click("61;17");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}