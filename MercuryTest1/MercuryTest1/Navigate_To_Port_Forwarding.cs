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
    ///The Navigate_To_Port_Forwarding recording.
    /// </summary>
    [TestModule("51d3306e-28c5-4e5c-b14c-95ef0618552e", ModuleType.Recording, 1)]
    public partial class Navigate_To_Port_Forwarding : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_Port_Forwarding instance = new Navigate_To_Port_Forwarding();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_Port_Forwarding()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_Port_Forwarding Instance
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

            repo.WebDocument19216801.AdvancedSettings.Click("38;9");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Advanced settings') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "InnerText", "Advanced settings");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=125,Height=19}) on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.AdvancedSettingsInfo, AdvancedSettings_Screenshot2, AdvancedSettings_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Security1.Click("19;9");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.Security1'.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.Security1Info, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Security') on item 'WebDocument19216801.Security1'.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.Security1Info, "InnerText", "Security");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=48,Height=16}) on item 'WebDocument19216801.Security1'.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(7));
            //Validate.ContainsImage(repo.WebDocument19216801.Security1Info, Security1_Screenshot1, Security1_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -240 units.", new RecordItemIndex(8));
            //Mouse.ScrollWheel(-240);
            //Delay.Milliseconds(500);
            
            repo.WebDocumentIE.PortForwarding.Click("26;5");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.PortForwarding'.", repo.WebDocumentIE.PortForwardingInfo, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocumentIE.PortForwardingInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Port forwarding') on item 'WebDocumentIE.PortForwarding'.", repo.WebDocumentIE.PortForwardingInfo, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocumentIE.PortForwardingInfo, "InnerText", "Port forwarding");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.LabelPortForwarding'.", repo.WebDocument19216801.LabelPortForwardingInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.LabelPortForwardingInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_PortForwarding') on item 'WebDocument19216801.LabelPortForwarding'.", repo.WebDocument19216801.LabelPortForwardingInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.LabelPortForwardingInfo, "Id", "label_PortForwarding");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Port forwarding') on item 'WebDocument19216801.LabelPortForwarding'.", repo.WebDocument19216801.LabelPortForwardingInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.LabelPortForwardingInfo, "InnerText", "Port forwarding");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=728,Height=66}) on item 'WebDocument19216801.LabelPortForwarding'.", repo.WebDocument19216801.LabelPortForwardingInfo, new RecordItemIndex(15));
            //Validate.ContainsImage(repo.WebDocument19216801.LabelPortForwardingInfo, LabelPortForwarding_Screenshot1, LabelPortForwarding_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage AdvancedSettings_Screenshot2
        { get { return repo.WebDocument19216801.AdvancedSettingsInfo.GetScreenshot2(new Rectangle(0, 0, 125, 19)); } }

        Imaging.FindOptions AdvancedSettings_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Security1_Screenshot1
        { get { return repo.WebDocument19216801.Security1Info.GetScreenshot1(new Rectangle(0, 0, 48, 16)); } }

        Imaging.FindOptions Security1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LabelPortForwarding_Screenshot1
        { get { return repo.WebDocument19216801.LabelPortForwardingInfo.GetScreenshot1(new Rectangle(0, 0, 728, 66)); } }

        Imaging.FindOptions LabelPortForwarding_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
