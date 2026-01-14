using FilipQuizBattle.Questions;
using System;
namespace FilipQuizBattle.Questions;

public class TrueFalseQuestion : IQuestion
{
    public string QuestionText { get; }
    public bool CorrectAnswer { get; }
    public bool IsAsked { get; set; }

    public TrueFalseQuestion(string text, bool correct)
    {
        QuestionText = text;
        CorrectAnswer = correct;
    }
    
    // Visar frågan med instruktioner för svar
    public void Display()
    {
        Console.WriteLine($"{QuestionText}  (1 = True/ 2 = False)");
    }

    
    // Ändrar du om vill du ändra svaret från "True" och "False" till "1" och "2"
    public bool CheckAnswer(string answer)
    {
        return answer switch
        {
            "1" => CorrectAnswer,
            "2" => !CorrectAnswer,
            _ => false
        };
    }
}