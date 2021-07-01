using System;
using System.IO;
using System.Xml.Serialization;

namespace ManagerFile
{
    [Serializable]
    public class Settings
    {
        /// <summary>
        /// Путь для сканирования файлов
        /// </summary>
        public string PathScan { get; set; }

        /// <summary>
        /// Путь для сохранения файлов
        /// </summary>
        public string PathSave { get; set; } 
        
        /// <summary>
        /// Интервал сканирования данных
        /// </summary>
        public int Interval { get; set; }
        
        /// <summary>
        /// Сохранять журнал
        /// </summary>
        public bool SaveJournal { get; set; }

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        public void Save()
        {
            Formatters.XML.SerializeXML(GetPathSettings(), this);
        }

        /// <summary>
        /// Загрузить настройки
        /// </summary>
        public static Settings Load()
        {
            Settings settings = null;

            if (File.Exists(GetPathSettings()))
            {
                using (FileStream fs = new FileStream(GetPathSettings(), FileMode.Open))
                {
                    settings = Formatters.XML.DeserializeXML<Settings>(fs);
                }
            }
            else
            {
                settings = SaveDefault();
            }
            return settings;
        }

        private static string GetPathSettings()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SettingsManagerFile.XML");
        }

        /// <summary>
        /// Сохранить настройки по умолчанию
        /// </summary>
        private static Settings SaveDefault()
        {
            Settings settings = new Settings();
            settings.PathSave = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settings.PathScan = null;
            settings.Interval = 300000;
            settings.SaveJournal = false;
            settings.Save();
            return settings;
        }


    }
}
