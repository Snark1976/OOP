namespace Market.Services
{
    /// <summary>
    /// Класс, предоставляющий функционал логирования в текстовый файл.
    /// </summary>
    public class Logger(string logFilePath)
    {
        private readonly string _logFilePath = logFilePath;

        /// <summary>
        /// Метод для записи сообщения в текстовый файл логов.
        /// </summary>
        /// <param name="logMessage">Сообщение для записи в лог.</param>
        public void LogToFile(string logMessage)
        {
            using StreamWriter writer = new(_logFilePath, true);
            writer.WriteLine(logMessage);
        }
    }
}
