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
    ///The Enable_2_4GHz_WirelessSignal recording.
    /// </summary>
    [TestModule("50d6eb59-580d-4028-b73a-0c4d3514debe", ModuleType.Recording, 1)]
    public partial class Enable_2_4GHz_WirelessSignal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Enable_2_4GHz_WirelessSignal instance = new Enable_2_4GHz_WirelessSignal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_2_4GHz_WirelessSignal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enable_2_4GHz_WirelessSignal Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnEnable24' at 13;17.", repo.WebDocument19216801.FmRbtnEnable24Info, new RecordItemIndex(0));
            repo.WebDocument19216801.FmRbtnEnable24.Click("13;17");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.TrEnable24'.", repo.WebDocument19216801.TrEnable24Info, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.TrEnable24Info, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='tr_Enable24') on item 'WebDocument19216801.TrEnable24'.", repo.WebDocument19216801.TrEnable24Info, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.TrEnable24Info, "Id", "tr_Enable24");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=219,Height=26}) on item 'WebDocument19216801.TrEnable24'.", repo.WebDocument19216801.TrEnable24Info, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.TrEnable24Info, TrEnable24_Screenshot1, TrEnable24_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate_FmRbtnEnable24();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmRadio checked') on item 'WebDocument19216801.FmRbtnEnable24'.", repo.WebDocument19216801.FmRbtnEnable24Info, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnable24Info, "Class", "fmRadio checked");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-Enable24') on item 'WebDocument19216801.FmRbtnEnable24'.", repo.WebDocument19216801.FmRbtnEnable24Info, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnable24Info, "Id", "fmRbtn-Enable24");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Rel='WirelessFrequency24GHzGrp') on item 'WebDocument19216801.FmRbtnEnable24'.", repo.WebDocument19216801.FmRbtnEnable24Info, new RecordItemIndex(7));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnable24Info, "Rel", "WirelessFrequency24GHzGrp");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=26,Height=26}) on item 'WebDocument19216801.FmRbtnEnable24'.", repo.WebDocument19216801.FmRbtnEnable24Info, new RecordItemIndex(8));
            //Validate.ContainsImage(repo.WebDocument19216801.FmRbtnEnable24Info, FmRbtnEnable24_Screenshot1_2, FmRbtnEnable24_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage TrEnable24_Screenshot1
        { get { return repo.WebDocument19216801.TrEnable24Info.GetScreenshot1(new Rectangle(0, 0, 219, 26)); } }

        Imaging.FindOptions TrEnable24_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage FmRbtnEnable24_Screenshot1
        { get { return repo.WebDocument19216801.FmRbtnEnable24Info.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions FmRbtnEnable24_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage FmRbtnEnable24_Screenshot1_2
        { get { return repo.WebDocument19216801.FmRbtnEnable24Info.GetScreenshot1(new Rectangle(0, 0, 26, 26)); } }

        Imaging.FindOptions FmRbtnEnable24_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}