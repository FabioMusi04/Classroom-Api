
namespace Classroom_Api
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CmbClassromm = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbCompiti = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabelInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbAllegati = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.CmbClassromm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllegati)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbClassromm
            // 
            this.CmbClassromm.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.CmbClassromm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClassromm.DropDownWidth = 166;
            this.CmbClassromm.Location = new System.Drawing.Point(2, 3);
            this.CmbClassromm.Name = "CmbClassromm";
            this.CmbClassromm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.CmbClassromm.Size = new System.Drawing.Size(693, 41);
            this.CmbClassromm.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbClassromm.StateCommon.ComboBox.Border.ColorAngle = 12F;
            this.CmbClassromm.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmbClassromm.StateCommon.ComboBox.Border.Rounding = 15;
            this.CmbClassromm.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbClassromm.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.CmbClassromm.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CmbClassromm.StateCommon.Item.Border.Rounding = 3;
            this.CmbClassromm.TabIndex = 0;
            this.CmbClassromm.SelectedIndexChanged += new System.EventHandler(this.CbBoxMaterie_SelectedIndexChanged);
            // 
            // lbCompiti
            // 
            this.lbCompiti.Location = new System.Drawing.Point(750, 3);
            this.lbCompiti.Name = "lbCompiti";
            this.lbCompiti.Size = new System.Drawing.Size(515, 239);
            this.lbCompiti.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lbCompiti.StateCommon.Border.Rounding = 12;
            this.lbCompiti.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbCompiti.StateCommon.Item.Back.Color2 = System.Drawing.Color.Maroon;
            this.lbCompiti.StateCommon.Item.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.lbCompiti.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbCompiti.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbCompiti.StateCommon.Item.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lbCompiti.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lbCompiti.StateCommon.Item.Border.Rounding = 3;
            this.lbCompiti.TabIndex = 3;
            this.lbCompiti.SelectedIndexChanged += new System.EventHandler(this.listBoxCompiti_SelectedIndexChanged);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.Red;
            this.kryptonPalette1.ButtonSpecs.FormClose.ExtraText = "Close";
            this.kryptonPalette1.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.kryptonPalette1.ButtonSpecs.FormClose.Text = "Close";
            this.kryptonPalette1.ButtonSpecs.FormClose.ToolTipTitle = "Close";
            this.kryptonPalette1.ButtonSpecs.FormMin.ColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Switch25;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.ColorAngle = 12F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // kryptonLabelInfo
            // 
            this.kryptonLabelInfo.Location = new System.Drawing.Point(12, 96);
            this.kryptonLabelInfo.Name = "kryptonLabelInfo";
            this.kryptonLabelInfo.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabelInfo.TabIndex = 4;
            this.kryptonLabelInfo.Values.Text = "";
            // 
            // cbAllegati
            // 
            this.cbAllegati.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.cbAllegati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllegati.DropDownWidth = 166;
            this.cbAllegati.Location = new System.Drawing.Point(2, 186);
            this.cbAllegati.Name = "cbAllegati";
            this.cbAllegati.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.cbAllegati.Size = new System.Drawing.Size(693, 41);
            this.cbAllegati.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbAllegati.StateCommon.ComboBox.Border.ColorAngle = 12F;
            this.cbAllegati.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbAllegati.StateCommon.ComboBox.Border.Rounding = 15;
            this.cbAllegati.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllegati.StateCommon.DropBack.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.cbAllegati.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbAllegati.StateCommon.Item.Border.Rounding = 3;
            this.cbAllegati.TabIndex = 5;
            this.cbAllegati.SelectedIndexChanged += new System.EventHandler(this.cbAllegati_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 248);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1263, 346);
            this.webBrowser1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1265, 596);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.cbAllegati);
            this.Controls.Add(this.kryptonLabelInfo);
            this.Controls.Add(this.lbCompiti);
            this.Controls.Add(this.CmbClassromm);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbClassromm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAllegati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbClassromm;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbCompiti;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbAllegati;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

