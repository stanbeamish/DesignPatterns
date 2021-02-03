using System;

namespace DesignPatterns.State
{
  public class Neutral : State
  {
    private readonly Doggy _dog;

    public Neutral(Doggy dog)
    {
      _dog = dog;
    }
    public void LeaveAlone()
    {
      Console.WriteLine("[Neutral] Ich lasse in Ruhe ...");
      _dog.SetCurrentMood(new Angry(_dog));
    }

    public void Calm()
    {
      Console.WriteLine("[Neutral] Wuff ...");
    }

    public void Anger()
    {
      Console.WriteLine("[Neutral] Ich ärgere ...");
      _dog.SetCurrentMood(new Angry(_dog));
    }

    public void Play()
    {
      Console.WriteLine("[Neutral] Ich bin müde ...");
      _dog.SetCurrentMood(new Happy(_dog));
    }

    public void Stroke()
    {
      Console.WriteLine("[Neutral] Ok, ...");
      _dog.SetCurrentMood(new Happy(_dog));
    }

    public void GiveMeal()
    {
      Console.WriteLine("[Neutral] Hunger habe ich nicht...");
    }
  }
}