using System;

namespace DesignPatterns.State
{
  public class Happy : State
  {
    private readonly Doggy _dog;

    public Happy(Doggy dog)
    {
      _dog = dog;
    }
    
    public void LeaveAlone()
    {
      Console.WriteLine("[Happy] Stop, wo willst du hin?");
      _dog.SetCurrentMood(new Angry(_dog));
    }

    public void Calm()
    {
      Console.WriteLine("[Happy] Nö no, lass mal spielen ...");
    }

    public void Anger()
    {
      Console.WriteLine("[Happy] Stop, sonst ...");
      _dog.SetCurrentMood(new Angry(_dog));
    }

    public void Play()
    {
      Console.WriteLine("[Happy] Ich spiele gerne...");
    }

    public void Stroke()
    {
      Console.WriteLine("[Happy] #nice,  ...");
    }

    public void GiveMeal()
    {
      Console.WriteLine("[Happy] Lecker, Ja, super ...");
      _dog.SetCurrentMood(new Neutral(_dog));
    }
  }
}