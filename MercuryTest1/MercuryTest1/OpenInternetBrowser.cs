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
    ///The OpenInternetBrowser recording.
    /// </summary>
    [TestModule("556c64c3-aa70-4da4-9908-860a198770b7", ModuleType.Recording, 1)]
    public partial class OpenInternetBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static OpenInternetBrowser instance = new OpenInternetBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenInternetBrowser()
        {
            BoxUrl = "";
            ModemUrl = "";
            BrowserName = "IE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenInternetBrowser Instance
        {
            get { return instance; }
        }

#region Variables

        string _BoxUrl;

        /// <summary>
        /// Gets or sets the value of variable BoxUrl.
        /// </summary>
        [TestVariable("48b26b02-6744-4ba8-9c5c-c3966cba80be")]
        public string BoxUrl
        {
            get { return _BoxUrl; }
            set { _BoxUrl = value; }
        }

        string _ModemUrl;

        /// <summary>
        /// Gets or sets the value of variable ModemUrl.
        /// </summary>
        [TestVariable("9c10d9d3-4e37-4c4f-8579-523c975511d0")]
        public string ModemUrl
        {
            get { return _ModemUrl; }
            set { _ModemUrl = value; }
        }

        string _BrowserName;

        /// <summary>
        /// Gets or sets the value of variable BrowserName.
        /// </summary>
        [TestVariable("7a2221dc-a603-4747-a5b4-10239b22c3a9")]
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

            // Arris Automation
            try {
                Host.Local.OpenBrowser(BoxUrl, BrowserName, "", false, true, false, false, false);
                Delay.Milliseconds(0);
            } catch(Exception) {  }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}