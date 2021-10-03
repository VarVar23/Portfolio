using UnityEngine;

 public class Player
    {
        private float _playerSpeed;
        private float _jumpForce;
        private Health _hpPlayerHealth;
        private GameObject _playerGameObject;
        private Rigidbody _playerRigidBody;
        public Health HpPlayerHealth => _hpPlayerHealth;
        public GameObject PlayerGameObject => _playerGameObject;
        
        private ValueClass _valueClass = new ValueClass();
        
        public Player(float playerSpeed, float jumpForce, Rigidbody playerRigidBody,GameObject gameObject)
        {

            _playerGameObject = gameObject;
            _playerGameObject.tag = "Player";
            _playerGameObject.name = "Player";
            _hpPlayerHealth = new Health(_valueClass.MaximalHpValue, _valueClass.MinimalHpCurrent, _valueClass.CurrenHpInCreatePLayer);
            _playerSpeed = playerSpeed;
            _jumpForce = jumpForce;
            _playerRigidBody = playerRigidBody;
        }
        private PlayerMove _playerMove = new PlayerMove();
        private PlayerJump _playerJump = new PlayerJump();
       public void Update(Player player)
        {
            _playerJump.JumpPlayer(player._jumpForce,player._playerRigidBody);
        }

       public void FixedUpdate(Player player)
       {
           _playerMove.Move(player._playerSpeed, player._playerRigidBody);
       }
    }
