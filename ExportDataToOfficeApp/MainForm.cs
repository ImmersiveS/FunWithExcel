using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    public partial class MainForm : Form
    {
        List<Car> carsInStock = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            carsInStock = new List<Car>
            {
                new Car {Color="Green", Make="VW", PetName="Mary"},
                new Car {Color="Red", Make="Saab", PetName="Mel"},
                new Car {Color="Black", Make="Ford", PetName="Hank"},
                new Car {Color="Yellow", Make="BMW", PetName="Davie"}
            };

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            //Reset the source of data
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carsInStock;
        }

        private void BtnAddNewCar_Click(object sender, EventArgs e)
        {
            NewCarDialog d = new NewCarDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                //Add new car to list
                carsInStock.Add(d.theCar);
            }
            UpdateGrid();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(carsInStock);
        }

        static void ExportToExcel(List<Car> carsInStock)
        {
            //Load up excel and then make a new empty workbook
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();

            //It uses single worksheet
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            //Establish column headings in cells
            workSheet.Cells[1, "A"] = "Color";
            workSheet.Cells[1, "B"] = "Make";
            workSheet.Cells[1, "C"] = "PetName";

            //Map all data in List<Car> to the cells of the spreadsheet
            int row = 1;
            foreach (var c in carsInStock)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Color;
                workSheet.Cells[row, "B"] = c.Make;
                workSheet.Cells[row, "C"] = c.PetName;
            }

            //Customize table data style
            workSheet.Range["A1"].AutoFormat(
                Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            //Save the file, quit Excel and display message to user
            workSheet.SaveAs(string.Format(@"{0}\Inventory.xslx", Environment.CurrentDirectory));
            excelApp.Quit();
            MessageBox.Show("The Inventory.xlsx file has been saved to your app folder",
                "Export complete!");
        }
    }
}
