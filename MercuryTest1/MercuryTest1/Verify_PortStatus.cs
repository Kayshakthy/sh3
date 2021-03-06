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
    ///The Verify_PortStatus recording.
    /// </summary>
    [TestModule("52ef3600-e11a-4279-80b9-a15f7c14b2db", ModuleType.Recording, 1)]
    public partial class Verify_PortStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Verify_PortStatus instance = new Verify_PortStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_PortStatus()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_PortStatus Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'www.grc.com/shieldsup' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("www.grc.com/shieldsup", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Welcome to ShieldsUP!') on item 'WebDocumentIE.WelcomeToShieldsUP'.", repo.WebDocumentIE.WelcomeToShieldsUPInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocumentIE.WelcomeToShieldsUPInfo, "InnerText", "Welcome to ShieldsUP!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='    Proceed    ') on item 'WebDocumentIE.InputTag12'.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocumentIE.InputTag12Info, "TagValue", "    Proceed    ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='    Proceed    ') on item 'WebDocumentIE.InputTag12'.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocumentIE.InputTag12Info, "Value", "    Proceed    ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.InputTag12' at 60;15.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(4));
            repo.WebDocumentIE.InputTag12.Click("60;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Alt='Common Ports') on item 'WebDocumentIE.InputTag6'.", repo.WebDocumentIE.InputTag6Info, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocumentIE.InputTag6Info, "Alt", "Common Ports");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.grc.com/image/pa_cp.gif') on item 'WebDocumentIE.InputTag6'.", repo.WebDocumentIE.InputTag6Info, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocumentIE.InputTag6Info, "Src", "https://www.grc.com/image/pa_cp.gif");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.InputTag6' at 58;12.", repo.WebDocumentIE.InputTag6Info, new RecordItemIndex(7));
            repo.WebDocumentIE.InputTag6.Click("58;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.grc.com/image/passed.gif') on item 'WebDocumentIE.HttpsWwwGrcComImagePassedGif'.", repo.WebDocumentIE.HttpsWwwGrcComImagePassedGifInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocumentIE.HttpsWwwGrcComImagePassedGifInfo, "Src", "https://www.grc.com/image/passed.gif");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Stealth') on item 'WebDocumentIE.Stealth2'.", repo.WebDocumentIE.Stealth2Info, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocumentIE.Stealth2Info, "InnerText", "Stealth");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='HTTP') on item 'WebDocumentIE.HTTP'.", repo.WebDocumentIE.HTTPInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocumentIE.HTTPInfo, "InnerText", "HTTP");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Stealth') on item 'WebDocumentIE.Stealth1'.", repo.WebDocumentIE.Stealth1Info, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocumentIE.Stealth1Info, "InnerText", "Stealth");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='HTTPS') on item 'WebDocumentIE.HTTPS'.", repo.WebDocumentIE.HTTPSInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.WebDocumentIE.HTTPSInfo, "InnerText", "HTTPS");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Stealth') on item 'WebDocumentIE.Stealth3'.", repo.WebDocumentIE.Stealth3Info, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocumentIE.Stealth3Info, "InnerText", "Stealth");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
