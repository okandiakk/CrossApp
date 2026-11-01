namespace Core.Reports;

public sealed record ReaderLoanCount(string ReaderId, int Loans, int Open); //кількість видач читача

public sealed record OverdueLine(string LoanId, string CopyId, string ReaderId, DateOnly DueDate, int DaysOverdue); //прострочена видача

public sealed record GroupSummary(string Key, int Count); //підсумок групи

public sealed record CopyStats(int Titles, int Copies, int IssuedCopies, double AverageCopiesPerTitle, int MaxCopiesPerTitle); //загальна статистика примірників

public sealed record BookAvailabilityLine(string Isbn, string Title, int Copies, int Free); //Звіт про наявність книг у бібліотеці.

public sealed record TitleLoanCount(string Isbn, string Title, int Loans); //Звіт про кількість видач кожної назви книги