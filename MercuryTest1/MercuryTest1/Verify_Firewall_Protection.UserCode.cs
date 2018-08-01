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
    public partial class Verify_Firewall_Protection
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Verify_Firewall_Protection_Level()
        {
        	bool FirewallProtect=false,BlockFragment=false,PortScan=false,PFloodDetect=false;
        	Delay.Seconds(5);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
        	
			Ranorex.InputTag IPv4FirewallProtectTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableFirewall']/input[#'EnableFirewall']";
			Ranorex.InputTag BlockFragmentTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableBlockFramentedPkts']/input[#'EnableBlockFramentedPkts']";
			Ranorex.InputTag PortScanTag = "/dom[@domain='192.168.0.1']//div[#'tr_EnablePortScanDetection']/input[#'EnablePortScanDetection']";
			Ranorex.InputTag IPFloodDetectTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableIPFloodDetection']/input[#'EnableIPFloodDetection']";
			
			//Report.Info("FirewallProtectTag(Default) : "+IPv4FirewallProtectTag.Checked.ToString());
			if(IPv4FirewallProtectTag.Checked.ToString() == "True"){
				FirewallProtect = true;
			}else{
				FirewallProtect =false;
			}
			//Report.Info("BlockFragmentTag(Default) : "+BlockFragmentTag.Checked.ToString());
			if(BlockFragmentTag.Checked.ToString() =="True"){
				BlockFragment = true;
			}else{
				BlockFragment = false;
			}
			//Report.Info("PortScanTag(Default) : " + PortScanTag.Checked.ToString());
			if(PortScanTag.Checked.ToString() =="True"){
				PortScan = true;
			}else{
				PortScan = false;
			}
			//Report.Info("IPFloodDetectTag(Default) : " + IPFloodDetectTag.Checked.ToString());
			if(IPFloodDetectTag.Checked.ToString() =="True"){
				PFloodDetect = true;
			}else{
				PFloodDetect = false;
			}
			
			if(FirewallProtect  && !BlockFragment && PortScan && PFloodDetect){
				Report.Success( " All default settings are valid  and it is as expected ");
			}else{
				Report.Failure("Some of Firewall_Page_Default_Settings are wrong ");
			}
			Ranorex.DivTag FirewallTag = "/dom[@domain='192.168.0.1']//div[#'IPv4Firewall']";
			Report.Screenshot("Firewall_Page_Default_Settings",FirewallTag.Element);
			
        	//Validate.ContainsImage(repo.WebDocument19216801.FmChbxEnableFirewallInfo, FmChbxEnableFirewall_Screenshot1, FmChbxEnableFirewall_Screenshot1_Options);
            Delay.Milliseconds(2);        	
        }

    }
}