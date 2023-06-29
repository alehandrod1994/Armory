using Armory.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Controller
{
    public class MessageController
    {
        private readonly Dictionary<DocumentResult, string> _messages;

        public MessageController() 
        {
            _messages = new Dictionary<DocumentResult, string>()
            {
                { DocumentResult.Added, "Данные успешно добавлены."},
                { DocumentResult.FailedConnection, "Не удалось открыть подключение к файлу."},
                { DocumentResult.NotSaved, "Не удалось сохранить файл."},
                { DocumentResult.Saved, "Успешно."},
                { DocumentResult.UnknownData, "Не удалось распознать файл. Операция отменена."}
            };
        }

        public string GetMessage(DocumentResult result)
        {
            return _messages[result];
        }
    }
}
