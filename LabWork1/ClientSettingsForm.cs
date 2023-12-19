using System;
using System.Windows.Forms;

namespace LabWork1
{
    public partial class ClientSettingsForm : Form
    {
        private ClientForm _clientForm;
        public IDrawer Drawer { get; private set; }
        public IDisplay Display { get; private set; }
        public IDisplayFactory TypeBorder { get; private set; }
        public ClientSettingsForm(ClientForm clientForm)
        {
            InitializeComponent();
            comboBoxBorderType.Enabled = false;
            _clientForm = clientForm;
            Drawer = _clientForm.Drawer;
            Display = _clientForm.Display;
            TypeBorder = _clientForm.TypeBorder;
            VisualizationComboBoxes();

        }
        private void SaveCharacteris()
        {
            switch (comboBoxBorderHave.SelectedIndex)
            {
                case 0:
                    SingleLine();
                    Drawer = new DrawerWithoutBorder(Display);
                    break;
                case 1:
                    SwitchBorderType();
                    Drawer = new DrawerWithBorder(Display);
                    break;

            }
            _clientForm.SetSettings();

        }
        private void VisualizationComboBoxes()
        {
            /*if (Display != null)
            {
                switch (Display.GetIndex)
                {
                    case 0:
                        comboBoxDisplayMatrix.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxDisplayMatrix.SelectedIndex = 1;
                        break;

                }

            }
            if (Drawer != null)
            {
                switch (Drawer.GetIndex)
                {
                    case 0:
                        comboBoxBorderHave.SelectedIndex = 0;
                        return;
                    case 1:
                        comboBoxBorderHave.SelectedIndex = 1;
                        break;

                }

            }
            if (GraphicsPrimetives != null)
            {
                switch (GraphicsPrimetives.GetIndex)
                {
                    case 0:
                        comboBoxBorderType.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxBorderType.SelectedIndex = 1;
                        break;

                }

            }
            if (ConsolePrimetives != null)
            {
                switch (ConsolePrimetives.GetIndex)
                {
                    case 0:
                        comboBoxBorderType.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxBorderType.SelectedIndex = 1;
                        break;

                }

            }*/

        }
        private void SwitchBorderType()
        {
            switch (comboBoxBorderType.SelectedIndex)
            {
                case 0:
                    SingleLine();
                    break;
                case 1:
                    DoubleLine();
                    break;

            }

        }
        private void DoubleLine()
        {
            TypeBorder = new DoubleBorder();
            switch (comboBoxDisplayMatrix.SelectedIndex)
            {
                case 0:
                    Display = TypeBorder.CreateConsoleDisplay();
                    break;
                case 1:
                    Display = TypeBorder.CreateGraphicsDisplay(_clientForm.GetPanelDrawing());
                    break;

            }

        }
        private void SingleLine()
        {
            TypeBorder = new SingleBorder();
            switch (comboBoxDisplayMatrix.SelectedIndex)
            {
                case 0:
                    Display = TypeBorder.CreateConsoleDisplay();
                    break;
                case 1:
                    Display = TypeBorder.CreateGraphicsDisplay(_clientForm.GetPanelDrawing());
                    break;

            }

        }
        private void comboBoxBorderHave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBorderHave.SelectedIndex == 1)
            {
                comboBoxBorderType.Enabled = true;

            }
            else
            {
                comboBoxBorderType.Enabled = false;
                comboBoxBorderType.SelectedIndex = -1;

            }

        }
        private void buttonSaveSeettings_Click(object sender, EventArgs e)
        {
            SaveCharacteris();
            this.Close();

        }
        private void buttonApplySettings_Click(object sender, EventArgs e)
        {
            SaveCharacteris();

        }
        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }

}
