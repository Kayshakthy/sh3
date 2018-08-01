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
    public partial class Backup_config_settings
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_Backup_Config_Settings()
        {
        	Report.Success(" Config Settings is Saved Successfully ...!");
        }

        public void Mouse_Click_Save()
        {
        	repo.Http19216801DeviceConnectionmidE.Notification.Save.Click("37;15");//added on 19th Dec 2017
            repo.Http19216801DeviceConnectionmidE.Notification.Save.Click("23;25");
            repo.Http19216801DeviceConnectionmidE.Notification.Save.DoubleClick();	//added on 31st May 2017
        }

    }
}