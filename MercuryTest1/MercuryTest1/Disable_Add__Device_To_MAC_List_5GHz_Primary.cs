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
    ///The Disable_Add__Device_To_MAC_List_5GHz_Primary recording.
    /// </summary>
    [TestModule("27c59c30-9a64-486a-957c-35cb1114dec3", ModuleType.Recording, 1)]
    public partial class Disable_Add__Device_To_MAC_List_5GHz_Primary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Disable_Add__Device_To_MAC_List_5GHz_Primary instance = new Disable_Add__Device_To_MAC_List_5GHz_Primary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Disable_Add__Device_To_MAC_List_5GHz_Primary()
        {
            Mac0 = "";
            Mac1 = "";
            Mac2 = "";
            Mac3 = "";
            Mac4 = "";
            Mac5 = "";
            Access_Mode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Disable_Add__Device_To_MAC_List_5GHz_Primary Instance
        {
            get { return instance; }
        }

#region Variables

        string _Mac0;

        /// <summary>
        /// Gets or sets the value of variable Mac0.
        /// </summary>
        [TestVariable("4245b547-71ca-4616-851c-dfe3a05394d9")]
        public string Mac0
        {
            get { return _Mac0; }
            set { _Mac0 = value; }
        }

        string _Mac1;

        /// <summary>
        /// Gets or sets the value of variable Mac1.
        /// </summary>
        [TestVariable("2d75b952-4170-4dd4-b76e-285db3ca2a13")]
        public string Mac1
        {
            get { return _Mac1; }
            set { _Mac1 = value; }
        }

        string _Mac2;

        /// <summary>
        /// Gets or sets the value of variable Mac2.
        /// </summary>
        [TestVariable("a3f21601-8c88-4db8-886b-0adbeee27c6a")]
        public string Mac2
        {
            get { return _Mac2; }
            set { _Mac2 = value; }
        }

        string _Mac3;

        /// <summary>
        /// Gets or sets the value of variable Mac3.
        /// </summary>
        [TestVariable("2b4c98a8-276d-4da2-9b54-e773f9d5b339")]
        public string Mac3
        {
            get { return _Mac3; }
            set { _Mac3 = value; }
        }

        string _Mac4;

        /// <summary>
        /// Gets or sets the value of variable Mac4.
        /// </summary>
        [TestVariable("0892dce4-2c40-4280-b529-c6dbd7172e9d")]
        public string Mac4
        {
            get { return _Mac4; }
            set { _Mac4 = value; }
        }

        string _Mac5;

        /// <summary>
        /// Gets or sets the value of variable Mac5.
        /// </summary>
        [TestVariable("8d012c61-1511-4594-aa98-c0d0c165a69f")]
        public string Mac5
        {
            get { return _Mac5; }
            set { _Mac5 = value; }
        }

        string _Access_Mode;

        /// <summary>
        /// Gets or sets the value of variable Access_Mode.
        /// </summary>
        [TestVariable("b63b3ca3-f147-423b-945c-f7d9ca74bb7f")]
        public string Access_Mode
        {
            get { return _Access_Mode; }
            set { _Access_Mode = value; }
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

            try {
                Choose_Attached_Devices_To_Disable_Add_5GHz_Primary(Mac0, Mac1, Mac2, Mac3, Mac4, Mac5, Access_Mode);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
