using System;
using System.Windows.Forms;

namespace LabWork1
{
    public partial class ClientSettingsForm : Form
    {
        private ClientForm _clientForm;
        private IDrawerMatrix _drawer;
        private IDrawerDisplay _display;
        private IGraphicsPrimitives _graphicsPrimetives;
        private IConsolePrimitives _consolePrimetives;
        public ClientSettingsForm(ClientForm clientForm)
        {
            InitializeComponent();
            comboBoxBorderType.Enabled = false;
            _clientForm = clientForm;
            _drawer = _clientForm.Drawer;
            _display = _clientForm.Display;
            _graphicsPrimetives = _clientForm.GraphicsPrimitives;
            _consolePrimetives = _clientForm.ConsolePrimitives;
            VisualComboBoxes();

        }
        private void SaveCharacteris()
        {
            switch (comboBoxBorderHave.SelectedIndex)
            {
                case 0:
                    SwitchDisplay();
                    _drawer = new DrawerWithoutBorder(_display);
                    break;
                case 1:
                    SwitchBorderType();
                    _drawer = new DrawerWithBorder(_display);
                    break;

            }
            _clientForm.Drawer = _drawer;
            _clientForm.Display = _display;
            _clientForm.GraphicsPrimitives = _graphicsPrimetives;
            _clientForm.ConsolePrimitives = _consolePrimetives;

        }
        private void VisualComboBoxes()
        {
            if (_display != null)
            {
                switch (_display.GetIndex)
                {
                    case 0:
                        comboBoxDisplayMatrix.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxDisplayMatrix.SelectedIndex = 1;
                        break;

                }

            }
            if (_drawer != null)
            {
                switch (_drawer.GetIndex)
                {
                    case 0:
                        comboBoxBorderHave.SelectedIndex = 0;
                        return;
                    case 1:
                        comboBoxBorderHave.SelectedIndex = 1;
                        break;

                }

            }
            if (_graphicsPrimetives != null)
            {
                switch (_graphicsPrimetives.GetIndex)
                {
                    case 0:
                        comboBoxBorderType.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxBorderType.SelectedIndex = 1;
                        break;

                }

            }
            if (_consolePrimetives != null)
            {
                switch (_consolePrimetives.GetIndex)
                {
                    case 0:
                        comboBoxBorderType.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBoxBorderType.SelectedIndex = 1;
                        break;

                }

            }

        }
        private void SwitchDisplay()
        {
            switch (comboBoxDisplayMatrix.SelectedIndex)
            {
                case 0:
                    _consolePrimetives = new ConsolePrimitives();
                    _display = new ConsoleDisplay(_consolePrimetives);
                    break;
                case 1:
                    _graphicsPrimetives = new GraphicsPrimitives();
                    _display = new GraphicsDisplay(_clientForm.GetPanelDrawing(), _graphicsPrimetives);
                    break;

            }

        }
        private void SwitchBorderType()
        {
            switch (comboBoxBorderType.SelectedIndex)
            {
                case 0:
                    SwitchDisplay();
                    break;
                case 1:
                    switch (comboBoxDisplayMatrix.SelectedIndex)
                    {
                        case 0:
                            _consolePrimetives = new DecoratorConsoleDoubleLine(new ConsolePrimitives());
                            _display = new ConsoleDisplay(_consolePrimetives);
                            break;
                        case 1:
                            _graphicsPrimetives = new GraphicsPrimitives(); //Добавить декоратор!
                            _display = new GraphicsDisplay(_clientForm.GetPanelDrawing(), _graphicsPrimetives);
                            break;

                    }
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
