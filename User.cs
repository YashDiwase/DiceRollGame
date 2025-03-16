// See https://aka.ms/new-console-template for more information



public class User 
{
    private  int attempt_=0;
    private static int maxAttempt_=3;
    private  bool lose_ = true;
    public int Attempt { get => attempt_;  set => attempt_ = value; }
    public static int MaxAttempt { get => maxAttempt_;  }
    public bool Lose { get => lose_; set => lose_ = value; }
}

