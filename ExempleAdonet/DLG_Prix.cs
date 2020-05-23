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
    public partial class DLG_Prix : Form
    {
        public string mPrix { get; set; }
        private ValidationProvider mValidationProvider;

        // Constructeur //
        public DLG_Prix()
        {
            InitializeComponent();
        }

        private void DLG_Prix_Load(object sender, EventArgs e)
        {
            InitialiserValidation();
        }

        //-----------------------------------------------------------------------
        //                              Méthodes//
        //-----------------------------------------------------------------------
        private void InitialiserValidation()
        {
            mValidationProvider = new ValidationProvider(this);
            mValidationProvider.AddControlToValidate(TBX_Prix, Validate_TBX_Prix);
        }

        private bool Validate_TBX_Prix(ref string Message)
        {
            bool EstValide = true;

            if (String.IsNullOrWhiteSpace(TBX_Prix.Text))
            {
                Message = "Il n'y a aucun prix!";
                EstValide = false;
            }

            if (!String.IsNullOrEmpty(TBX_Prix.Text))
            {
                if (int.Parse(TBX_Prix.Text) < 50)
                {
                    Message = "Le prix doit être plus grand que 50!";
                    EstValide = false;
                }
            }

            return EstValide;
        }

        private void BTN_Confirmer_Click(object sender, EventArgs e)
        {
            if (TBX_Prix.Text != "")
            {
                mPrix = TBX_Prix.Text;
            }
        }

        private void TBX_Prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        //-----------------------------------------------------------------------
        //                Responsable du mouvement de la fenêtre //
        //-----------------------------------------------------------------------
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
    }
}
