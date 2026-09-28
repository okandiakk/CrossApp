\# CrossApp

Наскрізний проєкт з крос-платформного програмування.

Предметна область: Бібліотека. Сутності: Book, BookCopy, Reader, Loan.

Призначення: облік видач примірників книг читачам і повернень.

Структура solution
```
CrossApp/
├── CrossApp.sln
├── README.md
├── .gitignore
└── src/
    ├── Core/
    │   ├── Core.csproj
    │   └── EnvironmentInfo.cs
    └── Cli/
        ├── Cli.csproj
        └── Program.cs
```

## Інваріанти доменної моделі (lab04)

**BookCopy**
- Id примірника не порожній (ArgumentException) — Create
- ISBN не порожній (ArgumentException) — Create
- Не можна видати вже виданий примірник (InvalidOperationException) — Issue
- Не можна повернути невиданий примірник (InvalidOperationException) — Return

**Loan**
- Id видачі та читача не порожні (ArgumentException) — Open, FromDto
- Дата повернення не раніше дати видачі (ArgumentOutOfRangeException) — Close, FromDto
- Не можна закрити вже закриту видачу (InvalidOperationException) — Close
- FromDto проходить ті самі перевірки, що й Open

\## Запуск

dotnet build

dotnet run --project src/Cli

Publish:

dotnet publish src/Cli -c Release -r win-x64 --self-contained true

dotnet publish src/Cli -c Release -r win-x64 --self-contained false


| RID     | Режим               | Розмір publish  | Потрібен runtime      |
|---------|---------------------|-----------------|-----------------------|
| win-x64 | self-contained      | 70,51 МБ        |         ні            |
| win-x64 | framework-dependent | 0.3 МБ          |    так (.NET 8)       |

\## Середовище

.NET SDK 9.0.317, runtime .NET 8.0.11, Windows x64
