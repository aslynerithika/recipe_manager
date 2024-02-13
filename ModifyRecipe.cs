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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodManagerReceipr
{
    public partial class FrmModifyRecipe : Form
    {

        public string dbfile = "URI=file:FoodManagerReceipe.db";
        public SQLiteConnection ARSqlconn;
        public SQLiteCommand ARCmd;
        public SQLiteDataReader ARDataReader;
        public SQLiteDataAdapter ARDap;
        public DataTable ARTbl;
        public static int rat, stp;
        public static string[] Psteps = new string[10];
        public static string RccPID;
        public static string[,] IngrDet = new string[20, 4];
        public static int nct = 0, Qct = 0, Uct = 0, ITct = 0;
        public static int idx = 0;


        public FrmModifyRecipe()
        {
            InitializeComponent();
            ARSqlconn = new SQLiteConnection(dbfile);
            this.WindowState = FormWindowState.Maximized;

        }

        private void ModifyRecipe_Load(object sender, EventArgs e)
        {
            msgb();
            FillRecpNamGrd();
            // Add emtpty to each cells
            for (int i =0; i < 15; i++)
                for(int j =0; j < 4; j++)
                {
                    IngrDet[i , j] = " ";
                }

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
            FoodRecipe myRecipe = new FoodRecipe();

            // When double click the row in the Grid table it should fetch the values in the text box
            // Blank All Label Cell
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            Text5.Text = "";
            Text6.Text = "";
            Text7.Text = "";
            Text8.Text = "";
            Text9.Text = "";
            Text10.Text = "";

            Text1.Visible = false;
            Text2.Visible = false;
            Text3.Visible = false;
            Text4.Visible = false;
            Text5.Visible = false;
            Text6.Visible = false;
            Text7.Visible = false;
            Text8.Visible = false;
            Text9.Visible = false;
            Text10.Visible = false;

            //File the textbox / label box and radio button values with the row selected
            if (lBxRcpnam.SelectedItem != null)
            {
                TxtRnm.Text = lBxRcpnam.SelectedItem.ToString();
            }

            myRecipe.RCP_Name = TxtRnm.Text.Trim();

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

            TxtCal.Text = dGWRcnm.Rows[0].Cells["NutritionInfo"].Value.ToString();
            TxtYld.Text = dGWRcnm.Rows[0].Cells["Yield"].Value.ToString();
            TxtCt.Text = dGWRcnm.Rows[0].Cells["CookTime"].Value.ToString();
            int rtr = int.Parse(dGWRcnm.Rows[0].Cells["Rating"].Value.ToString());
            string rrat = dGWRcnm.Rows[0].Cells["Rating"].Value.ToString().Trim();
            //rat = rtr;
            //MessageBox.Show("Rating is " + rtr.ToString());
            if (rrat == "1")
                cBxRat.SelectedIndex = cBxRat.FindStringExact("*");
            else if (rrat == "2")
                cBxRat.SelectedIndex = cBxRat.FindStringExact("**");
            else if (rrat == "3")
                cBxRat.SelectedIndex = cBxRat.FindStringExact("***");
            else if (rrat == "4")
                cBxRat.SelectedIndex = cBxRat.FindStringExact("****");
            else if (rrat == "5")
                cBxRat.SelectedIndex = cBxRat.FindStringExact("*****");

            TxtRI.Text = dGWRcnm.Rows[0].Cells["receipeInfo"].Value.ToString();

            pBxRcp.ImageLocation = @"D:\SHU\FoodManagerReceipr\data resorces\" + dGWRcnm.Rows[0].Cells["Pic"].Value.ToString();
            txtimgpic.Text = dGWRcnm.Rows[0].Cells["Pic"].Value.ToString();
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
            Int32 index = dGVIngdt.Rows.Count - 1;
            int vi = 0;
            //Copy Gridview details inot string array
            foreach (DataGridViewRow r in dGVIngdt.Rows)
            {
                if (vi < index)
                {
                    IngrDet[vi, 0] = r.Cells[0].Value.ToString();
                    IngrDet[vi, 1] = r.Cells[1].Value.ToString();
                    IngrDet[vi, 2] = r.Cells[2].Value.ToString();
                    vi = vi + 1;
                }
            }


            // Add Dynamic test and combo box and dispplay current ingredients list
            int pX1 = 0, pX2 = 66, pX3 = 134;
            int pY = 3, i = 0;

            TextBox[] Q = new TextBox[25];
            ComboBox[] U = new ComboBox[25];
            TextBox[] Itm = new TextBox[25];

            for (i = 0; i < 18; i++)
            {
                // Add new text box for Quantity input
                Q[i] = new TextBox();
                Q[i].AutoSize = false;
                Q[i].Location = new Point(pX1, pY);
                Q[i].Size = new System.Drawing.Size(60, 25);
                Q[i].Name = "QtyBx" + i.ToString();
                Q[i].Text = IngrDet[i, 0];
                pnlIngrt.Controls.Add(Q[i]);

                // Add text box for Items input
                Itm[i] = new TextBox();
                Itm[i].AutoSize = false;
                Itm[i].Location = new Point(pX3, pY);
                Itm[i].Size = new System.Drawing.Size(175, 25);
                Itm[i].Name = "ItmsBx" + i.ToString();
                Itm[i].Text = IngrDet[i, 2];
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

                U[i].SelectedIndex = U[i].FindStringExact(IngrDet[i, 1]);
                ARSqlconn.Close();
                pnlIngrt.Controls.Add(U[i]);

                pnlIngrt.Show();
                pY += 30;

            }

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

            Text1.Visible = true;
            Text2.Visible = true;
            Text3.Visible = true;
            Text4.Visible = true;
            Text5.Visible = true;
            Text6.Visible = true;
            Text7.Visible = true;
            Text8.Visible = true;
            Text9.Visible = true;
            Text10.Visible = true;

            foreach (DataGridViewRow row in dGWStp.Rows)
            {
                if (idx == 0 && idx < cnt) Text1.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 1 && idx < cnt) Text2.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 2 && idx < cnt) Text3.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 3 && idx < cnt) Text4.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 4 && idx < cnt) Text5.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 5 && idx < cnt) Text6.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 6 && idx < cnt) Text7.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 7 && idx < cnt) Text8.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 8 && idx < cnt) Text9.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();
                else if (idx == 9 && idx < cnt) Text10.Text = dGWStp.Rows[idx].Cells["Preparation_Details"].Value.ToString();

                idx++;
            }
            idx = idx - 1;
            //MessageBox.Show("Total Steps are " + idx.ToString());
        }

        private void btnModSav_Click(object sender, EventArgs e)
        {
            // To update the modified details to receipe/Prepration Steps and Ingrdients table

            // Updating the Prepration Steps table
            int nnct = 0;

            if (Text1.Text.Length != 0) { Psteps[0] = Text1.Text; nnct = 0; }
            if (Text2.Text.Length != 0) { Psteps[1] = Text2.Text; nnct = 1; }
            if (Text3.Text.Length != 0) { Psteps[2] = Text3.Text; nnct = 2; }
            if (Text4.Text.Length != 0) { Psteps[3] = Text4.Text; nnct = 3; }
            if (Text5.Text.Length != 0) { Psteps[4] = Text5.Text; nnct = 4; }
            if (Text6.Text.Length != 0) { Psteps[5] = Text6.Text; nnct = 5; }
            if (Text7.Text.Length != 0) { Psteps[6] = Text7.Text; nnct = 6; }
            if (Text8.Text.Length != 0) { Psteps[7] = Text8.Text; nnct = 7; }
            if (Text9.Text.Length != 0) { Psteps[8] = Text9.Text; nnct = 8; }
            if (Text10.Text.Length != 0) { Psteps[9] = Text10.Text; nnct = 9; }
            nct = nnct;
            //MessageBox.Show("Total Steps = " + int.Parse((nct+1).ToString()));

            ARSqlconn.Open();
            SQLiteCommand command = new SQLiteCommand(ARSqlconn);
            //Find Cuisine Name
            string Cnam = " ", Ftyp = " ", subty = " ";

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

            string yld = TxtYld.Text.Trim();
            string ctm = TxtCt.Text.Trim();
            string ninf = TxtCal.Text.Trim();
            string Rinf = TxtRI.Text.Trim();

            // Open connection to Rceipe table and insert new record
            command.CommandText = ("UPDATE Receipe SET RecipeName=@R4, Cus_ID=@R5, Typ_ID=@R6, SubCat_ID=@R7, Yield=@R8, CookTime=@R9, Rating=@R10, NutritionInfo=@R11, receipeInfo=@R12, Steps=@R13, Pic=@R14 where RCP_ID = @R15");
            command.Parameters.AddWithValue("@R4", TxtRnm.Text.Trim());
            command.Parameters.AddWithValue("@R5", Cnam);
            command.Parameters.AddWithValue("@R6", Ftyp);
            command.Parameters.AddWithValue("@R7", subty);
            command.Parameters.AddWithValue("@R8", yld);
            command.Parameters.AddWithValue("@R9", ctm);
            command.Parameters.AddWithValue("@R10", rat);
            command.Parameters.AddWithValue("@R11", ninf);
            command.Parameters.AddWithValue("@R12", Rinf);
            command.Parameters.AddWithValue("@R13", nct+1);
            command.Parameters.AddWithValue("@R14", txtimgpic.Text.Trim()); 
            command.Parameters.AddWithValue("@R15", RccPID);

            command.ExecuteNonQuery();

            ARSqlconn.Close();


             //Open connection to Prepare Steps Table
                            //First delete previous Receipe steps entries
                            ARSqlconn.Open();
                            command.CommandText = ("DELETE FROM PrepareSteps WHERE RCP_ID=@R1");
                            command.Parameters.AddWithValue("@R1", RccPID);
                            command.ExecuteNonQuery();

                            //Now add the modifed prepration steps
                            for (int i = 0; i <= nct; i++)
                            {
                                command.CommandText = ("INSERT INTO PrepareSteps VALUES(@R1, @R2, @R3)");
                                command.Parameters.AddWithValue("@R1", RccPID);
                                command.Parameters.AddWithValue("@R2", i + 1);
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
                                        //MessageBox.Show(IngrDet[Qct, 1]);
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
                            // !st delete the existing receipt Ingredients details then add again with modified details
                            command.CommandText = ("DELETE FROM Ingredients WHERE RCP_ID=@I1");
                            command.Parameters.AddWithValue("@I1", RccPID);
                            command.ExecuteNonQuery();

                            // Now add the modified Ingredients details
                            for (int i = 0; i < Uct; i++)
                            {
                                command.CommandText = ("INSERT INTO Ingredients VALUES(@I1, @I2, @I3, @I4)");
                                command.Parameters.AddWithValue("@I1", RccPID);
                                command.Parameters.AddWithValue("@I2", IngrDet[i, 2]);
                                command.Parameters.AddWithValue("@I3", IngrDet[i, 1]);
                                command.Parameters.AddWithValue("@I4", IngrDet[i, 3]);
                                command.ExecuteNonQuery();

                            }
                            ARSqlconn.Close();

                            MessageBox.Show("The Receipe " + RccPID + " - " + TxtRnm.Text.Trim() + " has been modified successfuly");
                        }

                        private void cBxRat_SelectionChangeCommitted(object sender, EventArgs e)
                        {
                            string s = cBxRat.SelectedItem.ToString().Trim();

                            if (s == "*") rat = 1;
                            else if (s == "**") rat = 2;
                            else if (s == "***") rat = 3;
                            else if (s == "****") rat = 4;
                            else if (s == "*****") rat = 5;
                        }

                    }

                }
