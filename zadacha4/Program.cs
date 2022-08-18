Console.Write("Введите 1 число=");
int number1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число=");
int number2= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число=");
int number3= Convert.ToInt32(Console.ReadLine());

int imax=0;

if(number1>number2) 
   imax=number1;

if(imax<number2) 
   imax=number2;

if(imax<number3) 
   imax=number3;

Console.WriteLine("max="+imax);
