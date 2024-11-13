// To-Do list app 
// Version 01
// Date : 12/11/2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string strName = txtboxName.Text.Trim();
            string strCategory = comboBxCategory.SelectedItem?.ToString() ?? string.Empty;
            string strDate = dtpDate.Value.ToShortDateString();
            string strTime = dtpTime.Value.ToString("hh:mm tt");

            object[] dataRow = { strName, strCategory, strDate, strTime };

            dgvTasks.Rows.Add(dataRow);
            dgvTasks.ClearSelection();

            // rest for next task
            txtboxName.Text = null;
            comboBxCategory.SelectedItem = null;
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTasks.CurrentRow != null)
            {
                txtboxName.Text = dgvTasks.CurrentRow.Cells["Task"].Value.ToString();
                comboBxCategory.SelectedItem = dgvTasks.CurrentRow.Cells["Category"].Value?.ToString();
                dtpDate.Value = Convert.ToDateTime(dgvTasks.CurrentRow.Cells["Date"].Value);
                dtpTime.Value = Convert.ToDateTime(dgvTasks.CurrentRow.Cells["Time"].Value);
            }
            else
            {
                MessageBox.Show("Error!", "Error!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                dgvTasks.CurrentRow.Cells["Task"].Value = txtboxName.Text.ToString();
                dgvTasks.CurrentRow.Cells["Category"].Value = comboBxCategory.SelectedItem.ToString();
                dgvTasks.CurrentRow.Cells["Date"].Value = dtpDate.Value.ToShortDateString();
                dgvTasks.CurrentRow.Cells["Time"].Value = dtpTime.Value.ToString("hh:mm tt");
            }
            else
            {
                MessageBox.Show("Error!", "Error!");
            }

            dgvTasks.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                // dgvTasks.Rows.Remove(dgvTasks.CurrentRow);
                dgvTasks.Rows.RemoveAt(dgvTasks.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Error!","Error!");
            }

            dgvTasks.ClearSelection();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/asmaaderghal/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/asmaaderghal/");
        }
    }
}
