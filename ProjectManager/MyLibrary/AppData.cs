using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyLibrary
{
    /// <summary>
    /// Class that provides class serialization.
    /// </summary>
    /// <typeparam name="T"> Class type. </typeparam>
    [Serializable]
    public class AppData<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "appData.dat";

        /// <summary>
        /// Serializes entity.
        /// </summary>
        /// <param name="fileName"> File name where to save. </param>
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// Deserializes entity.
        /// </summary>
        /// <param name="fileName"> File name from where to load. </param>
        /// <returns> Deserialized entity. </returns>
        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T data = new T();
            if (!File.Exists(fileName))
            {
                return data;
            }
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                data = (T)formatter.Deserialize(fs);
            }
            finally
            {
                fs.Close();
            }

            return data;
        }
    }
}
