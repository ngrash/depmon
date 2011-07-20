using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace DepMon
{
    class AppIcon
    {
        private const string _IconResourceName = "DepMon.homenet.ico";

        public event EventHandler Exit;

        protected void OnExit(object sender, EventArgs e)
        {
            if (Exit != null)
                Exit(sender, e);
        }

        NotifyIcon _notifyIcon = null;

        public AppIcon()
        {
            // load icon from resource
            Icon icon;
            using (Stream iconStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_IconResourceName))
            {
                icon = new Icon(iconStream);
            }
            
            // create context menu
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripButton menuItemExit = new ToolStripButton("Exit");
            menuItemExit.Click += (s, e) => DoExit();
            menu.Items.Add(menuItemExit);

            // create notify icon
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = icon;
            _notifyIcon.ContextMenuStrip = menu;
        }

        public void Show()
        {
            _notifyIcon.Visible = true;
        }

        public void Hide()
        {
            _notifyIcon.Visible = false;
        }

        private void DoExit()
        {
            Hide();
            OnExit(this, EventArgs.Empty);
        }
    }
}
