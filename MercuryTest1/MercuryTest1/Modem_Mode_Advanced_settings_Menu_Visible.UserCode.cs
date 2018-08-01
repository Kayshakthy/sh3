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
	public partial class Modem_Mode_Advanced_settings_Menu_Visible
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void Is_Advanced_settings_Tools_Menu_Visible()
		{
			//Advanced_settings_Tools_Menu should be Visible
			
			Delay.Seconds(5);
			WebDocument webDocument = "/dom[@domain='192.168.100.1']";
			webDocument.WaitForDocumentLoaded();
			
			//TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'ConnectionTable']");
			Ranorex.UlTag menuUITag = webDocument.FindSingle("/dom[@domain='192.168.100.1']//ul[#'menu']");
			IList<LiTag> menuCounts = menuUITag.FindChildren<LiTag>();	//counting menu items
			int menuItemsCount = menuCounts.Count;
			Report.Info("menuItemsCount" + menuItemsCount.ToString());
			if(menuItemsCount>4){
				Report.Failure(" Other than Home,Modem Mode,Advanced settings and Admin menu items are present in the screen");
				return ;
			}
//	     	Boolean isAdminTrue =true;
//	     	Boolean isRemoteAccessTrue = false;
			
			Boolean isAdvancedsettingsTrue =true;
			Boolean isAdvancedsettingsToolsTrue =true;
			Boolean isNetworkStatusTrue=true;
//	     	Ranorex.ATag adminTag = null;
			Ranorex.ATag AdvancedsettingsTag = null;
			Ranorex.ATag AdvancedsettingsToolsTag = null;
			
			foreach(LiTag col in menuCounts)
			{
//	        	Report.Info(col.InnerText);
				
				IList<ATag> aVals = col.Find<ATag>("./a");
				
				foreach(ATag aVal in aVals){
					string menuItem = aVal.InnerText.ToString();
					Report.Info(  "	menuItem Name: 	" + menuItem + "   : is present");
					//if((menuItem.Trim().StartsWith("Home")) || (menuItem.Trim().StartsWith("Modem Mode" ))|| (menuItem.Trim().StartsWith("Admin") )){
					if(menuItem.Trim().StartsWith("Advanced settings") ){
//	        			isAdminTrue = true;
						//get path of Admin element
						//find sub menu's under admin
//	        			/dom[@domain='192.168.100.1']//li[#'Admin']
//	        			/dom[@domain='192.168.100.1']//li[#'Admin']/ul
						
						//Ranorex.LiTag testTag = aVal;
						//Report.Info(LiTag.GetPath().ToString());
						isAdvancedsettingsTrue =true;
						
						String newPath = "";
						newPath = aVal.GetPath().ToString() ; //+ "/input[#'macFilterTable-Delete-"+delCheck+"']";
//			        			Report.Info("newPath : " + newPath);
						//Ranorex.InputTag MACFilterTableDeleteTag = newPath;
						//Ranorex.ATag adminTag = newPath;
						AdvancedsettingsTag = newPath;
						AdvancedsettingsTag.Click();
						Delay.Seconds(5);
						IList<LiTag> advancedsettingsMenuCounts = col.FindDescendants<LiTag>();	//counting menu items
						int advancedsettingsMenuCount = advancedsettingsMenuCounts.Count;
						Report.Info("advancedsettingsMenuCount :" + advancedsettingsMenuCount.ToString());
						foreach(LiTag col1 in advancedsettingsMenuCounts)
						{
							IList<ATag> aVals1 = col1.Find<ATag>("./a");
							foreach(ATag aVal1 in aVals1){
								string menuItem1 = aVal1.InnerText.ToString();
								Report.Info("menuItem name :" + menuItem1);
								if(menuItem1.StartsWith("Tools")){
									isAdvancedsettingsToolsTrue = true;
									isAdvancedsettingsTrue = true;
									Report.Info(  "	menuItem : 	" + menuItem1 + " : is  present under Advancedsettings menu");
									
									
									
									// check if network status menu item is present under tools //
									IList<LiTag> advancedsettingsToolsMenuCounts = col1.FindDescendants<LiTag>();	//counting menu items
									int advancedsettingsToolsMenuCount = advancedsettingsToolsMenuCounts.Count;
									Report.Info("advancedsettingsToolsMenuCount :" + advancedsettingsToolsMenuCount.ToString());
									//check the sub menu items under tools
									foreach(LiTag col2 in advancedsettingsToolsMenuCounts){
										IList<ATag> aVals2 = col2.Find<ATag>("./a");
										foreach(ATag aVal2 in aVals2){
											string menuItem2 = aVal2.InnerText.ToString();
											Report.Info("menuItem name(under tools) :" + menuItem2);
											if(menuItem1.StartsWith("Network status")){
												isNetworkStatusTrue=true;
												Report.Info(  "	menuItem : 	" + menuItem1 + " : is  present under Advancedsettings-Tools menu");
												break;
											}else{
//												Report.Info(  "	menuItem : 	" + menuItem1 + " : is  NOT present under Advancedsettings-Tools menu");
												isNetworkStatusTrue=true;
											}
										}
									}
									
									String newPath_Tools = "";
									newPath_Tools = aVal1.GetPath().ToString() ;
									AdvancedsettingsToolsTag = newPath_Tools;
									AdvancedsettingsToolsTag.Click();
									Delay.Seconds(5);
									
									break;
								}else if(menuItem1.StartsWith("Network status")){
									Report.Info(  "	menuItem : 	" + menuItem1 + " : is  present under Advancedsettings menu");
								}else{
									Report.Info(  "	menuItem : 	" + menuItem1 + "   : is present under Advancedsettings menu");
									isAdvancedsettingsToolsTrue = false;
								}
							}
							
						}
						Report.Screenshot(AdvancedsettingsTag.Element,true);
						
						
					}//end of menuitem check
				}
				
				
				
			}	//end of for-loop
			
			if(!isAdvancedsettingsTrue){	//if Advancedsettings is not present
				
				Report.Failure("Advancedsettings Menu items does not exist");
				
			}else{	//if Advancedsettings is  present
				Report.Success("Advancedsettings menu item exist with required sub menu items");
				if(isAdvancedsettingsToolsTrue){
					Report.Success(" Tools Menu item does exist under Advancedsettings menu ");
					if(isNetworkStatusTrue){
						Report.Success(" NetworkStatus Menu item does exist under AdvancedsettingsTools menu ");
					}else{
						Report.Failure(" NetworkStatus Menu item does NOT exist under AdvancedsettingsTools menu ");
					}
					Report.Screenshot(menuUITag.Element,true);
				}else{
					Report.Failure("AdvancedsettingsTools Menu items does not exist");
					Report.Screenshot(menuUITag.Element,true);
				}
				
				
			}
		}

	}
}