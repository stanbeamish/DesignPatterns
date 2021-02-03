using System;

namespace DesignPatterns.State
{
  public class Angry : State
  {
    private readonly Doggy _dog;
    
    public Angry(Doggy dog)
    {
      this._dog = dog;
    }
    
    public void Anger()
    {
      Console.WriteLine("[Angry] Ich beisse gleich ...");
    }

    public void Play()
    {
      Console.WriteLine("[Angry] Komme mir jetzt nicht mit spielen ...");
    }

    public void LeaveAlone()
    {
      Console.WriteLine("[Angry] Besser so ...");
      _dog.SetCurrentMood(new Neutral(_dog));
    }

    public void Calm()
    {
      Console.WriteLine("[Angry] Ich beruhige mihc schon ein wenig...");
      _dog.SetCurrentMood(new Happy(_dog));
    }
    
    public void Stroke()
    {
      Console.WriteLine("[Angry] Streicheln beruhigt ...");
      _dog.SetCurrentMood(new Happy(_dog));
    }

    public void GiveMeal()
    {
      Console.WriteLine("[Angry] Viel zu aufgeregt um zu essen, obwohl ...");
      _dog.SetCurrentMood(new Neutral(_dog));
    }
  }
}