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
        private BindingList<IProvider> _providers = new BindingList<IProvider>();
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
                    _providers = new BindingList<IProvider>(knownProviders.ToArray());
                }
            }
        }
    }
}
