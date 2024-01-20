using Armory.BL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Controller
{
    public class MessageController
    {
        private readonly Dictionary<MessageResult, string> _messages;

        public MessageController() 
        {
            _messages = new Dictionary<MessageResult, string>()
            {
                { MessageResult.Added, "Данные успешно добавлены."},
                { MessageResult.Changed, "Данные успешно изменены."},
                { MessageResult.Exported, "Данные успешно сохранены."},
                { MessageResult.FailedConnection, "Не удалось открыть подключение к файлу."},
                { MessageResult.Imported, "Данные успешно импортированы."},
                { MessageResult.NoSheet, "Не найден лист."},
                { MessageResult.NotSaved, "Не удалось сохранить файл."},
                { MessageResult.Removed, "Данные успешно удалены."},
                { MessageResult.Saved, "Успешно."},
                { MessageResult.UnknownData, "Не удалось распознать файл. Операция отменена."}
            };
        }

        public string? GetMessage(MessageResult key)
        {
            if (_messages.TryGetValue(key, out string? value))
            {
                return value;
            }

            return null;
        }
    }
}
