using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EF_Migrations.Logic
{
    class Functions
    {
        public void ExecuteCommandSync (ProcessStartInfo psi)
        {
            try
            {

            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
