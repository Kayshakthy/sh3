﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace ArrisTest
{
    public partial class ApplyChanges_To_WirelessSignal
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_ErrCloseSSID()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WebDocument19216801.ErrCloseSSID'.", repo.WebDocument19216801.ErrCloseSSIDInfo);
            Validate.NotExists(repo.WebDocument19216801.ErrCloseSSIDInfo);
//            Report.Success("2.5GHz SSID Name Renamed Successffully !!!");
            Report.Success("2.5GHz SSID Changes Appplied Successffully !!!");

        }

    }
}