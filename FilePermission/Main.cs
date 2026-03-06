using System;

// README.md를 읽고 코드를 작성하세요.

FilePermission p = FilePermission.None;

Console.WriteLine("=== 파일 권한 관리 ===\n");

Console.WriteLine($"현재 권한: {p}\n");
Console.WriteLine($"[권한 추가]");
Console.WriteLine($"+ Read 추가: {p |= FilePermission.Read}");
Console.WriteLine($"+ Write 추가: {p |= FilePermission.Write}");
Console.WriteLine($"+ Execute 추가: {p |= FilePermission.Execute}");
Console.WriteLine();

Console.WriteLine($"[권한 확인]");
Console.WriteLine($"Read 권한: {p.HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {p.HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {p.HasFlag(FilePermission.Execute)}");
Console.WriteLine();

Console.WriteLine($"[권한 제거]");
Console.WriteLine($"- Write 제거: {p &= ~FilePermission.Write}");
Console.WriteLine();

Console.WriteLine($"[제거 후 확인]");
Console.WriteLine($"Read 권한: {p.HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {p.HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {p.HasFlag(FilePermission.Execute)}");