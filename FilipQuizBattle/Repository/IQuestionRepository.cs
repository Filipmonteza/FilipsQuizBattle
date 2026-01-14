
using FilipQuizBattle.Questions;

namespace FilipQuizBattle.Repository;

public interface IQuestionRepository
{
    List<IQuestion> GetAllQuestions();
}