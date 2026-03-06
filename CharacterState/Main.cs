using System;

// README.md를 읽고 아래에 코드를 작성하세요.

CharacterState state = CharacterState.Idle;

Console.WriteLine($"=== 캐릭터 상태 관리 ===");
Console.WriteLine($"현재 상태: {state}");

bool flag = true;
while (flag)
{
    Console.WriteLine();
    Console.WriteLine($"1. 상태 변경");
    Console.WriteLine($"2. 상태 목록 보기");
    Console.WriteLine($"3. 현재 행동 보기");
    Console.WriteLine($"4. 종료");
    Console.Write($"선택: ");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            Console.Write($"변경할 상태 번호 입력 (0-5): ");
            int newState = int.Parse(Console.ReadLine());
            state = (CharacterState)newState;
            Console.WriteLine($"상태가 {state}(으)로 변경되었습니다.\n");
            Console.WriteLine($"현재 상태: {state}");
            break;
        case 2:
            Console.WriteLine($"=== 상태 목록 ===");
            foreach (var s in Enum.GetValues(typeof(CharacterState)))
            {
                Console.WriteLine($"{s} = {(int)s}");
            }
            Console.WriteLine($"\n현재 상태: {state}");
            break;
        case 3:
            if ((int)state == 0)    // Idle 상태에서는 가만히 있는 행동을 수행
                Console.WriteLine($"[행동] 가만히 있는 상태입니다.");
            else if ((int)state == 1)   // Walking 상태에서는 걷는 행동을 수행
                Console.WriteLine($"[행동] 걷는 상태입니다.");
            else if ((int)state == 2)   // Running 상태에서는 달리는 행동을 수행
                Console.WriteLine($"[행동] 달리는 상태입니다.");
            else if ((int)state == 3)   // Jumping 상태에서는 점프 행동을 수행
                Console.WriteLine($"[행동] 점프 상태입니다.");
            else if ((int)state == 4)   // Attacking 상태에서는 공격 행동을 수행
                Console.WriteLine($"[행동] 공격 상태입니다.");
            else if ((int)state == 5)   // Dead 상태에서는 행동할 수 없음
                Console.WriteLine($"[행동] 사망 상태입니다. 행동할 수 없습니다.");
            Console.WriteLine($"\n현재 상태: {state}");
            break;
        case 4:
            Console.WriteLine($"프로그램을 종료합니다.");
            flag = false;
            break;
        default:
            Console.WriteLine($"잘못된 선택입니다.");
            break;
    }

}