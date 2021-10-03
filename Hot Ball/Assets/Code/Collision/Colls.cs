using  UnityEngine;

public class Colls
{
    private Player _player;
    private Death _deathPlayer;
    private GameObject objCollision;

    public Colls(GameObject gameObject)
    {
        objCollision = gameObject;
        _player = Object.FindObjectOfType<InitGame>().Player;
        _deathPlayer = Object.FindObjectOfType<InitGame>().Death;
    }

    public void CollisionPlayer(GameObject gameObject)
    {
        _deathPlayer.DeathPlayer(_player);
    }
}
