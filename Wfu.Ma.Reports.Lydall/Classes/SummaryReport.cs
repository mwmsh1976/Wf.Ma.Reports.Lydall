
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Wfu.Core.Reports.Employee;
using Wfu.Ma.Reports.Lydall.Enums;

namespace Wfu.Ma.Reports.Lydall.Classes
{
    public class SummaryReport
    {
        private DateTime _day;
        private Workbook _workbook;
        private Application _xlApp;

        public SummaryReport(DateTime day)
        {
            _day = day.Date;
            _workbook = XLApp.Workbooks.Add();
            XLApp.DisplayAlerts = true;
            if(_workbook.Worksheets.Count > 1)
            {
                do
                {
                    _workbook.Sheets[_workbook.Sheets.Count].Delete();
                } while (_workbook.Sheets.Count > 1);
            }            
        }

        public Application XLApp
        {
            get
            {
                try
                {
                    if (_xlApp == null)
                    {
                        _xlApp = new Application();
                        _xlApp.Visible = false;
                        _xlApp.ScreenUpdating = false;
                    }
                    return _xlApp;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Whoops! An error occured." 
                        + Environment.NewLine + "I wonder if the version of Excel is the correct version?" +
                        ex.Message);
                    return null;
                }                
            }
            set
            {
                _xlApp = value;
            }
        }

        public bool Create(List<Batch> batchList, List<Employee> employeeList, string reportDestination, bool showReport = false)
        {
            try
            {
                var worksheet = _workbook.Worksheets[1];
                var currentRow = 2;
                worksheet.EnableCalculation = false;
                WriteHeader(worksheet);
                foreach (Batch batch in batchList)
                {
                    var batchItem = batch.TimeDetail.Where(b => b.Date.ToShortDateString() == _day.ToShortDateString()).FirstOrDefault();
                    if (batchItem != null && batchItem.TotalTime > 0)
                    {
                        var employee = employeeList.Where(e => e.PayrollNumber == batch.EmployeeId).FirstOrDefault();
                        worksheet.Cells[currentRow, SummaryReportHeader.Shift].Value = employee.DepartmentName.ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.Employee].Value = batch.EmployeeName.ToUpper() + " [" + batch.EmployeeId + "]";
                        worksheet.Cells[currentRow, SummaryReportHeader.Building].Value = employee.DepartmentCode.ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.TotalHours].Value = (batchItem.TotalTime).ToString("#.##").ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.Department].Value = batchItem.Department.ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.RegularHours].Value = batchItem.RegularTimeTotal.ToString("#.##").ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.Overtime].Value = batchItem.OverTimeOneTotal.ToString("#.##").ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.DownTime].Value = "";
                        worksheet.Cells[currentRow, SummaryReportHeader.RegularPayTotal].Value = (batchItem.RegularTimeTotal * employee.PayRate).ToString("#.##").ToUpper();
                        worksheet.Cells[currentRow, SummaryReportHeader.DateDay].Value = batchItem.Date.ToShortDateString() + " " + batchItem.Day.ToUpper();
                        currentRow += 1;
                    }
                }
                worksheet.Cells.Select();
                worksheet.Cells.EntireColumn.AutoFit();
                worksheet.Range("A1:J1").Font.Bold = true;
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                var time = DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() 
                    + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                var workbookName = reportDestination + @"LydallSummaryReport_" + time;
                _workbook.SaveAs( workbookName);
                if (showReport == true)
                {
                    _xlApp.ScreenUpdating = true;
                    XLApp.Visible = true;                    
                }
                else
                {
                   _workbook.Close();
                   XLApp.Quit();
                   XLApp = null;
                }
            }
           
        }

        private void WriteHeader(Worksheet worksheet)
        {
            worksheet.Cells[1, SummaryReportHeader.Department].Value = "Department";
            worksheet.Cells[1, SummaryReportHeader.Shift].Value = "Shift";
            worksheet.Cells[1, SummaryReportHeader.Employee].Value = "Employee";
            worksheet.Cells[1, SummaryReportHeader.Building].Value = "Building";
            worksheet.Cells[1, SummaryReportHeader.TotalHours].Value = "Total Hrs";
            worksheet.Cells[1, SummaryReportHeader.RegularHours].Value = "Reg. Hrs";
            worksheet.Cells[1, SummaryReportHeader.Overtime].Value = "OT";
            worksheet.Cells[1, SummaryReportHeader.DownTime].Value = "DT";
            worksheet.Cells[1, SummaryReportHeader.RegularPayTotal].Value = "Reg. Pay";
            worksheet.Cells[1, SummaryReportHeader.DateDay].Value = "Date/Day";
        }

    }
}
