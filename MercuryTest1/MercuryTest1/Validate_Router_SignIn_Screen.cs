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
    ///The Validate_Router_SignIn_Screen recording.
    /// </summary>
    [TestModule("99fb8c26-33da-4c0b-9b19-86c7277dd3ea", ModuleType.Recording, 1)]
    public partial class Validate_Router_SignIn_Screen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_Router_SignIn_Screen instance = new Validate_Router_SignIn_Screen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Router_SignIn_Screen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Router_SignIn_Screen Instance
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='mainTitle') on item 'CertificateErrorNavigationBlocked.MainTitle'.", repo.CertificateErrorNavigationBlocked.MainTitleInfo, new RecordItemIndex(0));
            //Validate.Attribute(repo.CertificateErrorNavigationBlocked.MainTitleInfo, "Id", "mainTitle");
            //Delay.Milliseconds(100);
            
            //Validate_MainTitle();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This page can’t be displayed') on item 'CertificateErrorNavigationBlocked.MainTitle'.", repo.CertificateErrorNavigationBlocked.MainTitleInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.CertificateErrorNavigationBlocked.MainTitleInfo, "InnerText", "This page can’t be displayed");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=875,Height=83}) on item 'CertificateErrorNavigationBlocked.MainTitle'.", repo.CertificateErrorNavigationBlocked.MainTitleInfo, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.CertificateErrorNavigationBlocked.MainTitleInfo, MainTitle_Screenshot1_2, MainTitle_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='task1-1') on item 'CertificateErrorNavigationBlocked.Task11'.", repo.CertificateErrorNavigationBlocked.Task11Info, new RecordItemIndex(4));
            //Validate.Attribute(repo.CertificateErrorNavigationBlocked.Task11Info, "Id", "task1-1");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.CertificateErrorNavigationBlocked.MainTitleInfo, "Id", "mainTitle");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.CertificateErrorNavigationBlocked.MainTitleInfo, "InnerText", "Can’t reach this page");
            Delay.Milliseconds(100);
            
            Validate.ContainsImage(repo.CertificateErrorNavigationBlocked.MainTitleInfo, MainTitle_Screenshot2, MainTitle_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            try {
                //Validate_Task11();
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Make sure the web address is correct.') on item 'CertificateErrorNavigationBlocked.Task11'.", repo.CertificateErrorNavigationBlocked.Task11Info, new RecordItemIndex(9));
            //Validate.Attribute(repo.CertificateErrorNavigationBlocked.Task11Info, "InnerText", "Make sure the web address is correct.");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=825,Height=27}) on item 'CertificateErrorNavigationBlocked.Task11'.", repo.CertificateErrorNavigationBlocked.Task11Info, new RecordItemIndex(10));
            //Validate.ContainsImage(repo.CertificateErrorNavigationBlocked.Task11Info, Task11_Screenshot1_2, Task11_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.CertificateErrorNavigationBlocked.Task11Info, "Id", "task1-1");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.CertificateErrorNavigationBlocked.Task11Info, "InnerText", "Make sure the web address is correct");
            Delay.Milliseconds(100);
            
            Validate.ContainsImage(repo.CertificateErrorNavigationBlocked.Task11Info, Task11_Screenshot2, Task11_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(14));
            
        }

#region Image Feature Data
        CompressedImage MainTitle_Screenshot1
        { get { return repo.CertificateErrorNavigationBlocked.MainTitleInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions MainTitle_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage MainTitle_Screenshot1_2
        { get { return repo.CertificateErrorNavigationBlocked.MainTitleInfo.GetScreenshot1(new Rectangle(0, 0, 875, 83)); } }

        Imaging.FindOptions MainTitle_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage MainTitle_Screenshot2
        { get { return repo.CertificateErrorNavigationBlocked.MainTitleInfo.GetScreenshot2(new Rectangle(0, 0, 700, 40)); } }

        Imaging.FindOptions MainTitle_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Task11_Screenshot1
        { get { return repo.CertificateErrorNavigationBlocked.Task11Info.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions Task11_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Task11_Screenshot1_2
        { get { return repo.CertificateErrorNavigationBlocked.Task11Info.GetScreenshot1(new Rectangle(0, 0, 825, 27)); } }

        Imaging.FindOptions Task11_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Task11_Screenshot2
        { get { return repo.CertificateErrorNavigationBlocked.Task11Info.GetScreenshot2(new Rectangle(0, 0, 660, 21)); } }

        Imaging.FindOptions Task11_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
