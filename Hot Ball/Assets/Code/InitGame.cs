using System;
using UnityEngine;

namespace Code
{
    public class InitGame : MonoBehaviour
    {
        [SerializeField]private float _speed;
        [SerializeField]private float _force;
        [SerializeField]private Rigidbody _rigidbody;
        protected Player _player;
        protected Death _death;

        private void Awake()
        {
            _player = new Player(_speed,_force,_rigidbody);
            _death = new Death(_player);
        }

        private void Update()
        {
            _player.Update(_player);
            _death.Update();
        }

        private void FixedUpdate()
        {
            _player.FixedUpdate(_player);
        }
    }
}