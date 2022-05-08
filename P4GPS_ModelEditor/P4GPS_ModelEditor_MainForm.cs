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
                    lbl_FusionXOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionXOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_FusionYOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionYOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_FusionZOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X");  numericUpDown_FusionZOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    reader.ReadBytes(2); // skip unknown value
                    lbl_FusionScaleHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionScale.Value = Convert.ToDecimal(reader.ReadSingle());
                    lbl_FusionRotationHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionRotation.Value = Convert.ToDecimal(reader.ReadSingle());

                    lbl_FusionOpacityHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionOpacity.Value = Convert.ToDecimal(reader.ReadByte());

                    reader.ReadBytes(8); // skip unknown values (byte 2 and 3 seem to be used for light rotation)

                    lbl_FusionRGBHex.Text = "0x" + reader.BaseStream.Position.ToString("X");  //read the rgb values backwards
                    byte B = reader.ReadByte();
                    byte G = reader.ReadByte();
                    byte R = reader.ReadByte();
                    FusionColorBox.BackColor = Color.FromArgb(R, G, B);
                    FusionColorBox.ForeColor = Color.FromArgb(R, G, B);

                    lbl_FusionCameraXHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionCameraX.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_FusionCameraYHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_FusionCameraY.Value = Convert.ToDecimal(reader.ReadInt16());



                    // Read data from compendium entry
                    reader.BaseStream.Position = 32 + (32 * id) + 8272;
                    lbl_CompendiumXOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumXOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_CompendiumYOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumYOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_CompendiumZOffsetHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumZOffset.Value = Convert.ToDecimal(reader.ReadInt16());
                    reader.ReadBytes(2); // skip unknown value
                    lbl_CompendiumScaleHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumScale.Value = Convert.ToDecimal(reader.ReadSingle());
                    lbl_CompendiumRotationHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumRotation.Value = Convert.ToDecimal(reader.ReadSingle());

                    lbl_CompendiumOpacityHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumOpacity.Value = Convert.ToDecimal(reader.ReadByte());

                    reader.ReadBytes(8); // skip unknown values (byte 2 and 3 seem to be used for light rotation)

                    lbl_CompendiumRGBHex.Text = "0x" + reader.BaseStream.Position.ToString("X");  //read the rgb values backwards
                    byte B2 = reader.ReadByte();
                    byte G2 = reader.ReadByte();
                    byte R2 = reader.ReadByte();
                    FusionColorBox.BackColor = Color.FromArgb(R2, G2, B2);
                    FusionColorBox.ForeColor = Color.FromArgb(R2, G2, B2);

                    lbl_CompendiumCameraXHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumCameraX.Value = Convert.ToDecimal(reader.ReadInt16());
                    lbl_CompendiumCameraYHex.Text = "0x" + reader.BaseStream.Position.ToString("X"); numericUpDown_CompendiumCameraY.Value = Convert.ToDecimal(reader.ReadInt16());

                    // No need to save changes as values from file have just been loaded
                    dataChanged = false;
                    btn_Apply.Enabled = false;
                    this.Text = this.Text.Replace("*", "");
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
                writer.Write(Convert.ToInt16(numericUpDown_FusionXOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_FusionYOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_FusionZOffset.Value));
                writer.BaseStream.Position += 2; // skip unknown value
                writer.Write(Convert.ToSingle(numericUpDown_FusionScale.Value));
                writer.Write(Convert.ToSingle(numericUpDown_FusionRotation.Value));

                writer.Write(Convert.ToByte(numericUpDown_FusionOpacity.Value));
                writer.Write(FusionColorBox.BackColor.B); writer.Write(FusionColorBox.BackColor.G); writer.Write(FusionColorBox.BackColor.R); //write the rgb values backwards

                writer.Write(Convert.ToInt16(numericUpDown_FusionCameraX.Value));
                writer.Write(Convert.ToInt16(numericUpDown_FusionCameraY.Value));



                // Write data to compendium entry
                writer.BaseStream.Position = 32 + (32 * id) + 8272;
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumXOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumYOffset.Value));
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumZOffset.Value));
                writer.BaseStream.Position += 2; // skip unknown value, segment id?
                writer.Write(Convert.ToSingle(numericUpDown_CompendiumScale.Value));
                writer.Write(Convert.ToSingle(numericUpDown_CompendiumRotation.Value));

                writer.Write(Convert.ToByte(numericUpDown_CompendiumOpacity.Value));
                writer.Write(CompendiumColorBox.BackColor.B); writer.Write(CompendiumColorBox.BackColor.G); writer.Write(CompendiumColorBox.BackColor.R); //write the rgb values backwards

                writer.Write(Convert.ToInt16(numericUpDown_CompendiumCameraX.Value));
                writer.Write(Convert.ToInt16(numericUpDown_CompendiumCameraY.Value));

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

        private void Value_Changed(object sender, EventArgs e)
        {
            DataChanged();
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

        private void lbl_FusionRightOffsetHex_Click(object sender, EventArgs e)
        {

        }

        private void FusionRGBButton_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPicker = new ColorDialog();
            ColorPicker.Color = FusionColorBox.BackColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                if (ColorPicker.Color != FusionColorBox.BackColor)
                {
                    FusionColorBox.BackColor = ColorPicker.Color;
                    FusionColorBox.ForeColor = ColorPicker.Color;
                    DataChanged();
                }
            }
                
        }

        private void CompendiumRGBButton_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPicker = new ColorDialog();
            ColorPicker.Color = CompendiumColorBox.BackColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                if (ColorPicker.Color != FusionColorBox.BackColor)
                {
                    CompendiumColorBox.BackColor = ColorPicker.Color;
                    CompendiumColorBox.ForeColor = ColorPicker.Color;
                    DataChanged();
                }
            }
        }

        private void P4GPS_ModelEditor_MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"P4G ps_model Editor v.{Application.ProductVersion}";
        }

    }
}
