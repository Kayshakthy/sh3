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
    ///The Verify_DMZ_Activation recording.
    /// </summary>
    [TestModule("50e13196-dd19-4356-961a-bfd27d9a0a73", ModuleType.Recording, 1)]
    public partial class Verify_DMZ_Activation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Verify_DMZ_Activation instance = new Verify_DMZ_Activation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_DMZ_Activation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_DMZ_Activation Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'www.canyouseeme.org' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("www.canyouseeme.org", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='CanYouSeeMe.org') on item 'WebDocumentIE.Main.CanYouSeeMeOrg'.", repo.WebDocumentIE.Main.CanYouSeeMeOrgInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocumentIE.Main.CanYouSeeMeOrgInfo, "InnerText", "CanYouSeeMe.org");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Main.Port' at 95;15.", repo.WebDocumentIE.Main.PortInfo, new RecordItemIndex(2));
            repo.WebDocumentIE.Main.Port.Click("95;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocumentIE.Main.Port'.", repo.WebDocumentIE.Main.PortInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.WebDocumentIE.Main.Port);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocumentIE.Main.Port'.", repo.WebDocumentIE.Main.PortInfo, new RecordItemIndex(4));
            repo.WebDocumentIE.Main.Port.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '80' with focus on 'WebDocumentIE.Main.Port'.", repo.WebDocumentIE.Main.PortInfo, new RecordItemIndex(5));
            repo.WebDocumentIE.Main.Port.PressKeys("80");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Main.CheckPort' at 60;15.", repo.WebDocumentIE.Main.CheckPortInfo, new RecordItemIndex(6));
            repo.WebDocumentIE.Main.CheckPort.Click("60;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=' Connection timed out') on item 'WebDocumentIE.Main.SmallTagConnectionTimedOut'.", repo.WebDocumentIE.Main.SmallTagConnectionTimedOutInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocumentIE.Main.SmallTagConnectionTimedOutInfo, "InnerText", " Connection timed out");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OpenPortCheckToolInternetExplorer.ButtonFile' at 14;14.", repo.OpenPortCheckToolInternetExplorer.ButtonFileInfo, new RecordItemIndex(9));
            repo.OpenPortCheckToolInternetExplorer.ButtonFile.Click("14;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Iexplore.Exit' at 69;9.", repo.Iexplore.ExitInfo, new RecordItemIndex(10));
            repo.Iexplore.Exit.Click("69;9");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
