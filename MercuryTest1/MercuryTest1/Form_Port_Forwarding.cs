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
    ///The Form_Port_Forwarding recording.
    /// </summary>
    [TestModule("dff4eeaf-4d68-41a1-95ff-34e61097f0fd", ModuleType.Recording, 1)]
    public partial class Form_Port_Forwarding : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Form_Port_Forwarding instance = new Form_Port_Forwarding();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_Port_Forwarding()
        {
            LocalIPAddr = "";
            LocalStartPort = "";
            LocalEndPort = "";
            ExternalStartPort = "";
            ExternalEndPort = "";
            Port_Fwd_Protocol = "";
            Port_Fwd_Enable = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_Port_Forwarding Instance
        {
            get { return instance; }
        }

#region Variables

        string _LocalIPAddr;

        /// <summary>
        /// Gets or sets the value of variable LocalIPAddr.
        /// </summary>
        [TestVariable("df358f38-891e-4bec-a644-17c29a55472c")]
        public string LocalIPAddr
        {
            get { return _LocalIPAddr; }
            set { _LocalIPAddr = value; }
        }

        string _LocalStartPort;

        /// <summary>
        /// Gets or sets the value of variable LocalStartPort.
        /// </summary>
        [TestVariable("c0a458f3-5e12-415b-a383-bd0736616a16")]
        public string LocalStartPort
        {
            get { return _LocalStartPort; }
            set { _LocalStartPort = value; }
        }

        string _LocalEndPort;

        /// <summary>
        /// Gets or sets the value of variable LocalEndPort.
        /// </summary>
        [TestVariable("75689dd3-f677-4d6a-9588-83cb955acce8")]
        public string LocalEndPort
        {
            get { return _LocalEndPort; }
            set { _LocalEndPort = value; }
        }

        string _ExternalStartPort;

        /// <summary>
        /// Gets or sets the value of variable ExternalStartPort.
        /// </summary>
        [TestVariable("3fc9561d-5c13-4385-bc04-f20f2b7ec2b2")]
        public string ExternalStartPort
        {
            get { return _ExternalStartPort; }
            set { _ExternalStartPort = value; }
        }

        string _ExternalEndPort;

        /// <summary>
        /// Gets or sets the value of variable ExternalEndPort.
        /// </summary>
        [TestVariable("50fadfa1-def5-4620-88ce-fb0b7efe2f5a")]
        public string ExternalEndPort
        {
            get { return _ExternalEndPort; }
            set { _ExternalEndPort = value; }
        }

        string _Port_Fwd_Protocol;

        /// <summary>
        /// Gets or sets the value of variable Port_Fwd_Protocol.
        /// </summary>
        [TestVariable("fa9c899c-3f39-411f-bf2e-63ebbb4db78c")]
        public string Port_Fwd_Protocol
        {
            get { return _Port_Fwd_Protocol; }
            set { _Port_Fwd_Protocol = value; }
        }

        string _Port_Fwd_Enable;

        /// <summary>
        /// Gets or sets the value of variable Port_Fwd_Enable.
        /// </summary>
        [TestVariable("36ff1b1c-0f57-4205-98e2-6652d762327b")]
        public string Port_Fwd_Enable
        {
            get { return _Port_Fwd_Enable; }
            set { _Port_Fwd_Enable = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.LocalIPAddress' at 48;10.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(0));
            //repo.WebDocument19216801.LocalIPAddress.MoveTo("48;10");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.LocalIPAddress' at 48;10.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(1));
            //repo.WebDocument19216801.LocalIPAddress.MoveTo("48;10");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.LocalIPAddress.Click();
            //Delay.Milliseconds(200);
            
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.LocalIPAddress' at 48;10.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(5));
            //repo.WebDocument19216801.LocalIPAddress.MoveTo("48;10");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.LocalIPAddress' at 56;2.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(6));
            //repo.WebDocument19216801.LocalIPAddress.MoveTo("56;2");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.SomeSpanTag7' at 2;18.", repo.WebDocument19216801.SomeSpanTag7Info, new RecordItemIndex(7));
            //repo.WebDocument19216801.SomeSpanTag7.MoveTo("2;18");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.LocalIPAddress.PressKeys(LocalIPAddr);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPAdd1' at 81;23.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(9));
            //repo.WebDocument19216801.IPAdd1.Click("81;23");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IPSingleAddress_3') on item 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocument19216801.IPSingleAddress3Info, "Id", "IPSingleAddress_3");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='0') on item 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.IPSingleAddress3Info, "TagValue", "0");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='0') on item 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.IPSingleAddress3Info, "Value", "0");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='submitBtn') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Class", "submitBtn");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='IP_Add') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Id", "IP_Add");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Create a new rule') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(15));
            Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "TagValue", "Create a new rule");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Tabindex='2') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(16));
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Tabindex", "2");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Type='button') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(17));
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Type", "button");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Create a new rule') on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(18));
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Value", "Create a new rule");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=247,Height=56}) on item 'WebDocument19216801.IPAdd1'.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(19));
            //Validate.ContainsImage(repo.WebDocument19216801.IPAdd1Info, IPAdd1_Screenshot3, IPAdd1_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPAdd1' at 128;39.", repo.WebDocument19216801.IPAdd1Info, new RecordItemIndex(20));
            //repo.WebDocument19216801.IPAdd1.Click("128;39");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPSingleAddress3' at 23;18.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(21));
            repo.WebDocument19216801.IPSingleAddress3.Click("23;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(22));
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPSingleAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(23));
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPSingleAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LocalIPAddr' with focus on 'WebDocument19216801.IPSingleAddress3'.", repo.WebDocument19216801.IPSingleAddress3Info, new RecordItemIndex(24));
            repo.WebDocument19216801.IPSingleAddress3.PressKeys(LocalIPAddr);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LocalStartPort' at 14;12.", repo.WebDocument19216801.LocalStartPortInfo, new RecordItemIndex(25));
            //repo.WebDocument19216801.LocalStartPort.Click("14;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.LocalIPAddress'.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(26));
            //Validate.Attribute(repo.WebDocument19216801.LocalIPAddressInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.LocalIPAddress'.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(27));
            //Validate.Attribute(repo.WebDocument19216801.LocalIPAddressInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LocalIPAddress') on item 'WebDocument19216801.LocalIPAddress'.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(28));
            //Validate.Attribute(repo.WebDocument19216801.LocalIPAddressInfo, "Id", "LocalIPAddress");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='192.168.0.10') on item 'WebDocument19216801.LocalIPAddress'.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(29));
            //Validate.Attribute(repo.WebDocument19216801.LocalIPAddressInfo, "TagValue", "192.168.0.10");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='192.168.0.10') on item 'WebDocument19216801.LocalIPAddress'.", repo.WebDocument19216801.LocalIPAddressInfo, new RecordItemIndex(30));
            //Validate.Attribute(repo.WebDocument19216801.LocalIPAddressInfo, "Value", "192.168.0.10");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.LocalStartPort.Click("38;10");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.LocalStartPort.PressKeys(LocalStartPort);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.LocalStartPort'.", repo.WebDocument19216801.LocalStartPortInfo, new RecordItemIndex(35));
            //Validate.Attribute(repo.WebDocument19216801.LocalStartPortInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LocalStartPort') on item 'WebDocument19216801.LocalStartPort'.", repo.WebDocument19216801.LocalStartPortInfo, new RecordItemIndex(36));
            //Validate.Attribute(repo.WebDocument19216801.LocalStartPortInfo, "Id", "LocalStartPort");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='20') on item 'WebDocument19216801.LocalStartPort'.", repo.WebDocument19216801.LocalStartPortInfo, new RecordItemIndex(37));
            //Validate.Attribute(repo.WebDocument19216801.LocalStartPortInfo, "TagValue", "20");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='20') on item 'WebDocument19216801.LocalStartPort'.", repo.WebDocument19216801.LocalStartPortInfo, new RecordItemIndex(38));
            //Validate.Attribute(repo.WebDocument19216801.LocalStartPortInfo, "Value", "20");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.LocalEndPort.Click("23;8");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.LocalEndPort.PressKeys(LocalEndPort);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.LocalEndPort'.", repo.WebDocument19216801.LocalEndPortInfo, new RecordItemIndex(43));
            //Validate.Attribute(repo.WebDocument19216801.LocalEndPortInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LocalEndPort') on item 'WebDocument19216801.LocalEndPort'.", repo.WebDocument19216801.LocalEndPortInfo, new RecordItemIndex(44));
            //Validate.Attribute(repo.WebDocument19216801.LocalEndPortInfo, "Id", "LocalEndPort");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='20') on item 'WebDocument19216801.LocalEndPort'.", repo.WebDocument19216801.LocalEndPortInfo, new RecordItemIndex(45));
            //Validate.Attribute(repo.WebDocument19216801.LocalEndPortInfo, "TagValue", "20");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='20') on item 'WebDocument19216801.LocalEndPort'.", repo.WebDocument19216801.LocalEndPortInfo, new RecordItemIndex(46));
            //Validate.Attribute(repo.WebDocument19216801.LocalEndPortInfo, "Value", "20");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.ExternalStartPort.Click("58;6");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.ExternalStartPort.PressKeys(ExternalStartPort);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.ExternalStartPort'.", repo.WebDocument19216801.ExternalStartPortInfo, new RecordItemIndex(51));
            //Validate.Attribute(repo.WebDocument19216801.ExternalStartPortInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='ExternalStartPort') on item 'WebDocument19216801.ExternalStartPort'.", repo.WebDocument19216801.ExternalStartPortInfo, new RecordItemIndex(52));
            //Validate.Attribute(repo.WebDocument19216801.ExternalStartPortInfo, "Id", "ExternalStartPort");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='20') on item 'WebDocument19216801.ExternalStartPort'.", repo.WebDocument19216801.ExternalStartPortInfo, new RecordItemIndex(53));
            //Validate.Attribute(repo.WebDocument19216801.ExternalStartPortInfo, "TagValue", "20");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='20') on item 'WebDocument19216801.ExternalStartPort'.", repo.WebDocument19216801.ExternalStartPortInfo, new RecordItemIndex(54));
            //Validate.Attribute(repo.WebDocument19216801.ExternalStartPortInfo, "Value", "20");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.ExternalEndPort.Click("33;6");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.ExternalEndPort.PressKeys(ExternalEndPort);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.ExternalEndPort'.", repo.WebDocument19216801.ExternalEndPortInfo, new RecordItemIndex(59));
            //Validate.Attribute(repo.WebDocument19216801.ExternalEndPortInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='ExternalEndPort') on item 'WebDocument19216801.ExternalEndPort'.", repo.WebDocument19216801.ExternalEndPortInfo, new RecordItemIndex(60));
            //Validate.Attribute(repo.WebDocument19216801.ExternalEndPortInfo, "Id", "ExternalEndPort");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='20') on item 'WebDocument19216801.ExternalEndPort'.", repo.WebDocument19216801.ExternalEndPortInfo, new RecordItemIndex(61));
            //Validate.Attribute(repo.WebDocument19216801.ExternalEndPortInfo, "TagValue", "20");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='20') on item 'WebDocument19216801.ExternalEndPort'.", repo.WebDocument19216801.ExternalEndPortInfo, new RecordItemIndex(62));
            //Validate.Attribute(repo.WebDocument19216801.ExternalEndPortInfo, "Value", "20");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1353;300.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(63));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1353;300");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1345;442.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(64));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1345;442");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 66;12.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(65));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("66;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.BOTH' at 61;16.", repo.WebDocument19216801.FmSelProtocol.BOTHInfo, new RecordItemIndex(66));
            //repo.WebDocument19216801.FmSelProtocol.BOTH.Click("61;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 73;14.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(67));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("73;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' at 49;14.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(68));
            //repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Click("49;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOff' at 28;11.", repo.WebDocument19216801.FmSelEnabled.LiTagOffInfo, new RecordItemIndex(69));
            //repo.WebDocument19216801.FmSelEnabled.LiTagOff.Click("28;11");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' at 51;12.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(70));
            //repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Click("51;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOn' at 14;12.", repo.WebDocument19216801.FmSelEnabled.LiTagOnInfo, new RecordItemIndex(71));
            //repo.WebDocument19216801.FmSelEnabled.LiTagOn.Click("14;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 73;14.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(72));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("73;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.FmSelProtocol.SomeUlTag' at 74;39.", repo.WebDocument19216801.FmSelProtocol.SomeUlTagInfo, new RecordItemIndex(73));
            //repo.WebDocument19216801.FmSelProtocol.SomeUlTag.MoveTo("74;39");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.FmSelProtocol.SomeUlTag' at 80;77.", repo.WebDocument19216801.FmSelProtocol.SomeUlTagInfo, new RecordItemIndex(74));
            //repo.WebDocument19216801.FmSelProtocol.SomeUlTag.MoveTo("80;77");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute '' from item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' and assigning its value to variable 'Port_Fwd_Protocol'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(75));
            //Port_Fwd_Protocol = repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Element.GetAttributeValueText("");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute '' from item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' and assigning its value to variable 'Port_Fwd_Enable'.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(76));
            //Port_Fwd_Enable = repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Element.GetAttributeValueText("");
            //Delay.Milliseconds(0);
            
            try {
                update_the_values_for_add_forward_rule(Port_Fwd_Protocol, Port_Fwd_Enable);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(77)); }
            
        }

#region Image Feature Data
        CompressedImage IPAdd1_Screenshot3
        { get { return repo.WebDocument19216801.IPAdd1Info.GetScreenshot3(new Rectangle(0, 0, 247, 56)); } }

        Imaging.FindOptions IPAdd1_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
