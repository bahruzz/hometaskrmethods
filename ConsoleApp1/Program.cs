//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//temp qebul eden method yazirsiz. 
//    Return type olan method olmalidir. Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin

//string Tempurature(int temp)
//{
//    string message;
//    if (temp == 20)
//    {
//        message = "mulayim";
//    }
//    else if (temp > 20) 
//    {
//        message = "isti";
//    }
//    else
//    {
//        message = "soyuq";
//    }
//    return message;
//}
//Console.WriteLine(Tempurature(20));


//methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin

//int SumOfNumbers()
//{
//    int sum = 0;
//    int a = 21;
//    int b = 37;
//    if (a >= 0)
//    {
//        sum = a - b;
//    }
//    else
//    {
//        sum = b - a;

//    }
//    return sum;

//}
//int result = SumOfNumbers();
//Console.WriteLine(result);



//method reqemlerden ibaret 2 array qebul edecek,
//    her iki arrayin elementlerinin cemini geri qaytarsin

//int SumOfNumbers(int[] elems1, int[]elems2)
//{
//    int sum=0;

//    foreach (int elem1 in elems1)
//    {
//        sum += elem1;
//    }
//    foreach (int elem2 in elems2) 
//    {
//        sum += elem2;
//    }
//    return sum;
//}
//int[] elems1 = { 1, 3, 5, 6, 7 };
//int[] elems2 = { 8, 11, 13, 15, 17 };

//Console.WriteLine(SumOfNumbers(elems1, elems2));


//methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin

//int Number()
//{
//    int a = 4;
//    return a * a;
//}
//Console.WriteLine(Number());    


//methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin

//int SumOfEvenNumber()
//{
//    int sum = 0;
//    int a = 4;
//    for (int i = 1; i <= a; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//Console.WriteLine(SumOfEvenNumber());


//1.Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın

//using System.ComponentModel.Design;
// versiya-1
//String Divide(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        return "Is Divide";

//    }
//    else
//    {
//        return "Not Divide";
//    }

//}
//Console.WriteLine(Divide(42));

////versiya-2
//bool IsDivide(int n)
//{
//    if(n%3==0 && n % 7 == 0)
//    {
//        return true;
//    }
//    return false;

//}
//Console.WriteLine(IsDivide(14));



//2.n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın

//void SumOfEvenNumbers(int n, int m)
//{
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        Console.WriteLine(n + m);
//    }
//    else
//    {
//        Console.WriteLine("cut ede olmalidir");
//    }
//}
//SumOfEvenNumbers(6, 16);


//3.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin

//int SumOffOddNumber(int n,int m)
//{ int count = 0;
//    for (int i =n;i < m; i++)
//    {   if (i % 2 == 1) 
//        count++;

//    }
//    return count;
//}
//Console.WriteLine(SumOffOddNumber(11, 21));


//4.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin

//int SumOffOddNumber(int n, int m)
//{
//    int sum = 0;
//for (int i = n; i < m; i++)
//{
//        if (i % 2 == 1)
//            sum += i;

//}
//    return sum;
//}
//Console.WriteLine(SumOffOddNumber(11, 21));

//5.Verilmish arrayin icindeki tek ededlerin cemini tapin
//void SumOfOddNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 41 };
//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 1)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}
//SumOfOddNumbers();



//6.Verilmish arrayin icindeki cut ededlerin sayini tapin
//void SumOfEvenNumbers()
//{
//    int[] elems = { 1, 2, 3, 4, 56 };
//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item % 2 == 0)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}
//SumOfEvenNumbers();

//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//int n = 12;
//void Nums(int n)
//{
//    int count = 0;
//    if (n < 2)
//    {
//        Console.WriteLine("ne sade ne muurekkeb");

//    }
//    else
//    {
//        for (int i =1; i<=n;i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("sade");
//    }

//    else
//    {
//        Console.WriteLine("murekkeb");
//    }
    
//}
//Nums(n);



//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//    Meselen: Cavablar ola  biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.
//int n = 16;
//int i = 2;
//void Nums(int n)
//{
//    if (n <= 0)
//    {
//        Console.WriteLine("please add positive numbers");
//    }
//    else
//    {
//        while (i < n)
//        {
//            i*= 2;
//        }
//        if (n == i)
//        {
//            Console.WriteLine("yes");
//        }
//        else
//        {
//            Console.WriteLine("No");
//        }
//    }
//}
//Nums(n);

/*9.* Verilmish **//*/*/ /*arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.

//           * Mes ([1,3,55,6,33], cavab: 18)*/
//int Arrays()
//{
//    int result = 1;
//    int[] elems = { 1, 3, 55, 6, 33 };
//    for (int i = 0; i < elems.Length; i++)
//    {
//        if (elems[i] < 20)
//        {
//            result *= elems[i];

//        }

//    }
//    return result;
//}
//Console.WriteLine(Arrays());




//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq

//using System.Diagnostics.CodeAnalysis;

//using System.Diagnostics.CodeAnalysis;

/////
//int Arrays(int []elems)
//{
//    int sum = 0;
//    foreach (int elem in elems)
//    {
//        if (elem % 2 == 0)
//        {
//            sum += elem;
//        }
//    }
//    return sum * sum;
//}

//int[] elems = { 1, 2, 3, 4, 5,6 };
//Console.WriteLine(Arrays(elems));