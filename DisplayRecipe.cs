using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static FoodManagerReceipr.frmDspRcp;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodManagerReceipr
{
    public partial class frmDspRcp : Form
    {

        public string dbfile = "URI=file:FoodManagerReceipe.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static string RccPID;

        public frmDspRcp()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmDspRcp_Load(object sender, EventArgs e)
        {
            msgb();
            FillRecpNamGrd();

        }

        public void FillRecpNamGrd()
        {
            // Fill Listbox
            lBxRcpnam.Items.Clear();
            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            // Show Receipe as per selection
            //frmFdMgr.CSN, frmFdMgr.CTG, frmFdMgr.TPY
            string Cun = frmFdMgr.CSN, Cat = frmFdMgr.CTG, Ty = frmFdMgr.TPY;

            if (Cun == "1" && Cat == "1" && Ty == "1") // English - Non Veg - Chicken
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST01");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "1" && Ty == "2") // English - Non Veg - Beef
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST04");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "1" && Ty == "3") // English - Non Veg - Pork
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST06");
                command.Parameters.AddWithValue("@stus", "Active");

                //MessageBox.Show(" Display - Non Veg - Pork Selected");
            }
            else if (Cun == "1" && Cat == "1" && Ty == "4") // English - Non Veg - Lamb
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST03");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "1" && Ty == "5") // English - Non Veg - Seafood
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST05");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "2") // English - Veg
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T01");
                command.Parameters.AddWithValue("@sID", "ST07");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "3") // English - Vegan
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T02");
                command.Parameters.AddWithValue("@sID", "ST08");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "1" && Cat == "4") // English - Dessert
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T04");
                command.Parameters.AddWithValue("@sID", "ST09");
                command.Parameters.AddWithValue("@stus", "Active");

            }

            if (Cun == "2" && Cat == "1" && Ty == "1") // Italian - Non Veg - Chicken
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST01");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "1" && Ty == "2") // Italian - Non Veg - Beef
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST04");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "1" && Ty == "3") // Italian - Non Veg - Pork
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C01");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST06");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "1" && Ty == "4") // Italian - Non Veg - Lamb
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST03");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "1" && Ty == "5") // Italian - Non Veg - Seafood
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST05");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "2") // Italian - Veg
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T01");
                command.Parameters.AddWithValue("@sID", "ST07");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "3") // Italian - Vegan
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T02");
                command.Parameters.AddWithValue("@sID", "ST08");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "2" && Cat == "4") // Italian - Dessert
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C02");
                command.Parameters.AddWithValue("@tID", "T04");
                command.Parameters.AddWithValue("@sID", "ST09");
                command.Parameters.AddWithValue("@stus", "Active");
            }

            if (Cun == "3" && Cat == "1" && Ty == "1") // Indian - Non Veg - Chicken
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST01");
                command.Parameters.AddWithValue("@stus", "Active");
            }
            else if (Cun == "3" && Cat == "1" && Ty == "2") // Indian - Non Veg - Beef
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST04");
                command.Parameters.AddWithValue("@stus", "Active");
            }
            else if (Cun == "3" && Cat == "1" && Ty == "3") // Indian - Non Veg - Pork
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST06");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "3" && Cat == "1" && Ty == "4") // Indian - Non Veg - Lamb
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST03");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "3" && Cat == "1" && Ty == "5") // Indian - Non Veg - Seafood
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID AND Status = @stus ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST05");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "3" && Cat == "2") // Indian - Veg
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T01");
                command.Parameters.AddWithValue("@sID", "ST07");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "3" && Cat == "3") // Indian - Vegan
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T02");
                command.Parameters.AddWithValue("@sID", "ST08");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "3" && Cat == "4") // Indian - Dessert
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C03");
                command.Parameters.AddWithValue("@tID", "T04");
                command.Parameters.AddWithValue("@sID", "ST09");
                command.Parameters.AddWithValue("@stus", "Active");

            }

            if (Cun == "4" && Cat == "1" && Ty == "1") // Chinese - Non Veg - Chicken
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST01");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "1" && Ty == "2") // Chinese - Non Veg - Beef
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST04");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "1" && Ty == "3") // Chinese - Non Veg - Pork
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST06");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "1" && Ty == "4") // Chinese - Non Veg - Lamb
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST03");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "1" && Ty == "5") // Chinese - Non Veg - Seafood
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST05");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "2") // Chinese - Veg
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T01");
                command.Parameters.AddWithValue("@sID", "ST07");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "3") // Chinese - Vegan
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T02");
                command.Parameters.AddWithValue("@sID", "ST08");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "4" && Cat == "5") // Chinese - Dessert
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T04");
                command.Parameters.AddWithValue("@sID", "ST09");
                command.Parameters.AddWithValue("@stus", "Active");

            }


            if (Cun == "5" && Cat == "1" && Ty == "1") // Japanese - Non Veg - Chicken
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST01");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "1" && Ty == "2") // Japanese - Non Veg - Beef
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C04");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST04");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "1" && Ty == "3") // Japanese - Non Veg - Pork
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST06");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "1" && Ty == "4") // Japanese - Non Veg - Lamb
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST03");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "1" && Ty == "5") // Japanese - Non Veg - Seafood
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T03");
                command.Parameters.AddWithValue("@sID", "ST05");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "2") // Japanese - Veg
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T01");
                command.Parameters.AddWithValue("@sID", "ST07");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "3") // Japanese - Vegan
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T02");
                command.Parameters.AddWithValue("@sID", "ST08");
                command.Parameters.AddWithValue("@stus", "Active");

            }
            else if (Cun == "5" && Cat == "5") // Japanese - Dessert
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C05");
                command.Parameters.AddWithValue("@tID", "T04");
                command.Parameters.AddWithValue("@sID", "ST09");
                command.Parameters.AddWithValue("@stus", "Active");

            }

            if (Cun == "6") // Drink 
            {
                command.CommandText = "select RecipeName from Receipe Where Cus_ID = @cID AND Typ_ID = @tID AND SubCat_ID = @sID ORDER BY RecipeName ASC"; ;
                command.Parameters.AddWithValue("@cID", "C06");
                command.Parameters.AddWithValue("@tID", "T05");
                command.Parameters.AddWithValue("@sID", "ST10");
                command.Parameters.AddWithValue("@stus", "Active");

            }

            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                lBxRcpnam.Items.Add(reader["RecipeName"]);
            }
            ARSqlconn.Close();

        }

        //On double click - Display the Receipe details

        public void msgb()
        {
            if (frmFdMgr.CSN == "1") lblcus.Text = "ENGLISH";
            else if (frmFdMgr.CSN == "2") lblcus.Text = "ITALIAN";
            else if (frmFdMgr.CSN == "3") lblcus.Text = "INDIAN";
            else if (frmFdMgr.CSN == "4") lblcus.Text = "CHINESE";
            else if (frmFdMgr.CSN == "5") lblcus.Text = "JAPANESE";
            else if (frmFdMgr.CSN == "6") lblcus.Text = "DRINKS";

            if (frmFdMgr.CTG == "1") lblCat.Text = "NON VEG";
            else if (frmFdMgr.CTG == "2") lblCat.Text = "VEG";
            else if (frmFdMgr.CTG == "3") lblCat.Text = "VEGAN";
            else if (frmFdMgr.CTG == "4") lblCat.Text = "DESSERT";

            if (frmFdMgr.TPY == "1") lbltyp.Text = "CHICKEN";
            else if (frmFdMgr.TPY == "2") lbltyp.Text = "BEEF";
            else if (frmFdMgr.TPY == "3") lbltyp.Text = "PORK";
            else if (frmFdMgr.TPY == "4") lbltyp.Text = "LAMB";
            else if (frmFdMgr.TPY == "5") lbltyp.Text = "SEAFOOD";
        }

        //int RwId;

        private void lBxRcpnam_DoubleClick(object sender, EventArgs e)
        {
            // Declaring the class variable and using inherting its objects
            FoodRecipe myRecipe = new FoodRecipe();

            // When double click the row in the Grid table it should fetch the values in the text box
            // Blank All Label Cell
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            //File the textbox / label box and radio button values with the row selected
            if (lBxRcpnam.SelectedItem != null)
            {
                lblRnm.Text = lBxRcpnam.SelectedItem.ToString();
            }

            myRecipe.RCP_Name = lblRnm.Text.Trim();

            ARSqlconn.Open();
            ARCmd = new SQLiteCommand(ARSqlconn);
            ARCmd.CommandText = "SELECT Rcp_ID from Receipe WHERE RecipeName = @RCiD";
            ARCmd.Parameters.AddWithValue("@RCiD", myRecipe.RCP_Name);
            ARCmd.Prepare();
            ARCmd.ExecuteNonQuery();
            myRecipe.RCP_ID = (string)ARCmd.ExecuteScalar();
            RccPID = myRecipe.RCP_ID;

            ARDap = new SQLiteDataAdapter("select * from Receipe WHERE Rcp_ID='" + myRecipe.RCP_ID + "'", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB1 = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGWRcnm.DataSource = ARTbl;

            myRecipe.Cus_ID = dGWRcnm.Rows[0].Cells["Cus_ID"].Value.ToString();
            myRecipe.Typ_ID = dGWRcnm.Rows[0].Cells["Typ_ID"].Value.ToString();
            myRecipe.SubCat_ID = dGWRcnm.Rows[0].Cells["SubCat_ID"].Value.ToString();

            lblCal.Text = dGWRcnm.Rows[0].Cells["NutritionInfo"].Value.ToString();
            lblYld.Text = dGWRcnm.Rows[0].Cells["Yield"].Value.ToString();
            lblCt.Text = dGWRcnm.Rows[0].Cells["CookTime"].Value.ToString();
            lblRt.Text = dGWRcnm.Rows[0].Cells["Rating"].Value.ToString();
            lblRI.Text = dGWRcnm.Rows[0].Cells["receipeInfo"].Value.ToString();

            pBxRcp.ImageLocation = @"D:\SHU\FoodManagerReceipr\data resorces\" + dGWRcnm.Rows[0].Cells["Pic"].Value.ToString();

            // Display Ingredients details for selected Receipe 
            SQLiteCommand cmd = new SQLiteCommand(
            @"select 
            Ingredients.OUM,
            UOM.Abbv,
            Ingredients.Items
            from Ingredients
            inner join UOM on Ingredients.UOM_ID = 
            UOM.UOM_ID
            where Ingredients.Rcp_ID= @RiD", ARSqlconn);

            cmd.Parameters.AddWithValue("@RiD", myRecipe.RCP_ID);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
            SQLiteCommandBuilder ARCdB2 = new SQLiteCommandBuilder(sda);
            ARTbl = new DataTable();
            sda.Fill(ARTbl);
            dGVIngdt.DataSource = ARTbl;

            ARSqlconn.Open();
            ARCmd = new SQLiteCommand(ARSqlconn);
            ARCmd.CommandText = "SELECT CuisineName FROM Cuisines WHERE Cuisines.Cus_ID = @CiD";
            ARCmd.Parameters.AddWithValue("@CiD", myRecipe.Cus_ID);
            ARCmd.Prepare();
            ARCmd.ExecuteNonQuery();
            lblCui.Text = (string)ARCmd.ExecuteScalar();

            ARCmd.CommandText = "SELECT FoodType FROM Types WHERE Types.Typ_ID = @TiD";
            ARCmd.Parameters.AddWithValue("@TiD", myRecipe.Typ_ID);
            ARCmd.Prepare();
            ARCmd.ExecuteNonQuery();
            lblCatg.Text = (string)ARCmd.ExecuteScalar();

            ARCmd.CommandText = "SELECT SubCat FROM Sub_Category WHERE Sub_Category.SubCat_ID = @SiD";
            ARCmd.Parameters.AddWithValue("@SiD", myRecipe.SubCat_ID);
            ARCmd.Prepare();
            ARCmd.ExecuteNonQuery();
            lblTp.Text = (string)ARCmd.ExecuteScalar();

            ARCmd.CommandText = "SELECT count(*) FROM PrepareSteps WHERE PrepareSteps.Rcp_ID = @RiD";
            ARCmd.Parameters.AddWithValue("@RiD", myRecipe.RCP_ID);
            int cnt = Convert.ToInt32(ARCmd.ExecuteScalar());

       
            ARDap = new SQLiteDataAdapter("SELECT Preparation_Details FROM PrepareSteps WHERE PrepareSteps.Rcp_ID ='" + myRecipe.RCP_ID + "'", ARSqlconn);
            ARSqlconn.Close();
            SQLiteCommandBuilder ARCdB = new SQLiteCommandBuilder(ARDap);
            ARTbl = new DataTable();
            ARDap.Fill(ARTbl);
            dGWStp.DataSource = ARTbl;

            int idx = 0;
            foreach (DataGridViewRow row in dGWStp.Rows)
            {
                if (idx == 0 && idx < cnt)
                {
                    label1.Visible = true;
                    label1.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 1 && idx < cnt)
                {
                    label2.Visible = true;
                    label2.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 2 && idx < cnt)
                {
                    label3.Visible = true;
                    label3.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 3 && idx < cnt)
                {
                    label4.Visible = true;
                    label4.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 4 && idx < cnt)
                {
                    label5.Visible = true;
                    label5.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 5 && idx < cnt)
                {
                    label6.Visible = true;
                    label6.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 6 && idx < cnt)
                {
                    label7.Visible = true;
                    label7.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 7 && idx < cnt)
                {
                    label8.Visible = true;
                    label8.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 8 && idx < cnt)
                {
                    label9.Visible = true;
                    label9.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }
                else if (idx == 9 && idx < cnt)
                {
                    label10.Visible = true;
                    label10.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                }

                idx++;

            }

        }

        private void btnInactv_Click(object sender, EventArgs e)
        {
            ARSqlconn.Open();
            ARCmd = new SQLiteCommand(ARSqlconn);
            ARCmd.CommandText = "UPDATE Receipe SET Status = @st WHERE Rcp_ID  = @RCiD";
            ARCmd.Parameters.AddWithValue("@st", "Inactive");
            ARCmd.Parameters.AddWithValue("@RCiD", RccPID);
            ARCmd.Prepare();
            ARCmd.ExecuteNonQuery();

            MessageBox.Show("The Receipe "+ RccPID + " is been Inactivate... Cannot be Displayed/Edited");
        }
    }

}
