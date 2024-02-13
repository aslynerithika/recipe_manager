using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FoodManagerReceipr
{
    public partial class FrmAddRecipe : Form
    {

        public string dbfile = "URI=file:FoodManagerReceipe.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static int rat, stp;
        public static string [] Psteps = new string[10];
        public static string [,] IngrDet = new string[18,4];
        public static int nct = 1, Qct =0, Uct =0, ITct =0;

        public FrmAddRecipe()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void FrmAddRecipe_Load(object sender, EventArgs e)
        {
            msgb();
        }

        public void msgb()
        {
            if (frmFdMgr.CSN == "1") lblCui.Text = "ENGLISH";
            else if (frmFdMgr.CSN == "2") lblCui.Text = "ITALIAN";
            else if (frmFdMgr.CSN == "3") lblCui.Text = "INDIAN";
            else if (frmFdMgr.CSN == "4") lblCui.Text = "CHINESE";
            else if (frmFdMgr.CSN == "5") lblCui.Text = "JAPANESE";
            else if (frmFdMgr.CSN == "6") lblCui.Text = "DRINKS";

            if (frmFdMgr.CTG == "1") lblCatg.Text = "NON VEG";
            else if (frmFdMgr.CTG == "2") lblCatg.Text = "VEG";
            else if (frmFdMgr.CTG == "3") lblCatg.Text = "VEGAN";
            else if (frmFdMgr.CTG == "4") lblCatg.Text = "DESSERT";

            if (frmFdMgr.TPY == "1") lblTp.Text = "CHICKEN";
            else if (frmFdMgr.TPY == "2") lblTp.Text = "BEEF";
            else if (frmFdMgr.TPY == "3") lblTp.Text = "PORK";
            else if (frmFdMgr.TPY == "4") lblTp.Text = "LAMB";
            else if (frmFdMgr.TPY == "5") lblTp.Text = "SEAFOOD";

            pBxRcp.Image = null;

        }

        private void DrpBxStps_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // To get the selected value between 1..10
            string s = DrpBxStps.SelectedItem.ToString().Trim();
            int cnt = int.Parse(s.Trim());
            stp = int.Parse(s.Trim());
            TextBox[] a = new TextBox[cnt];
            
            try
            {
                int pointX = 3;
                int pointY = 3;
                pnlSteps.Controls.Clear();
                for (int i = 0; i < cnt; i++)
                {
                    if (i < 5)
                    { 
                      a[i] = new TextBox();
                      a[i].Text = (i + 1).ToString();
                      a[i].Multiline = true;
                      a[i].AutoSize = false;
                      a[i].Location = new Point(pointX, pointY);
                      a[i].Size = new System.Drawing.Size(590, 90);
                      a[i].Name = "Pst" + nct.ToString().Trim();
                      pnlSteps.Controls.Add(a[i]);
                      pnlSteps.Show();
                      pointY += 95;
                        nct = nct + 1;
                    }
                    else
                    {
                        pointX = 605;
                        if (i ==5) pointY = 3;
                        a[i] = new TextBox();
                        a[i].Text = (i + 1).ToString();
                        a[i].Multiline = true;
                        a[i].AutoSize = false;
                        a[i].Location = new Point(pointX, pointY);
                        a[i].Size = new System.Drawing.Size(590, 90);
                        a[i].Name = "Pst" + nct.ToString().Trim();
                        pnlSteps.Controls.Add(a[i]);
                        pnlSteps.Show();
                        pointY += 95;
                        nct = nct + 1;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

            DrpBxStps.Enabled = false;

        }

        private void pBxRcp_DoubleClick(object sender, EventArgs e)
        {
            pBxRcp.ImageLocation = @"D:\SHU\FoodManagerReceipr\data resorces\" + txtimgpic.Text.Trim();
        }

        private void btnIngrt_Click(object sender, EventArgs e)
        {
            // Add Dynamic Input boxes
            pnlIngrt.Visible = true;
            lblqty.Visible=true;
            lblUOM.Visible=true;
            lblitms.Visible=true;

            int pX1 =0, pX2 =66 ,pX3=134;
            int pY = 3, i=0;

            TextBox[] Q = new TextBox[25];
            ComboBox[] U = new ComboBox[25];
            TextBox[] Itm = new TextBox[25];

            for (i=0; i<18;i++)
            {
                // Add new text box for Quantity input
                Q[i] = new TextBox();
                Q[i].AutoSize = false;
                Q[i].Location = new Point(pX1, pY);
                Q[i].Size = new System.Drawing.Size(60, 25);
                Q[i].Name = "QtyBx"+i.ToString();
                pnlIngrt.Controls.Add(Q[i]);

                // Add text box for Items input
                Itm[i] = new TextBox();
                Itm[i].AutoSize = false;
                Itm[i].Location = new Point(pX3, pY);
                Itm[i].Size = new System.Drawing.Size(175, 25);
                Itm[i].Name = "ItmsBx" + i.ToString();
                pnlIngrt.Controls.Add(Itm[i]);

                // Add Combo box for selecting UOM
                U[i] = new ComboBox();
                U[i].Location = new Point(pX2, pY);
                U[i].Size = new System.Drawing.Size(68, 25);
                U[i].Name = "UOMBx" + i.ToString();
                ARSqlconn.Open();
                SQLiteCommand command = new SQLiteCommand(ARSqlconn);
                command.CommandText = "SELECT Abbv from UOM";
                command.ExecuteNonQuery();
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    U[i].Items.Add(reader["Abbv"]);
                }
                ARSqlconn.Close();
                pnlIngrt.Controls.Add(U[i]);

                pnlIngrt.Show();
                pY += 30;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Rid;
            // To save the details in receipe and Ingredients tables
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            command.CommandText = "SELECT R_ID from Counter";
            command.Prepare();
            command.ExecuteNonQuery();
            Rid = (Int32)command.ExecuteScalar();
            Rid = Rid + 1;
            string NRid = "RCP0" + Rid.ToString().Trim();
            ARSqlconn.Close();

            // To save the details in Receipe table
            string sta = "Active";
            string Tdt = DateTime.Now.ToString("yyyy/MM/dd");
            //txtAddRcpNm
            //Find Cuisine Name
            string Cnam=" ", Ftyp=" " , subty=" ";

            if (frmFdMgr.CSN == "1") Cnam = "C01";
            else if (frmFdMgr.CSN == "2") Cnam = "C02";
            else if (frmFdMgr.CSN == "3") Cnam = "C03";
            else if (frmFdMgr.CSN == "4") Cnam = "C04";
            else if (frmFdMgr.CSN == "5") Cnam = "C05";
            else if (frmFdMgr.CSN == "6")
            {
                Cnam = "C06";
                Ftyp = "T05";
                subty = "ST10";
            }

            if (frmFdMgr.CTG == "1") Ftyp = "T03";
            else if (frmFdMgr.CTG == "2")
            {
                Ftyp = "T01";
                subty = "ST07";
            }
            else if (frmFdMgr.CTG == "3")
            {
                Ftyp = "T02";
                subty = "ST08";
            }
            else if (frmFdMgr.CTG == "4")
            {
                Ftyp = "T04";
                subty = "ST09";

            }

            if (frmFdMgr.TPY == "1") subty = "ST01";
            else if (frmFdMgr.TPY == "2") subty = "ST04";
            else if (frmFdMgr.TPY == "3") subty = "ST06";
            else if (frmFdMgr.TPY == "4") subty = "ST03";
            else if (frmFdMgr.TPY == "5") subty = "ST05";

            string yld = txtAddYld.Text.Trim();
            string ctm = txtAddCt.Text.Trim();
            string ninf = txtAddCal.Text.Trim();
            string Rinf = txtAddIfo.Text.Trim();

            // Open connection to Rceipe table and insert new record
            ARSqlconn.Open();
            command.CommandText = ("INSERT INTO Receipe VALUES(@R1, @R2, @R3, @R4, @R5, @R6, @R7, @R8, @R9, @R10, @R11, @R12, @R13, @R14)");
            command.Parameters.AddWithValue("@R1", NRid);
            command.Parameters.AddWithValue("@R2", sta);
            command.Parameters.AddWithValue("@R3", Tdt);
            command.Parameters.AddWithValue("@R4", txtAddRcpNm.Text.Trim());
            command.Parameters.AddWithValue("@R5", Cnam);
            command.Parameters.AddWithValue("@R6", Ftyp);
            command.Parameters.AddWithValue("@R7", subty);
            command.Parameters.AddWithValue("@R8", yld);
            command.Parameters.AddWithValue("@R9", ctm);
            command.Parameters.AddWithValue("@R10", rat);
            command.Parameters.AddWithValue("@R11", ninf);
            command.Parameters.AddWithValue("@R12", Rinf);
            command.Parameters.AddWithValue("@R13", stp);
            command.Parameters.AddWithValue("@R14", txtimgpic.Text.Trim());

            command.ExecuteNonQuery();

            // Updating Counter table
            command.CommandText = ("UPDATE Counter SET R_ID=@RD");
            command.Parameters.AddWithValue("@RD", Rid);
            command.ExecuteNonQuery();

            
            ARSqlconn.Close();

            // Updating the Prepration Steps table
            nct = 0;
            foreach (Control childControl in pnlSteps.Controls)
            {
                if (childControl is TextBox)
                {
                    nct = nct + 1;
                    TextBox box = (TextBox)childControl;
                    //Retrieve and store value from Panel Steps -> childControl.Text
                    Psteps[nct-1] = box.Text;
                }
            }
            //Open connection to Prepare Steps Table
            ARSqlconn.Open();
            for (int i = 0; i < nct; i++)
            { 
            command.CommandText = ("INSERT INTO PrepareSteps VALUES(@R1, @R2, @R3)");
            command.Parameters.AddWithValue("@R1", NRid);
            command.Parameters.AddWithValue("@R2", i+1);
            command.Parameters.AddWithValue("@R3", Psteps[i]);
            command.ExecuteNonQuery();

            }
            ARSqlconn.Close();

            // Retrieve Qty and Item text box values from Panel Ingredients
            //public static string[,] IngrDet = new string[18, 3];
            //public static int nct = 1, Qct = 0, Uct = 0, ITct = 0;
            List<TextBox> listI = pnlIngrt.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb1 in listI)
            {
                if (tb1.Name.Contains("ItmsBx"))
                {
                    if (String.IsNullOrEmpty(tb1.Text.Trim()))
                    {
                        //Text Box is not empty
                    }
                    else
                    {
                        IngrDet[ITct, 3] = tb1.Text;
                        ITct = ITct + 1;
                    }
                }

            }

            List<TextBox> list = pnlIngrt.Controls.Cast<Control>().Where(i => i.GetType() == typeof(TextBox)).Cast<TextBox>().ToList();
            foreach (TextBox tb in list)
            {
                if (tb.Name.Contains("QtyBx"))
                {
                    if (String.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        //Text Box is not empty
                    }
                    else
                    {
                        IngrDet[Qct, 1] = tb.Text;
                        MessageBox.Show(IngrDet[Qct, 1]);
                        Qct = Qct + 1;
                    }
                }
            }

            // Retrieve Uom combo box values from panel Ingredients
            string abv;
            foreach (Control childControl in pnlIngrt.Controls)
            {
                if (childControl is ComboBox)
                {
                    ComboBox Cbox = (ComboBox)childControl;
                    //Retrieve and store value from Panel Steps -> childControl.Text
                    if (String.IsNullOrEmpty(Cbox.Text.Trim()))
                    {
                        //No task
                    }
                    else
                    {
                        abv = Cbox.Text.Trim();
                        // Got the Abbv... with that get the UOM_ID-Name-Abbv
                        ARSqlconn.Open();
                        command.CommandText = ("SELECT UOM_ID from UOM WHERE Abbv= @Um");
                        command.Parameters.AddWithValue("@Um", abv.Trim());
                        command.Prepare();
                        command.ExecuteNonQuery();
                        IngrDet[Uct, 2] = (string)command.ExecuteScalar();
                        ARSqlconn.Close();

                        Uct = Uct + 1;
                    }
                }
            }
            // To Insert the gathered values into Ingredients table
            ARSqlconn.Open();
            for (int i = 0; i < Uct; i++)
            {
                command.CommandText = ("INSERT INTO Ingredients VALUES(@I1, @I2, @I3, @I4)");
                command.Parameters.AddWithValue("@I1", NRid);
                command.Parameters.AddWithValue("@I2", IngrDet[i, 2]);
                command.Parameters.AddWithValue("@I3", IngrDet[i, 1]);
                command.Parameters.AddWithValue("@I4", IngrDet[i, 3]);
                command.ExecuteNonQuery();

            }
            ARSqlconn.Close();

            MessageBox.Show("The New Receipe "+ NRid + " - "+ txtAddRcpNm.Text.Trim()+ " has been added");
        }

        private void lblSteps_DoubleClick(object sender, EventArgs e)
        {
                        
            MessageBox.Show("Total Quantity Rows are " + Qct.ToString());
            MessageBox.Show("Total Items Rows are " + ITct.ToString());
        }

        private void cBxRat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string s = cBxRat.SelectedItem.ToString().Trim();

            if (s== "*") rat = 1;
            else if (s == "**") rat = 2;
            else if (s == "***") rat = 3; 
            else if (s == "****") rat = 4;
            else if (s == "*****") rat = 5; 
        }
    }
}
