using lesson4HW;
Service service = new Service();
string message1 = service.TriangleTest(3, 3, 3);
string message2 = service.TriangleTest(3, 4, 4);
string message3 = service.TriangleTest(3, 4, 5);
string message4 = service.TriangleTest(3, 5, 9);
Console.ReadKey();

