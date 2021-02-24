namespace TriggerForm
{
    partial class FormDrivers
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrivers));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.leftbtn = new System.Windows.Forms.ToolStripButton();
            this.rightbtn = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 34);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1378, 416);
            this.dgv.TabIndex = 0;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbCancel,
            this.toolStripSeparator,
            this.leftbtn,
            this.rightbtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1378, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(29, 24);
            this.tsbNew.Text = "&Nuovo";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // leftbtn
            // 
            this.leftbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftbtn.Enabled = false;
            this.leftbtn.Image = ((System.Drawing.Image)(resources.GetObject("leftbtn.Image")));
            this.leftbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(29, 24);
            this.leftbtn.Tag = "0";
            this.leftbtn.Text = "toolStripButton1";
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // rightbtn
            // 
            this.rightbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightbtn.Image = ((System.Drawing.Image)(resources.GetObject("rightbtn.Image")));
            this.rightbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(29, 24);
            this.rightbtn.Tag = "1";
            this.rightbtn.Text = "toolStripButton2";
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(29, 24);
            this.tsbCancel.Text = "toolStripButton1";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // FormDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgv);
            this.MinimumSize = new System.Drawing.Size(1396, 497);
            this.Name = "FormDrivers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers info";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton leftbtn;
        private System.Windows.Forms.ToolStripButton rightbtn;
        private System.Windows.Forms.ToolStripButton tsbCancel;
    }
}

