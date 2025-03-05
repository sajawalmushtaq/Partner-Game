using System;
using System.Collections.Generic;

namespace FluentBlazorQuiz.Components.Services
{
    public class QuizState
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public int CurrentQuestionIndex { get; set; }
        public int CurrentTime { get; set; }
        public bool IsPaused { get; set; }
        public bool IsSubmitted { get; set; }
        public int Grade { get; set; }
        public int TotalTime { get; set; }
    }

    // You can also include your Question and QuestionType classes here
    // or keep them in your existing file.
    public class Question
    {
        public string Text { get; set; } = "";
        public QuestionType Type { get; set; }
        public List<string> Options { get; set; } = new List<string>();
        public string? SelectedAnswer { get; set; }
        public string TextAnswer { get; set; } = "";
        public List<string> CheckboxAnswers { get; set; } = new List<string>();
        public string ImageUrl { get; set; } = "";
        public int ElapsedTime { get; set; }
        public int? CorrectAnswer { get; set; }
        public string? CorrectFraction { get; set; }
    }

    public enum QuestionType
    {
        MultipleChoice,
        Text,
        Checkbox,
        Image
    }

    public class QuizStateService
    {
        // Hold the quiz state. This will persist across navigation.
        public QuizState QuizState { get; set; } = new QuizState();

        // Optional: Helper methods
        public void PauseQuiz() => QuizState.IsPaused = true;
        public void ResumeQuiz() => QuizState.IsPaused = false;
    }
}