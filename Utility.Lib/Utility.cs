using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UtilityLib
{
    public class Utility
    {
        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is RadioButton)
                {
                    RadioButton rd = (RadioButton)item;
                    rd.Checked = false;
                }
            }
        }       
    }
}
