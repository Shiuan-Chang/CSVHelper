using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CSVHelper
{
    internal class CSV
    {
        public static void CreateDirectory(string filePath) 
        {
            string pathWithFile = filePath;
            string pathWithDocument = "";

            int lastSlashIndex = pathWithFile.LastIndexOf('\\');
            if (lastSlashIndex == -1) 
            {
                pathWithDocument = pathWithFile.Substring(0, lastSlashIndex);
            }
            if (!Directory.Exists(pathWithDocument)) 
            {
                Directory.CreateDirectory(pathWithDocument);
            }
        }

        public static void WriteCSV<T>(string filePath, List<T> data, bool isAppend = false) where T : new() 
        {
            using (var writer = new StreamWriter(filePath, isAppend, Encoding.UTF8)) 
            {
                foreach (var item in data) 
                {
                    List<string> values = new List<string>();
                    foreach (PropertyInfo property in typeof(T).GetProperties()) 
                    {
                        object value = property.GetValue(item);
                        values.Add(value !=  null ? value.ToString() : string.Empty);
                    }
                    string line = string.Join(",", values);
                    writer.WriteLine(line);
                }
            }
        }
    }
}

// PropertyInfo 反射的使用
