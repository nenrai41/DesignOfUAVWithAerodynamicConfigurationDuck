namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public partial class MainWindow : Form
    {
        public double RelativePayloadMass { get; set; }
        public double RelativeMassOfEquipment { get; set; }
        public double RelativePayloadOfEngineSystem { get; set; }
        public double PayloadMass { get; set; }
        public double StartingWeight { get; set; }
         
        public MainWindow()
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
        private void PayloadMassLabel_Click(object sender, EventArgs e) 
        {
            MessageBox.Show(Convert.ToString(CalculateOfMass.CalculateOfStartingMass(PayloadMass, RelativePayloadMass)));
        }
        private void PayloadMassTextBox_TextChanged(object sender, EventArgs e)
        {
            PayloadMass = Convert.ToDouble(PayloadMassTextBox.Text);
        }
        
        private void RelativePayloadMassTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativePayloadMass = Convert.ToDouble(RelativePayloadMassTextBox.Text);
        }

        private void RelativeMassOfEquipmentTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativePayloadMass = Convert.ToDouble(RelativeMassOfEquipmentTextBox.Text);
        }

        private void RelativeMassOfEngineSystemTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativePayloadOfEngineSystem = Convert.ToDouble(RelativeMassOfEngineSystemTextBox.Text);
        }
    }
}
