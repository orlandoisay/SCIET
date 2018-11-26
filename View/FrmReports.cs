using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Data;

namespace View
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void btnExportSales_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void rdbDaySales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDaySales.Checked)
            {
                cmbFinalSalesDare.Visible = false;
                cmbInitialSalesDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today + 1));
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbWeekSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWeekSales.Checked)
            {
                cmbFinalSalesDare.Visible = false;
                cmbInitialSalesDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                DateTime finish = DateTime.Now;
                DayOfWeek today = DateTime.Today.DayOfWeek;
                int diffDaysFromMonday = DayOfWeek.Sunday - (today + 1);
                DateTime init = DateTime.Today.AddDays(diffDaysFromMonday);
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbMonthSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonthSales.Checked)
            {
                cmbFinalSalesDare.Visible = false;
                cmbInitialSalesDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Day.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbYearSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYearSales.Checked)
            {
                cmbFinalSalesDare.Visible = false;
                cmbInitialSalesDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.DayOfYear.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbDayInputOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDayInputOutput.Checked)
            {
                cmbFinalDateInputOutput.Visible = false;
                cmbInitialDateInputOutput.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today + 1));
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbWeekInputOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWeekInputOutput.Checked)
            {
                cmbFinalDateInputOutput.Visible = false;
                cmbInitialDateInputOutput.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                DateTime finish = DateTime.Now;
                DayOfWeek today = DateTime.Today.DayOfWeek;
                int diffDaysFromMonday = DayOfWeek.Sunday - (today + 1);
                DateTime init = DateTime.Today.AddDays(diffDaysFromMonday);
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbMonthInputOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonthInputOutput.Checked)
            {
                cmbFinalDateInputOutput.Visible = false;
                cmbInitialDateInputOutput.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Day.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbYeadInputOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYeadInputOutput.Checked)
            {
                cmbFinalDateInputOutput.Visible = false;
                cmbInitialDateInputOutput.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.DayOfYear.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbCustomInputsAndOutputs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustomSales.Checked)
            {
                cmbFinalDateInputOutput.Visible = false;
                cmbInitialDateInputOutput.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                DateTime finish = cmbFinalSalesDare.Value;
                DateTime init = cmbInitialSalesDate.Value;
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbCustomSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustomSales.Checked)
            {
                cmbFinalSalesDare.Visible = true;
                cmbInitialSalesDate.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                DateTime finish = cmbFinalSalesDare.Value;
                DateTime init = cmbInitialSalesDate.Value;
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbDayCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDayInputOutput.Checked)
            {
                cmbFinalDateCost.Visible = false;
                cmbInitialDateCost.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today + 1));
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(init, finish);
                dtgSalesReport.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgSalesReport.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }
    }
}
