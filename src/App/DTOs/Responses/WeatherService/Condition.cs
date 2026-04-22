namespace App.DTOs.Responses.WeatherService;

/// <summary>
///Представляет описание погодных условий (текст, иконка, код)
///</summary>
public class Condition
{
    /// <summary>
    ///Текстовое описание погоды
    ///</summary>
    public string Text { get; set; }

    /// <summary>
    ///URL иконки погоды
    ///</summary>
    public string Icon { get; set; }

    /// <summary>
    ///Числовой код погодного условия
    ///</summary>
    public int? Code { get; set; }
}