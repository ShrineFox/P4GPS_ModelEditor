using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace P4GPS_ModelEditor
{
    public partial class P4GPS_ModelEditor_MainForm : Form
    {
        public static bool dataChanged;
        public static int lastSelectedID;
        public P4GPS_ModelEditor_MainForm()
        {
            dataChanged = false;
            InitializeComponent();
        }

        private void OpenFile()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (Read(dialog.FileName, Convert.ToInt32(numericUpDown_PersonaID.Value)))
                {
                    textBox_Browse.Text = dialog.FileName;
                    groupBox_Compendium.Enabled = true;
                    groupBox_Fusion.Enabled = true;
                }
                else
                {
                    textBox_Browse.Text = "";
                    groupBox_Compendium.Enabled = false;
                    groupBox_Fusion.Enabled = false;
                    MessageBox.Show("Not a valid P4G ps_model.bin file!");
                }
            }
        }

        private bool Read(string fileName, int id)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
                {
                    lbl_PersonaIDHex.Text = "0x" + id.ToString("X");
                    // Skip to entry's coordinates
                    reader.BaseStream.Position = 32 + (32 * id);
                    // Read data from fusion entry
                    lbl_FusionRightOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionRightOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_FusionBottomOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionBottomOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    reader.ReadBytes(4); // skip unknown value, segment id?
                    lbl_FusionScaleHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionScale.Value = Convert.ToDecimal(reader.ReadSingle());
                    lbl_FusionRotationHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionRotation.Value = Convert.ToDecimal(reader.ReadSingle());
                    // Read data from compendium entry
                    reader.BaseStream.Position = 32 + (32 * id) + 8272;
                    lbl_CompendiumRightOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumRightOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_CompendiumBottomOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumBottomOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    reader.ReadBytes(4); // skip unknown value, segment id?
                    lbl_CompendiumScaleHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumScale.Value = Convert.ToDecimal(reader.ReadSingle());
                    lbl_CompendiumRotationHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumRotation.Value = Convert.ToDecimal(reader.ReadSingle());
                    // No need to save changes as values from file have just been loaded
                    dataChanged = false;
                    btn_Apply.Enabled = false;
                }
            }
            catch
            {
                return false;
            }

            // Return true if data is valid
            return true;
        }

        private void Write(string fileName, int id)
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream(fileName, FileMode.Open)))
            {
                // Skip to entry's coordinates
                writer.BaseStream.Position = 32 + (32 * id);
                // Write data to fusion entry
                writer.Write(Convert.ToInt16(numericUpDown_FusionRightOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_FusionBottomOffset.Value));
                writer.BaseStream.Position += 4; // skip unknown value, segment id?
                writer.Write(Convert.ToSingle(numericUpDown_FusionScale.Value));
                writer.Write(Convert.ToSingle(numericUpDown_FusionRotation.Value));
                // Write data to compendium entry
                writer.BaseStream.Position = 32 + (32 * id) + 8272;
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumRightOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumBottomOffset.Value));
                writer.BaseStream.Position += 4; // skip unknown value, segment id?
                writer.Write(Convert.ToSingle(numericUpDown_CompendiumScale.Value));
                writer.Write(Convert.ToSingle(numericUpDown_CompendiumRotation.Value));
            }
        }

        private void Path_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void ID_Changed(object sender, EventArgs e)
        {
            // Save changes to last selected Persona ID to file before loading new data
            if (textBox_Browse.Text != "")
            {
                if (dataChanged)
                    Write(textBox_Browse.Text, lastSelectedID);
                Read(textBox_Browse.Text, Convert.ToInt32(numericUpDown_PersonaID.Value));
                lastSelectedID = Convert.ToInt32(numericUpDown_PersonaID.Value);
                dataChanged = false;
                this.Text = this.Text.Replace("*","");
            }
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            // Save changes to currently selected Persona ID to file
            Write(textBox_Browse.Text, lastSelectedID);
            btn_Apply.Enabled = false;
            dataChanged = false;
            this.Text = this.Text.Replace("*", "");
        }

        private void DataChanged()
        {
            // Mark that changes have taken place
            dataChanged = true;
            btn_Apply.Enabled = true;
            this.Text += "*";
        }

        private void RightFusionOffset_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void BottomFusionOffset_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void FusionScale_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void FusionRotation_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void RightCompendiumOffset_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void BottomCompendiumOffset_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void CompendiumScale_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void CompendiumRotation_Changed(object sender, EventArgs e)
        {
            DataChanged();
        }
    }
}
