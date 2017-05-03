using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace ColorThemeEditor
{
    public class ThemeFacade
    {
        ThemeBase _theme;
        public ThemeBase themeBase;

        public ThemeFacade(ThemeBase theme)
        {
            _theme = theme;
        }

        [Category("Auto Hide")]
        [DisplayName("Dock Strip Background Color")]
        [Description("Unknown Functionality")]
        public Color autoHide_dockStripBackgroundColor
        {
            get
            {
                return _theme.Skin.AutoHideStripSkin.DockStripBackground.EndColor;
            }
            set
            {
                _theme.Skin.AutoHideStripSkin.DockStripBackground.EndColor = value;
                _theme.Skin.AutoHideStripSkin.DockStripBackground.StartColor = value;
            }
        }

        [Category("Auto Hide")]
        [DisplayName("Dock Strip Color")]
        [Description("Color of the Dock Strip")]
        public Color autoHide_dockStripColor
        {
            get
            {
                return _theme.Skin.AutoHideStripSkin.DockStripGradient.EndColor;
            }
            set
            {
                _theme.Skin.AutoHideStripSkin.DockStripGradient.EndColor = value;
                _theme.Skin.AutoHideStripSkin.DockStripGradient.StartColor = value;
            }
        }

        [Category("Auto Hide")]
        [DisplayName("Tab Color")]
        [Description("Color of the Tab")]
        public Color autoHide_tabColor
        {
            get
            {
                return _theme.Skin.AutoHideStripSkin.TabGradient.EndColor;
            }
            set
            {
                _theme.Skin.AutoHideStripSkin.TabGradient.EndColor = value;
                _theme.Skin.AutoHideStripSkin.TabGradient.StartColor = value;
            }
        }

        [Category("Auto Hide")]
        [DisplayName("Tab Text Color")]
        [Description("Color of the Text on the Tab")]
        public Color autoHide_tabTextColor
        {
            get
            {
                return _theme.Skin.AutoHideStripSkin.TabGradient.TextColor;
            }
            set
            {
                _theme.Skin.AutoHideStripSkin.TabGradient.TextColor = value;
            }
        }

        [Category("Auto Hide")]
        [DisplayName("Text Font")]
        [Description("Font of the Text on the Tab")]
        public Font autoHide_textFont
        {
            get
            {
                return _theme.Skin.AutoHideStripSkin.TextFont;
            }
            set
            {
                _theme.Skin.AutoHideStripSkin.TextFont = value;
            }
        }

        [Category("Document")]
        [DisplayName("Active Tab Color")]
        [Description("Color of the Active tab.")]
        public Color document_activeTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.StartColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Active Tab Text Color")]
        [Description("Color of the Text on the Active Tab")]
        public Color document_activeTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.ActiveTabGradient.TextColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Dock Strip Color")]
        [Description("Color of the Dock Strip")]
        public Color document_dockStripColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.DocumentGradient.DockStripGradient.StartColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Hover Tab Color")]
        [Description("Unknown Functionality")]
        public Color document_hoverTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.HoverTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.HoverTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.DocumentGradient.HoverTabGradient.StartColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Hover Tab Text Color")]
        [Description("Unknown Functionality")]
        public Color document_hoverTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.HoverTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.HoverTabGradient.TextColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Inactive Tab Color")]
        [Description("Color of the Inactive Tab")]
        public Color document_inactiveTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.StartColor = value;
            }
        }

        [Category("Document")]
        [DisplayName("Inactive Tab Text Color")]
        [Description("Color of the Text on the Inactive Tab")]
        public Color document_inactiveTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.DocumentGradient.InactiveTabGradient.TextColor = value;
            }
        }

        [Category("Dock Pane")]
        [DisplayName("Text Font")]
        [Description("Font of the Text in Visible Tabs")]
        public Font dockPane_textFont
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.TextFont;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.TextFont = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Active Caption Color")]
        [Description("Color of the Border at the top of the Active Window")]
        public Color toolWindow_activeCaptionColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Active Caption Text Color")]
        [Description("Color of the Text at the top of the Active Window")]
        public Color toolWindow_activeCaptionTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveCaptionGradient.TextColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Active Tab Color")]
        [Description("Color of the Active Toolbar Window Tab")]
        public Color toolWindow_activeTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Active Tab Text Color")]
        [Description("Color of the Font of the Active Toolbar Window Tab")]
        public Color toolWindow_activeTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.ActiveTabGradient.TextColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Dock Strip Color")]
        [Description("Color of the Dock Strip")]
        public Color toolWindow_dockStripColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.DockStripGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Hover Tab Color")]
        [Description("Unknown Functionality")]
        public Color toolWindow_hoverTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.HoverTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.HoverTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.HoverTabGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Hover Tab Text Color")]
        [Description("Unknown Functionality")]
        public Color toolWindow_hoverTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.HoverTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.HoverTabGradient.TextColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Inactive Caption Color")]
        [Description("Color of the Border at the top of the Inactive Window")]
        public Color toolWindow_inactiveCaptionColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Inactive Caption Text Color")]
        [Description("Color of the Text at the top of the Inactive Window")]
        public Color toolWindow_inactiveCaptionTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveCaptionGradient.TextColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Inactive Tab Color")]
        [Description("Color of the Inactive Toolbar Window Tab")]
        public Color toolWindow_inactiveTabColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.EndColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.EndColor = value;
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.StartColor = value;
            }
        }

        [Category("Tool Window")]
        [DisplayName("Inactive Tab Text Color")]
        [Description("Color of the Font of the Inactive Toolbar Window Tab")]
        public Color toolWindow_inactiveTabTextColor
        {
            get
            {
                return _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.TextColor;
            }
            set
            {
                _theme.Skin.DockPaneStripSkin.ToolWindowGradient.InactiveTabGradient.TextColor = value;
            }
        }

        /// <summary>
        /// Creates a simplified ThemeModel from the Dock Panel Suite ThemeBase
        /// </summary>
        /// <returns>ThemeModel</returns>
        public ThemeModel toThemeModel()
        {
            ThemeModel model = new ThemeModel();
            model.autoHide_dockStripBackgroundColor = colorToString(this.autoHide_dockStripBackgroundColor);
            model.autoHide_dockStripColor = colorToString(this.autoHide_dockStripColor);
            model.autoHide_tabColor = colorToString(this.autoHide_tabColor);
            model.autoHide_tabTextColor = colorToString(this.autoHide_tabTextColor);
            model.autoHide_textFont = fontToString(this.autoHide_textFont);
            model.document_activeTabColor = colorToString(this.document_activeTabColor);
            model.document_activeTabTextColor = colorToString(this.document_activeTabTextColor);
            model.document_dockStripColor = colorToString(this.document_dockStripColor);
            model.document_hoverTabColor = colorToString(this.document_hoverTabColor);
            model.document_hoverTabTextColor = colorToString(this.document_hoverTabTextColor);
            model.document_inactiveTabColor = colorToString(this.document_inactiveTabColor);
            model.document_inactiveTabTextColor = colorToString(this.document_inactiveTabTextColor);
            model.dockPane_textFont = fontToString(this.dockPane_textFont);
            model.toolWindow_activeCaptionColor = colorToString(this.toolWindow_activeCaptionColor);
            model.toolWindow_activeCaptionTextColor = colorToString(this.toolWindow_activeCaptionTextColor);
            model.toolWindow_activeTabColor = colorToString(this.toolWindow_activeTabColor);
            model.toolWindow_activeTabTextColor = colorToString(this.toolWindow_activeTabTextColor);
            model.toolWindow_dockStripColor = colorToString(this.toolWindow_dockStripColor);
            model.toolWindow_hoverTabColor = colorToString(this.toolWindow_hoverTabColor);
            model.toolWindow_hoverTabTextColor = colorToString(this.toolWindow_hoverTabTextColor);
            model.toolWindow_inactiveCaptionColor = colorToString(this.toolWindow_inactiveCaptionColor);
            model.toolWindow_inactiveCaptionTextColor = colorToString(this.toolWindow_inactiveCaptionTextColor);
            model.toolWindow_inactiveTabColor = colorToString(this.toolWindow_inactiveTabColor);
            model.toolWindow_inactiveTabTextColor = colorToString(this.toolWindow_inactiveTabTextColor);
            return model;
        }

        /// <summary>
        /// Copies parameters from ThemeModel into the Dockpanel Suite ThemeBase
        /// </summary>
        /// <param name="model">ThemeModel</param>
        public void fromThemeModel(ThemeModel model)
        {            
            this.autoHide_dockStripBackgroundColor = stringToColor(model.autoHide_dockStripBackgroundColor);
            this.autoHide_dockStripColor = stringToColor(model.autoHide_dockStripColor);
            this.autoHide_tabColor = stringToColor(model.autoHide_tabColor);
            this.autoHide_tabTextColor = stringToColor(model.autoHide_tabTextColor);
            this.autoHide_textFont = stringToFont(model.autoHide_textFont);
            this.document_activeTabColor = stringToColor(model.document_activeTabColor);
            this.document_activeTabTextColor = stringToColor(model.document_activeTabTextColor);
            this.document_dockStripColor = stringToColor(model.document_dockStripColor);
            this.document_hoverTabColor = stringToColor(model.document_hoverTabColor);
            this.document_hoverTabTextColor = stringToColor(model.document_hoverTabTextColor);
            this.document_inactiveTabColor = stringToColor(model.document_inactiveTabColor);
            this.document_inactiveTabTextColor = stringToColor(model.document_inactiveTabTextColor);
            this.dockPane_textFont = stringToFont(model.dockPane_textFont);
            this.toolWindow_activeCaptionColor = stringToColor(model.toolWindow_activeCaptionColor);
            this.toolWindow_activeCaptionTextColor = stringToColor(model.toolWindow_activeCaptionTextColor);
            this.toolWindow_activeTabColor = stringToColor(model.toolWindow_activeTabColor);
            this.toolWindow_activeTabTextColor = stringToColor(model.toolWindow_activeTabTextColor);
            this.toolWindow_dockStripColor = stringToColor(model.toolWindow_dockStripColor);
            this.toolWindow_hoverTabColor = stringToColor(model.toolWindow_hoverTabColor);
            this.toolWindow_hoverTabTextColor = stringToColor(model.toolWindow_hoverTabTextColor);
            this.toolWindow_inactiveCaptionColor = stringToColor(model.toolWindow_inactiveCaptionColor);
            this.toolWindow_inactiveCaptionTextColor = stringToColor(model.toolWindow_inactiveCaptionTextColor);
            this.toolWindow_inactiveTabColor = stringToColor(model.toolWindow_inactiveTabColor);
            this.toolWindow_inactiveTabTextColor = stringToColor(model.toolWindow_inactiveTabTextColor);
        }

        private String colorToString(Color color)
        {
            return ColorTranslator.ToHtml(Color.FromArgb(color.ToArgb()));
        }

        private Color stringToColor(String color)
        {
            return ColorTranslator.FromHtml(color);
        }

        private String fontToString(Font font)
        {
            System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
            return converter.ConvertToString(font);
        }

        private Font stringToFont(String font)
        {
            System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
            return (Font)converter.ConvertFromString(font);
        }
    }
}
