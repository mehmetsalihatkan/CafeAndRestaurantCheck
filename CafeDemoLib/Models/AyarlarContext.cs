﻿using CafeDemoLib.Sınıflar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Models
{
    public class AyarlarContext
    {
        private static string _path =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CafeDemo/db.json";

        public static List<DataSet> Datalar { get; set; } = new List<DataSet>();
       

        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    Datalar = JsonConvert.DeserializeObject<List<DataSet>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory("C:/KisiEnvanteri");
            }
        }
        public static void Save()
        {
            try
            {
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(Datalar, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}