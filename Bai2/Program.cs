namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        Console.WriteLine("Nhap chuoi s");
        string s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {  
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                myStack.Push((int)s[i]);
            }
            else
            {
                if (myStack.Count >= 1)
                {
                    int dinh = myStack.Peek();
                    if (Math.Abs(dinh - ((int)s[i])) <= 2)
                        myStack.Pop();
                }
            }
        }

        Console.WriteLine((myStack.Count == 0) ? "YES" : "NO");
    }
}