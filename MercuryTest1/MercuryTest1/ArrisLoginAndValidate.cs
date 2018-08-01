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
    ///The ArrisLoginAndValidate recording.
    /// </summary>
    [TestModule("02ffaccb-8e66-48dd-b05e-308aecf3dd4f", ModuleType.Recording, 1)]
    public partial class ArrisLoginAndValidate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static ArrisLoginAndValidate instance = new ArrisLoginAndValidate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ArrisLoginAndValidate()
        {
            LoginPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ArrisLoginAndValidate Instance
        {
            get { return instance; }
        }

#region Variables

        string _LoginPassword;

        /// <summary>
        /// Gets or sets the value of variable LoginPassword.
        /// </summary>
        [TestVariable("1d3fee31-e029-42db-bfe6-e005998c8695")]
        public string LoginPassword
        {
            get { return _LoginPassword; }
            set { _LoginPassword = value; }
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

            repo.WebDocument19216801.Password.Click("80;15");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Password.PressKeys(LoginPassword);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Button.Click("61;34");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocument19216801.LogOutInfo, "InnerText", "Log out");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=116,Height=83}) on item 'WebDocument19216801.LogoContainer'.", repo.WebDocument19216801.LogoContainerInfo, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.LogoContainerInfo, LogoContainer_Screenshot1, LogoContainer_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage LogoContainer_Screenshot1
        { get { return repo.WebDocument19216801.LogoContainerInfo.GetScreenshot1(new Rectangle(0, 0, 116, 83)); } }

        Imaging.FindOptions LogoContainer_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
