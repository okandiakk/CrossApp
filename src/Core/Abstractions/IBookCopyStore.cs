using Core.Domain;

namespace Core.Abstractions;

public interface IBookCopyStore
{
    IReadOnlyList<BookCopy> List(); // Повертає список усіх книжок (лише для читання, щоб захистити дані від змін)
    BookCopy? GetById(string id); // Шукає книжку за ID (повертає null, якщо книжку не знайдено)
    void Add(BookCopy item); // Додає нову книжку до сховища
    void Update(BookCopy item); // Оновлює дані існуючої книжки
    bool Remove(string id); // Видаляє книжку за ID (повертає true, якщо видалено успішно, і false — якщо запис не знайдено)
 IReadOnlyList<BookCopy> Find(Func<BookCopy, bool> predicate) => // Шукає книжки, що відповідають заданій умові
        List().Where(predicate).ToList();
}