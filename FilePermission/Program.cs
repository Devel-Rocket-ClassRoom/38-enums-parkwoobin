using System;

// README.md를 읽고 코드를 작성하세요.

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1 << 0,   // 1
    Write = 1 << 1,  // 2
    Execute = 1 << 2 // 4
}
