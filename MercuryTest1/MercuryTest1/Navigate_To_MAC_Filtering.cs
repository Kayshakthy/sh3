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
    ///The Navigate_To_MAC_Filtering recording.
    /// </summary>
    [TestModule("d6e37706-b938-4f15-9572-7ffe944110dd", ModuleType.Recording, 1)]
    public partial class Navigate_To_MAC_Filtering : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_MAC_Filtering instance = new Navigate_To_MAC_Filtering();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_MAC_Filtering()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_MAC_Filtering Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(0));
            Delay.Duration(30000, false);
            
            repo.WebDocument19216801.AdvancedSettings.Click("71;9");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Security1.Click("30;9");
            Delay.Milliseconds(200);
            
            repo.WebDocumentIE.MACFiltering.Click("32;9");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 40;12.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(4));
            //repo.WebDocument19216801.AdvancedSettings.Click("40;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security1' at 21;12.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(5));
            //repo.WebDocument19216801.Security1.Click("21;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.MACFiltering' at 46;6.", repo.WebDocumentIE.MACFilteringInfo, new RecordItemIndex(6));
            //repo.WebDocumentIE.MACFiltering.Click("46;6");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 43;8.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(7));
            //repo.WebDocument19216801.AdvancedSettings.Click("43;8");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security1' at 28;6.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(8));
            //repo.WebDocument19216801.Security1.Click("28;6");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.MACFiltering' at 36;0.", repo.WebDocument19216801.MACFilteringInfo, new RecordItemIndex(9));
            //repo.WebDocument19216801.MACFiltering.Click("36;0");
            //Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
