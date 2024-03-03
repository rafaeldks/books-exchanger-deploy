namespace BooksExchanger.Repositories.Exeptions;

public class GenreAlreadyExistsException : Exception
{
    public GenreAlreadyExistsException()
    {
    }

    public GenreAlreadyExistsException(string message) : base(message)
    {
    }

    public GenreAlreadyExistsException(string message, Exception inner) : base(message, inner)
    {
    }
}