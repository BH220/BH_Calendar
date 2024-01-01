using BH_Calendar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BH_Calendar
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Icon = Resources.MainIcon;
            base.OnLoad(e);
        }
    }
}
