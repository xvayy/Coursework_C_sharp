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
    public partial class EditScale : Form
    {

        public DigitalScale ScaleToEdit { get; set; }

        public EditScale()
        {
            InitializeComponent();
        }

        private void EditScale_Load(object sender, EventArgs e)
        {
            if (ScaleToEdit != null)
            {
                txtMass.Text = ScaleToEdit.Weight.ToString();
                txtMin.Text = ScaleToEdit.MinWeight.ToString();
                txtMax.Text = ScaleToEdit.MaxWeight.ToString();
                txtError.Text = ScaleToEdit.WeighingError.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(txtMass.Text);
                double min = double.Parse(txtMin.Text);
                double max = double.Parse(txtMax.Text);
                double error = double.Parse(txtError.Text);

                ScaleToEdit.MinWeight = min;
                ScaleToEdit.MaxWeight = max;
                ScaleToEdit.Weight = mass;
                ScaleToEdit.WeighingError = error;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("All values must be valid numbers.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Validation error: " + ex.Message, "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
