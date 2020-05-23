using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleAdonet
{
    public partial class DLG_Aide : Form
    {
        // Constructeur //
        public DLG_Aide()
        {
            InitializeComponent();
        }

        private void DLG_Aide_Load(object sender, EventArgs e)
        { 
    
        }

        private bool Dragging = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void SPX_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
