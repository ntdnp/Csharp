using Infrastructure;
var anna = new Student("anna", 18, 8, 9);
var anna1 = new EnglishStudent("Anna", 18, 9, 7, 8.5);
var historySchool1 = new GenericSchool<HistoryStudent>();
var englishSchool1 = new GenericSchool<EnglishStudent>();
Console.WriteLine(anna1.GetInfo());
Console.ReadKey();