namespace FoodManagerReceipr
{
    partial class FrmAddRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddRecipe));
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
            this.txtAddRcpNm = new System.Windows.Forms.TextBox();
            this.txtAddCal = new System.Windows.Forms.TextBox();
            this.txtAddYld = new System.Windows.Forms.TextBox();
            this.txtAddCt = new System.Windows.Forms.TextBox();
            this.txtAddIfo = new System.Windows.Forms.TextBox();
            this.DrpBxStps = new System.Windows.Forms.ComboBox();
            this.pnlSteps = new System.Windows.Forms.Panel();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblitms = new System.Windows.Forms.Label();
            this.pnlIngrt = new System.Windows.Forms.Panel();
            this.btnIngrt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cBxRat = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtimgpic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBxRcp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTp
            // 
            this.lblTp.Location = new System.Drawing.Point(741, 52);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(135, 24);
            this.lblTp.TabIndex = 76;
            // 
            // lblCatg
            // 
            this.lblCatg.Location = new System.Drawing.Point(509, 52);
            this.lblCatg.Name = "lblCatg";
            this.lblCatg.Size = new System.Drawing.Size(135, 24);
            this.lblCatg.TabIndex = 75;
            // 
            // lblCui
            // 
            this.lblCui.Location = new System.Drawing.Point(962, 11);
            this.lblCui.Name = "lblCui";
            this.lblCui.Size = new System.Drawing.Size(135, 24);
            this.lblCui.TabIndex = 74;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(769, 261);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(45, 20);
            this.lblSteps.TabIndex = 63;
            this.lblSteps.Text = "Steps";
            this.lblSteps.DoubleClick += new System.EventHandler(this.lblSteps_DoubleClick);
            // 
            // pBxRcp
            // 
            this.pBxRcp.Image = global::FoodManagerReceipr.Properties.Resources.cawl;
            this.pBxRcp.Location = new System.Drawing.Point(1130, 11);
            this.pBxRcp.Name = "pBxRcp";
            this.pBxRcp.Size = new System.Drawing.Size(301, 227);
            this.pBxRcp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxRcp.TabIndex = 62;
            this.pBxRcp.TabStop = false;
            this.pBxRcp.DoubleClick += new System.EventHandler(this.pBxRcp_DoubleClick);
            // 
            // lblRcpIfo
            // 
            this.lblRcpIfo.AutoSize = true;
            this.lblRcpIfo.Location = new System.Drawing.Point(405, 140);
            this.lblRcpIfo.Name = "lblRcpIfo";
            this.lblRcpIfo.Size = new System.Drawing.Size(136, 20);
            this.lblRcpIfo.TabIndex = 61;
            this.lblRcpIfo.Text = "Recipe Information";
            // 
            // lblNifo
            // 
            this.lblNifo.AutoSize = true;
            this.lblNifo.Location = new System.Drawing.Point(903, 52);
            this.lblNifo.Name = "lblNifo";
            this.lblNifo.Size = new System.Drawing.Size(62, 20);
            this.lblNifo.TabIndex = 60;
            this.lblNifo.Text = "Calories";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(903, 93);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(58, 20);
            this.lblRating.TabIndex = 59;
            this.lblRating.Text = "Ratings";
            // 
            // lblCookTime
            // 
            this.lblCookTime.AutoSize = true;
            this.lblCookTime.Location = new System.Drawing.Point(666, 93);
            this.lblCookTime.Name = "lblCookTime";
            this.lblCookTime.Size = new System.Drawing.Size(80, 20);
            this.lblCookTime.TabIndex = 58;
            this.lblCookTime.Text = "Cook Time";
            // 
            // lblYield
            // 
            this.lblYield.AutoSize = true;
            this.lblYield.Location = new System.Drawing.Point(405, 93);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(42, 20);
            this.lblYield.TabIndex = 57;
            this.lblYield.Text = "Yield";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(675, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 56;
            this.lblType.Text = "Type";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(405, 49);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(69, 20);
            this.lblCatagory.TabIndex = 55;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Location = new System.Drawing.Point(888, 11);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(56, 20);
            this.lblCuisine.TabIndex = 54;
            this.lblCuisine.Text = "Cuisine";
            // 
            // lblRcpNm
            // 
            this.lblRcpNm.AutoSize = true;
            this.lblRcpNm.Location = new System.Drawing.Point(405, 11);
            this.lblRcpNm.Name = "lblRcpNm";
            this.lblRcpNm.Size = new System.Drawing.Size(98, 20);
            this.lblRcpNm.TabIndex = 53;
            this.lblRcpNm.Text = "Recipe Name";
            // 
            // txtAddRcpNm
            // 
            this.txtAddRcpNm.Location = new System.Drawing.Point(510, 11);
            this.txtAddRcpNm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddRcpNm.Name = "txtAddRcpNm";
            this.txtAddRcpNm.Size = new System.Drawing.Size(365, 27);
            this.txtAddRcpNm.TabIndex = 87;
            // 
            // txtAddCal
            // 
            this.txtAddCal.Location = new System.Drawing.Point(966, 48);
            this.txtAddCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCal.Name = "txtAddCal";
            this.txtAddCal.Size = new System.Drawing.Size(131, 27);
            this.txtAddCal.TabIndex = 88;
            // 
            // txtAddYld
            // 
            this.txtAddYld.Location = new System.Drawing.Point(509, 93);
            this.txtAddYld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddYld.Name = "txtAddYld";
            this.txtAddYld.Size = new System.Drawing.Size(134, 27);
            this.txtAddYld.TabIndex = 89;
            // 
            // txtAddCt
            // 
            this.txtAddCt.Location = new System.Drawing.Point(743, 92);
            this.txtAddCt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddCt.Name = "txtAddCt";
            this.txtAddCt.Size = new System.Drawing.Size(132, 27);
            this.txtAddCt.TabIndex = 90;
            // 
            // txtAddIfo
            // 
            this.txtAddIfo.Location = new System.Drawing.Point(533, 141);
            this.txtAddIfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddIfo.Multiline = true;
            this.txtAddIfo.Name = "txtAddIfo";
            this.txtAddIfo.Size = new System.Drawing.Size(564, 105);
            this.txtAddIfo.TabIndex = 92;
            // 
            // DrpBxStps
            // 
            this.DrpBxStps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrpBxStps.FormattingEnabled = true;
            this.DrpBxStps.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DrpBxStps.Location = new System.Drawing.Point(821, 256);
            this.DrpBxStps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrpBxStps.Name = "DrpBxStps";
            this.DrpBxStps.Size = new System.Drawing.Size(138, 28);
            this.DrpBxStps.TabIndex = 93;
            this.DrpBxStps.SelectionChangeCommitted += new System.EventHandler(this.DrpBxStps_SelectionChangeCommitted);
            // 
            // pnlSteps
            // 
            this.pnlSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlSteps.Location = new System.Drawing.Point(391, 297);
            this.pnlSteps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSteps.Name = "pnlSteps";
            this.pnlSteps.Size = new System.Drawing.Size(1358, 713);
            this.pnlSteps.TabIndex = 94;
            // 
            // lblqty
            // 
            this.lblqty.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblqty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblqty.Location = new System.Drawing.Point(14, 133);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(71, 36);
            this.lblqty.TabIndex = 95;
            this.lblqty.Text = "QTY";
            this.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUOM
            // 
            this.lblUOM.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblUOM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUOM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUOM.Location = new System.Drawing.Point(83, 133);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(86, 36);
            this.lblUOM.TabIndex = 96;
            this.lblUOM.Text = "UOM";
            this.lblUOM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblitms
            // 
            this.lblitms.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblitms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblitms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblitms.Location = new System.Drawing.Point(171, 133);
            this.lblitms.Name = "lblitms";
            this.lblitms.Size = new System.Drawing.Size(203, 36);
            this.lblitms.TabIndex = 97;
            this.lblitms.Text = "ITEMS";
            this.lblitms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIngrt
            // 
            this.pnlIngrt.BackColor = System.Drawing.Color.Beige;
            this.pnlIngrt.Location = new System.Drawing.Point(16, 176);
            this.pnlIngrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlIngrt.Name = "pnlIngrt";
            this.pnlIngrt.Size = new System.Drawing.Size(361, 745);
            this.pnlIngrt.TabIndex = 98;
            this.pnlIngrt.Visible = false;
            // 
            // btnIngrt
            // 
            this.btnIngrt.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIngrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngrt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngrt.Location = new System.Drawing.Point(13, 92);
            this.btnIngrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngrt.Name = "btnIngrt";
            this.btnIngrt.Size = new System.Drawing.Size(362, 41);
            this.btnIngrt.TabIndex = 99;
            this.btnIngrt.Text = "INGREDIENTS";
            this.btnIngrt.UseVisualStyleBackColor = false;
            this.btnIngrt.Click += new System.EventHandler(this.btnIngrt_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Wheat;
            this.btnSave.Location = new System.Drawing.Point(16, 27);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 43);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Wheat;
            this.btnExit.Location = new System.Drawing.Point(192, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 43);
            this.btnExit.TabIndex = 101;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // cBxRat
            // 
            this.cBxRat.FormattingEnabled = true;
            this.cBxRat.Items.AddRange(new object[] {
            "*",
            "**",
            "***",
            "****",
            "*****"});
            this.cBxRat.Location = new System.Drawing.Point(966, 92);
            this.cBxRat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBxRat.Name = "cBxRat";
            this.cBxRat.Size = new System.Drawing.Size(130, 28);
            this.cBxRat.TabIndex = 102;
            this.cBxRat.SelectionChangeCommitted += new System.EventHandler(this.cBxRat_SelectionChangeCommitted);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1493, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 264);
            this.listBox1.TabIndex = 103;
            // 
            // txtimgpic
            // 
            this.txtimgpic.Location = new System.Drawing.Point(1129, 250);
            this.txtimgpic.Name = "txtimgpic";
            this.txtimgpic.Size = new System.Drawing.Size(298, 27);
            this.txtimgpic.TabIndex = 104;
            // 
            // FrmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1754, 1015);
            this.Controls.Add(this.txtimgpic);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cBxRat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnIngrt);
            this.Controls.Add(this.pnlIngrt);
            this.Controls.Add(this.lblitms);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.pnlSteps);
            this.Controls.Add(this.DrpBxStps);
            this.Controls.Add(this.txtAddIfo);
            this.Controls.Add(this.txtAddCt);
            this.Controls.Add(this.txtAddYld);
            this.Controls.Add(this.txtAddCal);
            this.Controls.Add(this.txtAddRcpNm);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddRecipe";
            this.Text = "AddRecipe";
            this.Load += new System.EventHandler(this.FrmAddRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBxRcp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private TextBox txtAddRcpNm;
        private TextBox txtAddCal;
        private TextBox txtAddYld;
        private TextBox txtAddCt;
        private TextBox txtAddIfo;
        private ComboBox DrpBxStps;
        private Panel pnlSteps;
        private Label lblqty;
        private Label lblUOM;
        private Label lblitms;
        private Panel pnlIngrt;
        private Button btnIngrt;
        private Button btnSave;
        private Button btnExit;
        private ComboBox cBxRat;
        private ListBox listBox1;
        private TextBox txtimgpic;
    }
}