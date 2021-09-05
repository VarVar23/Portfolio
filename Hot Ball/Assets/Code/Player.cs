﻿using UnityEngine;

namespace Code
{
    public class Player
    {
        internal Health _hp;
        private float _speed;
        private float _force;
        private Rigidbody _rigidbody;
        public Player(float speed, float force, Rigidbody rigidbody)
        {
            _speed = speed;
            _force = force;
            _rigidbody = rigidbody;
            _hp = new Health(InputManager.HP,InputManager.CURRENTHP);
        }        
        private PlayerMove _playerMove = new PlayerMove();
        private PlayerJump _playerJump = new PlayerJump();
       public void Update(Player player)
        {
            _playerJump.JumpPlayer(player._force,player._rigidbody);
        }

       public void FixedUpdate(Player player)
       {
           _playerMove.Move(player._speed, player._rigidbody);
       }
    }
}