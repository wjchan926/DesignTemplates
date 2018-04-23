using System;
using System.Runtime.InteropServices;
using Inventor;
using Microsoft.Win32;
using InvAddIn;
using System.Drawing;
using System.Windows.Forms;

namespace DesignTemplates
{
    /// <summary>
    /// This is the primary AddIn Server class that implements the ApplicationAddInServer interface
    /// that all Inventor AddIns are required to implement. The communication between Inventor and
    /// the AddIn is via the methods on this interface.
    /// </summary>
    [GuidAttribute("6e3e7db7-6b73-4695-9fe8-86d035e9b969")]
    public class StandardAddInServer : Inventor.ApplicationAddInServer
    {

        // Inventor application object.
        private Inventor.Application m_inventorApplication;

        // Buttons for Each Design Template
        private ButtonDefinition m_CrosswireBasketButton;
        
        // iLogic AddinGUID
        private static string addInGUID = "124e7311-6a45-4301-8485-29fc60060a1f";

        public StandardAddInServer()
        {
        }

        #region ApplicationAddInServer Members

        public void Activate(Inventor.ApplicationAddInSite addInSiteObject, bool firstTime)
        {
            // This method is called by Inventor when it loads the addin.
            // The AddInSiteObject provides access to the Inventor Application object.
            // The FirstTime flag indicates if the addin is loaded for the first time.

            // Initialize AddIn members.
            m_inventorApplication = addInSiteObject.Application;

            ControlDefinitions controlDefs = m_inventorApplication.CommandManager.ControlDefinitions;

            // Icons 
            string appData = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);

            Icon small = new Icon(appData + @"\Autodesk\ApplicationPlugins\DesignTemplates\cwBasket.ico");
            Icon large = new Icon(appData + @"\Autodesk\ApplicationPlugins\DesignTemplates\cwBasket.ico");

            stdole.IPictureDisp smallIcon = PictureDispConverter.ToIPictureDisp(small);
            stdole.IPictureDisp largeIcon = PictureDispConverter.ToIPictureDisp(large);
            // End Icon code

            // Create button objects
            m_CrosswireBasketButton = controlDefs.AddButtonDefinition("Crosswire\nBasket", "Crosswire Basket Design Template", CommandTypesEnum.kShapeEditCmdType, addInGUID, "Generate a crosswire basket 3D model and\nengineering drawing using a template.",
                "Crosswire Basket Design Template", smallIcon, largeIcon);

            // TODO: Add ApplicationAddInServer.Activate implementation.
            // e.g. event initialization, command creation etc.

            if (firstTime)
            {

                try
                {
                    if (m_inventorApplication.UserInterfaceManager.InterfaceStyle == InterfaceStyleEnum.kRibbonInterface)
                    {
                        // Assembly Button
                        Ribbon assemblyRibbon = m_inventorApplication.UserInterfaceManager.Ribbons["Assembly"];
                        RibbonTab assemblyTab = assemblyRibbon.RibbonTabs["id_TabAssemble"];

                        // Part Buttons
                        Ribbon partRibbon = m_inventorApplication.UserInterfaceManager.Ribbons["Part"];
                        RibbonTab sketchTab = partRibbon.RibbonTabs["id_TabSketch"];
                        RibbonTab sheetMetalTab = partRibbon.RibbonTabs["id_TabSheetMetal"];
                        RibbonTab modelTab = partRibbon.RibbonTabs["id_TabModel"];


                        try
                        {
                            // For ribbon interface
                            // This is a new panel that can be made
                            RibbonPanel panel = assemblyTab.RibbonPanels.Add("Assembly to Parts", "Autodesk:Assembly to Parts:Panel1", addInGUID, "", false);
                            CommandControl control1 = panel.CommandControls.AddButton(m_CrosswireBasketButton, true, true, "", false);


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        // For classic interface, possibly incorrect code
                        CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["AMxAssemblyPanelCmdBar"];
                        oCommandBar.Controls.AddButton(m_CrosswireBasketButton, 0);
                    }
                }
                catch
                {
                    // For classic interface, possibly incorrect code
                    CommandBar oCommandBar = m_inventorApplication.UserInterfaceManager.CommandBars["AMxAssemblyPanelCmdBar"];
                    oCommandBar.Controls.AddButton(m_CrosswireBasketButton, 0);
                }
            }

            m_CrosswireBasketButton.OnExecute += new ButtonDefinitionSink_OnExecuteEventHandler(m_CrosswireBasketButton_OnExecute);




        }

        public void Deactivate()
        {
            // This method is called by Inventor when the AddIn is unloaded.
            // The AddIn will be unloaded either manually by the user or
            // when the Inventor session is terminated

            // TODO: Add ApplicationAddInServer.Deactivate implementation

            // Release objects.
            m_inventorApplication = null;

            Marshal.ReleaseComObject(m_CrosswireBasketButton);
            m_CrosswireBasketButton = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void ExecuteCommand(int commandID)
        {
            // Note:this method is now obsolete, you should use the 
            // ControlDefinition functionality for implementing commands.
        }

        public object Automation
        {
            // This property is provided to allow the AddIn to expose an API 
            // of its own to other programs. Typically, this  would be done by
            // implementing the AddIn's API interface in a class and returning 
            // that class object through this property.

            get
            {
                // TODO: Add ApplicationAddInServer.Automation getter implementation
                return null;
            }
        }

        public void m_CrosswireBasketButton_OnExecute(NameValueMap Context)
        {
            CWBasketForm cwBasketForm = new CWBasketForm(m_inventorApplication);
            cwBasketForm.ShowDialog();
        }

        #endregion
    }

    /// <summary>
    /// This class handles the icons for the addin
    /// </summary>
    public sealed class PictureDispConverter
    {
        [DllImport("OleAut32.dll", EntryPoint = "OleCreatePictureIndirect", ExactSpelling = true, PreserveSig = false)]
        private static extern stdole.IPictureDisp OleCreatePictureIndirect([MarshalAs(UnmanagedType.AsAny)]
            object picdesc, ref Guid iid, [MarshalAs(UnmanagedType.Bool)]
            bool fOwn);


        static Guid iPictureDispGuid = typeof(stdole.IPictureDisp).GUID;

        private sealed class PICTDESC
        {
            private PICTDESC()
            {
            }

            //Picture Types

            public const short PICTYPE_UNINITIALIZED = -1;
            public const short PICTYPE_NONE = 0;
            public const short PICTYPE_BITMAP = 1;
            public const short PICTYPE_METAFILE = 2;
            public const short PICTYPE_ICON = 3;

            public const short PICTYPE_ENHMETAFILE = 4;

            [StructLayout(LayoutKind.Sequential)]
            public class Icon
            {
                internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PICTDESC.Icon));
                internal int picType = PICTDESC.PICTYPE_ICON;
                internal IntPtr hicon = IntPtr.Zero;
                internal int unused1;

                internal int unused2;

                internal Icon(System.Drawing.Icon icon)
                {
                    this.hicon = icon.ToBitmap().GetHicon();
                }
            }


            [StructLayout(LayoutKind.Sequential)]
            public class Bitmap
            {
                internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PICTDESC.Bitmap));
                internal int picType = PICTDESC.PICTYPE_BITMAP;
                internal IntPtr hbitmap = IntPtr.Zero;
                internal IntPtr hpal = IntPtr.Zero;

                internal int unused;

                internal Bitmap(System.Drawing.Bitmap bitmap)
                {
                    this.hbitmap = bitmap.GetHbitmap();
                }
            }
        }


        public static stdole.IPictureDisp ToIPictureDisp(System.Drawing.Icon icon)
        {
            PICTDESC.Icon pictIcon = new PICTDESC.Icon(icon);
            return OleCreatePictureIndirect(pictIcon, ref iPictureDispGuid, true);
        }


        public static stdole.IPictureDisp ToIPictureDisp(System.Drawing.Bitmap bmp)
        {
            PICTDESC.Bitmap pictBmp = new PICTDESC.Bitmap(bmp);
            return OleCreatePictureIndirect(pictBmp, ref iPictureDispGuid, true);
        }
    }
}
