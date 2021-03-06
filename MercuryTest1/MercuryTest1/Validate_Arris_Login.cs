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
    ///The Validate_Arris_Login recording.
    /// </summary>
    [TestModule("a3fafa3f-dc84-415d-b775-363566472370", ModuleType.Recording, 1)]
    public partial class Validate_Arris_Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_Arris_Login instance = new Validate_Arris_Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Arris_Login()
        {
            LoginPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Arris_Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _LoginPassword;

        /// <summary>
        /// Gets or sets the value of variable LoginPassword.
        /// </summary>
        [TestVariable("cc439f68-4a00-462d-90f7-5b22d040b2e2")]
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
            
            try {
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=116,Height=83}) on item 'WebDocument19216801.LogoContainer'.", repo.WebDocument19216801.LogoContainerInfo, new RecordItemIndex(4));
                //Validate.ContainsImage(repo.WebDocument19216801.LogoContainerInfo, LogoContainer_Screenshot1, LogoContainer_Screenshot1_Options, Validate.DefaultMessage, false);
                //Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
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
