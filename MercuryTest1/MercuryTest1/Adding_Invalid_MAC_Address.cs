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
    ///The Adding_Invalid_MAC_Address recording.
    /// </summary>
    [TestModule("91ca60b7-253a-4eee-8c12-07dd4d6930c9", ModuleType.Recording, 1)]
    public partial class Adding_Invalid_MAC_Address : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Adding_Invalid_MAC_Address instance = new Adding_Invalid_MAC_Address();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adding_Invalid_MAC_Address()
        {
            DeviceName = "";
            MAC_Address0 = "";
            MAC_Address1 = "";
            MAC_Address2 = "";
            MAC_Address3 = "";
            MAC_Address4 = "";
            MAC_Address5 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adding_Invalid_MAC_Address Instance
        {
            get { return instance; }
        }

#region Variables

        string _DeviceName;

        /// <summary>
        /// Gets or sets the value of variable DeviceName.
        /// </summary>
        [TestVariable("ff1828a5-0401-4594-96ad-5575dc11ee59")]
        public string DeviceName
        {
            get { return _DeviceName; }
            set { _DeviceName = value; }
        }

        string _MAC_Address0;

        /// <summary>
        /// Gets or sets the value of variable MAC_Address0.
        /// </summary>
        [TestVariable("f3ce9551-8705-493d-9f14-24835f8a19a1")]
        public string MAC_Address0
        {
            get { return _MAC_Address0; }
            set { _MAC_Address0 = value; }
        }

        string _MAC_Address1;

        /// <summary>
        /// Gets or sets the value of variable MAC_Address1.
        /// </summary>
        [TestVariable("7e80ea3d-e46a-4a4a-9a14-15b652ddde3a")]
        public string MAC_Address1
        {
            get { return _MAC_Address1; }
            set { _MAC_Address1 = value; }
        }

        string _MAC_Address2;

        /// <summary>
        /// Gets or sets the value of variable MAC_Address2.
        /// </summary>
        [TestVariable("4db200fd-4463-4182-9015-46699126dd67")]
        public string MAC_Address2
        {
            get { return _MAC_Address2; }
            set { _MAC_Address2 = value; }
        }

        string _MAC_Address3;

        /// <summary>
        /// Gets or sets the value of variable MAC_Address3.
        /// </summary>
        [TestVariable("f32b3af3-3d6c-44b7-a291-ae0be2a5edb7")]
        public string MAC_Address3
        {
            get { return _MAC_Address3; }
            set { _MAC_Address3 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MAC_Address4.
        /// </summary>
        [TestVariable("01cb02bc-6f6a-4847-8b1d-f96806082ca1")]
        public string MAC_Address4
        {
            get { return repo.MAC_Address4; }
            set { repo.MAC_Address4 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MAC_Address5.
        /// </summary>
        [TestVariable("8fb89e7e-3136-4b2e-a8ca-5e0b6a80c206")]
        public string MAC_Address5
        {
            get { return repo.MAC_Address5; }
            set { repo.MAC_Address5 = value; }
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

            //repo.WebDocument19216801.DeviceName.Click("65;8");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.DeviceName.Click("80;7");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.DeviceName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.DeviceName);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.DeviceName.PressKeys(DeviceName);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress0.DoubleClick("13;9");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress0);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress0);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress0.PressKeys(MAC_Address0);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress1.DoubleClick("9;8");
            Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.MACAddress1.DoubleClick("9;8");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.MACAddress1.MoveTo("7;9");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.MACAddress1.MoveTo("18;9");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress1);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress1.PressKeys(MAC_Address1);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress2.Click("13;13");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress2);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress2);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress2.PressKeys(MAC_Address2);
            Delay.Milliseconds(0);
            
            //repo.WebDocument19216801.MACAddress3.Click("11;10");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.MACAddress3.DoubleClick("11;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress3.PressKeys(MAC_Address3);
            Delay.Milliseconds(0);
            
            //repo.WebDocument19216801.MACAddress4.DoubleClick("14;10");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.MACAddress4.DoubleClick("14;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress4);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress4);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress4.PressKeys(MAC_Address4);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress5.Click("12;11");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress5);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress5);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //repo.WebDocument19216801.MACAddress5.PressKeys("{Delete}");
            //Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress5.PressKeys(MAC_Address5);
            Delay.Milliseconds(0);
            
            Validate.Attribute(repo.WebDocument19216801.MACAdd1Info, "Id", "MAC_Add");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.MACAdd1Info, "TagValue", "Add rule");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.MACAdd1Info, "Value", "Add rule");
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.MACAdd1.Click("55;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseMACAddress'.", repo.WebDocument19216801.ErrCloseMACAddressInfo, new RecordItemIndex(39));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseMACAddressInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-MACAddress') on item 'WebDocument19216801.ErrCloseMACAddress'.", repo.WebDocument19216801.ErrCloseMACAddressInfo, new RecordItemIndex(40));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseMACAddressInfo, "Id", "errClose-MACAddress");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocument19216801.ErrCloseMACAddress'.", repo.WebDocument19216801.ErrCloseMACAddressInfo, new RecordItemIndex(41));
            //Validate.ContainsImage(repo.WebDocument19216801.ErrCloseMACAddressInfo, ErrCloseMACAddress_Screenshot1, ErrCloseMACAddress_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='10:1:12:13:33:12 is not a valid mac address.') on item 'WebDocument19216801.SpanTag10112133312IsNotAValidM'.", repo.WebDocument19216801.SpanTag10112133312IsNotAValidMInfo, new RecordItemIndex(42));
            //Validate.Attribute(repo.WebDocument19216801.SpanTag10112133312IsNotAValidMInfo, "InnerText", "10:1:12:13:33:12 is not a valid mac address.");
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(43));
            
        }

#region Image Feature Data
        CompressedImage ErrCloseMACAddress_Screenshot1
        { get { return repo.WebDocument19216801.ErrCloseMACAddressInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseMACAddress_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
