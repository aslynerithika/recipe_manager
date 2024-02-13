using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace FoodManagerReceipr
{
    public partial class frmFdMgr : Form
    {
        public static string MNU, CSN, CTG, TPY="0";

        public frmFdMgr()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDsply_Click(object sender, EventArgs e)
        {
            pnLCuisines.Visible = true;
            pnlCatg.Visible = true;
            MNU = "1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnLCuisines.Visible = true;
            pnlCatg.Visible = true;
            MNU = "2";

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            pnLCuisines.Visible = true;
            pnlCatg.Visible = true;
            MNU = "3";

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pnLCuisines.Visible = true;
            pnlCatg.Visible = true;
            MNU = "4";

        }

        private void btnEng_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "1";

            pnlmov.Visible = true;
            pnlmov.Left = btnEng.Left;
            pnlmov.Width = btnEng.Width;

            pnlCatg.Visible=true;
            pnlCatg.Left = btnEng.Left;
            pnlCatg.Width = btnEng.Width;
        }

        private void btnInd_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "3";

            pnlmov.Visible = true;
            pnlmov.Left = btnInd.Left;
            pnlmov.Width = btnInd.Width;

            pnlCatg.Visible = true;
            pnlCatg.Left = btnInd.Left;
            pnlCatg.Width = btnInd.Width;
        }

        private void btnIta_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "2";

            pnlmov.Visible = true;
            pnlmov.Left = btnIta.Left;
            pnlmov.Width = btnIta.Width;

            pnlCatg.Visible = true;
            pnlCatg.Left = btnIta.Left;
            pnlCatg.Width = btnIta.Width;

        }

        private void btnChn_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "4";

            pnlmov.Visible = true;
            pnlmov.Left = btnChn.Left;
            pnlmov.Width = btnChn.Width;

            pnlCatg.Visible = true;
            //pnlCatg.Location = new Point(806, 230);
            pnlCatg.Left = btnChn.Left;
            pnlCatg.Width = btnChn.Width;

        }

        private void btnJap_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "5";

            pnlmov.Visible = true;
            pnlmov.Left = btnJap.Left;
            pnlmov.Width = btnJap.Width;

            pnlCatg.Visible = true;
            pnlCatg.Left = btnJap.Left;
            pnlCatg.Width = btnJap.Width;

        }

        private void btnDrnk_MouseMove(object sender, MouseEventArgs e)
        {
            CSN = "6";

            pnlmov.Visible = true;
            pnlmov.Left = btnDrnk.Left;
            pnlmov.Width = btnDrnk.Width;
        }

        private void btnEng_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
            pnlmovII.Visible = false;
        }

        private void btnInd_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
            pnlmovII.Visible = false;
            //pnlCatg.Visible = false;

        }

        private void btnIta_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
            pnlmovII.Visible = false;
        }

        private void btnChn_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
            pnlmovII.Visible = false;
        }

        private void btnJap_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
            pnlmovII.Visible = false;
        }

        private void btnDrnk_MouseLeave(object sender, EventArgs e)
        {
            pnlmov.Visible = false;
        }

        private void btnckn_MouseMove(object sender, MouseEventArgs e)
        {
            pnlmovII.Visible = true;
            pnlmovII.Left = btnckn.Left;
            pnlmovII.Width = btnckn.Width;

            pBxChk.Visible = true;

        }

        private void btnbef_MouseMove(object sender, MouseEventArgs e)
        {
            pnlmovII.Visible = true;
            pnlmovII.Left = btnbef.Left;
            pnlmovII.Width = btnbef.Width;

            pBxbef.Visible = true;
        }

        private void btnprk_MouseMove(object sender, MouseEventArgs e)
        {
            pnlmovII.Visible = true;
            pnlmovII.Left = btnprk.Left;
            pnlmovII.Width = btnprk.Width;

            pBxprk.Visible = true;
        }

        private void btnVg_Click(object sender, EventArgs e)
        {
            CTG = "2";

            // Call Select Form
            SelC();
        }

        private void btnVegan_Click(object sender, EventArgs e)
        {
            CTG = "3";

            // Call Select Form
            SelC();
        }

        private void btnDesert_Click(object sender, EventArgs e)
        {
            CTG = "4";

            // Call Select Form
            SelC();
        }

        private void btnckn_Click(object sender, EventArgs e)
        {
            TPY = "1";

            // Call Select Form
            SelC();
        }

        private void btnlmb_MouseMove(object sender, MouseEventArgs e)
        {
            pnlmovII.Visible = true;
            pnlmovII.Left = btnlmb.Left;
            pnlmovII.Width = btnlmb.Width;

            pBxlmb.Visible = true;

        }

        private void btnbef_Click(object sender, EventArgs e)
        {

            TPY = "2";

            // Call Select Form
            SelC();
        }

        private void btnprk_Click(object sender, EventArgs e)
        {

            TPY = "3";

            // Call Select Form
            SelC();
        }

        private void btnlmb_Click(object sender, EventArgs e)
        {

            TPY = "4";

            // Call Select Form
            SelC();
        }

        private void btnsf_Click(object sender, EventArgs e)
        {

            TPY = "5";

            // Call Select Form
            SelC();
        }

        private void btnDrnk_Click_1(object sender, EventArgs e)
        {
            CSN = "6";

            // Call Select Form
            SelC();
        }

        private void btnckn_MouseLeave(object sender, EventArgs e)
        {
            pBxChk.Visible = false;
        }

        private void btnbef_MouseLeave(object sender, EventArgs e)
        {
            pBxbef.Visible = false;
        }

        private void btnprk_MouseLeave(object sender, EventArgs e)
        {
            pBxprk.Visible = false;
        }

        private void btnlmb_MouseLeave(object sender, EventArgs e)
        {
            pBxlmb.Visible = false;
        }

        private void btnsf_MouseLeave(object sender, EventArgs e)
        {
            pBxsf.Visible = false;
        }

        private void btnsf_MouseMove(object sender, MouseEventArgs e)
        {
            pnlmovII.Visible = true;
            pnlmovII.Left = btnsf.Left;
            pnlmovII.Width = btnsf.Width;

            pBxsf.Visible = true;

        }

        private void btnNvg_Click(object sender, EventArgs e)
        {
            pnltyp.Visible = true;

            CTG = "1";

        }

        // Select which for, to load

        public void SelC()
        {
            if (MNU == "1")
            {
                // Display Receipe
                pnlmov.Visible = false;
                pnlmovII.Visible = false;
                pnlCatg.Visible = false;    
                pnltyp.Visible = false;
                pnLCuisines.Visible = false;
                frmDspRcp dsp = new frmDspRcp();
                dsp.Show();
            }
            else if (MNU == "2")
            {
                // Add recipe 
                pnlmov.Visible = false;
                pnlmovII.Visible = false;
                pnlCatg.Visible = false;
                pnltyp.Visible = false;
                pnLCuisines.Visible = false;
                FrmAddRecipe Adrsp = new FrmAddRecipe();
                Adrsp.Show();
            }
            else if (MNU == "3")
            {
                // Modify Receipe
                pnlmov.Visible = false;
                pnlmovII.Visible = false;
                pnlCatg.Visible = false;
                pnltyp.Visible = false;
                pnLCuisines.Visible = false;
                FrmModifyRecipe Morsp = new FrmModifyRecipe();
                Morsp.Show();
            }
            else 
            {
                // Delete Receipe
                pnlmov.Visible = false;
                pnlmovII.Visible = false;
                pnlCatg.Visible = false;
                pnltyp.Visible = false;
                pnLCuisines.Visible = false;
                frmDspRcp dsp = new frmDspRcp();
                dsp.Show();
            }
        }
    }
}