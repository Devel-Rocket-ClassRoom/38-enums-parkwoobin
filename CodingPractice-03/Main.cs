using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Animal a = Animal.Horse;
Console.WriteLine((int)a); // 0
Animal b = Animal.Sheep;
Console.WriteLine((int)b); // 5
Animal c = Animal.Monkey;
Console.WriteLine((int)c); // 6


CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;
Console.WriteLine(status); // Poison, Paralyzed

CharacterStatus status2 = CharacterStatus.Poison | CharacterStatus.Confused;
if ((status2 & CharacterStatus.Poison) != 0)
{
    Console.WriteLine("캐릭터가 독에 걸렸습니다!");
}
else
{
    Console.WriteLine("독 상태가 아닙니다.");
}

if ((status2 & CharacterStatus.Paralyzed) != 0)
{
    Console.WriteLine("캐릭터가 마비 상태입니다!");
}
else
{
    Console.WriteLine("마비 상태가 아닙니다.");
}

CharacterStatus status3 = CharacterStatus.Poison;
Console.WriteLine($"초기 상태: {status3}");
status3 |= CharacterStatus.Confused;
Console.WriteLine($"혼란 추가: {status3}");
status3 &= ~CharacterStatus.Poison;
Console.WriteLine($"독 제거: {status3}");
status3 ^= CharacterStatus.Invisible;
Console.WriteLine($"투명 토글: {status3}");

BuffStatus buffStatus = BuffStatus.None;
ApplyBuff(BuffStatus.AttackUp);
ApplyBuff(BuffStatus.SpeedUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");
RemoveBuff(BuffStatus.AttackUp);
Console.WriteLine($"공격력 버프 있음? {HasBuff(BuffStatus.AttackUp)}");



void ApplyBuff(BuffStatus buff)
{
    buffStatus |= buff;
    Console.WriteLine($"버프 적용: {buff}");
    Console.WriteLine($"현재 버프: {buffStatus}");
}
void RemoveBuff(BuffStatus buff)
{
    buffStatus &= ~buff;
    Console.WriteLine($"버프 해제: {buff}");
    Console.WriteLine($"현재 버프: {buffStatus}");
}
bool HasBuff(BuffStatus buff)
{
    return (buffStatus & buff) != 0;
}
