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

namespace ExempleAdonet
{
    public partial class DLG_NbEtoiles : Form
    {
        // Attributs //
        public int mNbEtoiles;
        private ValidationProvider mValidationProvider;
        public DLG_NbEtoiles()
        {
            InitializeComponent();
        }

        private void BTN_Confirmer_Click(object sender, EventArgs e)
        {
            mNbEtoiles = S_Stars.Value;
        }

        private void InitialiserValidationProvider()
        {
            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(S_Stars, Validate_S_Stars);
        }

        private bool Validate_S_Stars(ref string Message)
        {
            Message = "Aucune étoiles sélectionnées!";
            return S_Stars.Value > 0;
        }

        private void DLG_NbEtoiles_Load(object sender, EventArgs e)
        {
            InitialiserValidationProvider();
        }
    }
}
