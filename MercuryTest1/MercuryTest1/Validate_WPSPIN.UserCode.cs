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
    public partial class Validate_WPSPIN
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_ErrClosePIN()
        {
//            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WebDocument19216801.ErrClosePIN'.", repo.WebDocument19216801.ErrClosePINInfo);
//            Validate.NotExists(repo.WebDocument19216801.ErrClosePINInfo);
            bool rst = Validate.NotExists(repo.WebDocument19216801.ErrClosePINInfo,"{0}",false);
            if(rst){
            	Report.Success("Validation Success");
            	Report.Screenshot();
            }else{
            	Report.Failure("Validation Failed");
//            	Report.Info(repo.WebDocument19216801.ErrClosePIN.InnerText);
            	Report.Screenshot(repo.WebDocument19216801.ErrClosePIN.Element,true);
            	Report.Screenshot();
            }
            
        }

    }
}