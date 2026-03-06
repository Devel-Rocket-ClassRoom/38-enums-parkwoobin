using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine($"Animal.Dragon: {(int)Animal.Dragon}, {Animal.Dragon}");


Console.WriteLine("Priority 열거형의 값들: ");
foreach (Priority p in Enum.GetValues(typeof(Priority)))
{
    Console.WriteLine($"{p} = {(int)p}");
}
