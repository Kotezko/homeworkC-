// Удалить вторую цифру трёхзначного числа

Console.WriteLine("введите трехзначное число");
string num = Console.ReadLine() ?? "0";

Console.Write("число после удаления второй цифры: ");
Console.Write(num[0]);
Console.Write(num[2]);
