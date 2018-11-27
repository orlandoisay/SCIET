using System;
using System.Collections.Generic;
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
            ExportarDataGridViewExcel(dtgSalesReport);
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
                btnReportSales.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(inicio, fin);
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
                btnReportSales.Visible = false;
                DateTime finish = DateTime.Now;
                DayOfWeek today = DateTime.Today.DayOfWeek;
                int diffDaysFromMonday = DayOfWeek.Sunday - (today);
                DateTime init = DateTime.Today.AddDays(diffDaysFromMonday);
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(inicio, fin);
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
                btnReportSales.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Day.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(inicio, fin);
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
                btnReportSales.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.DayOfYear.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportSales(inicio, fin);
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
                btnReportInOut.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(inicio, fin);
                dtgInputOutput.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgInputOutput.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
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
                btnReportInOut.Visible = false;
                DateTime finish = DateTime.Now;
                DayOfWeek today = DateTime.Today.DayOfWeek;
                int diffDaysFromMonday = DayOfWeek.Sunday - (today);
                DateTime init = DateTime.Today.AddDays(diffDaysFromMonday);
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(inicio, fin);
                dtgInputOutput.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgInputOutput.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
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
                btnReportInOut.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Day.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(inicio, fin);
                dtgInputOutput.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgInputOutput.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
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
                btnReportInOut.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.DayOfYear.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportInOut(inicio, fin);
                dtgInputOutput.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgInputOutput.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
                }
            }
        }

        private void rdbCustomInputsAndOutputs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustomInputsAndOutputs.Checked)
            {
                cmbFinalDateInputOutput.Visible = true;
                cmbInitialDateInputOutput.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                btnReportInOut.Visible = true;

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
                btnReportSales.Visible = true;

            }
        }

        private void rdbDayCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDayCost.Checked)
            {
                cmbFinalDateCost.Visible = false;
                cmbInitialDateCost.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                btnReportCost.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Hour.ToString());
                DateTime init = DateTime.Today.AddHours(-(today + 1));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportCost(inicio, fin);
                dtgCost.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgCost.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            List<ReportPOJO> reports = ReportDAO.getAllReportInventory();
            dtgReportProducts.Rows.Clear();
            for (int i = 0; i < reports.Count; i++)
            {
                dtgReportProducts.Rows.Add(reports[i].IdArticle, 
                    reports[i].Name, reports[i].Size, reports[i].Color,
                    reports[i].Cost, reports[i].Price1, reports[i].Price2,
                    reports[i].Price3, reports[i].Price4, reports[i].QuantityArticle);
            }
        }

        private void rdbWeekCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWeekCost.Checked)
            {
                cmbFinalDateCost.Visible = false;
                cmbInitialDateCost.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                btnReportCost.Visible = false;
                DateTime finish = DateTime.Now;
                DayOfWeek today = DateTime.Today.DayOfWeek;
                int diffDaysFromMonday = DayOfWeek.Sunday - (today + 1);
                DateTime init = DateTime.Today.AddDays(diffDaysFromMonday);
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportCost(inicio, fin);
                dtgCost.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgCost.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void rdbMonthCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMonthCost.Checked)
            {
                cmbFinalDateCost.Visible = false;
                cmbInitialDateCost.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                btnReportCost.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.Day.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportCost(inicio, fin);
                dtgCost.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgCost.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }

        }

        private void rdbYearCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbYearCost.Checked)
            {
                cmbFinalDateCost.Visible = false;
                cmbInitialDateCost.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                btnReportCost.Visible = false;
                DateTime finish = DateTime.Now;
                int today = int.Parse(DateTime.Today.DayOfYear.ToString());
                DateTime init = DateTime.Today.AddDays(-(today));
                String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
                String inicio = init.Year + "-" + init.Month + "-" + init.Day;
                List<ReportPOJO> reports = ReportDAO.getAllReportCost(inicio, fin);
                dtgCost.Rows.Clear();
                for (int i = 0; i < reports.Count; i++)
                {
                    dtgCost.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
                }
            }
        }

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnInputOutput_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dtgInputOutput);
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dtgCost);
        }

        private void btnExportProducts_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dtgReportProducts);
        }

        private void btnReportSales_Click(object sender, EventArgs e)
        {
            DateTime finish = cmbFinalSalesDare.Value;
            DateTime init = cmbInitialSalesDate.Value;
            String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
            String inicio = init.Year + "-" + init.Month + "-" + (init.Day - 1);
            List<ReportPOJO> reports = ReportDAO.getAllReportSales(inicio, fin);
            dtgSalesReport.Rows.Clear();
            for (int i = 0; i < reports.Count; i++)
            {
                dtgSalesReport.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
            }
        }

        private void btnReportInOut_Click(object sender, EventArgs e)
        {
            DateTime finish = cmbFinalSalesDare.Value;
            DateTime init = cmbInitialSalesDate.Value;
            String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
            String inicio = init.Year + "-" + init.Month + "-" + (init.Day - 1);
            List<ReportPOJO> reports = ReportDAO.getAllReportInOut(inicio, fin);
            dtgInputOutput.Rows.Clear();
            for (int i = 0; i < reports.Count; i++)
            {
                dtgInputOutput.Rows.Add(reports[i].IdBatch, reports[i].DateBatch, reports[i].Reason, reports[i].QuantityBatch);
            }
        }

        private void btnReportCost_Click(object sender, EventArgs e)
        {
            DateTime finish = cmbFinalDateCost.Value;
            DateTime init = cmbInitialDateCost.Value;
            String fin = finish.Year + "-" + finish.Month + "-" + (finish.Day + 1);
            String inicio = init.Year + "-" + init.Month + "-" + (init.Day - 1);
            List<ReportPOJO> reports = ReportDAO.getAllReportCost(inicio, fin);
            dtgCost.Rows.Clear();
            for (int i = 0; i < reports.Count; i++)
            {
                dtgCost.Rows.Add(reports[i].IdSale, reports[i].Date, reports[i].Customer, reports[i].Total);
            }
        }

        private void rdbCustomCost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCustomSales.Checked)
            {
                cmbFinalDateCost.Visible = true;
                cmbInitialDateCost.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                btnReportCost.Visible = true;

            }
        }
    }
}
