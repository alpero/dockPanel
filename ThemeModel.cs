using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ColorThemeEditor
{
    public class ThemeModel
    {
        public ThemeModel()
        {
            // required for serialization
        }

        // Auto hide adjusts properties when tabs are minimizes.
        // Unknown Functionality
        public String autoHide_dockStripBackgroundColor;
        // Color of the Dock Strip
        public String autoHide_dockStripColor;
        // Color of the Tab 
        public String autoHide_tabColor;
        // Color of the Text on the Tab
        public String autoHide_tabTextColor;
        // Font of the Text on the Tab
        public String autoHide_textFont;

        // Document adjusts the properties when tabs are on the center screen.
        // Color of the Active tab.
        public String document_activeTabColor;
        // Color of the Text on the Active Tab
        public String document_activeTabTextColor;
        // Color of the Dock Strip
        public String document_dockStripColor;
        // Unknown Functionality
        public String document_hoverTabColor;
        // Unknown Functionality
        public String document_hoverTabTextColor;
        // Color of the Inactive Tab
        public String document_inactiveTabColor;
        // Color of the Text on the Inactive Tab
        public String document_inactiveTabTextColor;
        // Font of the Text in Visible Tabs
        public String dockPane_textFont;

        // Tool Window adjusts the properties of the Toolbar Window
        // Color of the Border at the top of the Active Window
        public String toolWindow_activeCaptionColor;
        // Color of the Text at the top of the Active Window
        public String toolWindow_activeCaptionTextColor;
        // Color of the Active Toolbar Window Tab
        public String toolWindow_activeTabColor;
        // Color of the Font of the Active Toolbar Window Tab
        public String toolWindow_activeTabTextColor;
        // Color of the Dock Strip
        public String toolWindow_dockStripColor;
        // Unknown Functionality
        public String toolWindow_hoverTabColor;
        // Unknown Functionality
        public String toolWindow_hoverTabTextColor;
        // Color of the Border at the top of the Inactive Window
        public String toolWindow_inactiveCaptionColor;
        // Color of the Text at the top of the Inactive Window
        public String toolWindow_inactiveCaptionTextColor;
        // Color of the Inactive Toolbar Window Tab
        public String toolWindow_inactiveTabColor;
        // Color of the Font of the Inactive Toolbar Window Tab
        public String toolWindow_inactiveTabTextColor;

        /// <summary>
        /// Create ThemeModel From XML File
        /// </summary>
        /// <param name="fileName">Full path of the file for XML to be read from.</param>
        /// <returns>Theme Model created from the XML file.</returns> 
        public static ThemeModel fromFile(String fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ThemeModel));
                FileStream fileStream = new FileStream(fileName, FileMode.Open);
                XmlReader reader = XmlReader.Create(fileStream);
                ThemeModel themeModel = (ThemeModel)serializer.Deserialize(reader);
                fileStream.Close();
                return themeModel;
            }
            catch (System.InvalidOperationException ex)
            {
                return null;
            }
            
        }

        /// <summary>
        /// Serialize ThemeModel to XML File
        /// </summary>
        /// <param name="themeModel">Theme Model to be serialized.</param>
        /// <param name="fileName">Full path of file for XML to be writen to.</param>
        public static bool toFile(ThemeModel themeModel, String fileName)
        {
            try
            {
                if (themeModel == null) return false;
                XmlSerializer serializer = new XmlSerializer(typeof(ThemeModel));
                TextWriter writer = new StreamWriter(fileName, false);
                serializer.Serialize(writer, themeModel);
                writer.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}
