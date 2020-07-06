using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

    
//██████╗░░█████╗░███╗░░░███╗░█████╗░███╗░░██╗  ░█████╗░██████╗░██╗░░░██╗███╗░░██╗███████╗████████╗░██████╗
//██╔══██╗██╔══██╗████╗░████║██╔══██╗████╗░██║  ██╔══██╗██╔══██╗╚██╗░██╔╝████╗░██║██╔════╝╚══██╔══╝██╔════╝
//██████╔╝██║░░██║██╔████╔██║███████║██╔██╗██║  ██║░░██║██║░░██║░╚████╔╝░██╔██╗██║█████╗░░░░░██║░░░╚█████╗░
//██╔══██╗██║░░██║██║╚██╔╝██║██╔══██║██║╚████║  ██║░░██║██║░░██║░░╚██╔╝░░██║╚████║██╔══╝░░░░░██║░░░░╚═══██╗
//██║░░██║╚█████╔╝██║░╚═╝░██║██║░░██║██║░╚███║  ╚█████╔╝██████╔╝░░░██║░░░██║░╚███║███████╗░░░██║░░░██████╔╝
//╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝  ░╚════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚══╝╚══════╝░░░╚═╝░░░╚═════╝░

namespace IniWorker
{
    /// <summary>
    /// Отвечает за работу с файлом конфигурации
    /// </summary>
    public class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        /// <summary>
        /// Коструктор конфигурационного файла
        /// </summary>
        /// <param name="IniPath">Путь к файлу</param>
        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        /// <summary>
        /// Чтение записи с конфигурации
        /// </summary>
        /// <param name="Key">Ключ записи</param>
        /// <param name="Section">Секция записи</param>
        /// <returns>Зачение записи</returns>
        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        /// <summary>
        /// Запись в конфигурацию
        /// </summary>
        /// <param name="Key">Ключ записи</param>
        /// <param name="Value">Значение записи</param>
        /// <param name="Section">Секция записи</param>
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        /// <summary>
        /// Удаление ключа с конфигурации
        /// </summary>
        /// <param name="Key">Ключ записи</param>
        /// <param name="Section">Секция записи</param>
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        /// <summary>
        /// Удаление целой секции с конфигурации
        /// </summary>
        /// <param name="Section">Секция</param>
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        /// <summary>
        /// Проверка на существование ключа в конфигурации
        /// </summary>
        /// <param name="Key">Ключ записи</param>
        /// <param name="Section">Секция записи</param>
        /// <returns>Булевый результат</returns>
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
