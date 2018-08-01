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
    ///The NavigateWirelessSignal recording.
    /// </summary>
    [TestModule("2e03050c-3273-4336-b5a7-41c63f15891e", ModuleType.Recording, 1)]
    public partial class NavigateWirelessSignal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static NavigateWirelessSignal instance = new NavigateWirelessSignal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NavigateWirelessSignal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NavigateWirelessSignal Instance
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(0));
            //Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Advanced settings') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "InnerText", "Advanced settings");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=125,Height=19}) on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(2));
            //Validate.ContainsImage(repo.WebDocument19216801.AdvancedSettingsInfo, AdvancedSettings_Screenshot2, AdvancedSettings_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Delay.Duration(10000, false);
            
            repo.WebDocument19216801.AdvancedSettings.Click("31;10");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.Wireless'.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.WirelessInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Wireless') on item 'WebDocument19216801.Wireless'.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.WirelessInfo, "InnerText", "Wireless");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=50,Height=16}) on item 'WebDocument19216801.Wireless'.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(7));
            //Validate.ContainsImage(repo.WebDocument19216801.WirelessInfo, Wireless_Screenshot2, Wireless_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Wireless.Click("26;9");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.WirelessSignal'.", repo.WebDocument19216801.WirelessSignalInfo, new RecordItemIndex(9));
            //Validate.Attribute(repo.WebDocument19216801.WirelessSignalInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Wireless signal') on item 'WebDocument19216801.WirelessSignal'.", repo.WebDocument19216801.WirelessSignalInfo, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocument19216801.WirelessSignalInfo, "InnerText", "Wireless signal");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='http://192.168.0.1/?wifi_radio&mid=WirelessSignal') on item 'WebDocument19216801.WirelessSignal'.", repo.WebDocument19216801.WirelessSignalInfo, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.WirelessSignalInfo, "Href", "http://192.168.0.1/?wifi_radio&mid=WirelessSignal");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=113,Height=13}) on item 'WebDocument19216801.WirelessSignal'.", repo.WebDocument19216801.WirelessSignalInfo, new RecordItemIndex(12));
            //Validate.ContainsImage(repo.WebDocument19216801.WirelessSignalInfo, WirelessSignal_Screenshot1, WirelessSignal_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.WirelessSignal.Click("30;2");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.LabelWirelessSignal'.", repo.WebDocument19216801.LabelWirelessSignalInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.LabelWirelessSignalInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_WirelessSignal') on item 'WebDocument19216801.LabelWirelessSignal'.", repo.WebDocument19216801.LabelWirelessSignalInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.LabelWirelessSignalInfo, "Id", "label_WirelessSignal");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Wireless signal') on item 'WebDocument19216801.LabelWirelessSignal'.", repo.WebDocument19216801.LabelWirelessSignalInfo, new RecordItemIndex(16));
            //Validate.Attribute(repo.WebDocument19216801.LabelWirelessSignalInfo, "InnerText", "Wireless signal");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=728,Height=66}) on item 'WebDocument19216801.LabelWirelessSignal'.", repo.WebDocument19216801.LabelWirelessSignalInfo, new RecordItemIndex(17));
            //Validate.ContainsImage(repo.WebDocument19216801.LabelWirelessSignalInfo, LabelWirelessSignal_Screenshot1, LabelWirelessSignal_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage AdvancedSettings_Screenshot2
        { get { return repo.WebDocument19216801.AdvancedSettingsInfo.GetScreenshot2(new Rectangle(0, 0, 125, 19)); } }

        Imaging.FindOptions AdvancedSettings_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Wireless_Screenshot2
        { get { return repo.WebDocument19216801.WirelessInfo.GetScreenshot2(new Rectangle(0, 0, 50, 16)); } }

        Imaging.FindOptions Wireless_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage WirelessSignal_Screenshot1
        { get { return repo.WebDocument19216801.WirelessSignalInfo.GetScreenshot1(new Rectangle(0, 0, 113, 13)); } }

        Imaging.FindOptions WirelessSignal_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LabelWirelessSignal_Screenshot1
        { get { return repo.WebDocument19216801.LabelWirelessSignalInfo.GetScreenshot1(new Rectangle(0, 0, 728, 66)); } }

        Imaging.FindOptions LabelWirelessSignal_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
