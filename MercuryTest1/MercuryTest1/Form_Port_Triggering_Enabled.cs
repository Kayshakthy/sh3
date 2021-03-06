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
    ///The Form_Port_Triggering_Enabled recording.
    /// </summary>
    [TestModule("a51a1f84-9c63-4a12-a1e4-af09d16321f3", ModuleType.Recording, 1)]
    public partial class Form_Port_Triggering_Enabled : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Form_Port_Triggering_Enabled instance = new Form_Port_Triggering_Enabled();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_Port_Triggering_Enabled()
        {
            Trigger_range_start_port = "";
            Trigger_range_end_port = "";
            Target_range_start_port = "";
            Target_range_end_port = "";
            Enable_Disable = "Off";
            Protocol = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_Port_Triggering_Enabled Instance
        {
            get { return instance; }
        }

#region Variables

        string _Trigger_range_start_port;

        /// <summary>
        /// Gets or sets the value of variable Trigger_range_start_port.
        /// </summary>
        [TestVariable("eff2dd10-20b8-465a-9e10-50ee848eb217")]
        public string Trigger_range_start_port
        {
            get { return _Trigger_range_start_port; }
            set { _Trigger_range_start_port = value; }
        }

        string _Trigger_range_end_port;

        /// <summary>
        /// Gets or sets the value of variable Trigger_range_end_port.
        /// </summary>
        [TestVariable("8200154c-2aa2-4f10-8dd6-daab74c8be60")]
        public string Trigger_range_end_port
        {
            get { return _Trigger_range_end_port; }
            set { _Trigger_range_end_port = value; }
        }

        string _Target_range_start_port;

        /// <summary>
        /// Gets or sets the value of variable Target_range_start_port.
        /// </summary>
        [TestVariable("e490e886-d699-4ebd-9b93-f6f84d72a962")]
        public string Target_range_start_port
        {
            get { return _Target_range_start_port; }
            set { _Target_range_start_port = value; }
        }

        string _Target_range_end_port;

        /// <summary>
        /// Gets or sets the value of variable Target_range_end_port.
        /// </summary>
        [TestVariable("bd652996-f101-4976-9ea8-65b95e4472d9")]
        public string Target_range_end_port
        {
            get { return _Target_range_end_port; }
            set { _Target_range_end_port = value; }
        }

        string _Enable_Disable;

        /// <summary>
        /// Gets or sets the value of variable Enable_Disable.
        /// </summary>
        [TestVariable("bd66f7dd-1d34-4302-994d-964240348e7b")]
        public string Enable_Disable
        {
            get { return _Enable_Disable; }
            set { _Enable_Disable = value; }
        }

        string _Protocol;

        /// <summary>
        /// Gets or sets the value of variable Protocol.
        /// </summary>
        [TestVariable("a36cb412-a331-4112-bab9-024b57f73393")]
        public string Protocol
        {
            get { return _Protocol; }
            set { _Protocol = value; }
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

            repo.WebDocument19216801.TriggerStartPort.Click("25;9");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TriggerStartPort.PressKeys(Trigger_range_start_port);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TriggerEndPort.Click("20;10");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TriggerEndPort.PressKeys(Trigger_range_end_port);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TargetStartPort.Click("14;10");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TargetStartPort.PressKeys(Target_range_start_port);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TargetEndPort.Click("19;11");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.TargetEndPort.PressKeys(Target_range_end_port);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Protocol' from item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' and assigning its value to variable 'Protocol'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(16));
            //Protocol = repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Element.GetAttributeValueText("Protocol");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'RuleStatus' from item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' and assigning its value to variable 'Enable_Disable'.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(17));
            //Enable_Disable = repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Element.GetAttributeValueText("RuleStatus");
            //Delay.Milliseconds(0);
            
            Populate_Port_Triggering_Combo_Boxes(Protocol, Enable_Disable);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 163;16.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(19));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("163;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 163;16.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(20));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("163;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 167;11.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(21));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("167;11");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.CiteTagUDP' at 138;14.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(22));
            //repo.WebDocument19216801.FmSelProtocol.CiteTagUDP.Click("138;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='UDP') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(23));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "InnerText", "UDP");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(24));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='cite') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(25));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "TagName", "cite");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' at 166;10.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(26));
            //repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Click("166;10");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOff' at 48;9.", repo.WebDocument19216801.FmSelEnabled.LiTagOffInfo, new RecordItemIndex(27));
            //repo.WebDocument19216801.FmSelEnabled.LiTagOff.Click("48;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Enable_Disable' with focus on 'WebDocumentIE.CiteTagOn'.", repo.WebDocumentIE.CiteTagOnInfo, new RecordItemIndex(28));
            //repo.WebDocumentIE.CiteTagOn.PressKeys(Enable_Disable);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Draggable='Off') on item 'WebDocumentIE.CiteTagOff'.", repo.WebDocumentIE.CiteTagOffInfo, new RecordItemIndex(29));
            //Validate.Attribute(repo.WebDocumentIE.CiteTagOffInfo, "Draggable", "Off");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' at 164;13.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(30));
            //repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Click("164;13");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOn' at 54;13.", repo.WebDocument19216801.FmSelEnabled.LiTagOnInfo, new RecordItemIndex(31));
            //repo.WebDocument19216801.FmSelEnabled.LiTagOn.Click("54;13");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='On') on item 'WebDocumentIE.CiteTagOn'.", repo.WebDocumentIE.CiteTagOnInfo, new RecordItemIndex(32));
            //Validate.Attribute(repo.WebDocumentIE.CiteTagOnInfo, "InnerText", "On");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.CiteTagOn'.", repo.WebDocumentIE.CiteTagOnInfo, new RecordItemIndex(33));
            //Validate.Attribute(repo.WebDocumentIE.CiteTagOnInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='cite') on item 'WebDocumentIE.CiteTagOn'.", repo.WebDocumentIE.CiteTagOnInfo, new RecordItemIndex(34));
            //Validate.Attribute(repo.WebDocumentIE.CiteTagOnInfo, "TagName", "cite");
            //Delay.Milliseconds(100);
            
            Print_Port_Trigger_Values(Trigger_range_start_port, Trigger_range_end_port, Target_range_start_port, Target_range_end_port, Enable_Disable, Protocol);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
