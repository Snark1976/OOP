namespace MvcStudentApp.Controller;

/// <summary>
/// Список поддерживаемых команд
/// </summary>
public enum Command
{
    NONE,
    READ,
    CREATE,
    UPDATE,
    LIST,
    DELETE,
    EXIT
}