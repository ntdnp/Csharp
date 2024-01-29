using LearnOOP;
var anna = new Person();
anna.age = 10;
anna.name = "anna";
anna.GetInfo();
var thoa = new Person() { age = 22, name = "thai thi thoa" };
thoa.GetInfo();
thoa.Score = 60;
var info = thoa.GetInfo;
// public class Vehicle 
var dat = new Vehicle();
dat.Name = "oto";
dat.Price = 330;
dat.GetInfo();
var messi = new Person("Messi", 30, "Unkown");
Console.ReadKey();

