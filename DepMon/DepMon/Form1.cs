using System;
using System.Windows.Forms;
using DepMon.ProviderManagement;
using DepMon.Core;

namespace DepMon
{
    public partial class Form1 : Form
    {
        private IProvider _selectedProvider = null;

        #region private view models

        class ProviderItem
        {
            public IProvider Provider { get; set; }

            public override string ToString()
            {
                return Provider.Name;
            }
        }

        class StationItem
        {
            public IStation Station { get; set; }

            public override string ToString()
            {
                return Station.Name;
            }
        }

        class LineItem
        {
            public ILine Line { get; set; }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearUI()
        {
            listBoxLines.Items.Clear();
            listBoxStations.Items.Clear();
            textBoxStation.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (IProvider provider in ProviderManager.ListAllKnownProviders())
            {
                comboBoxProviders.Items.Add(new ProviderItem() { Provider = provider });
            }

            if (comboBoxProviders.Items.Count > 0)
            {
                comboBoxProviders.SelectedIndex = 0;
            }
        }

        private void comboBoxProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearUI();

            ProviderItem selectedProviderItem = comboBoxProviders.SelectedItem as ProviderItem;
            if (selectedProviderItem != null)
            {
                _selectedProvider = selectedProviderItem.Provider;
            }
            else
            {
                _selectedProvider = null;
            }
        }

        private void buttonFindStation_Click(object sender, EventArgs e)
        {
            if (_selectedProvider == null)
            {
                MessageBox.Show("Select a provider first.");
                return;
            }

            if(textBoxStation.Text == string.Empty) {
                MessageBox.Show("Enter a station name to search for.");
                return;
            }

            listBoxStations.Items.Clear();
            var stations = _selectedProvider.StationService.FindStationByName(textBoxStation.Text);
            foreach (IStation station in stations)
            {
                listBoxStations.Items.Add(new StationItem() { Station = station });
            }
        }

        private void listBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationItem selectedStationItem = (StationItem)listBoxStations.SelectedItem;
            IStation selectedStation = selectedStationItem.Station;

            listBoxLines.Items.Clear();
            var lines = _selectedProvider.StationService.GetLines(selectedStation);
            foreach (ILine line in lines)
            {
                listBoxStations.Items.Add(new LineItem() { Line = line });
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
