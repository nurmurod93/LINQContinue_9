using LINQContinue_9;
using System.Security.Cryptography;

var products = GetProducts();
var anotherProducts = GetAnotherProducts();
ProductComparer comparer = new();

var query = products.Union(anotherProducts, comparer).ToList();

//foreach (var item in query)
//{
//    Console.WriteLine($"ID: {item.Id}, NAME: {item.Name}, COLOR: {item.Color}, PRISE: {item.Prise}, QUANTITY: {item.Quantity}, TOTALSTOCK: {item.TotalStock}\t");
//}

#region APPEND, RANGE, REPEAT, REVERSe, EMPTY,  GETTYPE, OFTYPE,  PREPEND, ZIP

//Console.WriteLine("___________________________ZIP_______________________________");

//int[] numbers = { 10, 20, 30, 40, 50 };
//string[] words = { "TEN", "TWENTY", "THIRTY", "FOURTY" };

//var result4 = numbers.Zip(words, (first, second) => first + " - " + second);
//foreach (var item in result4)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("___________________________DICTIONARY_______________________________");

//var keys = new List<string> { "ID", "NAME", "COLOR", "PRISE", "QUANTITY"};
//var values = new List<object> { 1, "Futbolka", "Ko'k", 15m, 23 };

//var query1 = keys.Zip(values, (key, value) => new { key, value });
//foreach (var item in query1)
//{ Console.WriteLine($"{item.key} - {item.value}"); }


//var keys = new List<string> { "ID", "NAME", "COLOR", "PRISE", "QUANTITY" };
//var values = new List<object> { 1, "Futbolka", "Ko'k", 15m, 23 };

//var query1 = keys.Zip(values, (key, value) => new { key, value }).ToDictionary(x => x.key, x => x.value);
//foreach(KeyValuePair<string, object> item in query1)
//    Console.WriteLine($"{item.Key} - {item.Value}");

//Console.WriteLine("__________________________PREPEND____________________________");

//List<int> list2 = new List<int> { 10, 20, 30, 50, 60 };
//var prepend = list2.Prepend(40);
//foreach (var item in prepend)
//    Console.WriteLine(item);

//Console.WriteLine("__________________________OFTYPE____________________________");

//var dataSourse = new List<object>()
//{
//    "Tom", "Marry", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
//};
//var intData = dataSourse.OfType<int>().ToList();
//foreach (var item in intData)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("__________________________EMPTY____________________________");

//var result = Enumerable.Empty<int>();
//Console.WriteLine("Empty: " + result.Count());

//var result2 = Enumerable.Empty<string>();
//Console.WriteLine("Empty: " + result2.Count());

//Console.WriteLine("__________________________GETTYPE____________________________");

//var result1 = Enumerable.Empty<Product>();
//Console.WriteLine("Empty: " + result1.GetType().Name);


//Console.WriteLine("__________________________REPEAT____________________________");

//var takror = Enumerable.Repeat("Salom", 2).ToList();

//foreach (var item in takror)
//    Console.WriteLine(item);


//Console.WriteLine("_________________________RANGE______________________________");

//var ketmaketlik = Enumerable.Range(1, 10).Where(x => x %2 == 0);

//foreach(var k in ketmaketlik)
//    Console.WriteLine(k);


//Console.WriteLine("________________________________APPEND________________________");


//List<int> list = new List<int> { 10, 20, 30, 50, 60 };
//var append = list.Append(40);
//foreach (var item in append)
//    Console.WriteLine(item);

#endregion

#region  TAKE, TAKEWHILE, TAKELAST, SKIP, SKIPWHILE, SKIPLAST

//Console.WriteLine("--------------------------------TAKE----------------------------------");

//var result = query.Take(2).ToList();
//var result2 = query.Take(4..).ToList();

//foreach (var item in result2)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}

//Console.WriteLine("-------------------------------TAKEWHILE------------------------------");


//var result3 = query.TakeWhile(p => p.Name.StartsWith("S")).ToList();

//foreach (var item in result3)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Prise}, {item.Quantity}");
//}

//var result4 = query.TakeWhile(p => p.Color.StartsWith("Y")).ToList();

//foreach (var item in result4)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color},{item.Prise}, {item.Quantity}");
//};

//Console.WriteLine("---------------------------------TAKELAST------------------------------------------");


//var result5 = query.TakeLast(3).ToList();

//var result6 = query.Take(3..).ToList();

//foreach (var item in result4)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color},{item.Prise}, {item.Quantity}");
//};

//Console.WriteLine();
//Console.WriteLine("-----------------------------------SKIP-----------------------------------");
//Console.WriteLine();


//var result = query.Skip(3).ToList();

//foreach (var item in result)
//{
//    Console.WriteLine($"ID: {item.Id}, NAME: {item.Name}, COLOR: {item.Color}, PRISE: {item.Prise}, QUANTITY: {item.Quantity}, TOTALSTOCK: {item.TotalStock}");
//}

//Console.WriteLine();
//Console.WriteLine("-----------------------------------SKIPWHILE-----------------------------------");
//Console.WriteLine();

//var result1 = query.SkipWhile(p => p.Color.StartsWith("Y")).ToList();

//foreach (var item in result1)
//{
//    Console.WriteLine($"ID: {item.Id}, NAME: {item.Name}, COLOR: {item.Color}, PRISE: {item.Prise}, QUANTITY: {item.Quantity}, TOTALSTOCK: {item.TotalStock}");
//}

//Console.WriteLine();
//Console.WriteLine("-----------------------------------SKIPLAST-----------------------------------");
//Console.WriteLine();

//var result2 = query.SkipLast(8).ToList();

//foreach (var item in result2)
//{
//    Console.WriteLine($"ID: {item.Id}, NAME: {item.Name}, COLOR: {item.Color}, PRISE: {item.Prise}, QUANTITY: {item.Quantity}, TOTALSTOCK: {item.TotalStock}");
//}

#endregion  



static List<Product> GetProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 1, Name = "Sharf", Color = "Yashil" , Prise = 15, Quantity = 11, TotalStock = 42},
        new Product { Id = 2, Name = "Krassovka", Color = "Qizil", Prise = 12, Quantity = 13, TotalStock = 9},
        new Product { Id = 3, Name = "Kostyum", Color = "Qora", Prise = 14, Quantity = 34, TotalStock = 2},
        new Product { Id = 4, Name = "Xalat", Color = "Pushti", Prise = 17, Quantity = 54, TotalStock = 1},
        new Product { Id = 5, Name = "Ko'ylak", Color = "Sariq", Prise = 67, Quantity = 345, TotalStock = 12},
        new Product { Id = 12, Name = "Bo'yinbog'", Color = "Binafsharang", Prise = 45, Quantity = 321, TotalStock = 95},
        new Product { Id = 13, Name = "Kepka", Color = "Kulrang", Prise = 34, Quantity =231, TotalStock = 57},
        new Product { Id = 14, Name = "Futbolka", Color = "Ko'k", Prise = 56, Quantity = 32, TotalStock = 85},
        new Product { Id = 15, Name = "Mayka", Color = "Oq", Prise = 76, Quantity = 56, TotalStock = 64},
        new Product { Id = 16, Name = "Paypoq", Color = "Qora", Prise = 45, Quantity = 43, TotalStock = 46},
        new Product { Id = 17, Name = "Sho'rtik", Color = "Kulrang", Prise = 43, Quantity = 25, TotalStock = 75},
        new Product { Id = 18, Name = "Shim", Color = "Qo'ng'ir", Prise = 63, Quantity = 58, TotalStock = 58},
        new Product { Id = 19, Name = "Tufli", Color = "Jigarrang", Prise = 54, Quantity = 23, TotalStock = 39},

    };
    return products;
}

static List<Product> GetAnotherProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 1, Name = "Futbolka", Color = "Ko'k", Prise = 32, Quantity = 36, TotalStock = 76},
        new Product { Id = 2, Name = "Mayka", Color = "Oq", Prise = 69, Quantity = 89, TotalStock = 12},
        new Product { Id = 3, Name = "Paypoq", Color = "Qora", Prise = 54, Quantity = 78, TotalStock = 76},
        new Product { Id = 4, Name = "Sho'rtik", Color = "Kulrang", Prise = 67, Quantity = 76, TotalStock = 73},
        new Product { Id = 5, Name = "Shim", Color = "Qo'ng'ir", Prise = 78, Quantity = 28, TotalStock = 764},
        new Product { Id = 6, Name = "Tufli", Color = "Qora", Prise = 98, Quantity = 27, TotalStock = 766},
        new Product { Id = 7, Name = "Sharf", Color = "Yashil", Prise = 76, Quantity = 37, TotalStock = 762},
        new Product { Id = 8, Name = "Krosofka", Color = "Qizil", Prise = 45, Quantity = 72, TotalStock = 7671},
        new Product { Id = 9, Name = "Kostyum", Color = "Qora", Prise = 25, Quantity = 94, TotalStock = 76239},
        new Product { Id = 10, Name = "Xalart", Color = "Pushti", Prise = 43, Quantity = 51, TotalStock = 7671},
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq", Prise = 21, Quantity = 42, TotalStock = 760},
        new Product { Id = 12, Name = "Boyinbog'", Color = "jigarrang", Prise = 23, Quantity = 36, TotalStock = 7600}
    };
    return products;
}