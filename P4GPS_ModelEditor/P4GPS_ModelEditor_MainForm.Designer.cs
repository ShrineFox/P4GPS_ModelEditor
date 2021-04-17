
namespace P4GPS_ModelEditor
{
    partial class P4GPS_ModelEditor_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P4GPS_ModelEditor_MainForm));
            this.numericUpDown_PersonaID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Fusion = new System.Windows.Forms.GroupBox();
            this.lbl_FusionScale = new System.Windows.Forms.Label();
            this.numericUpDown_FusionScale = new System.Windows.Forms.NumericUpDown();
            this.lbl_FusionBottomOffset = new System.Windows.Forms.Label();
            this.numericUpDown_FusionBottomOffset = new System.Windows.Forms.NumericUpDown();
            this.lbl_FusionRightOffset = new System.Windows.Forms.Label();
            this.numericUpDown_FusionRightOffset = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Compendium = new System.Windows.Forms.GroupBox();
            this.lbl_CompendiumScale = new System.Windows.Forms.Label();
            this.lbl_CompendiumRightOffset = new System.Windows.Forms.Label();
            this.numericUpDown_CompendiumScale = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CompendiumRightOffset = new System.Windows.Forms.NumericUpDown();
            this.lbl_CompendiumBottomOffset = new System.Windows.Forms.Label();
            this.numericUpDown_CompendiumBottomOffset = new System.Windows.Forms.NumericUpDown();
            this.textBox_Browse = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.lbl_FusionRotation = new System.Windows.Forms.Label();
            this.numericUpDown_FusionRotation = new System.Windows.Forms.NumericUpDown();
            this.lbl_CompendiumRotation = new System.Windows.Forms.Label();
            this.numericUpDown_CompendiumRotation = new System.Windows.Forms.NumericUpDown();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.lbl_PersonaIDHex = new System.Windows.Forms.Label();
            this.lbl_FusionRightOffsetHex = new System.Windows.Forms.Label();
            this.lbl_FusionBottomOffsetHex = new System.Windows.Forms.Label();
            this.lbl_FusionScaleHex = new System.Windows.Forms.Label();
            this.lbl_FusionRotationHex = new System.Windows.Forms.Label();
            this.lbl_CompendiumRightOffsetHex = new System.Windows.Forms.Label();
            this.lbl_CompendiumBottomOffsetHex = new System.Windows.Forms.Label();
            this.lbl_CompendiumScaleHex = new System.Windows.Forms.Label();
            this.lbl_CompendiumRotationHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PersonaID)).BeginInit();
            this.groupBox_Fusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionBottomOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionRightOffset)).BeginInit();
            this.groupBox_Compendium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumRightOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumBottomOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_PersonaID
            // 
            this.numericUpDown_PersonaID.Location = new System.Drawing.Point(100, 40);
            this.numericUpDown_PersonaID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_PersonaID.Name = "numericUpDown_PersonaID";
            this.numericUpDown_PersonaID.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown_PersonaID.TabIndex = 0;
            this.numericUpDown_PersonaID.ValueChanged += new System.EventHandler(this.ID_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persona ID:";
            // 
            // groupBox_Fusion
            // 
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionRotationHex);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionScaleHex);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionBottomOffsetHex);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionRightOffsetHex);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionRotation);
            this.groupBox_Fusion.Controls.Add(this.numericUpDown_FusionRotation);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionScale);
            this.groupBox_Fusion.Controls.Add(this.numericUpDown_FusionScale);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionBottomOffset);
            this.groupBox_Fusion.Controls.Add(this.numericUpDown_FusionBottomOffset);
            this.groupBox_Fusion.Controls.Add(this.lbl_FusionRightOffset);
            this.groupBox_Fusion.Controls.Add(this.numericUpDown_FusionRightOffset);
            this.groupBox_Fusion.Enabled = false;
            this.groupBox_Fusion.Location = new System.Drawing.Point(15, 68);
            this.groupBox_Fusion.Name = "groupBox_Fusion";
            this.groupBox_Fusion.Size = new System.Drawing.Size(330, 156);
            this.groupBox_Fusion.TabIndex = 2;
            this.groupBox_Fusion.TabStop = false;
            this.groupBox_Fusion.Text = "Fusion";
            // 
            // lbl_FusionScale
            // 
            this.lbl_FusionScale.AutoSize = true;
            this.lbl_FusionScale.Location = new System.Drawing.Point(6, 105);
            this.lbl_FusionScale.Name = "lbl_FusionScale";
            this.lbl_FusionScale.Size = new System.Drawing.Size(47, 17);
            this.lbl_FusionScale.TabIndex = 11;
            this.lbl_FusionScale.Text = "Scale:";
            // 
            // numericUpDown_FusionScale
            // 
            this.numericUpDown_FusionScale.DecimalPlaces = 14;
            this.numericUpDown_FusionScale.Location = new System.Drawing.Point(110, 103);
            this.numericUpDown_FusionScale.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_FusionScale.Name = "numericUpDown_FusionScale";
            this.numericUpDown_FusionScale.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown_FusionScale.TabIndex = 10;
            this.numericUpDown_FusionScale.ValueChanged += new System.EventHandler(this.FusionScale_Changed);
            // 
            // lbl_FusionBottomOffset
            // 
            this.lbl_FusionBottomOffset.AutoSize = true;
            this.lbl_FusionBottomOffset.Location = new System.Drawing.Point(6, 67);
            this.lbl_FusionBottomOffset.Name = "lbl_FusionBottomOffset";
            this.lbl_FusionBottomOffset.Size = new System.Drawing.Size(98, 17);
            this.lbl_FusionBottomOffset.TabIndex = 9;
            this.lbl_FusionBottomOffset.Text = "Bottom Offset:";
            // 
            // numericUpDown_FusionBottomOffset
            // 
            this.numericUpDown_FusionBottomOffset.Location = new System.Drawing.Point(110, 65);
            this.numericUpDown_FusionBottomOffset.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown_FusionBottomOffset.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown_FusionBottomOffset.Name = "numericUpDown_FusionBottomOffset";
            this.numericUpDown_FusionBottomOffset.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown_FusionBottomOffset.TabIndex = 8;
            this.numericUpDown_FusionBottomOffset.ValueChanged += new System.EventHandler(this.BottomFusionOffset_Changed);
            // 
            // lbl_FusionRightOffset
            // 
            this.lbl_FusionRightOffset.AutoSize = true;
            this.lbl_FusionRightOffset.Location = new System.Drawing.Point(6, 39);
            this.lbl_FusionRightOffset.Name = "lbl_FusionRightOffset";
            this.lbl_FusionRightOffset.Size = new System.Drawing.Size(87, 17);
            this.lbl_FusionRightOffset.TabIndex = 7;
            this.lbl_FusionRightOffset.Text = "Right Offset:";
            // 
            // numericUpDown_FusionRightOffset
            // 
            this.numericUpDown_FusionRightOffset.Location = new System.Drawing.Point(110, 39);
            this.numericUpDown_FusionRightOffset.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown_FusionRightOffset.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown_FusionRightOffset.Name = "numericUpDown_FusionRightOffset";
            this.numericUpDown_FusionRightOffset.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown_FusionRightOffset.TabIndex = 6;
            this.numericUpDown_FusionRightOffset.ValueChanged += new System.EventHandler(this.RightFusionOffset_Changed);
            // 
            // groupBox_Compendium
            // 
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumRotationHex);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumScaleHex);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumBottomOffsetHex);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumRightOffsetHex);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumRotation);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumScale);
            this.groupBox_Compendium.Controls.Add(this.numericUpDown_CompendiumRotation);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumRightOffset);
            this.groupBox_Compendium.Controls.Add(this.numericUpDown_CompendiumScale);
            this.groupBox_Compendium.Controls.Add(this.numericUpDown_CompendiumRightOffset);
            this.groupBox_Compendium.Controls.Add(this.lbl_CompendiumBottomOffset);
            this.groupBox_Compendium.Controls.Add(this.numericUpDown_CompendiumBottomOffset);
            this.groupBox_Compendium.Enabled = false;
            this.groupBox_Compendium.Location = new System.Drawing.Point(15, 230);
            this.groupBox_Compendium.Name = "groupBox_Compendium";
            this.groupBox_Compendium.Size = new System.Drawing.Size(330, 161);
            this.groupBox_Compendium.TabIndex = 3;
            this.groupBox_Compendium.TabStop = false;
            this.groupBox_Compendium.Text = "Compendium";
            // 
            // lbl_CompendiumScale
            // 
            this.lbl_CompendiumScale.AutoSize = true;
            this.lbl_CompendiumScale.Location = new System.Drawing.Point(6, 109);
            this.lbl_CompendiumScale.Name = "lbl_CompendiumScale";
            this.lbl_CompendiumScale.Size = new System.Drawing.Size(47, 17);
            this.lbl_CompendiumScale.TabIndex = 17;
            this.lbl_CompendiumScale.Text = "Scale:";
            // 
            // lbl_CompendiumRightOffset
            // 
            this.lbl_CompendiumRightOffset.AutoSize = true;
            this.lbl_CompendiumRightOffset.Location = new System.Drawing.Point(6, 43);
            this.lbl_CompendiumRightOffset.Name = "lbl_CompendiumRightOffset";
            this.lbl_CompendiumRightOffset.Size = new System.Drawing.Size(87, 17);
            this.lbl_CompendiumRightOffset.TabIndex = 13;
            this.lbl_CompendiumRightOffset.Text = "Right Offset:";
            // 
            // numericUpDown_CompendiumScale
            // 
            this.numericUpDown_CompendiumScale.DecimalPlaces = 14;
            this.numericUpDown_CompendiumScale.Location = new System.Drawing.Point(110, 107);
            this.numericUpDown_CompendiumScale.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_CompendiumScale.Name = "numericUpDown_CompendiumScale";
            this.numericUpDown_CompendiumScale.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown_CompendiumScale.TabIndex = 16;
            this.numericUpDown_CompendiumScale.ValueChanged += new System.EventHandler(this.CompendiumScale_Changed);
            // 
            // numericUpDown_CompendiumRightOffset
            // 
            this.numericUpDown_CompendiumRightOffset.Location = new System.Drawing.Point(110, 43);
            this.numericUpDown_CompendiumRightOffset.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown_CompendiumRightOffset.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown_CompendiumRightOffset.Name = "numericUpDown_CompendiumRightOffset";
            this.numericUpDown_CompendiumRightOffset.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown_CompendiumRightOffset.TabIndex = 12;
            this.numericUpDown_CompendiumRightOffset.ValueChanged += new System.EventHandler(this.RightCompendiumOffset_Changed);
            // 
            // lbl_CompendiumBottomOffset
            // 
            this.lbl_CompendiumBottomOffset.AutoSize = true;
            this.lbl_CompendiumBottomOffset.Location = new System.Drawing.Point(6, 71);
            this.lbl_CompendiumBottomOffset.Name = "lbl_CompendiumBottomOffset";
            this.lbl_CompendiumBottomOffset.Size = new System.Drawing.Size(98, 17);
            this.lbl_CompendiumBottomOffset.TabIndex = 15;
            this.lbl_CompendiumBottomOffset.Text = "Bottom Offset:";
            // 
            // numericUpDown_CompendiumBottomOffset
            // 
            this.numericUpDown_CompendiumBottomOffset.Location = new System.Drawing.Point(110, 69);
            this.numericUpDown_CompendiumBottomOffset.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDown_CompendiumBottomOffset.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numericUpDown_CompendiumBottomOffset.Name = "numericUpDown_CompendiumBottomOffset";
            this.numericUpDown_CompendiumBottomOffset.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown_CompendiumBottomOffset.TabIndex = 14;
            this.numericUpDown_CompendiumBottomOffset.ValueChanged += new System.EventHandler(this.BottomCompendiumOffset_Changed);
            // 
            // textBox_Browse
            // 
            this.textBox_Browse.Location = new System.Drawing.Point(15, 12);
            this.textBox_Browse.Name = "textBox_Browse";
            this.textBox_Browse.ReadOnly = true;
            this.textBox_Browse.Size = new System.Drawing.Size(250, 22);
            this.textBox_Browse.TabIndex = 4;
            this.textBox_Browse.Click += new System.EventHandler(this.Path_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(271, 11);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 5;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // lbl_FusionRotation
            // 
            this.lbl_FusionRotation.AutoSize = true;
            this.lbl_FusionRotation.Location = new System.Drawing.Point(6, 130);
            this.lbl_FusionRotation.Name = "lbl_FusionRotation";
            this.lbl_FusionRotation.Size = new System.Drawing.Size(65, 17);
            this.lbl_FusionRotation.TabIndex = 13;
            this.lbl_FusionRotation.Text = "Rotation:";
            // 
            // numericUpDown_FusionRotation
            // 
            this.numericUpDown_FusionRotation.DecimalPlaces = 14;
            this.numericUpDown_FusionRotation.Location = new System.Drawing.Point(110, 128);
            this.numericUpDown_FusionRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_FusionRotation.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown_FusionRotation.Name = "numericUpDown_FusionRotation";
            this.numericUpDown_FusionRotation.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown_FusionRotation.TabIndex = 12;
            this.numericUpDown_FusionRotation.ValueChanged += new System.EventHandler(this.FusionRotation_Changed);
            // 
            // lbl_CompendiumRotation
            // 
            this.lbl_CompendiumRotation.AutoSize = true;
            this.lbl_CompendiumRotation.Location = new System.Drawing.Point(6, 136);
            this.lbl_CompendiumRotation.Name = "lbl_CompendiumRotation";
            this.lbl_CompendiumRotation.Size = new System.Drawing.Size(65, 17);
            this.lbl_CompendiumRotation.TabIndex = 15;
            this.lbl_CompendiumRotation.Text = "Rotation:";
            // 
            // numericUpDown_CompendiumRotation
            // 
            this.numericUpDown_CompendiumRotation.DecimalPlaces = 14;
            this.numericUpDown_CompendiumRotation.Location = new System.Drawing.Point(110, 134);
            this.numericUpDown_CompendiumRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_CompendiumRotation.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown_CompendiumRotation.Name = "numericUpDown_CompendiumRotation";
            this.numericUpDown_CompendiumRotation.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown_CompendiumRotation.TabIndex = 14;
            this.numericUpDown_CompendiumRotation.ValueChanged += new System.EventHandler(this.CompendiumRotation_Changed);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Enabled = false;
            this.btn_Apply.Location = new System.Drawing.Point(260, 39);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(85, 26);
            this.btn_Apply.TabIndex = 6;
            this.btn_Apply.Text = "Apply Changes";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // lbl_PersonaIDHex
            // 
            this.lbl_PersonaIDHex.AutoSize = true;
            this.lbl_PersonaIDHex.Location = new System.Drawing.Point(172, 44);
            this.lbl_PersonaIDHex.Name = "lbl_PersonaIDHex";
            this.lbl_PersonaIDHex.Size = new System.Drawing.Size(30, 17);
            this.lbl_PersonaIDHex.TabIndex = 7;
            this.lbl_PersonaIDHex.Text = "0x0";
            // 
            // lbl_FusionRightOffsetHex
            // 
            this.lbl_FusionRightOffsetHex.AutoSize = true;
            this.lbl_FusionRightOffsetHex.Location = new System.Drawing.Point(204, 41);
            this.lbl_FusionRightOffsetHex.Name = "lbl_FusionRightOffsetHex";
            this.lbl_FusionRightOffsetHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_FusionRightOffsetHex.TabIndex = 8;
            // 
            // lbl_FusionBottomOffsetHex
            // 
            this.lbl_FusionBottomOffsetHex.AutoSize = true;
            this.lbl_FusionBottomOffsetHex.Location = new System.Drawing.Point(204, 67);
            this.lbl_FusionBottomOffsetHex.Name = "lbl_FusionBottomOffsetHex";
            this.lbl_FusionBottomOffsetHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_FusionBottomOffsetHex.TabIndex = 14;
            // 
            // lbl_FusionScaleHex
            // 
            this.lbl_FusionScaleHex.AutoSize = true;
            this.lbl_FusionScaleHex.Location = new System.Drawing.Point(255, 105);
            this.lbl_FusionScaleHex.Name = "lbl_FusionScaleHex";
            this.lbl_FusionScaleHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_FusionScaleHex.TabIndex = 15;
            // 
            // lbl_FusionRotationHex
            // 
            this.lbl_FusionRotationHex.AutoSize = true;
            this.lbl_FusionRotationHex.Location = new System.Drawing.Point(255, 130);
            this.lbl_FusionRotationHex.Name = "lbl_FusionRotationHex";
            this.lbl_FusionRotationHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_FusionRotationHex.TabIndex = 16;
            // 
            // lbl_CompendiumRightOffsetHex
            // 
            this.lbl_CompendiumRightOffsetHex.AutoSize = true;
            this.lbl_CompendiumRightOffsetHex.Location = new System.Drawing.Point(204, 45);
            this.lbl_CompendiumRightOffsetHex.Name = "lbl_CompendiumRightOffsetHex";
            this.lbl_CompendiumRightOffsetHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_CompendiumRightOffsetHex.TabIndex = 17;
            // 
            // lbl_CompendiumBottomOffsetHex
            // 
            this.lbl_CompendiumBottomOffsetHex.AutoSize = true;
            this.lbl_CompendiumBottomOffsetHex.Location = new System.Drawing.Point(204, 71);
            this.lbl_CompendiumBottomOffsetHex.Name = "lbl_CompendiumBottomOffsetHex";
            this.lbl_CompendiumBottomOffsetHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_CompendiumBottomOffsetHex.TabIndex = 18;
            // 
            // lbl_CompendiumScaleHex
            // 
            this.lbl_CompendiumScaleHex.AutoSize = true;
            this.lbl_CompendiumScaleHex.Location = new System.Drawing.Point(253, 109);
            this.lbl_CompendiumScaleHex.Name = "lbl_CompendiumScaleHex";
            this.lbl_CompendiumScaleHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_CompendiumScaleHex.TabIndex = 19;
            // 
            // lbl_CompendiumRotationHex
            // 
            this.lbl_CompendiumRotationHex.AutoSize = true;
            this.lbl_CompendiumRotationHex.Location = new System.Drawing.Point(253, 136);
            this.lbl_CompendiumRotationHex.Name = "lbl_CompendiumRotationHex";
            this.lbl_CompendiumRotationHex.Size = new System.Drawing.Size(0, 17);
            this.lbl_CompendiumRotationHex.TabIndex = 20;
            // 
            // P4GPS_ModelEditor_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 403);
            this.Controls.Add(this.lbl_PersonaIDHex);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.textBox_Browse);
            this.Controls.Add(this.groupBox_Compendium);
            this.Controls.Add(this.groupBox_Fusion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_PersonaID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(375, 450);
            this.MinimumSize = new System.Drawing.Size(375, 450);
            this.Name = "P4GPS_ModelEditor_MainForm";
            this.Text = "P4G ps_model Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PersonaID)).EndInit();
            this.groupBox_Fusion.ResumeLayout(false);
            this.groupBox_Fusion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionBottomOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionRightOffset)).EndInit();
            this.groupBox_Compendium.ResumeLayout(false);
            this.groupBox_Compendium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumRightOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumBottomOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FusionRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CompendiumRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_PersonaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Fusion;
        private System.Windows.Forms.GroupBox groupBox_Compendium;
        private System.Windows.Forms.TextBox textBox_Browse;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label lbl_FusionRightOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown_FusionRightOffset;
        private System.Windows.Forms.Label lbl_FusionScale;
        private System.Windows.Forms.NumericUpDown numericUpDown_FusionScale;
        private System.Windows.Forms.Label lbl_FusionBottomOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown_FusionBottomOffset;
        private System.Windows.Forms.Label lbl_CompendiumScale;
        private System.Windows.Forms.Label lbl_CompendiumRightOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown_CompendiumScale;
        private System.Windows.Forms.NumericUpDown numericUpDown_CompendiumRightOffset;
        private System.Windows.Forms.Label lbl_CompendiumBottomOffset;
        private System.Windows.Forms.NumericUpDown numericUpDown_CompendiumBottomOffset;
        private System.Windows.Forms.Label lbl_FusionRotation;
        private System.Windows.Forms.NumericUpDown numericUpDown_FusionRotation;
        private System.Windows.Forms.Label lbl_CompendiumRotation;
        private System.Windows.Forms.NumericUpDown numericUpDown_CompendiumRotation;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label lbl_PersonaIDHex;
        private System.Windows.Forms.Label lbl_FusionRightOffsetHex;
        private System.Windows.Forms.Label lbl_FusionBottomOffsetHex;
        private System.Windows.Forms.Label lbl_FusionScaleHex;
        private System.Windows.Forms.Label lbl_FusionRotationHex;
        private System.Windows.Forms.Label lbl_CompendiumRotationHex;
        private System.Windows.Forms.Label lbl_CompendiumScaleHex;
        private System.Windows.Forms.Label lbl_CompendiumBottomOffsetHex;
        private System.Windows.Forms.Label lbl_CompendiumRightOffsetHex;
    }
}

