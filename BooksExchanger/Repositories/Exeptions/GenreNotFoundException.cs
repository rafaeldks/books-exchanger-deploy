namespace BooksExchanger.Repositories.Exeptions;

/// <summary>
/// Жанр не найден.
/// </summary>
public class GenreNotFoundException : Exception
{
    /// <summary>
    /// Конструктор.
    /// </summary>
    public GenreNotFoundException()
    {
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public GenreNotFoundException(string message) : base(message)
    {
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public GenreNotFoundException(string message, Exception inner) : base(message, inner)
    {
    }
}