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
    ///The Presentation_without_default_password recording.
    /// </summary>
    [TestModule("028cbcb9-44ad-453b-bcd3-86b7f2b8145a", ModuleType.Recording, 1)]
    public partial class Presentation_without_default_password : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Presentation_without_default_password instance = new Presentation_without_default_password();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Presentation_without_default_password()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Presentation_without_default_password Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='login_title') on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.DivButtonsInfo, "Class", "login_title");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Welcome back') on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.DivButtonsInfo, "InnerText", "Welcome back");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=787,Height=106}) on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(2));
            Validate.ContainsImage(repo.WebDocument19216801.DivButtonsInfo, DivButtons_Screenshot3, DivButtons_Screenshot3_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='login_logo overlaycontainer') on item 'WebDocument19216801.LoginLogoOverlaycontainer'.", repo.WebDocument19216801.LoginLogoOverlaycontainerInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.LoginLogoOverlaycontainerInfo, "Class", "login_logo overlaycontainer");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=141,Height=100}) on item 'WebDocument19216801.LoginLogoOverlaycontainer'.", repo.WebDocument19216801.LoginLogoOverlaycontainerInfo, new RecordItemIndex(4));
            Validate.ContainsImage(repo.WebDocument19216801.LoginLogoOverlaycontainerInfo, LoginLogoOverlaycontainer_Screenshot1, LoginLogoOverlaycontainer_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='login_title_info') on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.DivButtonsInfo, "Class", "login_title_info");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Sign in to view or modify your Hub 3.0 settings.') on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.DivButtonsInfo, "InnerText", "Sign in to view or modify your Hub 3.0 settings.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot4' with region {X=0,Y=0,Width=787,Height=80}) on item 'WebDocument19216801.DivButtons'.", repo.WebDocument19216801.DivButtonsInfo, new RecordItemIndex(7));
            Validate.ContainsImage(repo.WebDocument19216801.DivButtonsInfo, DivButtons_Screenshot4, DivButtons_Screenshot4_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Password :') on item 'WebDocument19216801.Password1'.", repo.WebDocument19216801.Password1Info, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.Password1Info, "InnerText", "Password :");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=147,Height=52}) on item 'WebDocument19216801.Password1'.", repo.WebDocument19216801.Password1Info, new RecordItemIndex(9));
            Validate.ContainsImage(repo.WebDocument19216801.Password1Info, Password1_Screenshot1, Password1_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='Password') on item 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.PasswordInfo, "Id", "Password");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=278,Height=25}) on item 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(11));
            Validate.ContainsImage(repo.WebDocument19216801.PasswordInfo, Password_Screenshot2, Password_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='Password_image_tt') on item 'WebDocument19216801.PasswordImageTt'.", repo.WebDocument19216801.PasswordImageTtInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.PasswordImageTtInfo, "Id", "Password_image_tt");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=28,Height=31}) on item 'WebDocument19216801.PasswordImageTt'.", repo.WebDocument19216801.PasswordImageTtInfo, new RecordItemIndex(13));
            Validate.ContainsImage(repo.WebDocument19216801.PasswordImageTtInfo, PasswordImageTt_Screenshot1, PasswordImageTt_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Next') on item 'WebDocument19216801.Button'.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocument19216801.ButtonInfo, "TagValue", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Next') on item 'WebDocument19216801.Button'.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.WebDocument19216801.ButtonInfo, "Value", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=148,Height=77}) on item 'WebDocument19216801.Button'.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(16));
            Validate.ContainsImage(repo.WebDocument19216801.ButtonInfo, Button_Screenshot2, Button_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Check router status') on item 'WebDocumentIE.CheckRouterStatus'.", repo.WebDocumentIE.CheckRouterStatusInfo, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocumentIE.CheckRouterStatusInfo, "InnerText", "Check router status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=162,Height=22}) on item 'WebDocumentIE.CheckRouterStatus'.", repo.WebDocumentIE.CheckRouterStatusInfo, new RecordItemIndex(18));
            Validate.ContainsImage(repo.WebDocumentIE.CheckRouterStatusInfo, CheckRouterStatus_Screenshot1, CheckRouterStatus_Screenshot1_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage DivButtons_Screenshot3
        { get { return repo.WebDocument19216801.DivButtonsInfo.GetScreenshot3(new Rectangle(0, 0, 787, 106)); } }

        Imaging.FindOptions DivButtons_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LoginLogoOverlaycontainer_Screenshot1
        { get { return repo.WebDocument19216801.LoginLogoOverlaycontainerInfo.GetScreenshot1(new Rectangle(0, 0, 141, 100)); } }

        Imaging.FindOptions LoginLogoOverlaycontainer_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage DivButtons_Screenshot4
        { get { return repo.WebDocument19216801.DivButtonsInfo.GetScreenshot4(new Rectangle(0, 0, 787, 80)); } }

        Imaging.FindOptions DivButtons_Screenshot4_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Password1_Screenshot1
        { get { return repo.WebDocument19216801.Password1Info.GetScreenshot1(new Rectangle(0, 0, 147, 52)); } }

        Imaging.FindOptions Password1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Password_Screenshot2
        { get { return repo.WebDocument19216801.PasswordInfo.GetScreenshot2(new Rectangle(0, 0, 278, 25)); } }

        Imaging.FindOptions Password_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage PasswordImageTt_Screenshot1
        { get { return repo.WebDocument19216801.PasswordImageTtInfo.GetScreenshot1(new Rectangle(0, 0, 28, 31)); } }

        Imaging.FindOptions PasswordImageTt_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button_Screenshot2
        { get { return repo.WebDocument19216801.ButtonInfo.GetScreenshot2(new Rectangle(0, 0, 148, 77)); } }

        Imaging.FindOptions Button_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage CheckRouterStatus_Screenshot1
        { get { return repo.WebDocumentIE.CheckRouterStatusInfo.GetScreenshot1(new Rectangle(0, 0, 162, 22)); } }

        Imaging.FindOptions CheckRouterStatus_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
