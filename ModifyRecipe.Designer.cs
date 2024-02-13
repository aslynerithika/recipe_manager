namespace FoodManagerReceipr
{
    partial class FrmModifyRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyRecipe));
            this.btnModSav = new System.Windows.Forms.Button();
            this.dGVIngdt = new System.Windows.Forms.DataGridView();
            this.lBxRcpnam = new System.Windows.Forms.ListBox();
            this.lblTp = new System.Windows.Forms.Label();
            this.lblCatg = new System.Windows.Forms.Label();
            this.lblCui = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.pBxRcp = new System.Windows.Forms.PictureBox();
            this.lblRcpIfo = new System.Windows.Forms.Label();
            this.lblNifo = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblCookTime = new System.Windows.Forms.Label();
            this.lblYield = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblRcpNm = new System.Windows.Forms.Label();
            this.lbltyp = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblcus = new System.Windows.Forms.Label();
            this.dGWStp = new System.Windows.Forms.DataGridView();
            this.dGWRcnm = new System.Windows.Forms.DataGridView();
            this.TxtRnm = new System.Windows.Forms.TextBox();
            this.TxtCal = new System.Windows.Forms.TextBox();
            this.TxtYld = new System.Windows.Forms.TextBox();
            this.TxtCt = new System.Windows.Forms.TextBox();
            this.TxtRI = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Text6 = new System.Windows.Forms.TextBox();
            this.Text7 = new System.Windows.Forms.TextBox();
            this.Text8 = new System.Windows.Forms.TextBox();
            this.Text9 = new System.Windows.Forms.TextBox();
            this.Text10 = new System.Windows.Forms.TextBox();
            this.btnIngrt = new System.Windows.Forms.Button();
            this.pnlIngrt = new System.Windows.Forms.Panel();
            this.lblitms = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtimgpic = new System.Windows.Forms.TextBox();
            this.cBxRat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVIngdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxRcp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWStp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWRcnm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModSav
            // 
            this.btnModSav.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModSav.Location = new System.Drawing.Point(388, 195);
            this.btnModSav.Name = "btnModSav";
            this.btnModSav.Size = new System.Drawing.Size(145, 81);
            this.btnModSav.TabIndex = 86;
            this.btnModSav.Text = "Save Receipe";
            this.btnModSav.UseVisualStyleBackColor = true;
            this.btnModSav.Click += new System.EventHandler(this.btnModSav_Click);
            // 
            // dGVIngdt
            // 
            this.dGVIngdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVIngdt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVIngdt.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dGVIngdt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dGVIngdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVIngdt.Location = new System.Drawing.Point(386, 406);
            this.dGVIngdt.Name = "dGVIngdt";
            this.dGVIngdt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVIngdt.RowHeadersWidth = 51;
            this.dGVIngdt.RowTemplate.Height = 29;
            this.dGVIngdt.Size = new System.Drawing.Size(361, 604);
            this.dGVIngdt.TabIndex = 84;
            this.dGVIngdt.Visible = false;
            // 
            // lBxRcpnam
            // 
            this.lBxRcpnam.BackColor = System.Drawing.Color.MistyRose;
            this.lBxRcpnam.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lBxRcpnam.FormattingEnabled = true;
            this.lBxRcpnam.ItemHeight = 20;
            this.lBxRcpnam.Location = new System.Drawing.Point(14, 43);
            this.lBxRcpnam.Name = "lBxRcpnam";
            this.lBxRcpnam.Size = new System.Drawing.Size(361, 224);
            this.lBxRcpnam.Sorted = true;
            this.lBxRcpnam.TabIndex = 83;
            this.lBxRcpnam.DoubleClick += new System.EventHandler(this.lBxRcpnam_DoubleClick);
            // 
            // lblTp
            // 
            this.lblTp.Location = new System.Drawing.Point(741, 50);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(135, 24);
            this.lblTp.TabIndex = 75;
            // 
            // lblCatg
            // 
            this.lblCatg.Location = new System.Drawing.Point(509, 50);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(135, 24);
            this.lblCatg.TabIndex = 74;
            // 
            // lblCui
            // 
            this.lblCui.Location = new System.Drawing.Point(963, 16);
            this.lblCui.Name = "lblCui";
            this.lblCui.Size = new System.Drawing.Size(135, 24);
            this.lblCui.TabIndex = 73;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(770, 257);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(45, 20);
            this.lblSteps.TabIndex = 64;
            this.lblSteps.Text = "Steps";
            // 
            // pBxRcp
            // 
            this.pBxRcp.Image = global::FoodManagerReceipr.Properties.Resources.cawl;
            this.pBxRcp.Location = new System.Drawing.Point(1131, 16);
            this.pBxRcp.Name = "pBxRcp";
            this.pBxRcp.Size = new System.Drawing.Size(301, 227);
            this.pBxRcp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxRcp.TabIndex = 63;
            this.pBxRcp.TabStop = false;
            // 
            // lblRcpIfo
            // 
            this.lblRcpIfo.AutoSize = true;
            this.lblRcpIfo.Location = new System.Drawing.Point(405, 145);
            this.lblRcpIfo.Name = "lblRcpIfo";
            this.lblRcpIfo.Size = new System.Drawing.Size(136, 20);
            this.lblRcpIfo.TabIndex = 62;
            this.lblRcpIfo.Text = "Recipe Information";
            // 
            // lblNifo
            // 
            this.lblNifo.AutoSize = true;
            this.lblNifo.Location = new System.Drawing.Point(903, 57);
            this.lblNifo.Name = "lblNifo";
            this.lblNifo.Size = new System.Drawing.Size(62, 20);
            this.lblNifo.TabIndex = 61;
            this.lblNifo.Text = "Calories";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(903, 98);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(58, 20);
            this.lblRating.TabIndex = 60;
            this.lblRating.Text = "Ratings";
            // 
            // lblCookTime
            // 
            this.lblCookTime.AutoSize = true;
            this.lblCookTime.Location = new System.Drawing.Point(667, 98);
            this.lblCookTime.Name = "lblCookTime";
            this.lblCookTime.Size = new System.Drawing.Size(80, 20);
            this.lblCookTime.TabIndex = 59;
            this.lblCookTime.Text = "Cook Time";
            // 
            // lblYield
            // 
            this.lblYield.AutoSize = true;
            this.lblYield.Location = new System.Drawing.Point(405, 98);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(42, 20);
            this.lblYield.TabIndex = 58;
            this.lblYield.Text = "Yield";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(676, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 57;
            this.lblType.Text = "Type";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(405, 54);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(69, 20);
            this.lblCatagory.TabIndex = 56;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Location = new System.Drawing.Point(889, 16);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(56, 20);
            this.lblCuisine.TabIndex = 55;
            this.lblCuisine.Text = "Cuisine";
            // 
            // lblRcpNm
            // 
            this.lblRcpNm.AutoSize = true;
            this.lblRcpNm.Location = new System.Drawing.Point(405, 16);
            this.lblRcpNm.Name = "lblRcpNm";
            this.lblRcpNm.Size = new System.Drawing.Size(98, 20);
            this.lblRcpNm.TabIndex = 54;
            this.lblRcpNm.Text = "Recipe Name";
            // 
            // lbltyp
            // 
            this.lbltyp.AutoSize = true;
            this.lbltyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltyp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltyp.Location = new System.Drawing.Point(275, 3);
            this.lbltyp.MinimumSize = new System.Drawing.Size(100, 25);
            this.lbltyp.Name = "lbltyp";
            this.lbltyp.Size = new System.Drawing.Size(100, 30);
            this.lbltyp.TabIndex = 53;
            this.lbltyp.Text = " ---";
            this.lbltyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCat.Location = new System.Drawing.Point(140, 3);
            this.lblCat.MinimumSize = new System.Drawing.Size(100, 25);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(118, 30);
            this.lblCat.TabIndex = 52;
            this.lblCat.Text = "CATAGORY";
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcus
            // 
            this.lblcus.AutoSize = true;
            this.lblcus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcus.Location = new System.Drawing.Point(18, 3);
            this.lblcus.MinimumSize = new System.Drawing.Size(100, 25);
            this.lblcus.Name = "lblcus";
            this.lblcus.Size = new System.Drawing.Size(100, 30);
            this.lblcus.TabIndex = 51;
            this.lblcus.Text = "CUISINE";
            this.lblcus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGWStp
            // 
            this.dGWStp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWStp.Location = new System.Drawing.Point(1131, 173);
            this.dGWStp.Name = "dGWStp";
            this.dGWStp.RowHeadersWidth = 51;
            this.dGWStp.RowTemplate.Height = 29;
            this.dGWStp.Size = new System.Drawing.Size(391, 72);
            this.dGWStp.TabIndex = 81;
            this.dGWStp.Visible = false;
            // 
            // dGWRcnm
            // 
            this.dGWRcnm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGWRcnm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGWRcnm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWRcnm.Location = new System.Drawing.Point(1131, 24);
            this.dGWRcnm.Name = "dGWRcnm";
            this.dGWRcnm.RowHeadersWidth = 51;
            this.dGWRcnm.RowTemplate.Height = 29;
            this.dGWRcnm.Size = new System.Drawing.Size(391, 51);
            this.dGWRcnm.TabIndex = 82;
            this.dGWRcnm.Visible = false;
            // 
            // TxtRnm
            // 
            this.TxtRnm.Location = new System.Drawing.Point(509, 13);
            this.TxtRnm.Name = "TxtRnm";
            this.TxtRnm.Size = new System.Drawing.Size(367, 27);
            this.TxtRnm.TabIndex = 90;
            // 
            // TxtCal
            // 
            this.TxtCal.Location = new System.Drawing.Point(975, 54);
            this.TxtCal.Name = "TxtCal";
            this.TxtCal.Size = new System.Drawing.Size(125, 27);
            this.TxtCal.TabIndex = 91;
            // 
            // TxtYld
            // 
            this.TxtYld.Location = new System.Drawing.Point(509, 95);
            this.TxtYld.Name = "TxtYld";
            this.TxtYld.Size = new System.Drawing.Size(125, 27);
            this.TxtYld.TabIndex = 92;
            // 
            // TxtCt
            // 
            this.TxtCt.Location = new System.Drawing.Point(753, 95);
            this.TxtCt.Name = "TxtCt";
            this.TxtCt.Size = new System.Drawing.Size(125, 27);
            this.TxtCt.TabIndex = 93;
            // 
            // TxtRI
            // 
            this.TxtRI.Location = new System.Drawing.Point(549, 145);
            this.TxtRI.Multiline = true;
            this.TxtRI.Name = "TxtRI";
            this.TxtRI.Size = new System.Drawing.Size(551, 101);
            this.TxtRI.TabIndex = 95;
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(403, 321);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(1313, 60);
            this.Text1.TabIndex = 96;
            // 
            // Text2
            // 
            this.Text2.Location = new System.Drawing.Point(403, 387);
            this.Text2.Multiline = true;
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(1313, 60);
            this.Text2.TabIndex = 97;
            // 
            // Text3
            // 
            this.Text3.Location = new System.Drawing.Point(403, 453);
            this.Text3.Multiline = true;
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(1313, 60);
            this.Text3.TabIndex = 98;
            // 
            // Text4
            // 
            this.Text4.Location = new System.Drawing.Point(403, 519);
            this.Text4.Multiline = true;
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(1313, 60);
            this.Text4.TabIndex = 99;
            // 
            // Text5
            // 
            this.Text5.Location = new System.Drawing.Point(405, 585);
            this.Text5.Multiline = true;
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(1313, 60);
            this.Text5.TabIndex = 100;
            // 
            // Text6
            // 
            this.Text6.Location = new System.Drawing.Point(403, 651);
            this.Text6.Multiline = true;
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(1313, 60);
            this.Text6.TabIndex = 101;
            // 
            // Text7
            // 
            this.Text7.Location = new System.Drawing.Point(405, 717);
            this.Text7.Multiline = true;
            this.Text7.Name = "Text7";
            this.Text7.Size = new System.Drawing.Size(1313, 60);
            this.Text7.TabIndex = 102;
            // 
            // Text8
            // 
            this.Text8.Location = new System.Drawing.Point(403, 783);
            this.Text8.Multiline = true;
            this.Text8.Name = "Text8";
            this.Text8.Size = new System.Drawing.Size(1313, 60);
            this.Text8.TabIndex = 103;
            // 
            // Text9
            // 
            this.Text9.Location = new System.Drawing.Point(403, 849);
            this.Text9.Multiline = true;
            this.Text9.Name = "Text9";
            this.Text9.Size = new System.Drawing.Size(1313, 60);
            this.Text9.TabIndex = 104;
            // 
            // Text10
            // 
            this.Text10.Location = new System.Drawing.Point(403, 915);
            this.Text10.Multiline = true;
            this.Text10.Name = "Text10";
            this.Text10.Size = new System.Drawing.Size(1313, 60);
            this.Text10.TabIndex = 105;
            // 
            // btnIngrt
            // 
            this.btnIngrt.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIngrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngrt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngrt.Location = new System.Drawing.Point(12, 270);
            this.btnIngrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngrt.Name = "btnIngrt";
            this.btnIngrt.Size = new System.Drawing.Size(362, 41);
            this.btnIngrt.TabIndex = 110;
            this.btnIngrt.Text = "INGREDIENTS";
            this.btnIngrt.UseVisualStyleBackColor = false;
            // 
            // pnlIngrt
            // 
            this.pnlIngrt.BackColor = System.Drawing.Color.Beige;
            this.pnlIngrt.Location = new System.Drawing.Point(12, 351);
            this.pnlIngrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlIngrt.Name = "pnlIngrt";
            this.pnlIngrt.Size = new System.Drawing.Size(361, 691);
            this.pnlIngrt.TabIndex = 109;
            this.pnlIngrt.Visible = false;
            // 
            // lblitms
            // 
            this.lblitms.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblitms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblitms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblitms.Location = new System.Drawing.Point(170, 311);
            this.lblitms.Name = "lblitms";
            this.lblitms.Size = new System.Drawing.Size(203, 36);
            this.lblitms.TabIndex = 108;
            this.lblitms.Text = "ITEMS";
            this.lblitms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUOM
            // 
            this.lblUOM.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblUOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUOM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUOM.Location = new System.Drawing.Point(82, 311);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(86, 36);
            this.lblUOM.TabIndex = 107;
            this.lblUOM.Text = "UOM";
            this.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblqty
            // 
            this.lblqty.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblqty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblqty.Location = new System.Drawing.Point(13, 311);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(71, 36);
            this.lblqty.TabIndex = 106;
            this.lblqty.Text = "QTY";
            this.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtimgpic
            // 
            this.txtimgpic.Location = new System.Drawing.Point(1134, 257);
            this.txtimgpic.Name = "txtimgpic";
            this.txtimgpic.Size = new System.Drawing.Size(298, 27);
            this.txtimgpic.TabIndex = 111;
            // 
            // cBxRat
            // 
            this.cBxRat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBxRat.FormattingEnabled = true;
            this.cBxRat.Items.AddRange(new object[] {
            "*",
            "**",
            "***",
            "****",
            "*****"});
            this.cBxRat.Location = new System.Drawing.Point(975, 95);
            this.cBxRat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBxRat.Name = "cBxRat";
            this.cBxRat.Size = new System.Drawing.Size(130, 32);
            this.cBxRat.TabIndex = 112;
            this.cBxRat.SelectionChangeCommitted += new System.EventHandler(this.cBxRat_SelectionChangeCommitted);
            // 
            // FrmModifyRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1539, 1055);
            this.Controls.Add(this.cBxRat);
            this.Controls.Add(this.txtimgpic);
            this.Controls.Add(this.btnIngrt);
            this.Controls.Add(this.pnlIngrt);
            this.Controls.Add(this.lblitms);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.dGVIngdt);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text10);
            this.Controls.Add(this.Text9);
            this.Controls.Add(this.Text8);
            this.Controls.Add(this.Text7);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.TxtRI);
            this.Controls.Add(this.TxtCt);
            this.Controls.Add(this.TxtYld);
            this.Controls.Add(this.TxtCal);
            this.Controls.Add(this.TxtRnm);
            this.Controls.Add(this.btnModSav);
            this.Controls.Add(this.lBxRcpnam);
            this.Controls.Add(this.lblTp);
            this.Controls.Add(this.lblCatg);
            this.Controls.Add(this.lblCui);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.pBxRcp);
            this.Controls.Add(this.lblRcpIfo);
            this.Controls.Add(this.lblNifo);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblCookTime);
            this.Controls.Add(this.lblYield);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblCuisine);
            this.Controls.Add(this.lblRcpNm);
            this.Controls.Add(this.lbltyp);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblcus);
            this.Controls.Add(this.dGWStp);
            this.Controls.Add(this.dGWRcnm);
            this.Name = "FrmModifyRecipe";
            this.Text = "ModifyRecipe";
            this.Load += new System.EventHandler(this.ModifyRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVIngdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxRcp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWStp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWRcnm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModSav;
        private DataGridView dGVIngdt;
        private ListBox lBxRcpnam;
        private Label lblTp;
        private Label lblCatg;
        private Label lblCui;
        private Label lblSteps;
        private PictureBox pBxRcp;
        private Label lblRcpIfo;
        private Label lblNifo;
        private Label lblRating;
        private Label lblCookTime;
        private Label lblYield;
        private Label lblType;
        private Label lblCatagory;
        private Label lblCuisine;
        private Label lblRcpNm;
        private Label lbltyp;
        private Label lblCat;
        private Label lblcus;
        private DataGridView dGWStp;
        private DataGridView dGWRcnm;
        private TextBox TxtRnm;
        private TextBox TxtCal;
        private TextBox TxtYld;
        private TextBox TxtCt;
        private TextBox TxtRI;
        private TextBox Text1;
        private TextBox Text2;
        private TextBox Text3;
        private TextBox Text4;
        private TextBox Text5;
        private TextBox Text6;
        private TextBox Text7;
        private TextBox Text8;
        private TextBox Text9;
        private TextBox Text10;
        private Button btnIngrt;
        private Panel pnlIngrt;
        private Label lblitms;
        private Label lblUOM;
        private Label lblqty;
        private TextBox txtimgpic;
        private ComboBox cBxRat;
    }
}