using Luna_Bay_Resort_App.Helpers;
using Luna_Bay_Sub_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luna_Bay_Resort_App.Forms
{
    public partial class AddPax : Form
    {
        public AddPax()
        {
            InitializeComponent();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int additionalPax = Convert.ToInt32(Paxtxt.Text);

                if (additionalPax >= 1)
                {
                    SessionData.RoomPax += additionalPax;
                    SessionData.RoomCost += 150 * additionalPax;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Number of additional guests can be lower than 1");
                };
            }
            catch (FormatException eee)
            {
                MessageBox.Show("Input Number Only");
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
    }
}
