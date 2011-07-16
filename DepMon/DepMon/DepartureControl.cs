using System;
using System.Windows.Forms;
using DepMon.Provider;

namespace DepMon
{
    public partial class DepartureControl : UserControl
    {
        IDeparture _departure = null;

        public DepartureControl()
        {
            InitializeComponent();
        }

        public void SetDeparture(IDeparture departure)
        {
            _departure = departure;

            labelDestination.Text = departure.Line.Destination.ToString();
            labelLine.Text = departure.Line.ToString();
            labelTime.Text = departure.DepartureTime.ToShortTimeString();

            UpdateTimeRemaining();
        }

        public void UpdateTimeRemaining()
        {
            TimeSpan timeRemaining = _departure.DepartureTime - DateTime.Now;
            labelMinsRemaining.Text = timeRemaining.Minutes.ToString();
        }
    }
}
