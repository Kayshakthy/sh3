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
    ///The Valid_Ping_NoofPings_Field_Validation recording.
    /// </summary>
    [TestModule("1c359436-998a-41b3-8e86-31a4cb9209d5", ModuleType.Recording, 1)]
    public partial class Valid_Ping_NoofPings_Field_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Valid_Ping_NoofPings_Field_Validation instance = new Valid_Ping_NoofPings_Field_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Valid_Ping_NoofPings_Field_Validation()
        {
            PingURL = "";
            No_of_Pings = "3";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Valid_Ping_NoofPings_Field_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _PingURL;

        /// <summary>
        /// Gets or sets the value of variable PingURL.
        /// </summary>
        [TestVariable("e83a05da-1819-4216-ae94-1400240e8cb4")]
        public string PingURL
        {
            get { return _PingURL; }
            set { _PingURL = value; }
        }

        string _No_of_Pings;

        /// <summary>
        /// Gets or sets the value of variable No_of_Pings.
        /// </summary>
        [TestVariable("57bae4c6-3de6-4a4a-8782-c92fda75e1d8")]
        public string No_of_Pings
        {
            get { return _No_of_Pings; }
            set { _No_of_Pings = value; }
        }

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

            repo.WebDocument19216801.AdvancedSettings.Click("69;11");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Tools.Click("17;7");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Ping.Click("18;10");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Target.Click("20;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Target.PressKeys(PingURL);
            Delay.Milliseconds(200);
            
            repo.WebDocumentIE.NoofPings.Click("31;9");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocumentIE.NoofPings);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NoofPings.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NoofPings.PressKeys(No_of_Pings);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Start.Click("64;23");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocumentIE.ErrCloseNoofPings'.", repo.WebDocumentIE.ErrCloseNoofPingsInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocumentIE.ErrCloseNoofPingsInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WebDocumentIE.ErrCloseNoofPings'.", repo.WebDocumentIE.ErrCloseNoofPingsInfo, new RecordItemIndex(13));
            Validate.NotExists(repo.WebDocumentIE.ErrCloseNoofPingsInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(14));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}