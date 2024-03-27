using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locking_Time
{
    public partial class Form2 : Form
    {
        private List<LockingTimeData> his = new List<LockingTimeData>();
        public Form2(List<Form1.LockingTimeData> data)
        {
            InitializeComponent();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Sheet", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Week", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "CostCenter", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Incident", ReadOnly = true });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Time", ReadOnly = true });

            // Add data to DataGridView
            foreach (Form1.LockingTimeData item in data)
            {
                var newData = new LockingTimeData(item.Sheet, item.Week, item.Category, item.CostCenter, item.Incident, item.Time);
                his.Add(newData);
                dataGridView1.Rows.Add(item.Sheet, item.Week, item.Category, item.CostCenter, item.Incident, item.Time.ToString());
            }

            // Add DataGridView to the form
            Controls.Add(dataGridView1);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        public class LockingTimeData
        {
            public string Sheet { get; set; }
            public string Week { get; set; }
            public string Category { get; set; }
            public string CostCenter { get; set; }
            public string Incident { get; set; }
            public double Time { get; set; }
            public LockingTimeData(string Sheet, string Week, string Category, string CostCenter, string Incident, double Time)
            {
                this.Sheet = Sheet;
                this.Week = Week;
                this.Category = Category;
                this.CostCenter = CostCenter;
                this.Incident = Incident;
                this.Time = Time;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            //var selectedrow = dataGridView1.SelectedRows[0].DataBoundItem as LockingTimeData;
            var selectedrow = his[rowIndex];
            Textbox_sheet.Text  = selectedrow.Sheet;
            Textbox_cate.Text = selectedrow.Category;
            Textbox_CC.Text = selectedrow.CostCenter;
            Textbox_Incident.Text = selectedrow.Incident;
            Textbox_time.Text = selectedrow.Time.ToString();
            Textbox_WW.Text = selectedrow.Week;
        }
    }
}
