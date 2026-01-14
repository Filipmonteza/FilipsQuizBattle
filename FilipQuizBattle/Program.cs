using FilipQuizBattle.Logging;
using FilipQuizBattle.Repository;
using FilipQuizBattle.Services;

class Program
{
    static void Main()
    {
        IQuestionRepository repo = new InMemoryQuestionRepository();
        ILogger logger = new ConsoleLogger();
        
        var service = new QuestionService(repo, logger);

        service.AskNextQuestion();
    }
}