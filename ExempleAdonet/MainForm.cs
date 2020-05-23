 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using PhotoManagerClient;
using EvaluationDemo;
using DB_Images_Utilities;
using System.Collections.Specialized;

namespace ExempleAdonet
{
    public partial class Main : Form
    {
        // Attributs //
        private string[] Tab;
        private OracleParameter mDate;
        private string mHistoire, mNomMonument;
        private int mNbEtoiles { get; set; }
        private DateTime Date { get; set; }
        private DataGridViewCellEventArgs t;
        public string mNom, mAdresse, mPrenom, mId;
        private string mPrix;
        private List<string> mListMonument;
        private DB_Images mDB_Images;
        private DataSet mDataSetCircuit;
        private DataSet mDataSetMonument;
        private OracleDataAdapter mOracleAdapter;
        private string mSqlCommand { get; set; }
        private bool mDGV_MonumentActive { get; set; }
        private bool mDGV_CircuitActive { get; set; }
        private bool EstConnect = false;

        public Main()
        {
            InitializeComponent();

            // Initialiser les composants //
            mDataSetCircuit = new DataSet();
            mDataSetMonument = new DataSet();
            mOracleAdapter = new OracleDataAdapter();
            mSqlCommand = "";
            KeyPreview = true;
        }

        OracleConnection mOracleConnection = new OracleConnection();

        private void Main_Load(object sender, EventArgs e)
        {
            LoadSettings();
            string DateMenu = DateTime.Today.ToLongDateString();
            LBX_Date.Text = DateMenu;
            mDB_Images = new DB_Images("BaboucheQc", "9952");
            mDGV_MonumentActive = false;
            mDGV_CircuitActive = false;
        }

        private void AfficherDGV()
        {
            try
            {
                mOracleAdapter.SelectCommand = new OracleCommand(mSqlCommand, mOracleConnection);

                if (mDataSetCircuit.Tables.Contains("ListeCircuits"))
                {
                    mDataSetCircuit.Tables["ListeCircuits"].Clear();
                }

                mDataSetCircuit.Reset();
                mOracleAdapter.Fill(mDataSetCircuit, "ListeCircuits");

                DGV_Circuit.DataSource = new BindingSource(mDataSetCircuit, "ListeCircuits");
                mOracleAdapter.Dispose();
            }
            catch (Exception error)
            {
                // Affiche le message d'erreur //
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void AfficherDGV2()
        {
            DGV_Monuments.Hide();
            DGV_Monuments.Show();
            try
            {
                mOracleAdapter.SelectCommand = new OracleCommand(mSqlCommand, mOracleConnection);

                if (mDataSetMonument.Tables.Contains("ListeCircuits"))
                {
                    mDataSetMonument.Tables["ListeCircuits"].Clear();
                }

                mDataSetMonument.Reset();
                mOracleAdapter.Fill(mDataSetMonument, "ListeCircuits");

                DGV_Monuments.DataSource = new BindingSource(mDataSetMonument, "ListeCircuits");
                mOracleAdapter.Dispose();
            }
            catch (Exception error)
            {
                // Affiche le message d'erreur //
                MessageBox.Show(error.Message.ToString());
            }
        }

        private bool GetConnectionState()
        {
            return mOracleConnection.State.ToString() == "Open";
        }

        private void BTN_Dashboard_MouseHover(object sender, EventArgs e)
        {
            this.BTN_AjouterCircuit.BackColor = Color.FromArgb(31, 43, 55);
        }

        //----------------------------------------------------------------------------
        //                        Partie responsable des circuits //
        //----------------------------------------------------------------------------
        private void AjouterCircuit(string[] Informations)
        {
            try
            {
                string sqlcommand = "INSERT INTO CIRCUIT" +
                    "(NOMCIRCUIT, PRIX, DURÉE, CODEVILLEDEPART, CODEVILLEARRIVÉE, NUMEROSEQUNTIEL) VALUES" +
                    "(:nom, :prix, :duree, :codevilledepart, :codevillearrivee, seq_Circuit.nextval)";

                OracleParameter NOMCIRCUIT = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
                OracleParameter PRIX = new OracleParameter(":prix", OracleDbType.Decimal, 6);
                OracleParameter DUREE = new OracleParameter(":duree", OracleDbType.Int32, 3);
                OracleParameter CODEVILLEDEPART = new OracleParameter(":codevilledepart", OracleDbType.Char, 3);
                OracleParameter CODEVILLEARRIVEE = new OracleParameter(":codevillearrivee", OracleDbType.Char, 3);
                NOMCIRCUIT.Value = Informations[0];
                PRIX.Value = Informations[1];
                DUREE.Value = Informations[2];
                CODEVILLEDEPART.Value = GetCodeVille(Informations[3]);
                CODEVILLEARRIVEE.Value = GetCodeVille(Informations[4]);
              
                OracleCommand OraAddCircuit = new OracleCommand(sqlcommand, mOracleConnection);
                OraAddCircuit.CommandType = CommandType.Text;

                OraAddCircuit.Parameters.Add(NOMCIRCUIT);
                OraAddCircuit.Parameters.Add(PRIX);
                OraAddCircuit.Parameters.Add(DUREE);
                OraAddCircuit.Parameters.Add(CODEVILLEDEPART);
                OraAddCircuit.Parameters.Add(CODEVILLEARRIVEE);
                OraAddCircuit.ExecuteNonQuery();
            }
            catch (Exception test)
            {
                MessageBox.Show(test.Message.ToString());
            }
        }

        /// <summary>
        /// Ajoute les circuits dans une liste
        /// </summary>
        /// <param name="list"></param>
        private void RemplirCircuit(List<string> list)
        {
            if (GetConnectionState())
            {
                string sql3 = "SELECT DISTINCT NOMCIRCUIT FROM CIRCUIT";
                OracleCommand cmd3 = new OracleCommand(sql3, mOracleConnection);
                OracleDataReader reader2 = cmd3.ExecuteReader();
                while (reader2.Read())
                {
                    list.Add(reader2.GetValue(0).ToString());
                }

                reader2.Close();
            }
            else
                MessageBox.Show("Vous devez être connecté à la base de données!");
        }

        //----------------------------------------------------------------------------
        //                        Partie responsable des monuments //
        //----------------------------------------------------------------------------
        private void AjouterMonument(string[] Informations, Image image)
        {
            try
            {
                string Image_GUID = mDB_Images.Add(image);
                string sqlAddMonument = "insert into monuments" +
                    "(IdMonument,nom , DateDeCreation ,histoire , NbEtoiles, GUID)values" +
                    "(seq_Monuments.nextval,:nom,:DateDeCreation,:histoire,:NbEtoiles,:GUID)";
                OracleParameter nom = new OracleParameter(":nom,", OracleDbType.Varchar2, 30);
                OracleParameter Date = new OracleParameter(":DateDeCreation", OracleDbType.Date);
                OracleParameter story = new OracleParameter(":histoire", OracleDbType.Varchar2, 100);
                OracleParameter Star = new OracleParameter(":NbEtoiles", OracleDbType.Int32, 1);
                OracleParameter Guid = new OracleParameter(":GUID", OracleDbType.Varchar2, 100);
                nom.Value = Informations[0];
                story.Value = Informations[2];
                Star.Value = Informations[1];
                Date.Value = mDate.Value;
                Guid.Value = Image_GUID;

                OracleCommand OraAddMonument = new OracleCommand(sqlAddMonument, mOracleConnection);
                OraAddMonument.CommandType = CommandType.Text;

                OraAddMonument.Parameters.Add(nom);
                OraAddMonument.Parameters.Add(Date);
                OraAddMonument.Parameters.Add(story);
                OraAddMonument.Parameters.Add(Star);
                OraAddMonument.Parameters.Add(Guid);
                OraAddMonument.ExecuteNonQuery();

                int IdMonumment = 0;
                int NbMonuments = 0;
                string sql11 = "SELECT IDMONUMENT FROM MONUMENTS WHERE NOM = '" + Informations[0] + "'";
                OracleCommand cmd3 = new OracleCommand(sql11, mOracleConnection);
                OracleDataReader reader2 = cmd3.ExecuteReader();
                reader2.Read();
                IdMonumment = int.Parse(reader2.GetDecimal(0).ToString());
                reader2.Close();

                // Lier un monument à un circuit //
                NbMonuments = GetNbMonumentsParCircuit(Informations[3]);
                NbMonuments++;
                string sql = "INSERT INTO CIRCUITMONUMENTS VALUES ( " + IdMonumment + ", '" + Informations[3] + "'," + NbMonuments + ")";
                OracleCommand OraInsertMonumentIntoCircuit = new OracleCommand(sql, mOracleConnection);
                OraInsertMonumentIntoCircuit.ExecuteNonQuery();

                RemplirCBB_Monument();
            }

            catch (Exception sqlAddMonument)
            {
                MessageBox.Show(sqlAddMonument.Message.ToString());
            }
        }

        private int GetIdMonument(string NomMonument)
        {
            int Identifiant = 0;
            try
            {
                string sql = "SELECT IDMONUMENT FROM MONUMENTS WHERE NOM = '" + NomMonument + "'";
                OracleCommand oracleCommand = new OracleCommand(sql, mOracleConnection);
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                Identifiant = Int32.Parse(oracleDataReader.GetValue(0).ToString());
                oracleDataReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return Identifiant;
        }

        // Cette fonction permet de calculer le nombre de monumments dans un circuit pour pouvoir assigner le bon ordre lors d'une visite //
        private int GetNbMonumentsParCircuit(string NomCircuit)
        {
            int NbMonument = 0;
            string sql = "SELECT COUNT(*) AS NombreMonuments FROM MONUMENTS M INNER JOIN CIRCUITMONUMENTS CM ON M.IDMONUMENT = CM.IDMONUMENT INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT WHERE C.NOMCIRCUIT ='" + NomCircuit + "' ORDER BY NombreMonuments";
            OracleCommand oracleCommand = new OracleCommand(sql, mOracleConnection);
            OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

            oracleDataReader.Read();
            NbMonument = Int32.Parse(oracleDataReader.GetValue(0).ToString());

            oracleDataReader.Close();

            return NbMonument;
        }

        /// <summary>
        /// Permet de supprimer des monuments
        /// </summary>
        private void SupprimerMonument()
        {
            try
            {
                DialogResult dr = MessageBox.Show("Voulez-vous supprimer ce monument?", "Supprimer un monument...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(GetGUID(DGV_Monuments.Rows[t.RowIndex].Cells[0].Value.ToString())))
                    {
                        string GUID = GetGUID(DGV_Monuments.Rows[t.RowIndex].Cells[0].Value.ToString());
                        string sql11 = "DELETE FROM MONUMENTS WHERE NOM = '" + DGV_Monuments.Rows[t.RowIndex].Cells[0].Value.ToString() + "'";
                        OracleCommand cmd11 = new OracleCommand(sql11, mOracleConnection);
                        cmd11.ExecuteNonQuery();
                        mDB_Images.Delete(GUID); // Permet de supprimer l'iamge du serveur //
                    }
                    FBTN_AfficherMonument.PerformClick();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Permet d'ajouter les monuments dans une liste
        /// </summary>
        private void RemplirCBB_Monument()
        {
            if (GetConnectionState())
            {
                CBB_Monument.Items.Clear();
                string sql3 = "SELECT NOM FROM MONUMENTS";
                OracleCommand cmd3 = new OracleCommand(sql3, mOracleConnection);
                OracleDataReader reader2 = cmd3.ExecuteReader();
                mListMonument = new List<string>();
                while (reader2.Read())
                {
                    CBB_Monument.Items.Add(reader2.GetValue(0));
                    mListMonument.Add(reader2.GetValue(0).ToString());
                }

                reader2.Close();
            }
            else
                MessageBox.Show("Vous devez être connecté à la base de données!");
        }

        //----------------------------------------------------------------------------
        //               Partie responsable des Click sur les outils //
        //----------------------------------------------------------------------------
        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            mOracleConnection.Close(); // Fermer la connction //
            Application.Exit();
        }

        // Permer de se connecter à la base de données //
        private void BTN_Connexion_Click(object sender, EventArgs e)
        {
            SeConnecter();
        }
        private void SeConnecter()
        {
            try
            {
                string dsource = "(DESCRIPTION="
                                    + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                                    + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                                    + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

                // Déclaration de la chaine de connection //
                string ChaineDeConnection = "Data Source = " + dsource + "; User Id = Bertrand; password = ORACLE1";
                mOracleConnection.ConnectionString = ChaineDeConnection;
                mOracleConnection.Open();

                BTN_Connexion.Hide();

                FBTN_Etoiles.Enabled = true;
                DGV_Monuments.Enabled = true;
                FBTN_Ville.Enabled = true;
                CBB_Monument.Enabled = true;
                FBTN_Prix.Enabled = true;
                FBTN_AfficherMonument.Enabled = true;
                FBTN_AfficherCircuit.Enabled = true;
                FBTN_MeilleurCircuit.Enabled = true;
                EstConnect = true;
                mDB_Images = new DB_Images("BaboucheQc", "9952");
            }
            catch (Exception sqlmOracleConnection)
            {
                MessageBox.Show(sqlmOracleConnection.Message.ToString());
            }

            RemplirCBB_Monument();
        }
        private void FBTN_Fermer_Click(object sender, EventArgs e)
        {
            DGV_Circuit.Hide();
            BTN_ModifierCircuit.Hide();
            BTN_SupprimerMonument.Hide();
            DGV_Monuments.Hide();
            FBTN_More.Enabled = false;
        }

        private void LBX_Close_Click(object sender, EventArgs e)
        {
            mOracleConnection.Close();
            Application.Exit();
        }

        private void FBTN_AfficherCircuit_Click(object sender, EventArgs e)
        {
            AfficherCircuit();
        }

        private void AfficherCircuit()
        {
            DesactiverButton();
            mDGV_CircuitActive = true;
            mDataSetCircuit.Reset();
            DGV_Circuit.Show();
            DGV_Monuments.Hide();
            mSqlCommand = "SELECT * FROM AfficherTousLesCircuits";
            AfficherDGV();
        }

        private void LBX_MinimizedWindow_Click(object sender, EventArgs e)
        {
            Fullscreen();
        }

        private void Fullscreen()
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.LBX_MinimizedWindow.Text = "-";
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.LBX_MinimizedWindow.Text = "+";
            }
        }

        private void FBTN_AfficherMonument_Click(object sender, EventArgs e)
        {
            AfficherMonument();  
        }

        private void AfficherMonument()
        {
            DesactiverButton();
            mDGV_MonumentActive = true;
            mDataSetMonument.Reset();
            DGV_Circuit.Hide();
            DGV_Monuments.Show();
            mSqlCommand = "SELECT NOM, DATEDECReATION, NBETOILES, HISTOIRE FROM MONUMENTS";
            AfficherDGV2();
        }
        private void LBX_Quitter_Click(object sender, EventArgs e)
        {
            mOracleConnection.Close();
            Application.Exit();
        }

        private void DGV_Circuit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Circuit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (mDGV_CircuitActive)
                {
                    Tab = new string[4];
                    Tab[0] = DGV_Circuit.Rows[e.RowIndex].Cells[0].Value.ToString(); // NomCircuit //
                    Tab[1] = DGV_Circuit.Rows[e.RowIndex].Cells[1].Value.ToString(); // VilleDepart //
                    Tab[2] = DGV_Circuit.Rows[e.RowIndex].Cells[2].Value.ToString(); // VilleArrivée //
                    Tab[3] = DGV_Circuit.Rows[e.RowIndex].Cells[3].Value.ToString(); // Prix //
                    BTN_ModifierCircuit.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DLG_AjoutCircuit dlg = new DLG_AjoutCircuit();
            dlg.mPeuxModifier = true;
            dlg.mNomCircuit = Tab[0];
            dlg.mVilleArrivee = Tab[2];
            dlg.mVilleDepart = Tab[1];
            dlg.mPrixCircuit = Tab[3];

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FBTN_AfficherCircuit.PerformClick();
                BTN_ModifierCircuit.Hide();
            }
        }

        private void DGV_Monument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Monuments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (mDGV_MonumentActive)
                {
                    t = e;
                    BTN_SupprimerMonument.Show();
                    BTN_SupprimerMonument.Location = new Point(0, 230);
                    FBTN_More.Enabled = true;
                    mHistoire = DGV_Monuments.Rows[e.RowIndex].Cells[3].Value.ToString();
                    mNomMonument = DGV_Monuments.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string date = DGV_Monuments.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Date = DateTime.Parse(date);
                    mNbEtoiles = int.Parse(DGV_Monuments.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
            }
        }

        private void BTN_SupprimerMonument_Click(object sender, EventArgs e)
        {
            SupprimerMonument();
        }

        private void BTN_AjouterCircuit_Click(object sender, EventArgs e)
        {
            if (GetConnectionState())
            {
                DLG_AjoutCircuit dlg = new DLG_AjoutCircuit();
                string[] Informations = new string[5];
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Informations = dlg.mInformationCircuit;
                    AjouterCircuit(Informations);
                }
            }
            else
                MessageBox.Show("Vous devez être connecté à la base de données!");
        }

        private void BTN_AjouterMonument_Click(object sender, EventArgs e)
        {
            if (GetConnectionState())
            {
                DLG_AjoutMonument dlg = new DLG_AjoutMonument(mDB_Images, mListMonument);
                string[] Informations = new string[4];

                RemplirCircuit(dlg.mListeCircuit);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Informations = dlg.mInformationCircuit;
                    this.mDate = dlg.mDate;
                    AjouterMonument(Informations, dlg.Image);
                }
            }
            else
                MessageBox.Show("Vous devez être connecté à la base de données!");
        }

        private void FBTN_SearchMonument_Click(object sender, EventArgs e)
        {
            Rechercher();
        }
        private void Rechercher()
        {
            DGV_Monuments.Show();
            DGV_Circuit.Hide();
            mSqlCommand = "SELECT DISTINCT C.NOMCIRCUIT, V.NOMVILLE AS DEPART, V2.NOMVILLE AS ARRIVEE, C.PRIX AS PRICE, CM.ORDREDEVISITE FROM CIRCUITMONUMENTS CM" +
                " INNER JOIN MONUMENTS M ON M.IDMONUMENT = CM.IDMONUMENT" +
                " INNER JOIN CIRCUIT C ON C.NOMCIRCUIT = CM.NOMCIRCUIT"+
                " INNER JOIN VILLE V ON C.CODEVILLEDEPART = V.CODEVILLE"+
                " INNER JOIN VILLE V2 ON C.CODEVILLEARRIVÉE = V2.CODEVILLE"+
                " WHERE NOM = '" + CBB_Monument.SelectedItem.ToString() + "' ORDER BY CM.ORDREDEVISITE";
            AfficherDGV2();
        }
        private void FBTN_Ville_Click(object sender, EventArgs e)
        {
            AfficherVille();
        }
        private void AfficherVille()
        {
            DesactiverButton();
            DGV_Monuments.Hide();
            mDataSetCircuit.Reset();
            DGV_Circuit.Show();
            mSqlCommand = "SELECT *FROM AfficherCircuitVilleDepart";
            AfficherDGV();
        }
        private void FBTN_Etoiles_Click(object sender, EventArgs e)
        {
            AfficherEtoile();
        }
        private void AfficherEtoile()
        {
            DesactiverButton();
            DGV_Monuments.Hide();
            DGV_Circuit.Show();
            mDataSetCircuit.Reset();
            mSqlCommand = "SELECT * FROM AfficherCircuitNbEtoiles";
            AfficherDGV();
        }
        private void BTN_MeilleurMonument_Click(object sender, EventArgs e)
        {
            DLG_NbEtoiles dlg = new DLG_NbEtoiles();
            int NbEtoiles = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DGV_Circuit.Hide();
                DGV_Monuments.Show();
                NbEtoiles = dlg.mNbEtoiles;
                mSqlCommand = "select nomcircuit, nom ,ORDREDEVISITE from monuments inner join circuitmonuments on monuments.idmonument = circuitmonuments.idmonument where nbetoiles = '" + NbEtoiles + "' order by nomcircuit, ORDREDEVISITE";
                AfficherDGV2();
            }
        }

        //----------------------------------------------------------------------------
        //              Partie responsable du mouvement de la fenêtre //
        //----------------------------------------------------------------------------
        // Attributs //
        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void SPX_Header_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void SPX_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }

        private void SPX_Header_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        //----------------------------------------------------------------------------
        //            Partie responsable du type de recherche à effectuer //
        //----------------------------------------------------------------------------

        private string GetGUID(string NomMonument)
        {
            string GUID = "";
            try
            {
                string sql3 = "SELECT GUID FROM MONUMENTS WHERE NOM ='" + NomMonument + "'";

                OracleCommand oracleCommand = new OracleCommand(sql3, mOracleConnection);
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                GUID = oracleDataReader.GetString(0);
                oracleDataReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Le monuement sélectionné ne contient aucune photo!", "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return GUID;
        }

        private void BTN_AfficherContenuCircuit_Click(object sender, EventArgs e)
        {
            if (GetConnectionState())
            {
                DLG_AfficherInformation dlg = new DLG_AfficherInformation(mDB_Images);
                dlg.Show();
            }
            else
                MessageBox.Show("Vous devez être connecé à la base de donnée!");
        }

        private void FBTN_Prix_Click(object sender, EventArgs e)
        {
            AfficherParPrix();
        }
        private void AfficherParPrix()
        {
            DesactiverButton();
            DLG_Prix dlg = new DLG_Prix();
            mDataSetCircuit.Reset();
            DGV_Circuit.Hide();
            DGV_Monuments.Show();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mDataSetCircuit.Reset();
                mPrix = dlg.mPrix;
                mSqlCommand = "SELECT *FROM AfficherCircuitContraintePrix WHERE PRIX <= '" + mPrix + "' ORDER BY NOMCIRCUIT";
                AfficherDGV2();
            }
        }
        private void FBTN_MeilleurCircuit_Click(object sender, EventArgs e)
        {
            AfficherMeilleurCircuit();
        }
        private void AfficherMeilleurCircuit()
        {
            DesactiverButton();
            DGV_Monuments.Hide();
            DGV_Circuit.Show();
            mDataSetCircuit.Reset();
            mSqlCommand = "SELECT * FROM AfficherMeilleurCircuit";
            AfficherDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGV_Circuit.Columns.Clear();
        }

        private void ajouterUnCircuitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_AjouterCircuit.PerformClick();
        }

        private void voirInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_AfficherContenuCircuit.PerformClick();
        }

        private void FBTN_More_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void Check()
        {
            DLG_AjoutMonument dlg_modifier = new DLG_AjoutMonument(mDB_Images.Find(GetGUID(mNomMonument)));
            dlg_modifier.mPeuxModifier = true;
            dlg_modifier.mHistoire = this.mHistoire;
            dlg_modifier.mNomMonument = this.mNomMonument;
            dlg_modifier.mNBEtoiles = this.mNbEtoiles;
            dlg_modifier.Date = this.Date;
            dlg_modifier.mNomCircuit = GetNomCircuitFromMonument(mNomMonument);

            if (dlg_modifier.ShowDialog() == DialogResult.OK) { }
        }
        private void voirAuteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DLG_About dlg = new DLG_About();

            dlg.Show();
        }

        private void voirCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DLG_Aide dlg = new DLG_Aide();
            dlg.Show();
        }

        private void ajouterUnMonumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_AjouterMonument.PerformClick();
        }

        private void supprimerUnMonumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBTN_AfficherMonument.PerformClick();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (EstConnect == false)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        SeConnecter();
                        break;
                    default:
                        // do nothing
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        AfficherCircuit();
                        break;
                    case Keys.F2:
                        AfficherMonument();
                        break;
                    case Keys.F3:
                        AfficherEtoile();
                        break;
                    case Keys.F4:
                        AfficherVille();
                        break;
                    case Keys.F5:
                        AfficherParPrix();
                        break;
                    case Keys.F6:
                        AfficherMeilleurCircuit();
                        break;
                    case Keys.F11:
                        Fullscreen();
                        break;
                    //// etc
                    default:
                        // do nothing
                        break;
                }
            }
            
        }

     

        //----------------------------------------------------------------------------
        //                             Autre //
        //----------------------------------------------------------------------------
        private void CBB_Monument_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesactiverButton();
            if (CBB_Monument.SelectedIndex > -1)
            {
                FBTN_SearchMonument.Enabled = true;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainPosition = this.Location;
            Properties.Settings.Default.Save();
        }

        private void DesactiverButton()
        {
            mDGV_CircuitActive = false;
            mDGV_MonumentActive = false;
            BTN_SupprimerMonument.Hide();
            BTN_ModifierCircuit.Hide();
            FBTN_More.Enabled = false;
        }

        //----------------------------------------------------------------------------
        //                  Partie responsable des méthodes utiles //
        //----------------------------------------------------------------------------
        private string GetCodeVille(string NomVille)
        {
            string CodeVille = "";
            try
            {
                string sql3 = "SELECT CODEVILLE FROM VILLE WHERE NOMVILLE = '" + NomVille + "'";
                OracleCommand oracleCommand = new OracleCommand(sql3, mOracleConnection);
                OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

                oracleDataReader.Read();
                CodeVille = oracleDataReader.GetString(0);

                oracleDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return CodeVille;
        }

        private string GetNomCircuitFromMonument(string NomMonument)
        {
            string sql3 = "SELECT C.NOMCIRCUIT FROM MONUMENTS M INNER JOIN CIRCUITMONUMENTS CM ON M.IDMONUMENT = CM.IDMONUMENT INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT WHERE M.NOM ='" + NomMonument + "'";
            string NOM = "";
            OracleCommand oracleCommand = new OracleCommand(sql3, mOracleConnection);
            OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

            oracleDataReader.Read();
            NOM = oracleDataReader.GetString(0);
            oracleDataReader.Close();

            return NOM;
        }

        private void LoadSettings()
        {
            this.Location = Properties.Settings.Default.MainPosition;
        }
    }
}
