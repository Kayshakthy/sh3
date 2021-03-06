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
    ///The Choose_Channel_Manual_2GHz recording.
    /// </summary>
    [TestModule("72f1e657-5191-4d07-992c-fa1aabf97444", ModuleType.Recording, 1)]
    public partial class Choose_Channel_Manual_2GHz : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Channel_Manual_2GHz instance = new Choose_Channel_Manual_2GHz();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Channel_Manual_2GHz()
        {
            Manual_Channel_2GHz = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Channel_Manual_2GHz Instance
        {
            get { return instance; }
        }

#region Variables

        string _Manual_Channel_2GHz;

        /// <summary>
        /// Gets or sets the value of variable Manual_Channel_2GHz.
        /// </summary>
        [TestVariable("280668bc-4ba5-4520-8879-f050fafc7d20")]
        public string Manual_Channel_2GHz
        {
            get { return _Manual_Channel_2GHz; }
            set { _Manual_Channel_2GHz = value; }
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

            repo.WebDocument19216801.FmRbtnChannelManual.Click("12;18");
            Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.FmSelChannel24.SomeSpanTag11.Click("156;21");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.FmSelChannel24.Channel2.Click("66;17");
            //Delay.Milliseconds(200);
            
            Choose_Manual_Channel_2GHz(Manual_Channel_2GHz);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
