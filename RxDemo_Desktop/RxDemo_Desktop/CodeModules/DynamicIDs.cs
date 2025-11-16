/*
 * Created by Ranorex
 * User: Planit
 * Date: 12-11-2025
 * Time: 00:44
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
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

namespace RxDemo_Desktop.CodeModules
{
    /// <summary>
    /// Description of DynamicIDs.
    /// </summary>
    [TestModule("76451E2C-D3E0-4EAC-8317-1B0F10A13FE6", ModuleType.UserCode, 1)]
    public class DynamicIDs : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DynamicIDs()
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
            
            RxDemo_DesktopRepository rx = new RxDemo_DesktopRepository();
            rx.RxMainFrame.RxTabDynamicIDs.Chk_ShwDynID.Click();
            string currId = rx.RxMainFrame.RxTabDynamicIDs.TxtField_CurID.Element.GetAttributeValueText("Text");
            Report.Info(currId);
            rx.RxMainFrame.RxTabDynamicIDs.Chk_ShwDynID.Click();
            rx.RxMainFrame.RxTabDynamicIDs.Chk_ShwDynID.Click();
            string updId = rx.RxMainFrame.RxTabDynamicIDs.TxtField_CurID.Element.GetAttributeValueText("Text"); 
            //string updId = rx.
            Report.Info(updId);
            if(currId!=updId){
            	Report.Info("ID is updated");
            }
            
        }
    }
}
