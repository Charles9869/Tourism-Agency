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
using Validation;
using PhotoManagerClient;
using DB_Images_Utilities;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ExempleAdonet
{
    public partial class DLG_AjoutMonument : Form
    {
        // Attributs //
        public string UserName { set; private get; }
        public string Password { set; private get; }

        // Usager dédiés au stockage des photos de la BD
        private DB_Images mDB_Images;
        public Image Image { get; set; }
        public string[] mInformationCircuit;
        public OracleParameter mDate;
        ValidationProvider mValidationProvider;
        public List<String> mListeCircuit, mListMonument;
        public string mGUID { get; set; }
        public bool mPeuxModifier { get; set; }
        public int mNBEtoiles;
        public string mHistoire, mNomMonument;
        public DateTime Date;
        public string mNomCircuit { get; set; }
        private List<string> allo;

        OracleConnection mOracleConnection = new OracleConnection();

        // Constructeur //
        public DLG_AjoutMonument(DB_Images image, List<string> list)
        {
            InitializeComponent();
            mListeCircuit = new List<string>();
            mListMonument = list;
            InitialiserValidationProvider();
            mDB_Images = image;
        }

        public DLG_AjoutMonument(Image image)
        {
            InitializeComponent();
            Image = image;
            BTN_Ajouter.Enabled = false;
            DTP_DateMonument.Enabled = false;
        }

        private void DLG_AjoutMonument_Load(object sender, EventArgs e)
        {
            Connection();

            if (mPeuxModifier)
            {
                DesactiverControl();
                this.label1.Text = "Afficher les informations...";
                TBX_NomMonument.Text = mNomMonument;
                Etoiles.Value = mNBEtoiles;
                RTBX_Histoire.Text = mHistoire;
                IMB_Monuments.BackgroundImage = Image;
                CBB_Circuit.Text = mNomCircuit;
                DTP_DateMonument.Value = Date;
            }
            else
            {
                foreach (string Mot in mListeCircuit)
                {
                    CBB_Circuit.Items.Add(Mot);
                }

                CBB_Circuit.SelectedIndex = 0;
            }
        }

        private void DesactiverControl()
        {
            CBB_Circuit.Enabled = false;
            TBX_NomMonument.Enabled = false;
            RTBX_Histoire.Enabled = false;
            Etoiles.Enabled = false;
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

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            if (RTBX_Histoire.TextLength <= 100 && TBX_NomMonument.Text != "" && CBB_Circuit.SelectedIndex > -1 && IMB_Monuments.BackgroundImage != null)
            {
                mInformationCircuit = new string[4];
                mDate = new OracleParameter();
                int index = int.Parse(Etoiles.Value.ToString());
                mInformationCircuit[0] = TBX_NomMonument.Text;
                mInformationCircuit[1] = index.ToString();
                mInformationCircuit[2] = RTBX_Histoire.Text;
                mInformationCircuit[3] = CBB_Circuit.SelectedItem.ToString();
                mDate.Value = DTP_DateMonument.Value;
                Image = IMB_Monuments.BackgroundImage;
            }
        }

        //------------------------------------------------------------------------
        //              Partie responsable des validations provider //
        //------------------------------------------------------------------------
        private void InitialiserValidationProvider()
        {
            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(TBX_NomMonument, Validate_TBX_NomMonument);
            mValidationProvider.AddControlToValidate(DTP_DateMonument, Validate_DTP_DateMMonument);
            mValidationProvider.AddControlToValidate(Etoiles, Validate_Etoiles);
            mValidationProvider.AddControlToValidate(RTBX_Histoire, Validate_RTBX_Histoire);
            mValidationProvider.AddControlToValidate(CBB_Circuit, Validate_CBB_Circuit);
            mValidationProvider.AddControlToValidate(IMB_Monuments, Validate_IBM_Monuments);
        }

        private bool Validate_TBX_NomMonument(ref string Message)
        {
            bool EstValide = true;

            if (String.IsNullOrWhiteSpace(TBX_NomMonument.Text))
            {
                Message = "Il n'y a aucun nom!";
                EstValide = false;
            }

            // Permet de vérifier si le monument existe en ignorant les majuscules et minuscule //
            if (mListMonument.Any(s => s.Equals(TBX_NomMonument.Text, StringComparison.OrdinalIgnoreCase)))
            {
                Message = "Ce monument existe déjà!";
                EstValide = false;
            }

            return EstValide;
        }

        private bool Validate_DTP_DateMMonument(ref string Message)
        {
            Message = "Il n'y a aucune date sélectionnée!";
            return DTP_DateMonument.Value != null;
        }

        private bool Validate_RTBX_Histoire(ref string Message)
        {
            bool EstValide = true;
            if (String.IsNullOrWhiteSpace(RTBX_Histoire.Text))
            {
                Message = "Il n'y a aucune histoire!";
                EstValide = false;
            }
            if (RTBX_Histoire.TextLength > 100)
            {
                Message = "Erreur! Il y a une limite de 100 caractères";
                EstValide = false;
            }
            return EstValide;
        }

        private bool Validate_Etoiles(ref string Message)
        {
            Message = "Aucune étoiles sélectionnées!";
            return Etoiles.Value > 0;
        }

        private bool Validate_CBB_Circuit(ref string Message)
        {
            Message = "Il n'y a aucun circuit sélectionné!";
            return CBB_Circuit.SelectedIndex > -1;
        }

        private bool Validate_IBM_Monuments(ref string Message)
        {
            Message = "Il n'y a aucune image!";
            return IMB_Monuments.BackgroundImage != null;
        }

        private string GetNomCircuit(string NomMonument)
        {
             allo = new List<string>();
            string sql3 = "SELECT C.NOMCIRCUIT FROM MONUMENTS M INNER JOIN CIRCUITMONUMENTS CM ON M.IDMONUMENT = CM.IDMONUMENT INNER JOIN CIRCUIT C ON CM.NOMCIRCUIT = C.NOMCIRCUIT WHERE M.NOM ='" + NomMonument + "'";
            string NOM = "";
            OracleCommand oracleCommand = new OracleCommand(sql3, mOracleConnection);
            OracleDataReader oracleDataReader = oracleCommand.ExecuteReader();

            while (oracleDataReader.Read())
            {
                allo.Add(oracleDataReader.GetString(0));
            }

            oracleDataReader.Close();

            return NOM;
        }

        //------------------------------------------------------------------------
        //              Partie responsable du mouvement de la fenêtre //
        //------------------------------------------------------------------------
        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void SPX_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void LBX_Quitter_Click(object sender, EventArgs e)
        {
            BTN_Quitter.PerformClick();
        }

        private void SPX_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursorPoint));
                this.Location = Point.Add(DragFormPoint, new Size(dif));
            }
        }

        private void SPX_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        //------------------------------------------------------------------------
        //                              Autres //
        //------------------------------------------------------------------------
    }
}
