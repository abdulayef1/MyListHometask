
using ConsoleApp4;

MyList<int> myList = new MyList<int>();

myList.Add(12);
myList.Add(1);
myList.Add(1);
myList.Add(1);
myList.Add(12);
myList.Add(15);
myList.Add(33);
myList.Add(3);
myList.Add(7);

Console.WriteLine(myList.Exist(item => item == 16));



//Console.WriteLine(myList.Capacity);


foreach (var item in myList)
{
    Console.WriteLine(item);
}




