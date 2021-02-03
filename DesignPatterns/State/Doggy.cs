namespace DesignPatterns.State
{
  public class Doggy
  {
    private State _currentMood;

    public Doggy()
    {
      SetCurrentMood(new Neutral(this));
    }
    
    public void SetCurrentMood(State currentMood)
    {
      _currentMood = currentMood;
    }

    public void Calm()
    {
      _currentMood.Calm();
    }

    public void Anger()
    {
      _currentMood.Anger();
    }

    public void LeaveAlone()
    {
      _currentMood.LeaveAlone();
    }

    public void Play()
    {
      _currentMood.Play();
    }

    public void Stroke()
    {
      _currentMood.Play();
    }
    
    public void GiveMeal()
    {
      _currentMood.GiveMeal();
    }
  }
}