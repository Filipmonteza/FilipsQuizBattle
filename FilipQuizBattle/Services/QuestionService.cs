using FilipQuizBattle.Logging;
using FilipQuizBattle.Questions;
using FilipQuizBattle.Repository;

namespace FilipQuizBattle.Services;

public class QuestionService
{
    private readonly List<IQuestion> _questions;
    private readonly ILogger _logger;

    public QuestionService(IQuestionRepository repo, ILogger logger)
    {
        _questions = repo.GetAllQuestions();
        _logger = logger;
    }

    public void AskNextQuestion()
    {
        var question = _questions.FirstOrDefault(q => !q.IsAsked);
        if (question == null) return;
        
        question.Display();
        var answer = Console.ReadLine();

        _logger.Log($"Question: {question.QuestionText}");
        _logger.Log($"Answer: {answer}");
        
        question.IsAsked = true;
        
        Console.WriteLine(question.CheckAnswer(answer) ? "Correct" : "Incorrect");
    }
}