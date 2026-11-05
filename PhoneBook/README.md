# Домашна работа №2 – Телефонен указател (MVC)

Конзолно приложение на C# (.NET 8) с Model, View и Controller.

- `Models/Contact.cs` – Model (име и телефон)
- `Repositories/ContactRepository.cs` – пази списъка и търси по име
- `Views/ContactView.cs` – само показва и въвежда
- `Controllers/ContactController.cs` и `Program.cs` – готови от листа, не са променяни

Стартиране: `dotnet run --project PhoneBook`

## Задача 4

1) Run() върти менюто в цикъл. Менюто го показва View-то (ShowMenu), а контролерът решава какво да се изпълни според избора.

2) Защото контролерът само координира. Списъкът се пази в хранилището (Repository), а печатането е работа на View-то. Така всеки клас си има една задача.

3) Ако менюто трябва да изглежда по друг начин – променяме ContactView. Ако контактите трябва да се пазят във файл – променяме ContactRepository.
