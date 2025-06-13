using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Error : Form
    {
        private readonly IScaleManager scaleManager;
        public Error(IScaleManager manager)
        {
            InitializeComponent();
            scaleManager = manager;
        }

        private void Error_Load(object sender, EventArgs e)
        {
            int totalLogs = 0;
            foreach (var scale in scaleManager)
            {
                totalLogs += scale.GetWeighingLog().Count;
            }

            double totalError = scaleManager.CalculateTotalWeighingError();

            totalWeighingEntries.Text = totalLogs.ToString();
            lblTotalError.Text = totalError.ToString("F4");

        }
    }
}
