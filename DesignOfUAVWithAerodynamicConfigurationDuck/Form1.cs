namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public partial class Form1 : Form
    {
        private int relativePayloadMass;
        private int relativeMassOfEquipment;
        private int relativePayloadOfEngineSystem;
        public Form1()
        {
            InitializeComponent();
        }

        private void RelativePayloadMassLabel_Click(object sender, EventArgs e)
        {

        }
        private void RelativeMassOfEquipmentLabel_Click(object sender, EventArgs e)
        {

        }
        private void RelativeMassOfEngineSystemLabel_Click(object sender, EventArgs e)
        {

        }
        private void RelativePayloadMassTextBox_TextChanged(object sender, EventArgs e)
        {
            relativePayloadMass = Convert.ToInt32(RelativePayloadMassTextBox.Text);
        }

        private void RelativeMassOfEquipmentTextBox_TextChanged(object sender, EventArgs e)
        {
            relativePayloadMass = Convert.ToInt32(RelativeMassOfEquipmentTextBox.Text);
        }

        private void RelativeMassOfEngineSystemTextBox_TextChanged(object sender, EventArgs e)
        {
            relativePayloadOfEngineSystem = Convert.ToInt32(RelativeMassOfEngineSystemTextBox.Text);
        }
    }
}
