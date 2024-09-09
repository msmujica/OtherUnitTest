namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    ///
    public static bool ValidEmptySpace(string date)
    {
    if (date == "")
        {
            return true;
        }

        return false;
    }

    public static bool ValidFormat(string date)
    {
        int dateNumber = int.Parse(date.Substring(0, 2));
        if (dateNumber <= 1 || dateNumber >= 31)
        {
            return true;
        }

        return false;
    }
    public static string ChangeFormat(string date)
    { 
        if (ValidEmptySpace(date))
        {
            return null;
        }

        if (ValidFormat(date))
        {
            return "x";
        }
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}
