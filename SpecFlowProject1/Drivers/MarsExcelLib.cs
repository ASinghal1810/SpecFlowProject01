using SpecflowProject1.Drivers;
using OpenQA.Selenium;
using System.Data;
using ExcelDataReader;

namespace SpecFlowProject1.Drivers
{
    public class MarsExcelLib
    {
        static List<MarsExcelLibDatacollection> dataCol = new List<MarsExcelLibDatacollection>();
        public class MarsExcelLibDatacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }


        public static void MarsExcelLibClearData()
        {
            dataCol.Clear();
        }


        private static DataTable MarsExcelLibExcelToDataTable(string filename, string SheetName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            // excelReader.IsFirstRowAsColumnNames = true * Does not works anymore

            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table[SheetName];
            return resultTable;
        }

        public static string MarsExcelLibReadData(int rowNumber, string columnName)
        {
            try
            {
                ////Retrieving Data using LINQ
                var data = (from colData in dataCol
                            where colData.colName == columnName && colData.rowNumber == rowNumber
                            select colData.colValue).First().ToString();

                //var data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }

        }

        public static string MarsExcelLibWriteData(int rowNumber, string columnName)
        {
            try
            {
                ////Retrieving Data using LINQ
                var data = (from colData in dataCol
                            where colData.colName == columnName && colData.rowNumber == rowNumber
                            select colData.colValue).First().ToString();
                //var data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }

        }

        public static void MarsExcelLibPopulateInCollection(string filename, string SheetName)
        {
            //ExcelLib.ClearData();
            DataTable table = MarsExcelLibExcelToDataTable(filename, SheetName);
            //int totalRowCount = table.Rows.Count;
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    MarsExcelLibDatacollection dtTable = new MarsExcelLibDatacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };


                    dataCol.Add(dtTable);
                }
            }
        }
    }
}