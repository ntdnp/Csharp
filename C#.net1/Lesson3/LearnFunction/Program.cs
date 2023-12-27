
using LearnFunction;
// tao 1 doi tuong cua service
Service service = new Service();
double result = service.sum(5, 6);
double area = service.CalRecArea(5, 7);
double circleArea = service.CaAreaCircle(5);
// ref keywword
double circleArea1 = 5;
service.CalAreaCircle1(6, ref circleArea1);
double circleArea2 = 5;
service.CalAreaCircle2(6, circleArea2);

double recPerimater = 0;
// out ra nhieu gia tri tu mot ham mà ko phải viết thêm 
double reArea = service.CalRecArea1(6, 4 ,out recPerimater);
// ko muon nhan gia tri thi them _
double recArea1 = service.CalRecArea1(6, 4, out _);
// khai bao const ( ko the thay doi.giu nguyen)
//const string updateMessage = " Updata the product success";
//const string deleteMessage = " Delete the product success";

string iPhon = " Iphon 15";
Console.WriteLine(string.Format(CommonConstants.UpdateMessage,iPhon));
Console.WriteLine(string.Format(CommonConstants.DeleteMessage,iPhon));
    

Console.ReadKey();






