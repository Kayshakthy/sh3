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
    ///The Second_Login_Record recording.
    /// </summary>
    [TestModule("510148f4-367a-4a87-acd1-ecbc57a0a011", ModuleType.Recording, 1)]
    public partial class Second_Login_Record : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Second_Login_Record instance = new Second_Login_Record();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Second_Login_Record()
        {
            Login_Pass = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Second_Login_Record Instance
        {
            get { return instance; }
        }

#region Variables

        string _Login_Pass;

        /// <summary>
        /// Gets or sets the value of variable Login_Pass.
        /// </summary>
        [TestVariable("350aeedb-2c5f-487d-ae14-88408f66c0d0")]
        public string Login_Pass
        {
            get { return _Login_Pass; }
            set { _Login_Pass = value; }
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

            repo.WebDocument19216801.Password.Click("114;19");
            Delay.Milliseconds(200);
            
            Keyboard.Press("Ctrl+A");
            Delay.Milliseconds(0);
            
            Keyboard.Press("Del");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Password.PressKeys(Login_Pass);
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Button.Click("89;31");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.ErrTipPasswordInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.ErrTipPasswordInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ErrTipPasswordInfo, "Id", "errTip_Password");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.ErrTipPasswordInfo, "InnerText", "Other local user has already logged in,please wait");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Id", "errClose-Password");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.ErrClosePasswordInfo, ErrClosePassword_Screenshot1, ErrClosePassword_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.ContentHolder.Click("769;445");
            //Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument19216801.ContentHolderInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.ContentHolderInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.ContentHolderInfo, "Id", "login_box");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.ContentHolderInfo, ContentHolder_Screenshot1, ContentHolder_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocumentIE.OtherLocalUserHasAlreadyLoggedIn'.", repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'WebDocumentIE.OtherLocalUserHasAlreadyLoggedIn'.", repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.OtherLocalUserHasAlreadyLoggedIn'.", repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Other local user has already logged in, please wait...') on item 'WebDocumentIE.OtherLocalUserHasAlreadyLoggedIn'.", repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, new RecordItemIndex(21));
            Validate.Attribute(repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, "InnerText", "Other local user has already logged in, please wait...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=199,Height=35}) on item 'WebDocumentIE.OtherLocalUserHasAlreadyLoggedIn'.", repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, new RecordItemIndex(22));
            Validate.ContainsImage(repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo, OtherLocalUserHasAlreadyLoggedIn_Screenshot1, OtherLocalUserHasAlreadyLoggedIn_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocumentIE.ErrClosePassword'.", repo.WebDocumentIE.ErrClosePasswordInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'WebDocumentIE.ErrClosePassword'.", repo.WebDocumentIE.ErrClosePasswordInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.ErrClosePassword'.", repo.WebDocumentIE.ErrClosePasswordInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-Password') on item 'WebDocumentIE.ErrClosePassword'.", repo.WebDocumentIE.ErrClosePasswordInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.WebDocumentIE.ErrClosePasswordInfo, "Id", "errClose-Password");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=25,Height=29}) on item 'WebDocumentIE.ErrClosePassword'.", repo.WebDocumentIE.ErrClosePasswordInfo, new RecordItemIndex(27));
            Validate.ContainsImage(repo.WebDocumentIE.ErrClosePasswordInfo, ErrClosePassword_Screenshot1_2, ErrClosePassword_Screenshot1_2_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage ErrClosePassword_Screenshot1
        { get { return repo.WebDocumentIE.ErrClosePasswordInfo.GetScreenshot1(new Rectangle(0, 0, 25, 29)); } }

        Imaging.FindOptions ErrClosePassword_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ContentHolder_Screenshot1
        { get { return repo.WebDocument19216801.ContentHolderInfo.GetScreenshot1(new Rectangle(0, 0, 780, 486)); } }

        Imaging.FindOptions ContentHolder_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage OtherLocalUserHasAlreadyLoggedIn_Screenshot1
        { get { return repo.WebDocumentIE.OtherLocalUserHasAlreadyLoggedInInfo.GetScreenshot1(new Rectangle(0, 0, 199, 35)); } }

        Imaging.FindOptions OtherLocalUserHasAlreadyLoggedIn_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrClosePassword_Screenshot1_2
        { get { return repo.WebDocumentIE.ErrClosePasswordInfo.GetScreenshot1(new Rectangle(0, 0, 25, 29)); } }

        Imaging.FindOptions ErrClosePassword_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}