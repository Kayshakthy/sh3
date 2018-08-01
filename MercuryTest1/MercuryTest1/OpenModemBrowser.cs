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
    ///The OpenModemBrowser recording.
    /// </summary>
    [TestModule("31b0e038-3e6b-4638-87b6-966adc3074a3", ModuleType.Recording, 1)]
    public partial class OpenModemBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static OpenModemBrowser instance = new OpenModemBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenModemBrowser()
        {
            ModemUrl = "";
            BrowserName = "IE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenModemBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        string _ModemUrl;

        /// <summary>
        /// Gets or sets the value of variable ModemUrl.
        /// </summary>
        [TestVariable("13267387-5aa7-405d-acd7-9f45977e57a5")]
        public string ModemUrl
        {
            get { return _ModemUrl; }
            set { _ModemUrl = value; }
        }

        string _BrowserName;

        /// <summary>
        /// Gets or sets the value of variable BrowserName.
        /// </summary>
        [TestVariable("2b0a687a-ed39-47ed-83df-e878416e33e0")]
        public string BrowserName
        {
            get { return _BrowserName; }
            set { _BrowserName = value; }
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

            Host.Local.OpenBrowser(ModemUrl, BrowserName, "", false, true, false, false, false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
