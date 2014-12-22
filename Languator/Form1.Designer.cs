namespace Languator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.helloLabel = new System.Windows.Forms.Label();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelPolski = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textPolski = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.globalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLanguatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helloLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(49, 36);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(357, 38);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Cześć!";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.globalToolTip.SetToolTip(this.helloLabel, "Click and see vas happenin\'...");
            this.helloLabel.Click += new System.EventHandler(this.helloLabel_Click);
            // 
            // mainPicture
            // 
            this.mainPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPicture.Image = global::Languator.Properties.Resources.resumé;
            this.mainPicture.Location = new System.Drawing.Point(118, 77);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(218, 177);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 1;
            this.mainPicture.TabStop = false;
            this.mainPicture.Tag = "resumé";
            this.globalToolTip.SetToolTip(this.mainPicture, "Click for some magic");
            this.mainPicture.Click += new System.EventHandler(this.mainPicture_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnglish.Location = new System.Drawing.Point(42, 292);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(44, 13);
            this.labelEnglish.TabIndex = 2;
            this.labelEnglish.Text = "English:";
            this.globalToolTip.SetToolTip(this.labelEnglish, "Click to void this textbox");
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // labelPolski
            // 
            this.labelPolski.AutoSize = true;
            this.labelPolski.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPolski.Location = new System.Drawing.Point(18, 340);
            this.labelPolski.Name = "labelPolski";
            this.labelPolski.Size = new System.Drawing.Size(68, 13);
            this.labelPolski.TabIndex = 3;
            this.labelPolski.Text = "Język Polski:";
            this.globalToolTip.SetToolTip(this.labelPolski, "Click to void this textbox");
            this.labelPolski.Click += new System.EventHandler(this.labelPolski_Click);
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(118, 289);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(213, 20);
            this.textEnglish.TabIndex = 4;
            // 
            // textPolski
            // 
            this.textPolski.Location = new System.Drawing.Point(118, 337);
            this.textPolski.Name = "textPolski";
            this.textPolski.Size = new System.Drawing.Size(214, 20);
            this.textPolski.TabIndex = 5;
            // 
            // acceptButton
            // 
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.Location = new System.Drawing.Point(360, 292);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(81, 65);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Translate!";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutLanguatorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutLanguatorToolStripMenuItem
            // 
            this.aboutLanguatorToolStripMenuItem.Name = "aboutLanguatorToolStripMenuItem";
            this.aboutLanguatorToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutLanguatorToolStripMenuItem.Text = "About Languator";
            this.aboutLanguatorToolStripMenuItem.Click += new System.EventHandler(this.aboutLanguatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 458);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.textPolski);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.labelPolski);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.mainPicture);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Languator";
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelPolski;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.TextBox textPolski;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ToolTip globalToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutLanguatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

    }
}

