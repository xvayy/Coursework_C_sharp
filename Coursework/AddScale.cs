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
    public partial class AddScale : Form
    {

        public DigitalScale NewScale { get; private set; }

        public AddScale()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(txtMass.Text);
                double min = double.Parse(txtMin.Text);
                double max = double.Parse(txtMax.Text);
                double error = double.Parse(txtError.Text);
                double price = 0;

                RealNumber weight = new RealNumber(mass, min, max);

                DigitalScale scale = new DigitalScale(0, mass, min, max, error, price);

                NewScale = scale;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Mass, limits, error, and price must be numeric values.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Data error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddScale_Load(object sender, EventArgs e)
        {

        }
    }
}
