
using System;
using System.Collections.Generic;
using Wfu.Ma.Reports.Lydall.Enums;
using Microsoft.Office.Interop.Excel;

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
                if (_xlApp == null)
                {
                    _xlApp = new Application();
                    _xlApp.Visible = false;
                    _xlApp.ScreenUpdating = false;
                }
                return _xlApp;
            }
            set
            {
                _xlApp = value;
            }
        }

        public bool Create(List<Batch> batchList, string reportDestination, bool showReport = false)
        {
            try
            {
                var worksheet = _workbook.Worksheets[1];
                var currentRow = 2;
                worksheet.EnableCalculation = false;
                WriteHeader(worksheet);
                foreach (Batch batch in batchList)
                {
                    worksheet.Cells[currentRow, SummaryReportHeader.Shift].Value = "";
                    worksheet.Cells[currentRow, SummaryReportHeader.Employee].Value = batch.EmployeeName.ToUpper() + " [" + batch.EmployeeId + "]";
                    worksheet.Cells[currentRow, SummaryReportHeader.Building].Value = "";
                    worksheet.Cells[currentRow, SummaryReportHeader.RegularPay].Value = batch.GrossPay.ToString("#.##").ToUpper();
                    for (int i = 0; i < batch.TimeDetail.Count - 1; i++)
                    {
                        if(batch.TimeDetail[i].Date.ToShortDateString() == _day.ToShortDateString())
                        {
                            worksheet.Cells[currentRow, SummaryReportHeader.TotalHours].Value = batch.TimeDetail[i].TotalTime.ToString("#.##").ToUpper();
                            worksheet.Cells[currentRow, SummaryReportHeader.Department].Value = batch.TimeDetail[i].Department.ToUpper();
                            worksheet.Cells[currentRow, SummaryReportHeader.RegularHours].Value = batch.TimeDetail[i].RegularTimeTotal.ToString("#.##").ToUpper();
                            worksheet.Cells[currentRow, SummaryReportHeader.Overtime].Value = batch.TimeDetail[i].OverTimeOneTotal.ToString("#.##").ToUpper();
                            worksheet.Cells[currentRow, SummaryReportHeader.DateDay].Value = batch.TimeDetail[i].Date.ToShortDateString() + " " + batch.TimeDetail[0].Day;
                        }
                    }
                    currentRow += 1;
                }
                worksheet.Cells.Select();
                worksheet.Cells.EntireColumn.AutoFit();
                worksheet.Range("A1:I1").Font.Bold = true;
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
            worksheet.Cells[1, SummaryReportHeader.RegularPay].Value = "Reg. Pay";
            worksheet.Cells[1, SummaryReportHeader.DateDay].Value = "Date/Day";
        }

    }
}
