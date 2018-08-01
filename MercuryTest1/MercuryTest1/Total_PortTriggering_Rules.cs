/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 24/05/2016
 * Time: 10:38
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
	/// Description of Total_PortTriggering_Rules.
	/// </summary>
	[TestModule("B570E2D2-30BC-4A48-AE27-CE47FCC423FF", ModuleType.UserCode, 1)]
	public class Total_PortTriggering_Rules : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Total_PortTriggering_Rules()
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
			Report.Info("Inside Run() of  Total_PortTriggering_Rules before calling Count_PortTriggering_Rules()  ");
			this.Count_PortTriggering_Rules();
			
		}
		void Count_PortTriggering_Rules()
		{
			//count total number of port triggering rules
			int TotalRows =0;
			Delay.Seconds(40);
			WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
			webDocument1.WaitForDocumentLoaded();
//			Delay.Seconds(40);
			TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");

			IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
			TotalRows = rows1.Count;
			
//			Report.Info(" Total PortTrigger Rules",TotalRows.ToString());
			
			if(TotalRows == 1){
				//            	int rowNum = 1;
				foreach (var row in rows1)
				{
//			        Report.Info("Row: " + rowNum);
//			        Report.Info(row.GetInnerHtml().ToString());
					IList<TdTag> cols = row.Find<TdTag>("./td");
//			        int colNum = 1;
					int colCnt = cols.Count;
//			        Report.Info(" No of cols : " + colCnt.ToString());
					if(colCnt==1){	//if there is only one column - //No filtering rule applied!
						foreach(TdTag MacCol in cols){
//			        		Report.Info("MacCol: " + colNum);
							String colVal = MacCol.InnerText.ToString();
//			        	Report.Info("MacCol Info: "+MacCol.InnerText);
//			        	Report.Info("MacCol Info: " + colVal);
							if(colVal.StartsWith("No filtering rule")){
								Report.Info("There are No filtering rule !");
								//Report.LogHtml(ReportLevel.Info, "Link", "<a href='http://www.ranorex.com/'>Visit www.ranorex.com</a>");
								Report.LogHtml(ReportLevel.Info, "Link", "<a href='http://www.virginmedia.com/'>Visit www.virginmedia.com</a>");
								//<b>and this is bold text</b>
							}
						}
					}else{
						String Total_Rules = " There is only "+TotalRows.ToString() + "	rule exist";
						Ranorex.Report.Success(Total_Rules);
					}
				}
				
			}else{
				String Total_Rules = "Totally, There are "+TotalRows.ToString() + "	Rules";
				//Report.Info(" Ipv4_PortFiltering_Rules",TotalRows.ToString());
				// Report.Info(" IP_PortFilter",Total_Rules);
				Ranorex.Report.Success(Total_Rules);
				//Ranorex.Report.Failure("Failure Message");
			}
			
		}
	}
}
