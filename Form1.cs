using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using OfficeOpenXml;


namespace Locking_Time
{
    public partial class Form1 : Form
    {
        string excelFilePath;
        int week_no;
        string sheet_name;
        private List<LockingTimeData> history = new List<LockingTimeData>(); // List to store data
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            //Category Items
            List<string> cate = new List<string>();
            cate.Add("Internal matters");
            cate.Add("Maintenance");
            cate.Add("TOPdesk Service");
            cate.Add("TOPdesk Issue");
            cate.Add("Project");
            cate.Add("Others");
            category.DataSource = cate;
            //Cost center items
            List<string> CC = new List<string>();

            CC.Add("4020-Calibration");   // calib
            CC.Add("4031-M&S");       // M&S Test
            CC.Add("5100-PT1");       // PT1
            CC.Add("5120-PT2");       // PT2
            CC.Add("5140-PT3");       // PT3

            CC.Add("5160-PT4");       // PT4
            CC.Add("5170-PT5");       // PT5
            CC.Add("5175-PT5B");       // PT5B
            CC.Add("5180-PT6");       // PT6
            CC.Add("5185-PT7");       // PT7

            CC.Add("5140-PT8");       // PT8
            CC.Add("5200-EMS1");       // EMS1
            CC.Add("5210-EMS1B");      // EMS1B
            CC.Add("5220-EMS2");       // EMS2
            CC.Add("5240-EMS3");       // EMS3

            CC.Add("5260-EMS4");       // EMS4
            CC.Add("5800-SMT");       // SMT
            CC.Add("5811-SMT");       // SMT
            CC.Add("5820-SMT MVI");     // SMT MVI
            CC.Add("5821-SMT TEST");     // SMT TEST
            CC.Add("5824-SMT THT");     // SMT THT

            CC.Add("5300-VAZ");       // VAZ
            CC.Add("5400-ENI");       // ENI
            CC.Add("5900-CABLE");      // CABLE
            costcenter.DataSource = CC;
            // Gets the Calendar instance associated with a CultureInfo.
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            // Get current WW
            week_no = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            //Get all WW lower than current WW
            List<int> weeks = new List<int>();
            int week_limit = week_no - 7;
            for (int i = week_no; i > week_limit; i--)
            {
                weeks.Add(i);
            }
            week.DataSource = weeks;
            //GetSheetNames();
            button1.Enabled = false;  //disable button to prevent wrong input
            button2.Enabled = false;
        }
        public class LockingTimeData
        {
            public string Sheet { get; set; }
            public string Week { get; set; }
            public string Category { get; set; }
            public string CostCenter { get; set; }
            public string Incident { get; set; }
            public double Time { get; set; }
        }
        private void GetSheetNames()
        {
            if (string.IsNullOrEmpty(excelFilePath))
            {
                MessageBox.Show("Please select an Excel file first \n or place the program and excel file in the same folder.");
                return;
            }

            List<string> sheetNames = GetExcelSheetNames(excelFilePath);

            if (sheetNames.Count > 0)
            {
                // Display sheet names in list box
                sheet.Items.AddRange(sheetNames.ToArray());
                sheet.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                // Disable or hide controls until a valid worksheet is selected
                // For example:
                button1.Enabled = false;
                button2.Enabled = false;
                // You can also provide a message to inform the user
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the reason for closing is a result of clicking the "X" button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Add any additional logic here if needed
                // For example, you might want to prompt the user before closing
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    // If the user clicks "No", cancel the form closing
                    e.Cancel = true;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sheet_name = sheet.Text;
            using (ExcelHelper excel = new ExcelHelper(excelFilePath, sheet_name))
            {
                if (incident_txt.Text != "" && time_txt.Text != "")
                {
                    int n = ScanWW(excel);
                    int m = ScanInci(excel);
                    int z = m - 7;
                    if (m == 0 && n == 0)
                    {
                        MessageBox.Show("Failed to scan!!");
                    }
                    string costcenter_trim = costcenter.Text.Substring(0, 4);
                    // Add data to the history list
                    history.Add(new LockingTimeData
                    {
                        Sheet = sheet_name,
                        Week = week.SelectedItem.ToString(),
                        Category = category.Text,
                        CostCenter = costcenter_trim,
                        Incident = incident_txt.Text,
                        Time = double.Parse(time_txt.Text)
                    });
                    excel.WriteToCell(m, 2, category.Text);
                    excel.WriteToCell(m, 3, incident_txt.Text);
                    excel.WriteToCell(m, 4, costcenter_trim);
                    excel.WriteToCellDouble(m, n, double.Parse(time_txt.Text));
                    excel.WriteToCell(m, 1, z.ToString());
                    excel.Save();
                    MessageBox.Show("Lock time successfully!!");
                }
                else
                {
                    MessageBox.Show("Please enter incident and/or time");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            incident_txt.Text = String.Empty;
            time_txt.Text = String.Empty;
        }
        private int ScanWW(ExcelHelper excel)
        {
            for (int i = 0; i < 60; i++)
            {
                if (excel.ReadCell(7, i + 4) == week.SelectedItem.ToString())
                {
                    return i + 4;
                }
            }
            return 0;
        }
        public int ScanInci(ExcelHelper excel)
        {
            for (int i = 0; i < 9000; i++)
            {
                if (excel.ReadCell(i + 7, 3) == "")
                    return i + 7;
            }
            return 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the title and filter for the file dialog
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "All files (*.*)|*.*";

            // Show the file dialog and get the result
            DialogResult result = openFileDialog1.ShowDialog();

            // If the user selects a file and clicks OK
            if (result == DialogResult.OK)
            {
                // Get the file path
                string filePath = openFileDialog1.FileName;
                excelFilePath = filePath;
                // Optionally, you can save the directory path to a variable or use it as needed in your application
                GetSheetNames();
            }
        }


        private List<string> GetExcelSheetNames(string filePath)
        {
            List<string> sheetNames = new List<string>();

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    foreach (ExcelWorksheet sheet in package.Workbook.Worksheets)
                    {
                        sheetNames.Add(sheet.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return sheetNames;
        }

        private void week_input_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sheet_name = sheet.Text;
            using (ExcelHelper excel = new ExcelHelper(excelFilePath, sheet_name)) // Create excel instance here
            {
                name_label.Text = excel.ReadCell(4, 3); // Now 'excel' is in scope
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            // Create a new form for displaying history
            Form2 historyForm = new Form2(history);
            historyForm.Show();
        }
    }
}