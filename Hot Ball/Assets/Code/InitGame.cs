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

        private void Awake()
        {
            _player = new Player(_speed,_force,_rigidbody);
        }

        private void Update()
        {
            _player.Update(_player);
        }

        private void FixedUpdate()
        {
            _player.FixedUpdate(_player);
            
        }
    }
}