using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SwiatPracownikow
{
    public class binFormatter
    {
        public void SerializeList(List<Osoba> lista, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, lista);
            fileStream.Close();
        }
        public void SerializeDyzury(Osoba[,] dyzury, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, dyzury);
            fileStream.Close();
        }

        public void DeserializeList(string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath) && new FileInfo(filePath).Length != 0)
            {
                fileStream = File.OpenRead(filePath);
                Osoba.ListaPracownikow = bf.Deserialize(fileStream) as List<Osoba>;
                fileStream.Close();
            }
        }
        public void DeserializeDyzury(string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath) && new FileInfo(filePath).Length != 0)
            {
                fileStream = File.OpenRead(filePath);
                Dyzury.PlanDyzurow = bf.Deserialize(fileStream) as Osoba[,];
                fileStream.Close();
            }
        }
    }
}
