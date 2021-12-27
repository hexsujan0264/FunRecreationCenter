using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunRecreationCenter
{
    public partial class VisitorInfo : Form
    {
        DataTable dt = new DataTable();

        int visitorID;
        String name;
        String ageGroup;
        String date;
        String phoneNo;
        String visitorType;
        String inTime;
        String outTime;
        String group;
        public VisitorInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                visitorID = int.Parse(txtboxVisitorID.Text);
                name = txtboxName.Text;
                ageGroup = cmbBoxAgeGroup.SelectedItem.ToString();
                phoneNo = txtBoxPhoneNo.Text;
                visitorType = cmbBoxVisitorType.SelectedItem.ToString();
                txtboxDate.Text = DateTime.Now.ToString("M-d-yyyy");
                date = txtboxDate.Text;
                txtboxInTime.Text = DateTime.Now.ToString("hh:mm");
                inTime = txtboxInTime.Text;
                group = cmbBoxAgeGroup.SelectedItem.ToString();

                VisitorInfo v;
                v = new VisitorInfo();
                v.VisitorID = visitorID.ToString();
                v.Name = name;
                v.Group = ageGroup;
                v.PhoneNo = phoneNo;
                v.VisitorType = visitorType;
                v.Date = date;
                v.InTime = inTime;

                List<VisitorInfo> lstVisitor = new List<VisitorInfo>();

                string data = Utility.ReadFromFile();
                if (data != null && data != "")
                {
                    lstVisitor = JsonConvert.DeserializeObject<List<VisitorInfo>>(data);
                }
                lstVisitor.Add(v);
                string str = JsonConvert.SerializeObject(lstVisitor);
                Utility.WriteToText(str);

                MessageBox.Show("Data Submitted.");
                dataGridView1.Rows.Add(visitorID, name, ageGroup, phoneNo, visitorType, date, inTime, group);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                Pricing f1 = new Pricing();
                f1.ageGrp = cmbBoxAgeGroup.SelectedItem.ToString();
                f1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtboxName.Text = "";
            txtboxVisitorID.Text = "";
            cmbBoxAgeGroup.Text = "";
            txtBoxPhoneNo.Text = "";
            cmbBoxVisitorType.Text = "";
            txtboxDate.Text = "";
            txtboxInTime.Text = "";
            txtboxOutTime.Text = "";
            cmbBoxAgeGroup.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
