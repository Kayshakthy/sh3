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
    ///The NavigateToWPS recording.
    /// </summary>
    [TestModule("2d309b55-1e33-4055-a588-6e526b9045bd", ModuleType.Recording, 1)]
    public partial class NavigateToWPS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static NavigateToWPS instance = new NavigateToWPS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NavigateToWPS()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NavigateToWPS Instance
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

            repo.WebDocument19216801.AdvancedSettings.Click("61;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(1));
            Delay.Duration(30000, false);
            
            repo.WebDocument19216801.Wireless.Click("26;7");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -240 units.", new RecordItemIndex(3));
            //Mouse.ScrollWheel(-240);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.ATagWPS'.", repo.WebDocument19216801.ATagWPSInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.ATagWPSInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='WPS') on item 'WebDocument19216801.ATagWPS'.", repo.WebDocument19216801.ATagWPSInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.ATagWPSInfo, "InnerText", "WPS");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='http://192.168.0.1/?wifi_wps&mid=WPS') on item 'WebDocument19216801.ATagWPS'.", repo.WebDocument19216801.ATagWPSInfo, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.ATagWPSInfo, "Href", "http://192.168.0.1/?wifi_wps&mid=WPS");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=60,Height=14}) on item 'WebDocument19216801.ATagWPS'.", repo.WebDocument19216801.ATagWPSInfo, new RecordItemIndex(7));
            //Validate.ContainsImage(repo.WebDocument19216801.ATagWPSInfo, ATagWPS_Screenshot1, ATagWPS_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.ATagWPS.Click("21;4");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.LabelWPSSettings'.", repo.WebDocument19216801.LabelWPSSettingsInfo, new RecordItemIndex(9));
            //Validate.Attribute(repo.WebDocument19216801.LabelWPSSettingsInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_WPSSettings') on item 'WebDocument19216801.LabelWPSSettings'.", repo.WebDocument19216801.LabelWPSSettingsInfo, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocument19216801.LabelWPSSettingsInfo, "Id", "label_WPSSettings");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='WiFi Protected Set-up (WPS)') on item 'WebDocument19216801.LabelWPSSettings'.", repo.WebDocument19216801.LabelWPSSettingsInfo, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.LabelWPSSettingsInfo, "InnerText", "WiFi Protected Set-up (WPS)");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=728,Height=66}) on item 'WebDocument19216801.LabelWPSSettings'.", repo.WebDocument19216801.LabelWPSSettingsInfo, new RecordItemIndex(12));
            //Validate.ContainsImage(repo.WebDocument19216801.LabelWPSSettingsInfo, LabelWPSSettings_Screenshot1, LabelWPSSettings_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage ATagWPS_Screenshot1
        { get { return repo.WebDocument19216801.ATagWPSInfo.GetScreenshot1(new Rectangle(0, 0, 60, 14)); } }

        Imaging.FindOptions ATagWPS_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LabelWPSSettings_Screenshot1
        { get { return repo.WebDocument19216801.LabelWPSSettingsInfo.GetScreenshot1(new Rectangle(0, 0, 728, 66)); } }

        Imaging.FindOptions LabelWPSSettings_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
