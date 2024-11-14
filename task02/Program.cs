namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            
            List<int> myList = new List<int>();
            do
            {
                Console.WriteLine("\n------------- Welcome To Our List Program -------------");
                Console.WriteLine("Enter P To Print The Numbers Of The List : ");
                Console.WriteLine("Enter A To Add A Number To The List : ");
                Console.WriteLine("Enter M To Show The Mean Of The List : ");
                Console.WriteLine("Enter S To Show The Smallest Number Of The List : ");
                Console.WriteLine("Enter L To Show The Largest Number Of The List : ");
                Console.WriteLine("Enter F To Find A Number Of The List : ");
                Console.WriteLine("Enter C To Remove All The Numbers Of The List : ");
                Console.WriteLine("Enter Q To Quit The Program ");
                input = Console.ReadLine();
                input = input.ToUpper();
                switch (input)
                {
                    case "P":
                        if (myList.Count == 0)
                            Console.WriteLine("sorry the list is empty ");
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < myList.Count; i++) 
                            {
                                Console.Write(myList[i]+" ");
                            }
                            Console.WriteLine("]");
                        }
                        break;
                    case "A":
                        Console.Write("please enter the number :");
                        int num = int.Parse(Console.ReadLine());
                        myList.Add(num);
                        Console.WriteLine($"{num} has been added");
                        break;
                    case "M":
                        int sum = 0;
                        double result = 0;
                        for (int i = 0;i< myList.Count; i++)
                        {
                            sum += myList[i];
                        }
                        result = sum / myList.Count;
                        Console.WriteLine($"The Mean is  {sum} / {myList.Count } = {result:f2}");
                        break;
                    case "S":
                        int smallest = myList[0];
                        for(int i = 0; i < myList.Count; i++) 
                        {
                            if (myList[i] < smallest) 
                            {
                                smallest = myList[i];
                            }
                        }

                        Console.WriteLine($"The Smallest Number Is { smallest }");
                        break;
                    case "L":
                        int largest = myList[0];
                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (myList[i] > largest)
                            {
                                largest = myList[i];
                            }
                        }

                        Console.WriteLine($"The Largest Number Is {largest}");

                        break;
                    case "F":
                        if (myList.Count == 0)
                        {
                            Console.WriteLine("Sorry Your List is Empty ");
                        }
                        else
                        {
                            Console.Write("Please Enter The Number :");
                            int find = int.Parse(Console.ReadLine());
                            for (int i = 0; i < myList.Count; i++)
                            {
                                if (myList[i] == find)
                                {
                                    Console.WriteLine($"{find} exist in index number {i + 1}");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry The Number Does Not Exist  ");
                                }
                            }
                        }
                        break;
                    case "C":
                        if (myList.Count == 0)
                        {
                            Console.WriteLine("Your List Is Already Empty ");
                        }
                        else
                        {
                            myList.Clear();
                            Console.WriteLine("Your List Is Cleared !");
                        }
                        break;
                    default : Console.WriteLine("Invalid , Please Enter Another Input ");
                        break;
                }
            } while (input != "Q");
        }
    }
}
