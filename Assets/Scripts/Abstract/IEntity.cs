namespace Abstract
{
    public interface IEntity 
    {
        int Health { get; protected set; }
        int Damage { get; protected set; }
        int Speed { get; protected set; }
    }
}