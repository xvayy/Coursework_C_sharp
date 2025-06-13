using System.ComponentModel;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Menu : Form
    {
        private IScaleManager scaleManager;
        private PackingWorkshop packingWorkshop;
        private string path;
        private bool isModified = false;

        public Menu()
        {
            InitializeComponent();
            scaleManager = new ScaleManager();
            Product product = new Product("Chicken", 689, 85, 12);
            packingWorkshop = new PackingWorkshop(scaleManager, "Meat", product);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            /*scaleManager.AddScale(new DigitalScale(0, 12.5, 0.0, 50.0, 0.01, 100));
            scaleManager.AddScale(new DigitalScale(0, 8.3, 0.0, 40.0, 0.02, 80));
            scaleManager.AddScale(new DigitalScale(0, 5.0, 0.0, 30.0, 0.015, 120));
            scaleManager.AddScale(new DigitalScale(0, 20.0, 5.0, 50.0, 0.005, 150));
            scaleManager.AddScale(new DigitalScale(0, 18.2, 0.0, 60.0, 0.01, 90));
            scaleManager.AddScale(new DigitalScale(0, 10.0, 0.0, 25.0, 0.02, 75));
            scaleManager.AddScale(new DigitalScale(0, 14.4, 0.0, 45.0, 0.012, 110));
            scaleManager.AddScale(new DigitalScale(0, 9.9, 0.0, 20.0, 0.01, 95));
            scaleManager.AddScale(new DigitalScale(0, 22.1, 10.0, 60.0, 0.008, 130));
            scaleManager.AddScale(new DigitalScale(0, 16.7, 0.0, 35.0, 0.01, 105));
            scaleManager.AddScale(new DigitalScale(0, 12.5, 0.0, 50.0, 0.01, 100));
            scaleManager.AddScale(new DigitalScale(0, 8.3, 0.0, 40.0, 0.02, 80));
            scaleManager.AddScale(new DigitalScale(0, 5.0, 0.0, 30.0, 0.015, 120));
            scaleManager.AddScale(new DigitalScale(0, 20.0, 5.0, 50.0, 0.005, 150));
            scaleManager.AddScale(new DigitalScale(0, 18.2, 0.0, 60.0, 0.01, 90));
            scaleManager.AddScale(new DigitalScale(0, 10.0, 0.0, 25.0, 0.02, 75));
            scaleManager.AddScale(new DigitalScale(0, 14.4, 0.0, 45.0, 0.012, 110));
            scaleManager.AddScale(new DigitalScale(0, 9.9, 0.0, 20.0, 0.01, 95));
            scaleManager.AddScale(new DigitalScale(0, 22.1, 10.0, 60.0, 0.008, 130));
            scaleManager.AddScale(new DigitalScale(0, 16.7, 0.0, 35.0, 0.01, 105));*/
            RefreshGrid();

        }

        private void RefreshGrid()
        {

            dgv.DataSource = null;
            dgv.DataSource = scaleManager.GetAllScales();
            dgv.AutoGenerateColumns = true;
            dgv.Columns["Id"].FillWeight = 50;
            dgv.Columns["UnitPrice"].Visible = false;
            dgv.Columns["MeasuredWeight"].Visible = false;
            warning.Visible = isModified;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScale addScaleForm = new AddScale();

            if (addScaleForm.ShowDialog() == DialogResult.OK)
            {
                scaleManager.AddScale(addScaleForm.NewScale);
                isModified = true;
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                int rowIndex = dgv.CurrentRow.Index;
                var selectedScale = dgv.Rows[rowIndex].DataBoundItem as DigitalScale;

                if (selectedScale == null)
                {
                    MessageBox.Show("Failed to get scale object.");
                    return;
                }

                EditScale editForm = new EditScale
                {
                    ScaleToEdit = selectedScale
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    isModified = true;
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a scale to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                int rowIndex = dgv.CurrentRow.Index;
                var selectedScale = dgv.Rows[rowIndex].DataBoundItem as DigitalScale;

                if (selectedScale == null)
                {
                    MessageBox.Show("Cannot get selected scale.", "Error");
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this Digital Scale?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int indexToRemove = scaleManager.FindScaleIndexById(selectedScale.Id);
                    if (indexToRemove >= 0)
                    {
                        scaleManager.RemoveScale(indexToRemove);
                        isModified = true;
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Scale not found in collection.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Digital Scale to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                int rowIndex = dgv.CurrentRow.Index;
                var selectedScale = dgv.Rows[rowIndex].DataBoundItem as DigitalScale;
                Packing packingForm = new Packing(selectedScale, packingWorkshop);
                packingForm.ShowDialog();
                RefreshGrid();

            }
            else
            {
                MessageBox.Show("Please select a Digital Scale to start the process.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            int totalLogs = 0;
            foreach (var scale in scaleManager)
            {
                totalLogs += scale.GetWeighingLog().Count;
            }

            if (totalLogs == 0)
            {
                MessageBox.Show("No scales have been used for weighing yet", "No Logs",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Error error = new Error(scaleManager);
            error.ShowDialog();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedExtension = rbJSON.Checked ? ".json" : rbXML.Checked ? ".xml" : null;

            if (selectedExtension == null)
            {
                MessageBox.Show("Please select a file format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Якщо шлях не задано або файл не існує — відкриваємо SaveFileDialog
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Select location to save";
                sfd.Filter = rbJSON.Checked ? "JSON Files|*.json" : "XML Files|*.xml";
                sfd.InitialDirectory = Application.StartupPath;
                sfd.OverwritePrompt = true;

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("No file selected to save.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                path = sfd.FileName;
            }

            // 🔍 Захист: якщо розширення НЕ збігається з форматом, не перезаписуємо
            string actualExtension = Path.GetExtension(path).ToLower();
            if (actualExtension != selectedExtension)
            {
                DialogResult result = MessageBox.Show(
                    $"The selected file has extension \"{actualExtension}\" but you selected format \"{selectedExtension}\".\n\n" +
                    "Do you want to choose another file to prevent overwriting?",
                    "Format Mismatch",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Save as";
                    sfd.Filter = rbJSON.Checked ? "JSON Files|*.json" : "XML Files|*.xml";
                    sfd.InitialDirectory = Application.StartupPath;

                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    path = sfd.FileName;
                }
                else
                {
                    // Відміна
                    MessageBox.Show("Saving cancelled to avoid overwriting the existing file.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            try
            {
                if (rbJSON.Checked)
                    scaleManager.SaveToJson(path);

                else if (rbXML.Checked)
                    scaleManager.SaveToXml(path);

                isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving failed: " + ex.Message, "Error");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save them before loading another file?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                    return;

                if (result == DialogResult.Yes)
                {
                    btnSave_Click(null, null); // викликаємо збереження
                    if (isModified) return; // якщо після збереження файл не було обрано, зберігання скасовано
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select file to load";
            ofd.Filter = rbJSON.Checked ? "JSON Files|*.json" : "XML Files|*.xml";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("No file selected for loading.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            path = ofd.FileName;

            try
            {
                if (rbJSON.Checked)
                    scaleManager.LoadFromJson(path);
                else if (rbXML.Checked)
                    scaleManager.LoadFromXml(path);
                else
                {
                    MessageBox.Show("Please select a file format.", "Warning");
                    return;
                }

                isModified = false;
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading failed: " + ex.Message, "Error");
            }
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            double total = packingWorkshop.TotalPrice;
            MessageBox.Show($"Total packed product price: {total:F2} UAH",
                "Total Price",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
