//int[] arr = { 3, 6, 2, 4, 5, 9 };
//Array.Clear(arr, 2, 1);

//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//} ---- clear metodu




//int[] arr = { 5, 2, 4, 7, 8, 6 };
//arr.GetValue(5);
//Console.WriteLine(arr[5]); //--- getvalue metodu



////int[] arr = { 5, 7, 8, 9, 6 };
//arr[3] = 20;
//Console.WriteLine(arr);

//int[] arr = { 7, 8, 9, 4, 5, 2, 0, 3 };
//arr.SetValue(45,3); ---set method


//int[] arr = { 1,2,5,6,7,2};
//int index = Array.IndexOf(arr,6);
//Console.WriteLine(index); -- index metodu


//int[] arr = { 1, 2, 4, 5, 6 };
//Array.Resize(ref  arr, 8);
//foreach (int item in arr)
//{
//    Console.WriteLine(item + " ");
//} ----resize metodu


//int[] arr = { 1, 9, 0, 3, 8, 5 };
//Array.Sort(arr);
//foreach (int item in arr)
//{
//    Console.WriteLine(item + " ");
//} ---sort metodu


//int[] arr = { 4, 8, 2, 3, 6, 7 };
//Array.Fill(arr,8);
//foreach (int item in arr)
//{
//    Console.WriteLine(item+" ");
//} ---fill metodu

//string[] speciality = { "doctor", "teacher", "oilman" };
//String.Concat(speciality);
//foreach (String s in speciality)
//{
//    Console.WriteLine(s);
//} --- concat metodu

//string[] names = { "Aziko", "Akif", "Murad" };
//bool ContainsInNames=names.Contains(names[1]);
//if (true)
//{
//    Console.WriteLine("Akif exists in array");
//}
//else
//{
//    Console.WriteLine("this name doesn't exist");
//}
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}





//try
//{
//    int a = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(a);
//}
//catch (Exception)
//{
//    Console.WriteLine("It is not correct version");
//    throw;
//}
//finally {
//    Console.WriteLine("It always works");
//}





internal class Program
{
    static void Main(string[] args)
    {
        string word = "Salam JetAcademy qrupu";
        Console.WriteLine(Reverse(word)); 
    }
   static string Reverse(string word)
    {
        string[] words = word.Split(' ');

        for(int i=0; i<words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }
        return string.Join(" ", words);

    }
    static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}