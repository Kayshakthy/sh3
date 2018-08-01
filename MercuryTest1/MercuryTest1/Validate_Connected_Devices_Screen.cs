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
    ///The Validate_Connected_Devices_Screen recording.
    /// </summary>
    [TestModule("80295feb-4122-4585-9919-01060546a64f", ModuleType.Recording, 1)]
    public partial class Validate_Connected_Devices_Screen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_Connected_Devices_Screen instance = new Validate_Connected_Devices_Screen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Connected_Devices_Screen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Connected_Devices_Screen Instance
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

            repo.WebDocument19216801.ConnectedDevices.Click("85;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 40s.", new RecordItemIndex(1));
            Delay.Duration(40000, false);
            
            //Validate.Attribute(repo.WebDocument19216801.LabelConnectedDevicesInfo, "Id", "label_ConnectedDevices");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.LabelConnectedDevicesInfo, "InnerText", "Connected devices");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.LabelConnectedDevicesInfo, LabelConnectedDevices_Screenshot2, LabelConnectedDevices_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='All devices connected to your Hub 3.0 are listed below: ') on item 'WebDocument19216801.AllDevicesConnectedToYourHub30A'.", repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, "InnerText", "All devices connected to your Hub 3.0 are listed below: ");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, "InnerText", "All devices connected to your  Hub 3.0 are listed below:");
            //Delay.Milliseconds(100);
            
            //Validate.CompareImage(repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, AllDevicesConnectedToYourHub30A_Screenshot1, AllDevicesConnectedToYourHub30A_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='All devices connected to your Hub 3.0 are listed below: ') on item 'WebDocument19216801.AllDevicesConnectedToYourHub30A'.", repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo, "InnerText", "All devices connected to your Hub 3.0 are listed below: ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='div_tooltip') on item 'WebDocument19216801.ConnectedDevicesImageTt'.", repo.WebDocument19216801.ConnectedDevicesImageTtInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.ConnectedDevicesImageTtInfo, "Class", "div_tooltip");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='ConnectedDevices_image_tt') on item 'WebDocument19216801.ConnectedDevicesImageTt'.", repo.WebDocument19216801.ConnectedDevicesImageTtInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.ConnectedDevicesImageTtInfo, "Id", "ConnectedDevices_image_tt");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Id", "IP_Add");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "TagValue", "Refresh");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.IPAdd1Info, "Value", "Refresh");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.IPAdd1Info, IPAdd1_Screenshot5, IPAdd1_Screenshot5_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.DeviceName1Info, "InnerText", "Device name");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.AttachedDevicesTable1.DeviceName1Info, DeviceName1_Screenshot1, DeviceName1_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.MACAddressInfo, "InnerText", "MAC address");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.AttachedDevicesTable1.MACAddressInfo, MACAddress_Screenshot1, MACAddress_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.IPAddressInfo, "InnerText", "IP Address");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='IP address') on item 'WebDocument19216801.AttachedDevicesTable1.IPAddress1'.", repo.WebDocument19216801.AttachedDevicesTable1.IPAddress1Info, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.IPAddress1Info, "InnerText", "IP address");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.AttachedDevicesTable1.IPAddressInfo, IPAddress_Screenshot1, IPAddress_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.SpeedMbpsInfo, "InnerText", "Speed (Mbps)");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.AttachedDevicesTable1.SpeedMbpsInfo, SpeedMbps_Screenshot1, SpeedMbps_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate_ConnectedTo();
            Delay.Milliseconds(0);
            
            //Validate.ContainsImage(repo.WebDocument19216801.AttachedDevicesTable1.ConnectedToInfo, ConnectedTo_Screenshot1_2, ConnectedTo_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.AttachedDevicesTable1.ConnectedToInfo, "InnerText", "Connected to");
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(27));
            
            Validate_Connection_Device_Table();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage LabelConnectedDevices_Screenshot2
        { get { return repo.WebDocument19216801.LabelConnectedDevicesInfo.GetScreenshot2(new Rectangle(0, 0, 875, 78)); } }

        Imaging.FindOptions LabelConnectedDevices_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage AllDevicesConnectedToYourHub30A_Screenshot1
        { get { return repo.WebDocument19216801.AllDevicesConnectedToYourHub30AInfo.GetScreenshot1(new Rectangle(0, 0, 398, 20)); } }

        Imaging.FindOptions AllDevicesConnectedToYourHub30A_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage IPAdd1_Screenshot5
        { get { return repo.WebDocument19216801.IPAdd1Info.GetScreenshot5(new Rectangle(0, 0, 122, 57)); } }

        Imaging.FindOptions IPAdd1_Screenshot5_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage DeviceName1_Screenshot1
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.DeviceName1Info.GetScreenshot1(new Rectangle(0, 0, 186, 83)); } }

        Imaging.FindOptions DeviceName1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage MACAddress_Screenshot1
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.MACAddressInfo.GetScreenshot1(new Rectangle(0, 0, 192, 83)); } }

        Imaging.FindOptions MACAddress_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage IPAddress_Screenshot1
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.IPAddressInfo.GetScreenshot1(new Rectangle(0, 0, 143, 83)); } }

        Imaging.FindOptions IPAddress_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SpeedMbps_Screenshot1
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.SpeedMbpsInfo.GetScreenshot1(new Rectangle(0, 0, 142, 83)); } }

        Imaging.FindOptions SpeedMbps_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ConnectedTo_Screenshot1
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.ConnectedToInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions ConnectedTo_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ConnectedTo_Screenshot1_2
        { get { return repo.WebDocument19216801.AttachedDevicesTable1.ConnectedToInfo.GetScreenshot1(new Rectangle(0, 0, 208, 83)); } }

        Imaging.FindOptions ConnectedTo_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
