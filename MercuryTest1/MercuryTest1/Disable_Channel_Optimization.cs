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
    ///The Disable_Channel_Optimization recording.
    /// </summary>
    [TestModule("b9ed2395-4234-45a9-b36d-663530642eea", ModuleType.Recording, 1)]
    public partial class Disable_Channel_Optimization : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Disable_Channel_Optimization instance = new Disable_Channel_Optimization();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Disable_Channel_Optimization()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Disable_Channel_Optimization Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_SmartWiFi') on item 'WebDocument19216801.LabelSmartWiFi'.", repo.WebDocument19216801.LabelSmartWiFiInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.LabelSmartWiFiInfo, "Id", "label_SmartWiFi");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Smart WiFi') on item 'WebDocument19216801.LabelSmartWiFi'.", repo.WebDocument19216801.LabelSmartWiFiInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.LabelSmartWiFiInfo, "InnerText", "Smart WiFi");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Disable Channel Optimization') on item 'WebDocument19216801.DisableChannelOptimization'.", repo.WebDocument19216801.DisableChannelOptimizationInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.DisableChannelOptimizationInfo, "InnerText", "Disable Channel Optimization");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=875,Height=83}) on item 'WebDocument19216801.LabelSmartWiFi'.", repo.WebDocument19216801.LabelSmartWiFiInfo, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.LabelSmartWiFiInfo, LabelSmartWiFi_Screenshot1, LabelSmartWiFi_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=221,Height=20}) on item 'WebDocument19216801.DisableChannelOptimization'.", repo.WebDocument19216801.DisableChannelOptimizationInfo, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.DisableChannelOptimizationInfo, DisableChannelOptimization_Screenshot1, DisableChannelOptimization_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.DisableChannelOptimizationImageTt' at 13;17.", repo.WebDocument19216801.DisableChannelOptimizationImageTtInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.DisableChannelOptimizationImageTt.Click("13;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-disableChannelOptimization') on item 'WebDocument19216801.FmRbtnDisableChannelOptimization'.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, "Id", "fmRbtn-disableChannelOptimization");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Rel='channelOptimizationGrp') on item 'WebDocument19216801.FmRbtnDisableChannelOptimization'.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, "Rel", "channelOptimizationGrp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDisableChannelOptimization' at 14;23.", repo.WebDocument19216801.FmRbtnDisableChannelOptimizationInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.FmRbtnDisableChannelOptimization.Click("14;23");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
        }

#region Image Feature Data
        CompressedImage LabelSmartWiFi_Screenshot1
        { get { return repo.WebDocument19216801.LabelSmartWiFiInfo.GetScreenshot1(new Rectangle(0, 0, 875, 83)); } }

        Imaging.FindOptions LabelSmartWiFi_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage DisableChannelOptimization_Screenshot1
        { get { return repo.WebDocument19216801.DisableChannelOptimizationInfo.GetScreenshot1(new Rectangle(0, 0, 221, 20)); } }

        Imaging.FindOptions DisableChannelOptimization_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}