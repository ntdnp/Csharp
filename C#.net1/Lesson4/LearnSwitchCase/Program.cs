using LearnSwitchCase;
Service service = new Service();
string message = service.GetMessage(404);
int days = service.GetDaysOfMonth(2, 2020);

Console.ReadKey();