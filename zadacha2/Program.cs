Console.Write("Введите 1 число=");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число=");
int numberB= Convert.ToInt32(Console.ReadLine());
int imax=0;

if(numberA>numberB)
   imax=numberA;
   else
   imax=numberB;
   

Console.WriteLine("max = "+imax);
