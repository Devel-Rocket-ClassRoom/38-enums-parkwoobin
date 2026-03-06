using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Priority p = Priority.High;

if (p == Priority.High)
{
    Console.WriteLine("높은 우선순위");
}


Animal a = Animal.Tiger;
Console.WriteLine(a);
if (a == Animal.Tiger)
{
    Console.WriteLine("호랑이");
}

int c = (int)Color.Green;
int c2 = (int)Color.Red;
int c3 = (int)Color.Blue;

Console.WriteLine($"Red: {c}, Green: {c2}, Blue: {c3}");

Console.WriteLine(sizeof(SmallEnum));

Type type = typeof(ConsoleColor);

string[] enums = Enum.GetNames(type);
Console.WriteLine("ConsoleColor 열거형의 색상들:");
foreach (string name in enums)
{
    Console.WriteLine(name);
}

string colorName = "Red";
ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
Console.ForegroundColor = color;
Console.WriteLine("빨간색 텍스트");
Console.ResetColor();
Console.WriteLine("기본 색상 텍스트");

string input = "Up";
if (Enum.TryParse(input, out Direction direction))
{
    Console.WriteLine($"변환 성공: {direction}");
}
else
{
    Console.WriteLine("변환 실패");
}
string invalidInput = "Forward";
if (Enum.TryParse(invalidInput, out Direction invalidDirection))
{
    Console.WriteLine($"변환 성공: {invalidDirection}");
}
else
{
    Console.WriteLine($"\'{invalidInput}\'은(는) 유효하지 않은 값");
}

bool isValid1 = Enum.IsDefined(typeof(Direction), 1); // true
bool isValid2 = Enum.IsDefined(typeof(Direction), 100); // true
bool isValid3 = Enum.IsDefined(typeof(Direction), "Tiger"); // true
Console.WriteLine($"1은 유효한 Animal 값인가? {isValid1}");
Console.WriteLine($"100은 유효한 Animal 값인가? {isValid2}");
Console.WriteLine($"\'Tiger\'은 유효한 Animal 값인가? {isValid3}");

Direction dir1 = Direction.Right;
int num = (int)dir1;
Console.WriteLine($"{dir1} = {num}");

int value = 2;
Direction dir2 = (Direction)value;
Console.WriteLine($"{value} = {dir2}");

Animal b = (Animal)100;
Console.WriteLine(b);
