namespace EloRoteamento
{
    partial class Map
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
			this.label1 = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.cbFTRVND = new System.Windows.Forms.CheckBox();
			this.grid = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.txDataFinal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txDataInicial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txVendedor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gMap = new GMap.NET.WindowsForms.GMapControl();
			this.label6 = new System.Windows.Forms.Label();
			this.btnMaisZoom = new System.Windows.Forms.Button();
			this.btnMenosZoom = new System.Windows.Forms.Button();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Trajeto Vendedor";
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.cbFTRVND);
			this.panel.Controls.Add(this.grid);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.txDataFinal);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.txDataInicial);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.txVendedor);
			this.panel.Controls.Add(this.label2);
			this.panel.Location = new System.Drawing.Point(13, 29);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(220, 523);
			this.panel.TabIndex = 2;
			// 
			// cbFTRVND
			// 
			this.cbFTRVND.AutoSize = true;
			this.cbFTRVND.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.cbFTRVND.Location = new System.Drawing.Point(16, 184);
			this.cbFTRVND.Name = "cbFTRVND";
			this.cbFTRVND.Size = new System.Drawing.Size(140, 21);
			this.cbFTRVND.TabIndex = 9;
			this.cbFTRVND.Text = "Filtrar pelas vendas";
			this.cbFTRVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbFTRVND.UseVisualStyleBackColor = true;
			this.cbFTRVND.CheckedChanged += new System.EventHandler(this.cbFTRVND_CheckedChanged);
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.ColumnHeadersVisible = false;
			this.grid.Location = new System.Drawing.Point(16, 237);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.Size = new System.Drawing.Size(184, 265);
			this.grid.TabIndex = 8;
			this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new System.Drawing.Point(13, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Data / Hora";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txDataFinal
			// 
			this.txDataFinal.Location = new System.Drawing.Point(16, 144);
			this.txDataFinal.Name = "txDataFinal";
			this.txDataFinal.Size = new System.Drawing.Size(184, 25);
			this.txDataFinal.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(13, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data Final";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txDataInicial
			// 
			this.txDataInicial.Location = new System.Drawing.Point(16, 96);
			this.txDataInicial.Name = "txDataInicial";
			this.txDataInicial.Size = new System.Drawing.Size(184, 25);
			this.txDataInicial.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(13, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data Inicial";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txVendedor
			// 
			this.txVendedor.Location = new System.Drawing.Point(16, 27);
			this.txVendedor.Name = "txVendedor";
			this.txVendedor.Size = new System.Drawing.Size(184, 25);
			this.txVendedor.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(13, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Vendedor";
			// 
			// gMap
			// 
			this.gMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gMap.Bearing = 0F;
			this.gMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gMap.CanDragMap = true;
			this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMap.GrayScaleMode = false;
			this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMap.LevelsKeepInMemory = 5;
			this.gMap.Location = new System.Drawing.Point(239, 29);
			this.gMap.MarkersEnabled = true;
			this.gMap.MaxZoom = 20;
			this.gMap.MinZoom = 2;
			this.gMap.MouseWheelZoomEnabled = true;
			this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMap.Name = "gMap";
			this.gMap.NegativeMode = false;
			this.gMap.PolygonsEnabled = true;
			this.gMap.RetryLoadTile = 0;
			this.gMap.RoutesEnabled = true;
			this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMap.ShowTileGridLines = false;
			this.gMap.Size = new System.Drawing.Size(703, 523);
			this.gMap.TabIndex = 3;
			this.gMap.Zoom = 5D;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Location = new System.Drawing.Point(869, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "Zoom";
			// 
			// btnMaisZoom
			// 
			this.btnMaisZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaisZoom.BackColor = System.Drawing.Color.Transparent;
			this.btnMaisZoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaisZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaisZoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaisZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnMaisZoom.Image")));
			this.btnMaisZoom.Location = new System.Drawing.Point(872, 29);
			this.btnMaisZoom.Margin = new System.Windows.Forms.Padding(0);
			this.btnMaisZoom.Name = "btnMaisZoom";
			this.btnMaisZoom.Size = new System.Drawing.Size(35, 35);
			this.btnMaisZoom.TabIndex = 5;
			this.btnMaisZoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMaisZoom.UseVisualStyleBackColor = false;
			this.btnMaisZoom.Click += new System.EventHandler(this.btnMaisZoom_Click);
			// 
			// btnMenosZoom
			// 
			this.btnMenosZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMenosZoom.BackColor = System.Drawing.Color.Transparent;
			this.btnMenosZoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenosZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenosZoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenosZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnMenosZoom.Image")));
			this.btnMenosZoom.Location = new System.Drawing.Point(907, 29);
			this.btnMenosZoom.Margin = new System.Windows.Forms.Padding(0);
			this.btnMenosZoom.Name = "btnMenosZoom";
			this.btnMenosZoom.Size = new System.Drawing.Size(35, 35);
			this.btnMenosZoom.TabIndex = 6;
			this.btnMenosZoom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMenosZoom.UseVisualStyleBackColor = false;
			this.btnMenosZoom.Click += new System.EventHandler(this.btnMenosZoom_Click);
			// 
			// Map
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(954, 564);
			this.Controls.Add(this.btnMenosZoom);
			this.Controls.Add(this.btnMaisZoom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gMap);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Map";
			this.Text = "EloRoteamento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Map_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Map_FormClosed);
			this.Load += new System.EventHandler(this.Map_Load);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDataInicial;
        private System.Windows.Forms.Label label5;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaisZoom;
        private System.Windows.Forms.Button btnMenosZoom;
		private System.Windows.Forms.CheckBox cbFTRVND;
	}
}