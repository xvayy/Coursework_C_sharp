namespace Coursework
{
    partial class Packing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packing));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtTotal = new TextBox();
            txtPrice = new TextBox();
            txtMass = new TextBox();
            groupBox2 = new GroupBox();
            lblPackageCount = new Label();
            lblPackageWeight = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lblError = new Label();
            lblMax = new Label();
            lblMin = new Label();
            lblId = new Label();
            label7 = new Label();
            label6 = new Label();
            label12 = new Label();
            label15 = new Label();
            btnPack = new Button();
            btnWeight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtMass);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 481);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtTotal.ForeColor = Color.Firebrick;
            txtTotal.Location = new Point(270, 285);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(98, 33);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0.0";
            txtTotal.TextAlign = HorizontalAlignment.Center;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPrice.ForeColor = Color.Firebrick;
            txtPrice.Location = new Point(163, 285);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(98, 33);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "0.0";
            txtPrice.TextAlign = HorizontalAlignment.Center;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtMass
            // 
            txtMass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtMass.ForeColor = Color.Firebrick;
            txtMass.Location = new Point(52, 285);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(99, 33);
            txtMass.TabIndex = 1;
            txtMass.Text = "0.0";
            txtMass.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPackageCount);
            groupBox2.Controls.Add(lblPackageWeight);
            groupBox2.Controls.Add(lblPrice);
            groupBox2.Controls.Add(lblQuantity);
            groupBox2.Controls.Add(lblName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(470, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 121);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prodict info";
            // 
            // lblPackageCount
            // 
            lblPackageCount.AutoSize = true;
            lblPackageCount.Location = new Point(342, 71);
            lblPackageCount.Name = "lblPackageCount";
            lblPackageCount.Size = new Size(87, 15);
            lblPackageCount.TabIndex = 9;
            lblPackageCount.Text = "Package Count";
            // 
            // lblPackageWeight
            // 
            lblPackageWeight.AutoSize = true;
            lblPackageWeight.Location = new Point(224, 71);
            lblPackageWeight.Name = "lblPackageWeight";
            lblPackageWeight.Size = new Size(90, 15);
            lblPackageWeight.TabIndex = 8;
            lblPackageWeight.Text = "Package weight";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(162, 71);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(80, 71);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(342, 36);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 4;
            label5.Text = "Package Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(224, 36);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Package weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(162, 36);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(80, 36);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblError);
            groupBox3.Controls.Add(lblMax);
            groupBox3.Controls.Add(lblMin);
            groupBox3.Controls.Add(lblId);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(470, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(448, 105);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selected scale additionaly info";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(297, 67);
            lblError.Name = "lblError";
            lblError.Size = new Size(86, 15);
            lblError.TabIndex = 9;
            lblError.Text = "Weighing error";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(216, 67);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 8;
            lblMax.Text = "Max";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(134, 67);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 7;
            lblMin.Text = "Min";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(70, 67);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(297, 36);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 5;
            label7.Text = "Weighing error";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(216, 36);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 4;
            label6.Text = "Max";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.Location = new Point(134, 36);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 3;
            label12.Text = "Min";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.Location = new Point(70, 36);
            label15.Name = "label15";
            label15.Size = new Size(18, 15);
            label15.TabIndex = 0;
            label15.Text = "Id";
            // 
            // btnPack
            // 
            btnPack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPack.Location = new Point(470, 454);
            btnPack.Name = "btnPack";
            btnPack.Size = new Size(448, 53);
            btnPack.TabIndex = 5;
            btnPack.Text = "Pack";
            btnPack.UseVisualStyleBackColor = true;
            btnPack.Click += btnPack_Click;
            // 
            // btnWeight
            // 
            btnWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnWeight.Location = new Point(470, 395);
            btnWeight.Name = "btnWeight";
            btnWeight.Size = new Size(448, 53);
            btnWeight.TabIndex = 7;
            btnWeight.Text = "Weight";
            btnWeight.UseVisualStyleBackColor = true;
            btnWeight.Click += btnWeight_Click;
            // 
            // Packing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 540);
            Controls.Add(btnWeight);
            Controls.Add(btnPack);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Packing";
            Text = "Packing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtMass;
        private GroupBox groupBox2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblPackageCount;
        private Label lblPackageWeight;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblName;
        private GroupBox groupBox3;
        private Label label12;
        private Label label15;
        private Label label6;
        private Label label7;
        private TextBox txtTotal;
        private TextBox txtPrice;
        private Button btnPack;
        private Label lblError;
        private Label lblMax;
        private Label lblMin;
        private Label lblId;
        private Button btnWeight;
    }
}