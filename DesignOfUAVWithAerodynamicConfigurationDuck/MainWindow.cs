namespace DesignOfUAVWithAerodynamicConfigurationDuck
{
    public partial class MainWindow : Form
    {
        public float RelativePayloadMass { get; set; } // Относительная масса ПН
        public float RelativeMassOfEquipment { get; set; } // Относительная масса аппаратуры
        public float RelativePayloadOfEngineSystem { get; set; } // Относительная масса ДУ
        public float PayloadMass { get; set; } // Масса ПН
        public float StartingWeight { get; set; } // Стартовая масса БПЛА

        DataProcessor dataProcessor;

        public MainWindow()
        {
            InitializeComponent();
            dataProcessor = DataProcessor.GetCalculateObject();
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

        }
        private void PayloadMassTextBox_TextChanged(object sender, EventArgs e)
        {
            PayloadMass = ManipulationClass.ConvertTo(PayloadMassTextBox.Text);
        }

        private void RelativePayloadMassTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativePayloadMass = ManipulationClass.ConvertTo(RelativePayloadMassTextBox.Text);
        }

        private void RelativeMassOfEquipmentTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativeMassOfEquipment = ManipulationClass.ConvertTo(RelativeMassOfEquipmentTextBox.Text);
        }

        private void RelativeMassOfEngineSystemTextBox_TextChanged(object sender, EventArgs e)
        {
            RelativePayloadOfEngineSystem = ManipulationClass.ConvertTo(RelativeMassOfEngineSystemTextBox.Text);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            dataProcessor.CalculateOfStartingMass(PayloadMass, RelativePayloadMass);
            MessageBox.Show(Convert.ToString(dataProcessor.StartingMass));
        }
    }
}
