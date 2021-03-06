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
    ///The WiFi_Security_Password_Change recording.
    /// </summary>
    [TestModule("273afac2-6882-475b-8466-68d1f32f2078", ModuleType.Recording, 1)]
    public partial class WiFi_Security_Password_Change : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static WiFi_Security_Password_Change instance = new WiFi_Security_Password_Change();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WiFi_Security_Password_Change()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WiFi_Security_Password_Change Instance
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

            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1357;151");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1365;325");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            //Validate.Attribute(repo.WebDocument19216801.Button6Info, "Class", "submitBtn");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument19216801.Button6'.", repo.WebDocument19216801.Button6Info, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.Button6Info, "TagValue", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.Button6Info, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=166,Height=43}) on item 'WebDocument19216801.Button6'.", repo.WebDocument19216801.Button6Info, new RecordItemIndex(8));
            //Validate.ContainsImage(repo.WebDocument19216801.Button6Info, Button6_Screenshot2, Button6_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.Button6.Click("86;17");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Button25.Click("59;37");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Keyboard.Press("{LControlKey up}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LogOut' at 32;6.", repo.WebDocument19216801.LogOutInfo, new RecordItemIndex(13));
            //repo.WebDocument19216801.LogOut.Click("32;6");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(14));
            //Keyboard.Press("{LControlKey up}");
            //Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(15));
            
        }

#region Image Feature Data
        CompressedImage Button6_Screenshot2
        { get { return repo.WebDocument19216801.Button6Info.GetScreenshot2(new Rectangle(0, 0, 166, 43)); } }

        Imaging.FindOptions Button6_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
