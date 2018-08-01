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
    ///The Form_Device_To_MAC_List_2_4GHz_Primary recording.
    /// </summary>
    [TestModule("f9ba4dd1-123b-4053-91f4-39d689f0b5df", ModuleType.Recording, 1)]
    public partial class Form_Device_To_MAC_List_2_4GHz_Primary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Form_Device_To_MAC_List_2_4GHz_Primary instance = new Form_Device_To_MAC_List_2_4GHz_Primary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_Device_To_MAC_List_2_4GHz_Primary()
        {
            Device_Name = "Test1";
            MACAddress0 = "23";
            MACAddress1 = "02";
            MACAddress2 = "91";
            MACAddress3 = "22";
            MACAddress4 = "23";
            MACAddress5 = "21";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_Device_To_MAC_List_2_4GHz_Primary Instance
        {
            get { return instance; }
        }

#region Variables

        string _Device_Name;

        /// <summary>
        /// Gets or sets the value of variable Device_Name.
        /// </summary>
        [TestVariable("47670cb4-8f62-40e8-a5e7-5e30bb34b8d1")]
        public string Device_Name
        {
            get { return _Device_Name; }
            set { _Device_Name = value; }
        }

        string _MACAddress0;

        /// <summary>
        /// Gets or sets the value of variable MACAddress0.
        /// </summary>
        [TestVariable("55f95edf-107c-43d9-815e-a04332102b3e")]
        public string MACAddress0
        {
            get { return _MACAddress0; }
            set { _MACAddress0 = value; }
        }

        string _MACAddress1;

        /// <summary>
        /// Gets or sets the value of variable MACAddress1.
        /// </summary>
        [TestVariable("232074e0-8454-4b8a-bdf4-816c37b16da0")]
        public string MACAddress1
        {
            get { return _MACAddress1; }
            set { _MACAddress1 = value; }
        }

        string _MACAddress2;

        /// <summary>
        /// Gets or sets the value of variable MACAddress2.
        /// </summary>
        [TestVariable("fd9d0320-acbc-4c63-af3d-4050ed795823")]
        public string MACAddress2
        {
            get { return _MACAddress2; }
            set { _MACAddress2 = value; }
        }

        string _MACAddress3;

        /// <summary>
        /// Gets or sets the value of variable MACAddress3.
        /// </summary>
        [TestVariable("a51278c2-5a32-46f4-b00e-b0dad64e6d43")]
        public string MACAddress3
        {
            get { return _MACAddress3; }
            set { _MACAddress3 = value; }
        }

        string _MACAddress4;

        /// <summary>
        /// Gets or sets the value of variable MACAddress4.
        /// </summary>
        [TestVariable("8482f832-1c57-4d52-9f5f-6f23fe2c6287")]
        public string MACAddress4
        {
            get { return _MACAddress4; }
            set { _MACAddress4 = value; }
        }

        string _MACAddress5;

        /// <summary>
        /// Gets or sets the value of variable MACAddress5.
        /// </summary>
        [TestVariable("a0e940b4-5d8e-4199-bb3e-7594b257dd04")]
        public string MACAddress5
        {
            get { return _MACAddress5; }
            set { _MACAddress5 = value; }
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

            repo.WebDocument19216801.DeviceName.Click();
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.DeviceName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.DeviceName);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.DeviceName.PressKeys(Device_Name);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress0.DoubleClick("9;7");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress0);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress0);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress0.PressKeys(MACAddress0);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress1.Click("17;6");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress1);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress1.PressKeys(MACAddress1);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress2.DoubleClick("13;8");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress2);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress2);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress2.PressKeys(MACAddress2);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress3.DoubleClick("8;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress3.PressKeys(MACAddress3);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress4.Click("13;13");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress4);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress4);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress4.PressKeys(MACAddress4);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress5.DoubleClick("9;12");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress5);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MACAddress5);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //repo.WebDocument19216801.MACAddress5.PressKeys("{Delete}");
            //Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MACAddress5.PressKeys(MACAddress5);
            Delay.Milliseconds(0);
            
            Print_the_input_DeviceName_MAC(Device_Name, MACAddress0, MACAddress1, MACAddress2, MACAddress3, MACAddress4, MACAddress5);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
