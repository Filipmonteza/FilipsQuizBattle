namespace FilipQuizBattle.Questions;

public interface IQuestion
{
    string QuestionText { get; }
    bool IsAsked { get; set; }

    void Display();
    bool CheckAnswer(string answer);
}