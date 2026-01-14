namespace FilipQuizBattle.Questions;

public interface IQuestion
{
    string QuestionText { get; }
    bool IsAsked { get; set; }

    void Displat();
    bool CheckAnswer(string answer);
}