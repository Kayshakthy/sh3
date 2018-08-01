/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 02/08/2016
 * Time: 16:07
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
	/// Description of Total_MAC_Filtering_Lists.
	/// </summary>
	[TestModule("4559371F-B14F-4B7B-9342-5126503A402C", ModuleType.UserCode, 1)]
	public class Total_MAC_Filtering_Lists : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Total_MAC_Filtering_Lists()
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
			this.Count_MAC_Filtering_Lists();
		}
		void Count_MAC_Filtering_Lists()
		{
			//count total number of port triggering rules
//			Report.Info("---- Count_MAC_Filtering_Lists -----");
			int TotalRows =0;
			WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
			webDocument1.WaitForDocumentLoaded();
			Delay.Seconds(40);
			//TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macAddressFilterTable']");
			TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'macFilterTable']");
			IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
			TotalRows = rows1.Count;
			//            if it is just 1 row  need to check if it is an invalid filter
//			Report.Info("---- Total rows : " + TotalRows);
			if(TotalRows == 1){
				IList<TdTag> cols = myTable1.Find<TdTag>("./tbody//td");
				foreach(TdTag MacCol in cols) {
					//Report.Info("Column",j.ToString());
					Report.Info(MacCol.InnerText);
					if(MacCol.InnerText.ToString().StartsWith("No MAC filtering rule")){	//No MAC filtering rule! --R3.8
//						No MAC filtering rule!
						//Report.Info("No MAC filtering rule exists !!!");
//						Report.Failure("Wireless_Filter ","No MAC filtering rule!!");
						Report.Success("Wireless_Filter ","No MAC filtering rule!!");
						return;
					}else{
						break;
					}
				}
			}
			Report.Info("MAC_Filtering",TotalRows.ToString());
			
		}
	}
}
