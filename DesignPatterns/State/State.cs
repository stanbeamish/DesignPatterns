namespace DesignPatterns.State
{
  public interface State
  {
    public void LeaveAlone();
    public void Calm();
    public void Anger();
    public void Play();
    public void Stroke();
    public void GiveMeal();
  }
}