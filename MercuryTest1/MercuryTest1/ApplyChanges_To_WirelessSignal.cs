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
    ///The ApplyChanges_To_WirelessSignal recording.
    /// </summary>
    [TestModule("79877484-0aa0-4c88-b349-90eb8a9c9d14", ModuleType.Recording, 1)]
    public partial class ApplyChanges_To_WirelessSignal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static ApplyChanges_To_WirelessSignal instance = new ApplyChanges_To_WirelessSignal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ApplyChanges_To_WirelessSignal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ApplyChanges_To_WirelessSignal Instance
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

            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;189");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1357;462");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='submitBtn') on item 'WebDocument19216801.Button8'.", repo.WebDocument19216801.Button8Info, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.Button8Info, "Class", "submitBtn");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument19216801.Button8'.", repo.WebDocument19216801.Button8Info, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.Button8Info, "TagValue", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument19216801.Button8'.", repo.WebDocument19216801.Button8Info, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.Button8Info, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=166,Height=43}) on item 'WebDocument19216801.Button8'.", repo.WebDocument19216801.Button8Info, new RecordItemIndex(5));
            //Validate.ContainsImage(repo.WebDocument19216801.Button8Info, Button8_Screenshot1, Button8_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.Button8.Click("22;27");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            //Delay.Duration(1000, false);
            
            repo.WebDocument19216801.Button25.Click("61;15");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WebDocument19216801.ErrCloseSSID'.", repo.WebDocument19216801.ErrCloseSSIDInfo, new RecordItemIndex(9));
            //Validate.NotExists(repo.WebDocument19216801.ErrCloseSSIDInfo);
            //Delay.Milliseconds(100);
            
            Validate_ErrCloseSSID();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
        CompressedImage Button8_Screenshot1
        { get { return repo.WebDocument19216801.Button8Info.GetScreenshot1(new Rectangle(0, 0, 166, 43)); } }

        Imaging.FindOptions Button8_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseSSID_Screenshot1
        { get { return repo.WebDocument19216801.ErrCloseSSIDInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions ErrCloseSSID_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
