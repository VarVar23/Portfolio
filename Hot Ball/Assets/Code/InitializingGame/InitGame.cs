using System;
using UnityEngine;

namespace Code
{
    public class InitGame : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private float _force;
        [SerializeField]private Rigidbody _rigidbody;
        [SerializeField]private GameObject _playerGameObject;
        public Player Player { get; private set; }
        private Death _death;

        private void Awake()
        {
            Player = new Player(_speed,_force,_rigidbody,_playerGameObject);
            _death = new Death();
        }

        private void Update()
        {
            Player.Update(Player);
        }

        private void FixedUpdate()
        {
            Player.FixedUpdate(Player);
        }
    }
}