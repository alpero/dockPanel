using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Xml;
using ColorThemeEditor;


namespace ColorThemeEditor
{
    public partial class Form1 : Form
    {
        LayerPanel layerPanel;
        LayerPanel layerPanel2;
        LayerPanel layerPanel3;

        ThemeFacade themeFacade;
        PropertyGrid propertyGrid = new PropertyGrid();
        
        // Form 1
        public Form1()
        {
            InitializeComponent();
            showDockContent();
        }

        // Show Dock Conent
        public void showDockContent() {
            layerPanel = new LayerPanel();
            layerPanel.Show(dockPanel1, DockState.DockLeft);
            layerPanel2 = new LayerPanel();
            layerPanel2.Show(dockPanel1, DockState.Document);
            layerPanel3 = new LayerPanel();
            layerPanel3.Show(dockPanel1, DockState.DockRight);

            propertyGrid.Dock = DockStyle.Fill; 
            layerPanel3.Controls.Add(propertyGrid);

            themeFacade = new ThemeFacade(this.dockPanel1.Theme);
            propertyGrid.SelectedObject = themeFacade;
        }

        // Save Theme - File Menu Button
        private void saveThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "XML |*.xml";
            if (fd.ShowDialog() != DialogResult.OK) return;
            String fileName = Path.GetFullPath(fd.FileName);

            if (!ThemeModel.toFile(null, fileName))
                MessageBox.Show("An exception has occured.\nFile may not have been saved.", "File Not Saved", MessageBoxButtons.OK);
        }

        // Load Theme - File Menu Button
        private void loadThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "XML |*.xml";
            if (fd.ShowDialog() != DialogResult.OK) return;
            String fileName = Path.GetFullPath(fd.FileName);

            ThemeModel model = ThemeModel.fromFile(fileName);
            if (model == null)
            {
                MessageBox.Show("File selected is not a valid XML theme file.", "Invalid File", MessageBoxButtons.OK);
                return;
            }
            themeFacade.fromThemeModel(model);

            propertyGrid.Refresh();
            dockPanel1.Hide();
            dockPanel1.Show();
        }
    }
}
