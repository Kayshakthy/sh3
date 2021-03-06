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
    ///The Valid_New_Admin_Change_Password recording.
    /// </summary>
    [TestModule("0c60c126-1ea1-437a-b66e-cbad2fdf1674", ModuleType.Recording, 1)]
    public partial class Valid_New_Admin_Change_Password : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Valid_New_Admin_Change_Password instance = new Valid_New_Admin_Change_Password();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Valid_New_Admin_Change_Password()
        {
            currentPassword = "";
            New_Admin_Password = "";
            Reenter_password = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Valid_New_Admin_Change_Password Instance
        {
            get { return instance; }
        }

#region Variables

        string _currentPassword;

        /// <summary>
        /// Gets or sets the value of variable currentPassword.
        /// </summary>
        [TestVariable("23dc2333-b542-4628-bae1-23c7cec12216")]
        public string currentPassword
        {
            get { return _currentPassword; }
            set { _currentPassword = value; }
        }

        string _New_Admin_Password;

        /// <summary>
        /// Gets or sets the value of variable New_Admin_Password.
        /// </summary>
        [TestVariable("6056c54e-f708-4ba9-a24d-cf80f79a0119")]
        public string New_Admin_Password
        {
            get { return _New_Admin_Password; }
            set { _New_Admin_Password = value; }
        }

        string _Reenter_password;

        /// <summary>
        /// Gets or sets the value of variable Reenter_password.
        /// </summary>
        [TestVariable("e95bae0a-f5d4-4b1a-b2d5-369930b04920")]
        public string Reenter_password
        {
            get { return _Reenter_password; }
            set { _Reenter_password = value; }
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

            Print_Passwords(currentPassword, New_Admin_Password);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.CurrentPassword.Click("82;16");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.CurrentPassword);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.CurrentPassword);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.CurrentPassword.PressKeys(currentPassword);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NewPassword13.Click("81;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocumentIE.NewPassword13);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocumentIE.NewPassword13);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NewPassword13.PressKeys(New_Admin_Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='skipSVG check-icon') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages3'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, "Class", "skipSVG check-icon");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/skins/lgi/css/images/icon-check.svg') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages3'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, "Src", "http://192.168.0.1/skins/lgi/css/images/icon-check.svg");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='skipSVG check-icon') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages3'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, "Class", "skipSVG check-icon");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/skins/lgi/css/images/icon-check.svg') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages3'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, "Src", "http://192.168.0.1/skins/lgi/css/images/icon-check.svg");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(13));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=22,Height=23}) on item 'WebDocument19216801.Http19216801SkinsLgiCssImages3'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, new RecordItemIndex(14));
            Validate.ContainsImage(repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info, Http19216801SkinsLgiCssImages3_Screenshot1, Http19216801SkinsLgiCssImages3_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.ReenterPassword' at 93;12.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(15));
            //repo.WebDocumentIE.ReenterPassword.Click("93;12");
            //Delay.Milliseconds(200);
            
            //Keyboard.PrepareFocus(repo.WebDocumentIE.ReenterPassword);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Keyboard.PrepareFocus(repo.WebDocumentIE.ReenterPassword);
            //Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Reenter_password' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(18));
            //repo.WebDocumentIE.ReenterPassword.PressKeys(Reenter_password);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button7' at 75;31.", repo.WebDocument19216801.Button7Info, new RecordItemIndex(19));
            //repo.WebDocument19216801.Button7.Click("75;31");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(20));
            //Delay.Duration(1000, false);
            
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, "Class", "skipSVG check-icon");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, "TagName", "img");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, "Src", "http://192.168.0.1/skins/lgi/css/images/icon-check.svg");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, Http19216801SkinsLgiCssImages2_Screenshot1, Http19216801SkinsLgiCssImages2_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/skins/lgi/css/images/icon-check.svg') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages2'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, new RecordItemIndex(25));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, "Src", "http://192.168.0.1/skins/lgi/css/images/icon-check.svg");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=24,Height=25}) on item 'WebDocument19216801.Http19216801SkinsLgiCssImages2'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, new RecordItemIndex(26));
            //Validate.ContainsImage(repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info, Http19216801SkinsLgiCssImages2_Screenshot1_2, Http19216801SkinsLgiCssImages2_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            Report_Screenshot();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage Http19216801SkinsLgiCssImages3_Screenshot1
        { get { return repo.WebDocument19216801.Http19216801SkinsLgiCssImages3Info.GetScreenshot1(new Rectangle(0, 0, 22, 23)); } }

        Imaging.FindOptions Http19216801SkinsLgiCssImages3_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Http19216801SkinsLgiCssImages2_Screenshot1
        { get { return repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info.GetScreenshot1(new Rectangle(0, 0, 24, 25)); } }

        Imaging.FindOptions Http19216801SkinsLgiCssImages2_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Http19216801SkinsLgiCssImages2_Screenshot1_2
        { get { return repo.WebDocument19216801.Http19216801SkinsLgiCssImages2Info.GetScreenshot1(new Rectangle(0, 0, 24, 25)); } }

        Imaging.FindOptions Http19216801SkinsLgiCssImages2_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
