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
    ///The Input_Range_DestIPv6 recording.
    /// </summary>
    [TestModule("dc12d259-76b2-43ef-ba14-2a260c3fa350", ModuleType.Recording, 1)]
    public partial class Input_Range_DestIPv6 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Input_Range_DestIPv6 instance = new Input_Range_DestIPv6();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Input_Range_DestIPv6()
        {
            IPv6_address_destination = "192.168.0.1";
            Prefix_Length2 = "54";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Input_Range_DestIPv6 Instance
        {
            get { return instance; }
        }

#region Variables

        string _IPv6_address_destination;

        /// <summary>
        /// Gets or sets the value of variable IPv6_address_destination.
        /// </summary>
        [TestVariable("2cf65fa4-9e99-4f93-8cd7-9470dde73001")]
        public string IPv6_address_destination
        {
            get { return _IPv6_address_destination; }
            set { _IPv6_address_destination = value; }
        }

        string _Prefix_Length2;

        /// <summary>
        /// Gets or sets the value of variable Prefix_Length2.
        /// </summary>
        [TestVariable("1455f955-8520-4705-8d02-b647b5532aaa")]
        public string Prefix_Length2
        {
            get { return _Prefix_Length2; }
            set { _Prefix_Length2 = value; }
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='IPv6 address') on item 'WebDocument19216801.IPv6Address3'.", repo.WebDocument19216801.IPv6Address3Info, new RecordItemIndex(0));
            //Validate.Attribute(repo.WebDocument19216801.IPv6Address3Info, "InnerText", "IPv6 address");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='label') on item 'WebDocument19216801.IPv6Address3'.", repo.WebDocument19216801.IPv6Address3Info, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.IPv6Address3Info, "TagName", "label");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv6AddressDestRange') on item 'WebDocument19216801.IPv6AddressDestRange'.", repo.WebDocument19216801.IPv6AddressDestRangeInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.IPv6AddressDestRangeInfo, "Id", "IPv6AddressDestRange");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.IPv6AddressDestRange'.", repo.WebDocument19216801.IPv6AddressDestRangeInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.IPv6AddressDestRangeInfo, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv6AddressDestRange' at 115;13.", repo.WebDocument19216801.IPv6AddressDestRangeInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.IPv6AddressDestRange.Click("115;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IPv6_address_destination' with focus on 'WebDocument19216801.IPv6AddressDestRange'.", repo.WebDocument19216801.IPv6AddressDestRangeInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.IPv6AddressDestRange.PressKeys(IPv6_address_destination);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Prefix Length') on item 'WebDocument19216801.PrefixLength2'.", repo.WebDocument19216801.PrefixLength2Info, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.PrefixLength2Info, "InnerText", "Prefix Length");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='label') on item 'WebDocument19216801.PrefixLength2'.", repo.WebDocument19216801.PrefixLength2Info, new RecordItemIndex(7));
            //Validate.Attribute(repo.WebDocument19216801.PrefixLength2Info, "TagName", "label");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='PrefixLengthDest') on item 'WebDocument19216801.PrefixLengthDest'.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.PrefixLengthDestInfo, "Id", "PrefixLengthDest");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.PrefixLengthDest'.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.PrefixLengthDestInfo, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.PrefixLengthDest' at 26;17.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.PrefixLengthDest.Click("26;17");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.PrefixLengthDest' at 20;10.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(11));
            //repo.WebDocument19216801.PrefixLengthDest.Click("20;10");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.PrefixLengthDest'.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.WebDocument19216801.PrefixLengthDest);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.PrefixLengthDest'.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(13));
            repo.WebDocument19216801.PrefixLengthDest.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Prefix_Length2' with focus on 'WebDocument19216801.PrefixLengthDest'.", repo.WebDocument19216801.PrefixLengthDestInfo, new RecordItemIndex(14));
            repo.WebDocument19216801.PrefixLengthDest.PressKeys(Prefix_Length2);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
