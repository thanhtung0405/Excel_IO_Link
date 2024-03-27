using OfficeOpenXml;
using System.IO;
using System;

public class ExcelHelper : IDisposable
{

    private string path;
    private ExcelPackage excelPackage;
    private ExcelWorksheet worksheet;

    public ExcelHelper(string path, string sheet)
    {
        this.path = path;
        FileInfo fileInfo = new FileInfo(path);
        excelPackage = new ExcelPackage(fileInfo);
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        worksheet = excelPackage.Workbook.Worksheets[sheet];
    }
    public string ReadCell(int row, int column)
    {
        try
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (worksheet.Cells[row, column].Value != null)
            {
                return worksheet.Cells[row, column].Value.ToString();
            }
            else
                return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading cell: {ex.Message}");
            return ""; // Or return a default value based on requirements
        }
    }

    public void WriteToCell(int row, int column, string value)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        worksheet.Cells[row, column].Value = value;
    }
    public void WriteToCellDouble(int row, int column, double value)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        worksheet.Cells[row, column].Value = value;
        worksheet.Cells[row, column].Style.Numberformat.Format = "0.00";
    }
    public void Save()
    {
        excelPackage.Save();
    }

    public void Dispose()
    {
        excelPackage.Dispose();
    }
}