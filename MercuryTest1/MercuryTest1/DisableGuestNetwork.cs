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
    ///The DisableGuestNetwork recording.
    /// </summary>
    [TestModule("1927d96a-49c2-4b7b-9e99-bad0996af9dc", ModuleType.Recording, 1)]
    public partial class DisableGuestNetwork : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static DisableGuestNetwork instance = new DisableGuestNetwork();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DisableGuestNetwork()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DisableGuestNetwork Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1358;243.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(0));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1358;243");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1355;300.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(1));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;300");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Modify your Guest network') on item 'WebDocument19216801.ModifyYourGuestNetwork'.", repo.WebDocument19216801.ModifyYourGuestNetworkInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.ModifyYourGuestNetworkInfo, "InnerText", "Modify your Guest network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=310,Height=296}) on item 'WebDocument19216801.ButtonContainers'.", repo.WebDocument19216801.ButtonContainersInfo, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.ButtonContainersInfo, ButtonContainers_Screenshot1, ButtonContainers_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ModifyYourGuestNetwork' at 102;23.", repo.WebDocument19216801.ModifyYourGuestNetworkInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.ModifyYourGuestNetwork.Click("102;23");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Modify Your Guest Network') on item 'WebDocument19216801.ModifyYourGuestNetwork1'.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.ModifyYourGuestNetwork1Info, "InnerText", "Modify Your Guest Network");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ModifyYourGuestNetwork1' at 114;23.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(7));
            //repo.WebDocument19216801.ModifyYourGuestNetwork1.Click("114;23");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Guest network') on item 'WebDocument19216801.GuestNetwork'.", repo.WebDocument19216801.GuestNetworkInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkInfo, "InnerText", "Guest network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ModifyYourGuestNetwork1' at 133;6.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(9));
            //repo.WebDocument19216801.ModifyYourGuestNetwork1.Click("133;6");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Guest network') on item 'WebDocument19216801.GuestNetwork'.", repo.WebDocument19216801.GuestNetworkInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkInfo, "InnerText", "Guest network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDisableGuest' at 19;15.", repo.WebDocument19216801.FmRbtnDisableGuestInfo, new RecordItemIndex(11));
            //repo.WebDocument19216801.FmRbtnDisableGuest.Click("19;15");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestApplyOrNext' at 153;26.", repo.WebDocument19216801.GuestApplyOrNextInfo, new RecordItemIndex(12));
            //repo.WebDocument19216801.GuestApplyOrNext.Click("153;26");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxDisableGuest' at 16;19.", repo.WebDocument19216801.FmChbxDisableGuestInfo, new RecordItemIndex(13));
            repo.WebDocument19216801.FmChbxDisableGuest.Click("16;19");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "Disable Guest Network", null, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestApplyOrNext' at 208;34.", repo.WebDocument19216801.GuestApplyOrNextInfo, new RecordItemIndex(15));
            repo.WebDocument19216801.GuestApplyOrNext.Click("208;34");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage ButtonContainers_Screenshot1
        { get { return repo.WebDocument19216801.ButtonContainersInfo.GetScreenshot1(new Rectangle(0, 0, 310, 296)); } }

        Imaging.FindOptions ButtonContainers_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
