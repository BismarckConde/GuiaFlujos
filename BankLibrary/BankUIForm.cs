using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;// número de controles TextBox en el formulario
        // las connstantes en la enumeración especifican los índices de los controles TextBox
        public enum TextBoxIndices { Account, Firts, Last, Balance}
        public BankUIForm()
        {
            InitializeComponent();
        }

        //Limpia todos los controles TextBox
        public void ClearTextBox()
        {
            //itera a través de cada control en el formulario
            foreach (Control guiControl in Controls)
            {
                // si el control es TextBox, lo limpia
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length != TextBoxCount)
            {
                throw (new ArgumentException(
                    $"There must be {TextBoxCount} strings in the array", nameof(values)));
            }
            else
            {
                txtaccount.Text = values[(int)TextBoxIndices.Account];
                txtfirstName.Text = values[(int)TextBoxIndices.Firts];
                txtlastName.Text = values[(int)TextBoxIndices.Last];
                txtBalance.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                txtaccount.Text, txtfirstName.Text, txtlastName.Text, txtBalance.Text
            };
        }

        private void BankUIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
