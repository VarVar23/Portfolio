using UnityEngine;

namespace Code
{
    public sealed class Death
    {
        private Player _player;
        public Death(Player player)
        {
            _player = player;
        }
        public void Update()
        {
            DeathPlayer(_player);
        }
        public void DeathPlayer(Player player)
        {
            _player._hp.CurrenHp = player._hp.CurrenHp;
            if (_player._hp.CurrenHp <= 0.0f)
            {
                Time.timeScale = 0.0f;
                Debug.Log("Your player is Dead");
            }
        }
    }
}