using FilipQuizBattle.Questions;

namespace FilipQuizBattle.Repository;

public class InMemoryQuestionRepository : IQuestionRepository
{
    public List<IQuestion> GetAllQuestions()
    {
        // Sample questions
        return new List<IQuestion>
        {
            new TrueFalseQuestion("C# is a statically typed language.", true),
            new TrueFalseQuestion("The Earth is flat.", false),
            new TrueFalseQuestion("The capital of France is Berlin.", false),
            new TrueFalseQuestion("2 + 2 equals 4.", true),
        };
    }
}