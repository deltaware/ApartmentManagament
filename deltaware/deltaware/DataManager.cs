using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace deltaware
{
    class DataManager
    {
        public string adSoyad{ get; set; }
        public int kat { get; set; }
        public string aidat { get; set; }
        public string ozelNot { get; set; }
    }
    class Data
    {
        public string dir;
        public string dataDir;

        public Data()
        {
            dir = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\deltaware-data\\apartmentmanagament";
            dataDir = dir + "\\data.json";
        }
        public void writeData(string adSoyad, int kat, string aidat, string ozelNot)
        {
            DataManager dataManager = new DataManager()
            {
                adSoyad = adSoyad,
                kat = kat,
                aidat = aidat,
                ozelNot = ozelNot
            };
            string stringJSON = JsonConvert.SerializeObject(dataManager);
            Console.WriteLine(stringJSON);
            
            FileStream fileStream = File.Create(dataDir);
            fileStream.Close();
            StreamWriter streamWriter = new StreamWriter(dataDir);
            streamWriter.WriteLine(stringJSON);
            streamWriter.Close();
        }

        public void firstStart()
        {
            if (!Directory.Exists(dir))
            {
                Console.WriteLine("oluşturuluyor.");
                Directory.CreateDirectory(dir);
            }
        }
    }
}
