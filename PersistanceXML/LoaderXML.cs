using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Fourmia.Metier;
using System.IO;
using System.Collections.Generic;

namespace PersistanceXML
{
    public class LoaderXML : IDataLoader
    {
        List<Ant> IDataLoader.Load()
        {
            //DataControler dataControler;
            //DirectoryInfo dirInfo = DirectoryInfo.GetParent(Directory.GetCurrentDirectory());
            //string dirData = string.Format("{0}\\AntsData\\", dirInfo.FullName);
            //string xmlFile = string.Format("{0}{1}", dirData, "ants.xml");

            //Stream stream = File.Create(xmlFile);
            //var serializer = new DataContractSerializer(typeof(DataControler));
            //using (stream)
            //{
            //    try
            //    {
            //        dataControler = serializer.ReadObject(stream) as DataControler;
            //    }
            //    catch (XmlException)
            //    {
            //        dataControler = DataControler.getInstance(FourmiaLoader.FORMAT_NONE);
            //    }
            //}
            //return dataControler;

            return null;
        }

        void IDataLoader.Save()
        {
            //DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            //string dirData = string.Format("{0}\\AntsData\\", dirInfo.FullName);
            //string xmlFile = string.Format("{0}{1}", dirData, "ants.xml");

            //var serializer = new DataContractSerializer(typeof(DataControler));

            //XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };
            //using (XmlWriter writer = XmlWriter.Create(xmlFile, settings))
            //{
            //    serializer.WriteObject(writer, DataControler.getInstance(FourmiaLoader.FORMAT_XML));
            //}
        }
    }
}
