using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DepMon.Provider;
using DepMon.Core;

namespace DepMon.Test.SampleApp
{
    public partial class FormMain : Form
    {
        private BindingList<ILine> _lines = new BindingList<ILine>();
        private BindingList<IStation> _stations = new BindingList<IStation>();
        private BindingList<IProvider> _providers = new BindingList<IProvider>();

        private IStation _selectedStation = null;
        private IProvider _selectedProvider = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // setup binding
            comboBoxProviders.DataSource = _providers;
            comboBoxProviders.DisplayMember = "Name";

            listBoxStations.DataSource = _stations;
            listBoxStations.DisplayMember = "Name";

            listBoxLines.DataSource = _lines;
            listBoxLines.DisplayMember = "Name";
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                // let the user choose a provider
                DialogResult result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // load provider
                    string file = fileDialog.FileName;
                    ProviderManager.AddProviderAssembly(file);
                    // update list of providers
                    var knownProviders = ProviderManager.ListAllKnownProviders();

                    _providers.Clear();
                    foreach (IProvider provider in knownProviders)
                    {
                        _providers.Add(provider);
                    }
                }
            }
        }

        private void comboBoxProviders_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedProvider = comboBoxProviders.SelectedItem as IProvider;
        }

        private void buttonSearchStation_Click(object sender, EventArgs e)
        {
            var stations = _selectedProvider.StationService.FindStationByName(textBoxStationSearchTerm.Text);
            OverwriteList(_stations, stations);
        }

        private void buttonSelectStation_Click(object sender, EventArgs e)
        {
            IStation station = listBoxStations.SelectedItem as IStation;

            _selectedStation = station;

            var lines = _selectedProvider.StationService.GetLines(station);
            OverwriteList(_lines, lines);
        }

        private void buttonCreateQuery_Click(object sender, EventArgs e)
        {
            ILine line = listBoxLines.SelectedItem as ILine;

            IDepartureQuery query = _selectedProvider.DepartureService.CreateQuery(line, _selectedStation);

            DepartureQueryRepository repo = new DepartureQueryRepository();
            repo.Add(query, _selectedProvider);
        }

        private void OverwriteList<T>(IList<T> list, IEnumerable<T> newItems)
        {
            list.Clear();
            foreach (T item in newItems)
            {
                list.Add(item);
            }
        }

        private void buttonUpdateDepartures_Click(object sender, EventArgs e)
        {
            dataGridViewDepartures.Rows.Clear();

            DepartureQueryRepository repo = new DepartureQueryRepository();

            var providers = ProviderManager.ListAllKnownProviders();
            foreach (IProvider provider in providers)
            {
                var queries = repo.ListAll(provider);
                foreach (IDepartureQuery query in queries)
                {
                    IDeparture departure = provider.DepartureService.QueryNextDeparture(query);

                    object[] values = new object[] {
                        provider.Name,
                        departure.Station.Name,
                        departure.Line.Name,
                        departure.DepartureTime.ToShortTimeString()
                    };

                    dataGridViewDepartures.Rows.Add(values);
                }
            }
        }
    }
}
