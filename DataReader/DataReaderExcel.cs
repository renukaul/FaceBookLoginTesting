using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookLoginTesting.DataReader
{
    public class DataReaderExcel
    {
        string filename = "LoginData.xlsx";

        public DataTable readData()
        {
            string filePath = Directory.GetParent(@"../../../").FullName
                    + Path.DirectorySeparatorChar + "DataReader"
                    + Path.DirectorySeparatorChar + filename;


            using (System.IO.FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                //to handle the encoding exception 1252
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


                using (IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateOpenXmlReader(fs))
                {

                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        { 
                            UseHeaderRow = true
                        }
                    });
                  

                    DataTableCollection dtc = result.Tables;
                    DataTable dt = dtc[0];

                    return dt;

                }

            }


        }


    }
}
