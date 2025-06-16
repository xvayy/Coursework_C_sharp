namespace Coursework
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblTotalError = new Label();
            totalWeighingEntries = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(524, 40);
            label1.TabIndex = 1;
            label1.Text = "The formula for the total weighing error";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(49, 226);
            label2.Name = "label2";
            label2.Size = new Size(344, 30);
            label2.TabIndex = 2;
            label2.Text = "Number of weighings on all scales = ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 302);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 315);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 5;
            label3.Text = "=";
            // 
            // lblTotalError
            // 
            lblTotalError.AutoSize = true;
            lblTotalError.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTotalError.ForeColor = Color.Red;
            lblTotalError.Location = new Point(190, 304);
            lblTotalError.Name = "lblTotalError";
            lblTotalError.Size = new Size(33, 40);
            lblTotalError.TabIndex = 6;
            lblTotalError.Text = "0";
            // 
            // totalWeighingEntries
            // 
            totalWeighingEntries.AutoSize = true;
            totalWeighingEntries.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalWeighingEntries.ForeColor = Color.Black;
            totalWeighingEntries.Location = new Point(390, 226);
            totalWeighingEntries.Name = "totalWeighingEntries";
            totalWeighingEntries.Size = new Size(27, 32);
            totalWeighingEntries.TabIndex = 7;
            totalWeighingEntries.Text = "0";
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(567, 370);
            Controls.Add(totalWeighingEntries);
            Controls.Add(lblTotalError);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Error";
            Text = "Error";
            Load += Error_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lblTotalError;
        private Label totalWeighingEntries;
    }
}