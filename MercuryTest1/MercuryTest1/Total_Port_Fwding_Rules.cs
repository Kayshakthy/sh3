/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 23/05/2016
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
    /// <summary>
    /// Description of Total_Port_Fwding_Rules.
    /// </summary>
    [TestModule("F77C0608-5337-421D-BE7D-6CEC18412FAC", ModuleType.UserCode, 1)]
    public class Total_Port_Fwding_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Total_Port_Fwding_Rules()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            this.port_fwd_rules_count();
     //       this.pfRules_Count();
        }
        public void port_fwd_rules_count(){
        	Delay.Seconds(15); 
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            
//            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); 
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            int TotalRows = rows1.Count;
           // Report.Info(" Total Rules",TotalRows.ToString());   
            int j=1;
            bool isRuleExist=true;
            if(TotalRows > 0){
            	IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td");
            	foreach(TdTag col in cols)  
		    	{
            		//if(j == 1 && col.InnerText.StartsWith("No forwarding rule!")){	// R3.6
            		if(j == 1 && col.InnerText.StartsWith("No forwarding rule applied!")){
						isRuleExist=false;
						//return;
						Report.Info(" There are no active port forwarding rules ");  
						break;
            		}else{
            			isRuleExist=true;
            			break;
            		}
            		
            	}
            	if(isRuleExist){
            		Report.Info(" Total Rules",TotalRows.ToString());
            	}
            }
        	
        }
        public int pfRules_Count(){
        	Delay.Seconds(15);
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            
//            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); 
            TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']");
            IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            int TotalRows = rows1.Count;
           // Report.Info(" Total Rules",TotalRows.ToString());   
            int j=1;
            bool isRuleExist=true;
            if(TotalRows > 0){
            	IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td");
            	foreach(TdTag col in cols)  
		    	{
            		//if(j == 1 && col.InnerText.StartsWith("No forwarding rule!")){	// R3.6
            		if(j == 1 && col.InnerText.StartsWith("No forwarding rule applied!")){
						isRuleExist=false;
						//return;
						Report.Info(" There are no active port forwarding rules ");  
						TotalRows = -1;
						break;
            		}else{
            			isRuleExist=true;
            			break;
            		}
            		
            	}
            	if(isRuleExist){
            		Report.Info(" Total Rules",TotalRows.ToString());
            	}
            }
return TotalRows;             
        	
        }
    }
}
