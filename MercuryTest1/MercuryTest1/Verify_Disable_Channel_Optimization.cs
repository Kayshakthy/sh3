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
    ///The Verify_Disable_Channel_Optimization recording.
    /// </summary>
    [TestModule("a1f799c7-860d-4118-aa95-bf6e260e7206", ModuleType.Recording, 1)]
    public partial class Verify_Disable_Channel_Optimization : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Verify_Disable_Channel_Optimization instance = new Verify_Disable_Channel_Optimization();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Disable_Channel_Optimization()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Disable_Channel_Optimization Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmRbtnChannelManual'.", repo.WebDocument19216801.FmRbtnChannelManualInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnChannelManualInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-channelManual') on item 'WebDocument19216801.FmRbtnChannelManual'.", repo.WebDocument19216801.FmRbtnChannelManualInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnChannelManualInfo, "Id", "fmRbtn-channelManual");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=25,Height=25}) on item 'WebDocument19216801.FmRbtnChannelManual'.", repo.WebDocument19216801.FmRbtnChannelManualInfo, new RecordItemIndex(2));
            Validate.ContainsImage(repo.WebDocument19216801.FmRbtnChannelManualInfo, FmRbtnChannelManual_Screenshot1, FmRbtnChannelManual_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnChannelManual' at 11;13.", repo.WebDocument19216801.FmRbtnChannelManualInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.FmRbtnChannelManual.Click("11;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmRbtnChannelManual50'.", repo.WebDocument19216801.FmRbtnChannelManual50Info, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnChannelManual50Info, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmRadio') on item 'WebDocument19216801.FmRbtnChannelManual50'.", repo.WebDocument19216801.FmRbtnChannelManual50Info, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnChannelManual50Info, "Class", "fmRadio");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=25,Height=25}) on item 'WebDocument19216801.FmRbtnChannelManual50'.", repo.WebDocument19216801.FmRbtnChannelManual50Info, new RecordItemIndex(6));
            Validate.ContainsImage(repo.WebDocument19216801.FmRbtnChannelManual50Info, FmRbtnChannelManual50_Screenshot1, FmRbtnChannelManual50_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnChannelManual50' at 10;15.", repo.WebDocument19216801.FmRbtnChannelManual50Info, new RecordItemIndex(7));
            repo.WebDocument19216801.FmRbtnChannelManual50.Click("10;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmRadio checked') on item 'WebDocument19216801.FmRbtnDisableChannelOptimization'.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, "Class", "fmRadio checked");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-disableChannelOptimization') on item 'WebDocument19216801.FmRbtnDisableChannelOptimization'.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, "Id", "fmRbtn-disableChannelOptimization");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=25,Height=25}) on item 'WebDocument19216801.FmRbtnDisableChannelOptimization'.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(10));
            Validate.ContainsImage(repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, FmRbtnDisableChannelOptimization_Screenshot1, FmRbtnDisableChannelOptimization_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
        CompressedImage FmRbtnChannelManual_Screenshot1
        { get { return repo.WebDocument19216801.FmRbtnChannelManualInfo.GetScreenshot1(new Rectangle(0, 0, 25, 25)); } }

        Imaging.FindOptions FmRbtnChannelManual_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage FmRbtnChannelManual50_Screenshot1
        { get { return repo.WebDocument19216801.FmRbtnChannelManual50Info.GetScreenshot1(new Rectangle(0, 0, 25, 25)); } }

        Imaging.FindOptions FmRbtnChannelManual50_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage FmRbtnDisableChannelOptimization_Screenshot1
        { get { return repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo.GetScreenshot1(new Rectangle(0, 0, 25, 25)); } }

        Imaging.FindOptions FmRbtnDisableChannelOptimization_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
