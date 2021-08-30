using UnityEngine;

namespace Code
{
    public class InitGame : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private float _force;
        [SerializeField]private Rigidbody _rigidbody;
        private Player _player;

        private void Awake()
        {
            _player = new Player();
            
        }

        private void Update()
        {
            _player.Update(_speed,_rigidbody,_force);
        }
    }
}