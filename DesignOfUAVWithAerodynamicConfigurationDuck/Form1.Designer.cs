namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RelativePayloadMassTextBox = new TextBox();
            RelativePayloadMassLabel = new Label();
            RelativeMassOfEquipmentLabel = new Label();
            RelativeMassOfEquipmentTextBox = new TextBox();
            RelativeMassOfEngineSystemLabel = new Label();
            RelativeMassOfEngineSystemTextBox = new TextBox();
            SuspendLayout();
            // 
            // RelativePayloadMassTextBox
            // 
            RelativePayloadMassTextBox.Location = new Point(66, 71);
            RelativePayloadMassTextBox.Name = "RelativePayloadMassTextBox";
            RelativePayloadMassTextBox.Size = new Size(100, 23);
            RelativePayloadMassTextBox.TabIndex = 1;
            RelativePayloadMassTextBox.TextChanged += RelativePayloadMassTextBox_TextChanged;
            // 
            // RelativePayloadMassLabel
            // 
            RelativePayloadMassLabel.AutoSize = true;
            RelativePayloadMassLabel.Location = new Point(12, 44);
            RelativePayloadMassLabel.Name = "RelativePayloadMassLabel";
            RelativePayloadMassLabel.Size = new Size(235, 15);
            RelativePayloadMassLabel.TabIndex = 2;
            RelativePayloadMassLabel.Text = "Относительная масса полезной нагрузки";
            RelativePayloadMassLabel.Click += RelativePayloadMassLabel_Click;
            // 
            // RelativeMassOfEquipmentLabel
            // 
            RelativeMassOfEquipmentLabel.AutoSize = true;
            RelativeMassOfEquipmentLabel.Location = new Point(23, 108);
            RelativeMassOfEquipmentLabel.Name = "RelativeMassOfEquipmentLabel";
            RelativeMassOfEquipmentLabel.Size = new Size(196, 15);
            RelativeMassOfEquipmentLabel.TabIndex = 3;
            RelativeMassOfEquipmentLabel.Text = "Относительная масса аппаратуры";
            RelativeMassOfEquipmentLabel.Click += RelativeMassOfEquipmentLabel_Click;
            // 
            // RelativeMassOfEquipmentTextBox
            // 
            RelativeMassOfEquipmentTextBox.Location = new Point(66, 139);
            RelativeMassOfEquipmentTextBox.Name = "RelativeMassOfEquipmentTextBox";
            RelativeMassOfEquipmentTextBox.Size = new Size(100, 23);
            RelativeMassOfEquipmentTextBox.TabIndex = 4;
            RelativeMassOfEquipmentTextBox.TextChanged += RelativeMassOfEquipmentTextBox_TextChanged;
            // 
            // RelativeMassOfEngineSystemLabel
            // 
            RelativeMassOfEngineSystemLabel.AutoSize = true;
            RelativeMassOfEngineSystemLabel.Location = new Point(43, 182);
            RelativeMassOfEngineSystemLabel.Name = "RelativeMassOfEngineSystemLabel";
            RelativeMassOfEngineSystemLabel.Size = new Size(145, 15);
            RelativeMassOfEngineSystemLabel.TabIndex = 5;
            RelativeMassOfEngineSystemLabel.Text = "Относительная масса ДУ";
            RelativeMassOfEngineSystemLabel.Click += RelativeMassOfEngineSystemLabel_Click;
            // 
            // RelativeMassOfEngineSystemTextBox
            // 
            RelativeMassOfEngineSystemTextBox.Location = new Point(66, 210);
            RelativeMassOfEngineSystemTextBox.Name = "RelativeMassOfEngineSystemTextBox";
            RelativeMassOfEngineSystemTextBox.Size = new Size(100, 23);
            RelativeMassOfEngineSystemTextBox.TabIndex = 6;
            RelativeMassOfEngineSystemTextBox.TextChanged += RelativeMassOfEngineSystemTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 467);
            Controls.Add(RelativeMassOfEngineSystemTextBox);
            Controls.Add(RelativeMassOfEngineSystemLabel);
            Controls.Add(RelativeMassOfEquipmentTextBox);
            Controls.Add(RelativeMassOfEquipmentLabel);
            Controls.Add(RelativePayloadMassLabel);
            Controls.Add(RelativePayloadMassTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RelativePayloadMassTextBox;
        private Label RelativePayloadMassLabel;
        private Label RelativeMassOfEquipmentLabel;
        private TextBox RelativeMassOfEquipmentTextBox;
        private Label RelativeMassOfEngineSystemLabel;
        private TextBox RelativeMassOfEngineSystemTextBox;
    }
}
