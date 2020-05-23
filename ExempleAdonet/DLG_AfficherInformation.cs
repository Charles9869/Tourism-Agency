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
using DB_Images_Utilities;
namespace ExempleAdonet
{
    public partial class DLG_AfficherInformation : Form
    {
        // Attributs //
        private DB_Images mDB_Images;

        public DLG_AfficherInformation(DB_Images image)
        {
            InitializeComponent();
            mDB_Images = image;
        }

        OracleConnection mOracleConnection = new OracleConnection();

        private void DLG_AfficherInformation_Load(object sender, EventArgs e)
        {
            Connection();
            RemmplirCircuit();

            CBB_Circuit.SelectedIndex = 0;
            LBX_Monuments.SelectedIndex = 0;
        }

        private void Connection()
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
            }
            catch (Exception sqlmOracleConnection)
            {
                MessageBox.Show(sqlmOracleConnection.Message.ToString());
            }
        }

        //------------------------------------------------------------------------
        //                              Méthodes  //
        //------------------------------------------------------------------------
        private void RemmplirCircuit()
        {
            CBB_Circuit.Items.Clear();
            string sql3 = "SELECT * FROM AfficherCircuitAvecMonument";
            OracleCommand cmd3 = new OracleCommand(sql3, mOracleConnection);
            OracleDataReader reader2 = cmd3.ExecuteReader();
            while (reader2.Read())
            {
                CBB_Circuit.Items.Add(reader2.GetValue(0));
            }
            reader2.Close();
        }

        private void CBB_Circuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirMonuments();
        }

        private void RemplirMonuments()
        {
            LBX_Monuments.Items.Clear();

            string sql3 = "SELECT M.NOM FROM CIRCUIT C INNER JOIN CIRCUITMONUMENTS CM ON C.NOMCIRCUIT = CM.NOMCIRCUIT INNER JOIN MONUMENTS M ON CM.IDMONUMENT = M.IDMONUMENT WHERE C.NOMCIRCUIT = '" + CBB_Circuit.SelectedItem.ToString() + "'";
            OracleCommand cmd3 = new OracleCommand(sql3, mOracleConnection);
            OracleDataReader reader2 = cmd3.ExecuteReader();
            while (reader2.Read())
            {
                LBX_Monuments.Items.Add(reader2.GetValue(0));
            }
            reader2.Close();
            LBX_Monuments.SelectedIndex = 0;
        }

        private void LBX_Monuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "SELECT M.DATEDECREATION, CM.ORDREDEVISITE, M.GUID, M.NBETOILES, M.HISTOIRE FROM MONUMENTS M INNER JOIN CIRCUITMONUMENTS CM ON M.IDMONUMENT = CM.IDMONUMENT WHERE M.NOM ='" + LBX_Monuments.SelectedItem.ToString() + "'";
                OracleCommand cmd3 = new OracleCommand(sql3, mOracleConnection);
                OracleDataReader reader2 = cmd3.ExecuteReader();
                reader2.Read();
                DTP_DateMonument.Value = reader2.GetDateTime(0);
                TBX_Ordre.Text = reader2.GetValue(1).ToString();
                IMB_Monuments.BackgroundImage = mDB_Images.Find(reader2.GetValue(2).ToString());
                Etoiles.Value = reader2.GetInt32(3);
                RTBX_Histoire.Text = reader2.GetValue(4).ToString();
                reader2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Le monument ne contient aucune photo!");
            }

        }

        //------------------------------------------------------------------------
        //              Partie responsable du mouvement de la fenêtre //
        //------------------------------------------------------------------------
        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void SPX_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void SPX_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void SPX_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }

        private void LBX_Quitter_Click(object sender, EventArgs e)
        {
            mOracleConnection.Close();
            this.Close();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            mOracleConnection.Close();
            this.Close();
        }
    }
}
