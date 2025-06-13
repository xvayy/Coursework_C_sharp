namespace Coursework
{
    partial class AddScale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScale));
            btnCancel = new Button();
            btnAdd = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtError = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtMass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 402);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 26);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(65, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 26);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 275);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 45;
            label5.Text = "Weightning Error";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 229);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 44;
            label4.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 181);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 43;
            label3.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 139);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 42;
            label2.Text = "Weight";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(46, 199);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(162, 23);
            txtMin.TabIndex = 2;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(46, 247);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(162, 23);
            txtMax.TabIndex = 3;
            // 
            // txtError
            // 
            txtError.Location = new Point(46, 291);
            txtError.Name = "txtError";
            txtError.Size = new Size(162, 23);
            txtError.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(148, 43);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 52;
            label1.Text = "New Scale";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // txtMass
            // 
            txtMass.Location = new Point(46, 155);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(162, 23);
            txtMass.TabIndex = 1;
            // 
            // AddScale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(txtMass);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtError);
            Name = "AddScale";
            Text = "AddScale";
            Load += AddScale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtError;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtMass;
    }
}