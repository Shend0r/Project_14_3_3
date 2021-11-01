// See https://aka.ms/new-console-template for more information

using Project_14_3_3;

List<Contact> phoneBook = new List<Contact>();
phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

var sortedBook = phoneBook.OrderBy(s => s.Name).ThenBy(s => s.LastName);

foreach (var contact in sortedBook)
{
    Console.WriteLine(
        "Имя : {0} {1} | Тел. Номер : {2} | Почта : {3}", 
        contact.Name, 
        contact.LastName, 
        contact.PhoneNumber,
        contact.Email
        );
}

Console.ReadKey();
