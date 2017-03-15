using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportDataToOfficeApp
{
    public partial class NewCarDialog : Form
    {
        public Car theCar;

        public NewCarDialog()
        {
            InitializeComponent();
        }

        private void BtnSubmitCarDialog_Click(object sender, EventArgs e)
        {
            theCar = new Car
            {
                Color = this.textColor.Text,
                Make = this.textMake.Text,
                PetName = this.textPetName.Text
            };
        }
    }
}
