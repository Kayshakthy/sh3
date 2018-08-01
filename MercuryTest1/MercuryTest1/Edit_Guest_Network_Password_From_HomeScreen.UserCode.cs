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
    public partial class Edit_Guest_Network_Password_From_HomeScreen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_PasstextWifi(string argument1)
        {
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Good");
            string rstStr = "The Password : "+ argument1 + " : is : " + repo.WebDocument19216801.PasstextWifi.InnerText ;
          	Report.Success("Validation",rstStr);
			Report.Screenshot("GuestNetworkPassword",repo.WebDocument19216801.PasstextWifi,true);
            

        }

    }
}