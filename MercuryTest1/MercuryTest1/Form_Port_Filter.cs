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
    ///The Form_Port_Filter recording.
    /// </summary>
    [TestModule("3802813c-4fba-4434-b557-77602ad3e05b", ModuleType.Recording, 1)]
    public partial class Form_Port_Filter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Form_Port_Filter instance = new Form_Port_Filter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_Port_Filter()
        {
            Dest_IP_Addr = "";
            SourcePortStart = "";
            SourcePortEnd = "80";
            DestPortStart = "";
            DestPortEnd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_Port_Filter Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dest_IP_Addr;

        /// <summary>
        /// Gets or sets the value of variable Dest_IP_Addr.
        /// </summary>
        [TestVariable("0dbd8e4e-1eb8-4c62-9cab-9ba22d7170fc")]
        public string Dest_IP_Addr
        {
            get { return _Dest_IP_Addr; }
            set { _Dest_IP_Addr = value; }
        }

        string _SourcePortStart;

        /// <summary>
        /// Gets or sets the value of variable SourcePortStart.
        /// </summary>
        [TestVariable("e4a6a2cc-d28e-4cc4-b800-a738a0fdca2c")]
        public string SourcePortStart
        {
            get { return _SourcePortStart; }
            set { _SourcePortStart = value; }
        }

        string _SourcePortEnd;

        /// <summary>
        /// Gets or sets the value of variable SourcePortEnd.
        /// </summary>
        [TestVariable("502aa262-bba6-46d6-92bb-fd40f9080669")]
        public string SourcePortEnd
        {
            get { return _SourcePortEnd; }
            set { _SourcePortEnd = value; }
        }

        string _DestPortStart;

        /// <summary>
        /// Gets or sets the value of variable DestPortStart.
        /// </summary>
        [TestVariable("ecddd2ca-351f-4147-b838-547a03449029")]
        public string DestPortStart
        {
            get { return _DestPortStart; }
            set { _DestPortStart = value; }
        }

        string _DestPortEnd;

        /// <summary>
        /// Gets or sets the value of variable DestPortEnd.
        /// </summary>
        [TestVariable("46693582-701e-4ab2-a6ef-8240c2731b22")]
        public string DestPortEnd
        {
            get { return _DestPortEnd; }
            set { _DestPortEnd = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.SomeSpanTag4' at 172;22.", repo.WebDocument19216801.SomeSpanTag4Info, new RecordItemIndex(0));
            repo.WebDocument19216801.SomeSpanTag4.Click("172;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.CiteTagAll' at 150;10.", repo.WebDocument19216801.CiteTagAllInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.CiteTagAll.Click("150;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelIPv4SrcIPGrp.SomeSpanTag' at 174;15.", repo.WebDocument19216801.FmSelIPv4SrcIPGrp.SomeSpanTagInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.FmSelIPv4SrcIPGrp.SomeSpanTag.Click("174;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelIPv4SrcIPGrp.CiteTagAll1' at 118;10.", repo.WebDocument19216801.FmSelIPv4SrcIPGrp.CiteTagAll1Info, new RecordItemIndex(3));
            repo.WebDocument19216801.FmSelIPv4SrcIPGrp.CiteTagAll1.Click("118;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.SomeSpanTag5' at 173;20.", repo.WebDocument19216801.SomeSpanTag5Info, new RecordItemIndex(4));
            repo.WebDocument19216801.SomeSpanTag5.Click("173;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Single' at 59;12.", repo.WebDocument19216801.SingleInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.Single.Click("59;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.IPv4DestSingleAddress' at 65;8.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(6));
            repo.WebDocument19216801.IPv4DestSingleAddress.MoveTo("65;8");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.IPv4DestSingleAddress' at 73;0.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(7));
            repo.WebDocument19216801.IPv4DestSingleAddress.MoveTo("73;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.IPv4Address' at 74;20.", repo.WebDocument19216801.IPv4AddressInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.IPv4Address.MoveTo("74;20");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Dest_IP_Addr' with focus on 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.IPv4DestSingleAddress.PressKeys(Dest_IP_Addr);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestSingleAddressInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv4DestSingleAddress') on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestSingleAddressInfo, "Id", "IPv4DestSingleAddress");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestSingleAddressInfo, "TagName", "input");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='192.168.0.10') on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestSingleAddressInfo, "TagValue", "192.168.0.10");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='192.168.0.10') on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(16));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestSingleAddressInfo, "Value", "192.168.0.10");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=122,Height=20}) on item 'WebDocument19216801.IPv4DestSingleAddress'.", repo.WebDocument19216801.IPv4DestSingleAddressInfo, new RecordItemIndex(17));
            //Validate.ContainsImage(repo.WebDocument19216801.IPv4DestSingleAddressInfo, IPv4DestSingleAddress_Screenshot1, IPv4DestSingleAddress_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv4SrcPortStart' at 48;10.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(18));
            repo.WebDocument19216801.IPv4SrcPortStart.Click("48;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(19));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SourcePortStart' with focus on 'WebDocument19216801.IPv4SrcPortStart'.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(21));
            repo.WebDocument19216801.IPv4SrcPortStart.PressKeys(SourcePortStart);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.IPv4SrcPortStart'.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(22));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortStartInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv4SrcPortStart') on item 'WebDocument19216801.IPv4SrcPortStart'.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(23));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortStartInfo, "Id", "IPv4SrcPortStart");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='80') on item 'WebDocument19216801.IPv4SrcPortStart'.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(24));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortStartInfo, "TagValue", "80");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='80') on item 'WebDocument19216801.IPv4SrcPortStart'.", repo.WebDocument19216801.IPv4SrcPortStartInfo, new RecordItemIndex(25));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortStartInfo, "Value", "80");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv4SrcPortEnd' at 36;14.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(26));
            repo.WebDocument19216801.IPv4SrcPortEnd.Click("36;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(27));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(28));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SourcePortEnd' with focus on 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(29));
            repo.WebDocument19216801.IPv4SrcPortEnd.PressKeys(SourcePortEnd);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(30));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortEndInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv4SrcPortEnd') on item 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(31));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortEndInfo, "Id", "IPv4SrcPortEnd");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='80') on item 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(32));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortEndInfo, "TagValue", "80");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='80') on item 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(33));
            //Validate.Attribute(repo.WebDocument19216801.IPv4SrcPortEndInfo, "Value", "80");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv4DestPortStart' at 45;12.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(34));
            repo.WebDocument19216801.IPv4DestPortStart.Click("45;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(35));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(36));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '80' with focus on 'WebDocument19216801.IPv4SrcPortEnd'.", repo.WebDocument19216801.IPv4SrcPortEndInfo, new RecordItemIndex(37));
            //repo.WebDocument19216801.IPv4SrcPortEnd.PressKeys("80");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv4DestPortStart' at 40;13.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(38));
            //repo.WebDocument19216801.IPv4DestPortStart.Click("40;13");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DestPortStart' with focus on 'WebDocument19216801.IPv4DestPortStart'.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(39));
            repo.WebDocument19216801.IPv4DestPortStart.PressKeys(DestPortStart);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.IPv4DestPortStart'.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(40));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortStartInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv4DestPortStart') on item 'WebDocument19216801.IPv4DestPortStart'.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(41));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortStartInfo, "Id", "IPv4DestPortStart");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='80') on item 'WebDocument19216801.IPv4DestPortStart'.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(42));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortStartInfo, "TagValue", "80");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='80') on item 'WebDocument19216801.IPv4DestPortStart'.", repo.WebDocument19216801.IPv4DestPortStartInfo, new RecordItemIndex(43));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortStartInfo, "Value", "80");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KIRUSHAKTHYPC.KIRUSHAKTHYPC' at 868;538.", repo.KIRUSHAKTHYPC.KIRUSHAKTHYPCInfo, new RecordItemIndex(44));
            //repo.KIRUSHAKTHYPC.KIRUSHAKTHYPC.Click("868;538");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv4DestPortEnd' at 45;12.", repo.WebDocument19216801.IPv4DestPortEndInfo, new RecordItemIndex(45));
            repo.WebDocument19216801.IPv4DestPortEnd.Click("45;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(46));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(47));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DestPortEnd' with focus on 'WebDocument19216801.IPv4DestPortEnd'.", repo.WebDocument19216801.IPv4DestPortEndInfo, new RecordItemIndex(48));
            repo.WebDocument19216801.IPv4DestPortEnd.PressKeys(DestPortEnd);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.IPv4DestPortEnd'.", repo.WebDocument19216801.IPv4DestPortEndInfo, new RecordItemIndex(49));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortEndInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPv4DestPortEnd') on item 'WebDocument19216801.IPv4DestPortEnd'.", repo.WebDocument19216801.IPv4DestPortEndInfo, new RecordItemIndex(50));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortEndInfo, "Id", "IPv4DestPortEnd");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='80') on item 'WebDocument19216801.IPv4DestPortEnd'.", repo.WebDocument19216801.IPv4DestPortEndInfo, new RecordItemIndex(51));
            //Validate.Attribute(repo.WebDocument19216801.IPv4DestPortEndInfo, "TagValue", "80");
            //Delay.Milliseconds(100);
            
            Validate_IPv4DestPortEnd(Dest_IP_Addr, SourcePortStart, SourcePortEnd, DestPortStart, DestPortEnd);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage IPv4DestSingleAddress_Screenshot1
        { get { return repo.WebDocument19216801.IPv4DestSingleAddressInfo.GetScreenshot1(new Rectangle(0, 0, 122, 20)); } }

        Imaging.FindOptions IPv4DestSingleAddress_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}