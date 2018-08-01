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
    ///The Validation_WiFi_Guest_Network_Name_SSID recording.
    /// </summary>
    [TestModule("c94c09c6-af84-4988-bc8a-a0130b268c75", ModuleType.Recording, 1)]
    public partial class Validation_WiFi_Guest_Network_Name_SSID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validation_WiFi_Guest_Network_Name_SSID instance = new Validation_WiFi_Guest_Network_Name_SSID();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_WiFi_Guest_Network_Name_SSID()
        {
            Guest_Network_SSID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_WiFi_Guest_Network_Name_SSID Instance
        {
            get { return instance; }
        }

#region Variables

        string _Guest_Network_SSID;

        /// <summary>
        /// Gets or sets the value of variable Guest_Network_SSID.
        /// </summary>
        [TestVariable("5e628a45-5cd5-4b27-9812-f4df0ed18b98")]
        public string Guest_Network_SSID
        {
            get { return _Guest_Network_SSID; }
            set { _Guest_Network_SSID = value; }
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

            repo.WebDocument19216801.NetworkSSID.Click("62;18");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.NetworkSSID);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.NetworkSSID);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.NetworkSSID.PressKeys(Guest_Network_SSID);
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Button7.Click("99;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='WiFi Network Name (SSID) is over max length 32.') on item 'WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLen'.", repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, "InnerText", "WiFi Network Name (SSID) is over max length 32.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
