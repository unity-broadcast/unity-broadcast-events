using UnityEngine;

[CreateAssetMenu(fileName = "New Void Game Event", menuName = "Game Events/Value Types/Void Game Event")]
public class VoidGameEvent : BaseGameEvent<Void>
{
    public void Raise() => Raise(new Void());
}