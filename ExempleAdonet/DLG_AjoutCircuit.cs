using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ExempleAdonet
{
    public partial class DLG_AjoutCircuit : Form
    {
        // Attributs //
        public string[] mInformationCircuit;
        private ValidationProvider mValidationProvider;
        public string mNomCircuit, mPrixCircuit, mDureeCircuit, mVilleDepart, mVilleArrivee;
        public bool mPeuxModifier, mPeuxSupprimer;
        private List<string> mCircuit;

        // Constructeur //
        public DLG_AjoutCircuit()
        {
            InitializeComponent();
        }

        // Déclaration d'une connexion oracle //
        OracleConnection mOracleConnection = new OracleConnection();

        private void DLG_AjoutCircuit_Load(object sender, EventArgs e)
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

                if (mPeuxModifier)
                {
                    BTN_Ajouter.Text = "Modifier";
                    TBX_NomCircuit.ReadOnly = true;
                    TBX_DureeCircuit.ReadOnly = true;
                    CBB_Arrivee.Enabled = false;
                    CBB_VilleDepart.Enabled = false;
                    TBX_NomCircuit.Text = mNomCircuit;
                    TBX_DureeCircuit.Text = GetDureeFromCircuit(mNomCircuit);
                    TBX_PrixCircuit.Text = mPrixCircuit;
                    CBB_Arrivee.Text = mVilleArrivee;
                    CBB_VilleDepart.Text = mVilleDepart;
                }
                else
                {
                    mCircuit = new List<string>();
                    RemplirCircuitListe();
                    InitialiserValidationProvider();
                    RemplirCBBVille();
                }
            }
            catch (Exception sqlmOracleConnection)
            {
                MessageBox.Show(sqlmOracleConnection.Message.ToString());
            }
        }

        //-----------------------------------------------------------------------
        //                  Responsable des clicks sur les outils //
        //-----------------------------------------------------------------------
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            // Utiliser le validation provider pour s'assurer que toutes les cases sont remplies //
            mInformationCircuit = new string[5];

            // Permet de modifier le prix d'un circuit //
            if (mPeuxModifier)
            {
                string sql11 = "update circuit set prix = '" + TBX_PrixCircuit.Text + "' where nomcircuit ='" + TBX_NomCircuit.Text + "'";
                OracleCommand cmd11 = new OracleCommand(sql11, mOracleConnection);
                cmd11.ExecuteNonQuery();
            }
            else
            {
                mInformationCircuit[0] = TBX_NomCircuit.Text;
                mInformationCircuit[1] = TBX_PrixCircuit.Text;
                mInformationCircuit[2] = TBX_DureeCircuit.Text;
                mInformationCircuit[3] = CBB_VilleDepart.Text;
                mInformationCircuit[4] = CBB_Arrivee.Text;
            }
        }

        //------------------------------------------------------------------------
        //              Partie responsable des méthodes utiles //
        //------------------------------------------------------------------------
        private void RemplirCircuitListe()
        {
            string sql5 = "SELECT C.NOMCIRCUIT FROM CIRCUIT C";
            OracleCommand cmd12 = new OracleCommand(sql5, mOracleConnection);
            OracleDataReader reader3 = cmd12.ExecuteReader();

            while (reader3.Read())
            {
                mCircuit.Add(reader3.GetString(0));
            }

            reader3.Close();
        }

        private void RemplirCBBVille()
        {
            string sql4 = "SELECT DISTINCT nomville from ville";
            OracleCommand cmd4 = new OracleCommand(sql4, mOracleConnection);
            OracleDataReader reader3 = cmd4.ExecuteReader();

            while (reader3.Read())
            {
                CBB_Arrivee.Items.Add(reader3.GetValue(0));
                CBB_VilleDepart.Items.Add(reader3.GetValue(0));
            }

            reader3.Close();
        }

        //-----------------------------------------------------------------------
        //        Responsable de la vérification des validations provider //
        //-----------------------------------------------------------------------
        private void InitialiserValidationProvider()
        {
            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(TBX_NomCircuit, Validate_TBX_NomCircuit);
            mValidationProvider.AddControlToValidate(TBX_PrixCircuit, Validate_TBX_PrixCircuit);
            mValidationProvider.AddControlToValidate(TBX_DureeCircuit, Validate_TBX_DureeCircuit);
            mValidationProvider.AddControlToValidate(CBB_VilleDepart, Validate_TBX_VilleDepart);
            mValidationProvider.AddControlToValidate(CBB_Arrivee, Validate_TBX_VilleArrivee);
        }

        private bool Validate_TBX_VilleDepart(ref string Message)
        {
            Message = "Aucune ville sélectionnée!";
            return CBB_VilleDepart.SelectedIndex > -1;
        }

        private bool Validate_TBX_VilleArrivee(ref string Message)
        {
            Message = "Aucune ville sélectionnée!";
            return CBB_Arrivee.SelectedIndex > -1;
        }

        private bool Validate_TBX_NomCircuit(ref string Message)
        {
            bool EstValide = true;

            if (String.IsNullOrWhiteSpace(TBX_NomCircuit.Text))
            {
                Message = "Il n'y a aucun nom de circuit!";
                EstValide = false;
            }

            if (!mPeuxModifier)
            {
                // Permet de vérifier si le monument existe en ignorant les majuscules et minuscule //
                if (mCircuit.Any(s => s.Equals(TBX_NomCircuit.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    Message = "Ce circuit existe déjà!";
                    EstValide = false;
                }
            }

            return EstValide;
        }

        private bool Validate_TBX_PrixCircuit(ref string Message)
        {
            bool EstValide = true;

            if (!String.IsNullOrEmpty(TBX_PrixCircuit.Text))
            {
                if (int.Parse(TBX_PrixCircuit.Text) < 50)
                {
                    Message = "Le prix doit être plus grand que 50!";
                    EstValide = false;
                }
            }

            if (String.IsNullOrEmpty(TBX_PrixCircuit.Text))
            {
                Message = "Le prix est invalide!";
                EstValide = false;
            }

            return EstValide;
        }

        private bool Validate_TBX_DureeCircuit(ref string Message)
        {
            Message = "Le durée est invalide!";
            return TBX_DureeCircuit.Text != "";
        }

        private void LBX_Quitter_Click(object sender, EventArgs e)
        {
            BTN_Quitter.PerformClick();
        }

        //------------------------------------------------------------------------
        //              Partie responsable du mouvement de la fenêtre //
        //------------------------------------------------------------------------
        // Attributs //
        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void SPX_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }

        private void SPX_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void SPX_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void TBX_PrixCircuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TBX_DureeCircuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // Méthodes //
        private string GetDureeFromCircuit(string NomCircuit)
        {
           string sql = "SELECT C.DURÉE FROM CIRCUIT C WHERE C.NOMCIRCUIT ='" + NomCircuit + "'";
            OracleCommand cmd = new OracleCommand(sql,mOracleConnection);
            OracleDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string Duree = reader.GetValue(0).ToString();
            reader.Close();
            return Duree;
        }
    }
}
