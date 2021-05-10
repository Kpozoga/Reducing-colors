namespace gk_zad3
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reduceColorsButton = new System.Windows.Forms.Button();
            this.fullResButton = new System.Windows.Forms.Button();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kmeansAlgButton = new System.Windows.Forms.RadioButton();
            this.popularityAlgButton2 = new System.Windows.Forms.RadioButton();
            this.popularityAlgButton = new System.Windows.Forms.RadioButton();
            this.errorDiffusionButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.krLabel = new System.Windows.Forms.Label();
            this.kbNumeric = new System.Windows.Forms.NumericUpDown();
            this.kgNumeric = new System.Windows.Forms.NumericUpDown();
            this.krNumeric = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toGreyscaleButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(653, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toGreyscaleButton);
            this.groupBox1.Controls.Add(this.reduceColorsButton);
            this.groupBox1.Controls.Add(this.fullResButton);
            this.groupBox1.Controls.Add(this.loadPictureButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // reduceColorsButton
            // 
            this.reduceColorsButton.Location = new System.Drawing.Point(7, 106);
            this.reduceColorsButton.Name = "reduceColorsButton";
            this.reduceColorsButton.Size = new System.Drawing.Size(124, 23);
            this.reduceColorsButton.TabIndex = 2;
            this.reduceColorsButton.Text = "Reduce colors";
            this.reduceColorsButton.UseVisualStyleBackColor = true;
            this.reduceColorsButton.Click += new System.EventHandler(this.reduceColorsButton_Click);
            // 
            // fullResButton
            // 
            this.fullResButton.Location = new System.Drawing.Point(6, 48);
            this.fullResButton.Name = "fullResButton";
            this.fullResButton.Size = new System.Drawing.Size(125, 23);
            this.fullResButton.TabIndex = 1;
            this.fullResButton.Text = "View full resolution";
            this.fullResButton.UseVisualStyleBackColor = true;
            this.fullResButton.Click += new System.EventHandler(this.fullResButton_Click);
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(6, 19);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(125, 23);
            this.loadPictureButton.TabIndex = 0;
            this.loadPictureButton.Text = "Load new picture";
            this.loadPictureButton.UseVisualStyleBackColor = true;
            this.loadPictureButton.Click += new System.EventHandler(this.loadPictureButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kmeansAlgButton);
            this.groupBox2.Controls.Add(this.popularityAlgButton2);
            this.groupBox2.Controls.Add(this.popularityAlgButton);
            this.groupBox2.Controls.Add(this.errorDiffusionButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithms";
            // 
            // kmeansAlgButton
            // 
            this.kmeansAlgButton.AutoSize = true;
            this.kmeansAlgButton.Location = new System.Drawing.Point(7, 89);
            this.kmeansAlgButton.Name = "kmeansAlgButton";
            this.kmeansAlgButton.Size = new System.Drawing.Size(111, 17);
            this.kmeansAlgButton.TabIndex = 4;
            this.kmeansAlgButton.Text = "K-means algorithm";
            this.kmeansAlgButton.UseVisualStyleBackColor = true;
            this.kmeansAlgButton.CheckedChanged += new System.EventHandler(this.kmeansAlgButton_CheckedChanged);
            // 
            // popularityAlgButton2
            // 
            this.popularityAlgButton2.AutoSize = true;
            this.popularityAlgButton2.Location = new System.Drawing.Point(7, 66);
            this.popularityAlgButton2.Name = "popularityAlgButton2";
            this.popularityAlgButton2.Size = new System.Drawing.Size(122, 17);
            this.popularityAlgButton2.TabIndex = 3;
            this.popularityAlgButton2.Text = "Popularity algorithm2";
            this.popularityAlgButton2.UseVisualStyleBackColor = true;
            this.popularityAlgButton2.CheckedChanged += new System.EventHandler(this.popularityAlgButton2_CheckedChanged);
            // 
            // popularityAlgButton
            // 
            this.popularityAlgButton.AutoSize = true;
            this.popularityAlgButton.Location = new System.Drawing.Point(7, 43);
            this.popularityAlgButton.Name = "popularityAlgButton";
            this.popularityAlgButton.Size = new System.Drawing.Size(116, 17);
            this.popularityAlgButton.TabIndex = 1;
            this.popularityAlgButton.Text = "Popularity algorithm";
            this.popularityAlgButton.UseVisualStyleBackColor = true;
            this.popularityAlgButton.Click += new System.EventHandler(this.popularityAlgButton_Click);
            // 
            // errorDiffusionButton
            // 
            this.errorDiffusionButton.AutoSize = true;
            this.errorDiffusionButton.Checked = true;
            this.errorDiffusionButton.Location = new System.Drawing.Point(7, 19);
            this.errorDiffusionButton.Name = "errorDiffusionButton";
            this.errorDiffusionButton.Size = new System.Drawing.Size(132, 17);
            this.errorDiffusionButton.TabIndex = 0;
            this.errorDiffusionButton.TabStop = true;
            this.errorDiffusionButton.Text = "Error diffusion dithering";
            this.errorDiffusionButton.UseVisualStyleBackColor = true;
            this.errorDiffusionButton.CheckedChanged += new System.EventHandler(this.errorDiffusionButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.krLabel);
            this.groupBox3.Controls.Add(this.kbNumeric);
            this.groupBox3.Controls.Add(this.kgNumeric);
            this.groupBox3.Controls.Add(this.krNumeric);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coefficients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KG";
            // 
            // krLabel
            // 
            this.krLabel.AutoSize = true;
            this.krLabel.Location = new System.Drawing.Point(69, 20);
            this.krLabel.Name = "krLabel";
            this.krLabel.Size = new System.Drawing.Size(22, 13);
            this.krLabel.TabIndex = 3;
            this.krLabel.Text = "KR";
            // 
            // kbNumeric
            // 
            this.kbNumeric.Location = new System.Drawing.Point(7, 73);
            this.kbNumeric.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.kbNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kbNumeric.Name = "kbNumeric";
            this.kbNumeric.Size = new System.Drawing.Size(55, 20);
            this.kbNumeric.TabIndex = 2;
            this.kbNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // kgNumeric
            // 
            this.kgNumeric.Location = new System.Drawing.Point(7, 47);
            this.kgNumeric.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.kgNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kgNumeric.Name = "kgNumeric";
            this.kgNumeric.Size = new System.Drawing.Size(55, 20);
            this.kgNumeric.TabIndex = 1;
            this.kgNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // krNumeric
            // 
            this.krNumeric.Location = new System.Drawing.Point(7, 20);
            this.krNumeric.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.krNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.krNumeric.Name = "krNumeric";
            this.krNumeric.Size = new System.Drawing.Size(55, 20);
            this.krNumeric.TabIndex = 0;
            this.krNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 444);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toGreyscaleButton
            // 
            this.toGreyscaleButton.Location = new System.Drawing.Point(7, 77);
            this.toGreyscaleButton.Name = "toGreyscaleButton";
            this.toGreyscaleButton.Size = new System.Drawing.Size(124, 23);
            this.toGreyscaleButton.TabIndex = 3;
            this.toGreyscaleButton.Text = "Convert to greyscale";
            this.toGreyscaleButton.UseVisualStyleBackColor = true;
            this.toGreyscaleButton.Click += new System.EventHandler(this.toGrayscaleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "gk-3-color-reduction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fullResButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton popularityAlgButton;
        private System.Windows.Forms.RadioButton errorDiffusionButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label krLabel;
        private System.Windows.Forms.NumericUpDown kbNumeric;
        private System.Windows.Forms.NumericUpDown kgNumeric;
        private System.Windows.Forms.NumericUpDown krNumeric;
        private System.Windows.Forms.Button reduceColorsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton popularityAlgButton2;
        private System.Windows.Forms.RadioButton kmeansAlgButton;
        private System.Windows.Forms.Button toGreyscaleButton;
    }
}

