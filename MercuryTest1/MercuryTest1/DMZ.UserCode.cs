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
    public partial class DMZ
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_FmRbtnDisableDMZ()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=26,Height=26}) on item 'WebDocument19216801.FmRbtnDisableDMZ'.", repo.WebDocument19216801.FmRbtnDisableDMZInfo);
          //  Validate.ContainsImage(repo.WebDocument19216801.FmRbtnDisableDMZInfo, FmRbtnDisableDMZ_Screenshot1, FmRbtnDisableDMZ_Screenshot1_Options);
        }

      
        public void Validate_Button11()
        {
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=1366,Height=225}) on item 'WebDocument19216801.Button1'.", repo.WebDocument19216801.Button1Info);
            //Validate.ContainsImage(repo.WebDocument19216801.Button1Info, Button1_Screenshot2, Button1_Screenshot2_Options);
            Report.Log(ReportLevel.Info, "Validation", "vlidating Button1 Info", repo.WebDocument19216801.Button1Info);
         //   Validate.Attribute(repo.WebDocument19216801.Button1Info,"InnerTest","Apply chnages");
        }

    }
}