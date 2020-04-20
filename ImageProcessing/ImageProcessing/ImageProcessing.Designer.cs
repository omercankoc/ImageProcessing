namespace ImageProcessing
{
    partial class ImageProcessing
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
            this.In = new System.Windows.Forms.PictureBox();
            this.Out = new System.Windows.Forms.PictureBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.GreyScaleFilter = new System.Windows.Forms.Button();
            this.FilterRedComponent = new System.Windows.Forms.Button();
            this.FilterGreenComponent = new System.Windows.Forms.Button();
            this.FilterBlueComponent = new System.Windows.Forms.Button();
            this.MovingAverageFilter = new System.Windows.Forms.Button();
            this.MovingMedianFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.In)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out)).BeginInit();
            this.SuspendLayout();
            // 
            // In
            // 
            this.In.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In.Location = new System.Drawing.Point(12, 12);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(500, 500);
            this.In.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.In.TabIndex = 0;
            this.In.TabStop = false;
            // 
            // Out
            // 
            this.Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out.Location = new System.Drawing.Point(730, 12);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(500, 500);
            this.Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Out.TabIndex = 1;
            this.Out.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(518, 11);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(206, 23);
            this.SelectImage.TabIndex = 2;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // GreyScaleFilter
            // 
            this.GreyScaleFilter.Location = new System.Drawing.Point(518, 40);
            this.GreyScaleFilter.Name = "GreyScaleFilter";
            this.GreyScaleFilter.Size = new System.Drawing.Size(206, 23);
            this.GreyScaleFilter.TabIndex = 3;
            this.GreyScaleFilter.Text = "Grey Scale Filter";
            this.GreyScaleFilter.UseVisualStyleBackColor = true;
            this.GreyScaleFilter.Click += new System.EventHandler(this.GreyScaleFilter_Click);
            // 
            // FilterRedComponent
            // 
            this.FilterRedComponent.Location = new System.Drawing.Point(518, 69);
            this.FilterRedComponent.Name = "FilterRedComponent";
            this.FilterRedComponent.Size = new System.Drawing.Size(206, 23);
            this.FilterRedComponent.TabIndex = 4;
            this.FilterRedComponent.Text = "Filter Red Component ";
            this.FilterRedComponent.UseVisualStyleBackColor = true;
            this.FilterRedComponent.Click += new System.EventHandler(this.FilterRedComponent_Click);
            // 
            // FilterGreenComponent
            // 
            this.FilterGreenComponent.Location = new System.Drawing.Point(518, 98);
            this.FilterGreenComponent.Name = "FilterGreenComponent";
            this.FilterGreenComponent.Size = new System.Drawing.Size(206, 23);
            this.FilterGreenComponent.TabIndex = 5;
            this.FilterGreenComponent.Text = "Filter Green Component ";
            this.FilterGreenComponent.UseVisualStyleBackColor = true;
            this.FilterGreenComponent.Click += new System.EventHandler(this.FilterGreenComponent_Click);
            // 
            // FilterBlueComponent
            // 
            this.FilterBlueComponent.Location = new System.Drawing.Point(518, 127);
            this.FilterBlueComponent.Name = "FilterBlueComponent";
            this.FilterBlueComponent.Size = new System.Drawing.Size(206, 23);
            this.FilterBlueComponent.TabIndex = 6;
            this.FilterBlueComponent.Text = "Filter Blue Component";
            this.FilterBlueComponent.UseVisualStyleBackColor = true;
            this.FilterBlueComponent.Click += new System.EventHandler(this.FilterBlueComponent_Click);
            // 
            // MovingAverageFilter
            // 
            this.MovingAverageFilter.Location = new System.Drawing.Point(518, 156);
            this.MovingAverageFilter.Name = "MovingAverageFilter";
            this.MovingAverageFilter.Size = new System.Drawing.Size(206, 23);
            this.MovingAverageFilter.TabIndex = 7;
            this.MovingAverageFilter.Text = "Moving Average Filter";
            this.MovingAverageFilter.UseVisualStyleBackColor = true;
            this.MovingAverageFilter.Click += new System.EventHandler(this.MovingAverageFilter_Click);
            // 
            // MovingMedianFilter
            // 
            this.MovingMedianFilter.Location = new System.Drawing.Point(518, 185);
            this.MovingMedianFilter.Name = "MovingMedianFilter";
            this.MovingMedianFilter.Size = new System.Drawing.Size(206, 23);
            this.MovingMedianFilter.TabIndex = 8;
            this.MovingMedianFilter.Text = "Moving Median Filter";
            this.MovingMedianFilter.UseVisualStyleBackColor = true;
            this.MovingMedianFilter.Click += new System.EventHandler(this.MovingMedianFilter_Click);
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 525);
            this.Controls.Add(this.MovingMedianFilter);
            this.Controls.Add(this.MovingAverageFilter);
            this.Controls.Add(this.FilterBlueComponent);
            this.Controls.Add(this.FilterGreenComponent);
            this.Controls.Add(this.FilterRedComponent);
            this.Controls.Add(this.GreyScaleFilter);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.In);
            this.Name = "ImageProcessing";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.In)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox In;
        private System.Windows.Forms.PictureBox Out;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Button GreyScaleFilter;
        private System.Windows.Forms.Button FilterRedComponent;
        private System.Windows.Forms.Button FilterGreenComponent;
        private System.Windows.Forms.Button FilterBlueComponent;
        private System.Windows.Forms.Button MovingAverageFilter;
        private System.Windows.Forms.Button MovingMedianFilter;
    }
}

