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
    public partial class Packing : Form
    {
        private readonly DigitalScale scale;
        private readonly PackingWorkshop pkw;

        public Packing(DigitalScale scale, PackingWorkshop workshop)
        {
            InitializeComponent();
            this.scale = scale;
            pkw = workshop;
            
            txtMass.Text = scale.Weight.ToString("F2");
            txtPrice.Text = pkw.UnitPrice.ToString("F2");
            txtTotal.Text = scale.CalculateTotalPrice().ToString("F2");
            lblId.Text = scale.Id.ToString();
            lblMin.Text = scale.MinWeight.ToString("F2");
            lblMax.Text = scale.MaxWeight.ToString("F2");
            lblError.Text = scale.WeighingError.ToString("F2");
            lblName.Text = pkw.ProductName;
            lblQuantity.Text = pkw.ProductQuantity.ToString("F2");
            lblPrice.Text = pkw.UnitPrice.ToString("F2");
            lblPackageWeight.Text = pkw.PackageWeight.ToString("F2");
            lblPackageCount.Text = pkw.PackageCount.ToString();
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            pkw.startPacking(scale);

            scale.ResetWeight();
            txtMass.Text = scale.Weight.ToString("F2");
            txtTotal.Text = "0.0";
            lblQuantity.Text = pkw.ProductQuantity.ToString("F2");
            lblPackageCount.Text = pkw.PackageCount.ToString();
            UpdateScaleImage();
        }

        private void UpdateScaleImage()
        {
            if (scale.Weight > 0)
            {
                pictureBox1.Image = Image.FromFile("product.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("scale.png");
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

            try
            {
                scale.UnitPrice = double.TryParse(txtPrice.Text, out double price) ? price : 0;
                txtTotal.Text = scale.UnitPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Text = scale.UnitPrice.ToString("F2");
            }

            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = scale.CalculateTotalPrice().ToString("F2");
        }
        
        private void btnWeight_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMass.Text, out double mass))
            {
                try
                {
                    scale.ResetWeight();
                    scale.AddWeight(mass);
                    txtTotal.Text = scale.CalculateTotalPrice().ToString("F2");
                }
                catch (Exception ex)
                {
                    scale.ResetWeight();
                    txtMass.Text = scale.Weight.ToString("F2");
                    MessageBox.Show("Error: " + ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtTotal.Text = "0.00";
            }

            UpdateScaleImage();
        }
    }
}
