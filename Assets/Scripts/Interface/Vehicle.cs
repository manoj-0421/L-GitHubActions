using UnityEngine;

public interface ISideMovement
{
    public void TurnLeft();
    public void TurnRight();
}

public interface IMovement
{
    public void Front();
    public void Reverse();
}
