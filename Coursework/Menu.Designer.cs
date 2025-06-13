namespace Coursework
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            warning = new Panel();
            pictureBox1 = new PictureBox();
            UnsavedChanges = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            rbJSON = new RadioButton();
            rbXML = new RadioButton();
            label4 = new Label();
            label1 = new Label();
            dgv = new DataGridView();
            btnStartProcess = new Button();
            btnError = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBox2 = new GroupBox();
            btnTotalPrice = new Button();
            groupBox1.SuspendLayout();
            warning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 33);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(216, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 33);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 33);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(warning);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(rbJSON);
            groupBox1.Controls.Add(rbXML);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(712, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 160);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "File";
            // 
            // warning
            // 
            warning.Controls.Add(pictureBox1);
            warning.Controls.Add(UnsavedChanges);
            warning.Location = new Point(164, 27);
            warning.Name = "warning";
            warning.Size = new Size(145, 41);
            warning.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // UnsavedChanges
            // 
            UnsavedChanges.AutoSize = true;
            UnsavedChanges.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UnsavedChanges.ForeColor = Color.Black;
            UnsavedChanges.Location = new Point(32, 7);
            UnsavedChanges.Name = "UnsavedChanges";
            UnsavedChanges.Size = new Size(97, 26);
            UnsavedChanges.TabIndex = 25;
            UnsavedChanges.Text = "You have \r\nunsaved changes";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(166, 97);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(6, 97);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(140, 37);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // rbJSON
            // 
            rbJSON.AutoSize = true;
            rbJSON.Checked = true;
            rbJSON.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbJSON.ForeColor = Color.Black;
            rbJSON.Location = new Point(25, 38);
            rbJSON.Name = "rbJSON";
            rbJSON.Size = new Size(69, 25);
            rbJSON.TabIndex = 12;
            rbJSON.TabStop = true;
            rbJSON.Text = "JSON";
            rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            rbXML.AutoSize = true;
            rbXML.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbXML.ForeColor = Color.Black;
            rbXML.Location = new Point(100, 38);
            rbXML.Name = "rbXML";
            rbXML.Size = new Size(61, 25);
            rbXML.TabIndex = 11;
            rbXML.Text = "XML";
            rbXML.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 19);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 5;
            label4.Text = "Select file type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 16;
            label1.Text = "Digital Scales";
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgv.Location = new Point(27, 53);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new Size(666, 432);
            dgv.TabIndex = 15;
            // 
            // btnStartProcess
            // 
            btnStartProcess.Location = new Point(712, 335);
            btnStartProcess.Name = "btnStartProcess";
            btnStartProcess.Size = new Size(312, 46);
            btnStartProcess.TabIndex = 23;
            btnStartProcess.Text = "Start the packing process";
            btnStartProcess.UseVisualStyleBackColor = true;
            btnStartProcess.Click += btnStartProcess_Click;
            // 
            // btnError
            // 
            btnError.Location = new Point(712, 387);
            btnError.Name = "btnError";
            btnError.Size = new Size(312, 46);
            btnError.TabIndex = 24;
            btnError.Text = "Total weighing error";
            btnError.UseVisualStyleBackColor = true;
            btnError.Click += btnError_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(712, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 88);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Work with scales";
            // 
            // btnTotalPrice
            // 
            btnTotalPrice.Location = new Point(712, 439);
            btnTotalPrice.Name = "btnTotalPrice";
            btnTotalPrice.Size = new Size(312, 46);
            btnTotalPrice.TabIndex = 26;
            btnTotalPrice.Text = "Total price for packed products";
            btnTotalPrice.UseVisualStyleBackColor = true;
            btnTotalPrice.Click += btnTotalPrice_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 531);
            Controls.Add(btnTotalPrice);
            Controls.Add(groupBox2);
            Controls.Add(btnError);
            Controls.Add(btnStartProcess);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            warning.ResumeLayout(false);
            warning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnLoad;
        private Button btnSave;
        private RadioButton rbJSON;
        private RadioButton rbXML;
        private Label label4;
        private Label label1;
        private DataGridView dgv;
        private Button btnStartProcess;
        private Button btnError;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel warning;
        private PictureBox pictureBox1;
        private Label UnsavedChanges;
        private Button btnTotalPrice;
        private GroupBox groupBox2;
    }
}
