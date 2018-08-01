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
    ///The Accept_Range_SrcIP recording.
    /// </summary>
    [TestModule("5046d5aa-6cd3-42dd-b6c9-8f165adb3023", ModuleType.Recording, 1)]
    public partial class Accept_Range_SrcIP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Accept_Range_SrcIP instance = new Accept_Range_SrcIP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Accept_Range_SrcIP()
        {
            IPv4_Src_IP_Start = "";
            IPv4_Src_IP_End = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Accept_Range_SrcIP Instance
        {
            get { return instance; }
        }

#region Variables

        string _IPv4_Src_IP_Start;

        /// <summary>
        /// Gets or sets the value of variable IPv4_Src_IP_Start.
        /// </summary>
        [TestVariable("2b45dd38-2830-4867-a7f6-3e3154978ca2")]
        public string IPv4_Src_IP_Start
        {
            get { return _IPv4_Src_IP_Start; }
            set { _IPv4_Src_IP_Start = value; }
        }

        string _IPv4_Src_IP_End;

        /// <summary>
        /// Gets or sets the value of variable IPv4_Src_IP_End.
        /// </summary>
        [TestVariable("0040b683-3820-400f-b4db-9448a6ec5875")]
        public string IPv4_Src_IP_End
        {
            get { return _IPv4_Src_IP_End; }
            set { _IPv4_Src_IP_End = value; }
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

            repo.WebDocument19216801.IPv4SrcRangeAddressStart3.Click();
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPv4SrcRangeAddressStart3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPv4SrcRangeAddressStart3);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.IPv4SrcRangeAddressStart3.PressKeys(IPv4_Src_IP_Start);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.IPv4SrcRangeAddressEnd3.Click();
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPv4SrcRangeAddressEnd3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.IPv4SrcRangeAddressEnd3);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.IPv4SrcRangeAddressEnd3.PressKeys(IPv4_Src_IP_End);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}