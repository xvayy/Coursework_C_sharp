namespace Coursework
{
    partial class EditScale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScale));
            txtMass = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtError = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMass
            // 
            txtMass.Location = new Point(24, 145);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(162, 23);
            txtMass.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(120, 31);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 66;
            label1.Text = "Digital Scale";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(212, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 26);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(31, 392);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(159, 26);
            btnOk.TabIndex = 64;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 265);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 62;
            label5.Text = "Weightning Error";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 219);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 61;
            label4.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 171);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 60;
            label3.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 59;
            label2.Text = "Weight";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(24, 189);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(162, 23);
            txtMin.TabIndex = 55;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(24, 237);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(162, 23);
            txtMax.TabIndex = 56;
            // 
            // txtError
            // 
            txtError.Location = new Point(24, 281);
            txtError.Name = "txtError";
            txtError.Size = new Size(162, 23);
            txtError.TabIndex = 57;
            // 
            // EditScale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(txtMass);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtError);
            Name = "EditScale";
            Text = "EditScale";
            Load += EditScale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMass;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCancel;
        private Button btnOk;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtError;
    }
}