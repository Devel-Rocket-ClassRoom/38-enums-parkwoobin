using System;
using System.Data;

// README.md를 읽고 아래에 코드를 작성하세요.

Animal a = Animal.Dog;
switch (a)
{
    case Animal.Chicken:
        Console.WriteLine("닭");
        break;
    case Animal.Dog:
        Console.WriteLine("개");
        break;
    case Animal.Pig:
        Console.WriteLine("돼지");
        break;
}

CharacterState c = CharacterState.Idle;

c = CharacterState.Attacking;
Update(c);

void Update(CharacterState state)
{
    switch (state)
    {
        case CharacterState.Idle:
            Console.WriteLine("대기 애니메이션 재생");
            break;
        case CharacterState.Walking:
            Console.WriteLine("걷기 애니메이션 재생");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("공격 애니메이션 재생");
            break;
    }
}

void PrintItemInfo(string ItemName, ItemRarity r)
{
    Console.WriteLine($"아이템: {ItemName}");
    Console.WriteLine($"등급: {r}");
}

PrintItemInfo("전설의 검", ItemRarity.Legendary);

Move(Direction.Up);
Move(Direction.Right);

void Move(Direction d)
{
    switch (d)
    {
        case Direction.Up:
            Console.WriteLine("위로 이동 (y + 1)");
            break;
        case Direction.Down:
            Console.WriteLine("아래로 이동 (y - 1)");
            break;
        case Direction.Left:
            Console.WriteLine("왼쪽으로 이동 (x - 1)");
            break;
        case Direction.Right:
            Console.WriteLine("오른쪽으로 이동 (x + 1)");
            break;
    }
}