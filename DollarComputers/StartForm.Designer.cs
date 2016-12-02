namespace DollarComputers
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonSavedOrder = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonNewOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(40, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(364, 31);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Order Your Computer Today!";
            // 
            // ButtonSavedOrder
            // 
            this.ButtonSavedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSavedOrder.Location = new System.Drawing.Point(222, 340);
            this.ButtonSavedOrder.Name = "ButtonSavedOrder";
            this.ButtonSavedOrder.Size = new System.Drawing.Size(182, 33);
            this.ButtonSavedOrder.TabIndex = 3;
            this.ButtonSavedOrder.Text = "Open a Saved Order";
            this.ButtonSavedOrder.UseVisualStyleBackColor = true;
            this.ButtonSavedOrder.Click += new System.EventHandler(this.ButtonSavedOrder_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(161, 379);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(108, 33);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonNewOrder
            // 
            this.ButtonNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewOrder.Location = new System.Drawing.Point(34, 340);
            this.ButtonNewOrder.Name = "ButtonNewOrder";
            this.ButtonNewOrder.Size = new System.Drawing.Size(182, 33);
            this.ButtonNewOrder.TabIndex = 2;
            this.ButtonNewOrder.Text = "Start a New Order";
            this.ButtonNewOrder.UseVisualStyleBackColor = true;
            this.ButtonNewOrder.Click += new System.EventHandler(this.ButtonNewOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DollarComputers.Properties.Resources.apple;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(99, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 435);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonNewOrder);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSavedOrder);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonSavedOrder;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonNewOrder;
    }
}