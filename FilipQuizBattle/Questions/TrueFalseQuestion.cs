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
    public void Displat()
    {
        Console.WriteLine(QuestionText + " (True/False)");
    }

    public bool CheckAnswer(string answer)
    {
        return bool.TryParse(answer, out bool result) && result == CorrectAnswer;
    }
}