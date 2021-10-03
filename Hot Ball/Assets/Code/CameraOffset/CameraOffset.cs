using UnityEngine;

public class CameraOffset
    {
        private Vector3 _positionOffsetCamera;
        private Transform _transformOffsetCamera;
        private Player _playerPosition;

        public CameraOffset(Player player)
        {
            _playerPosition = Object.FindObjectOfType<InitGame>().Player;
            _positionOffsetCamera = new Vector3(0, 5, -5);
            _transformOffsetCamera = new RectTransform();
            _transformOffsetCamera = player.PlayerGameObject.transform;
        }

        public void FollowPlayer()
        {
            _transformOffsetCamera = _playerPosition.PlayerGameObject.transform; // <- не передаётся позиция
        }
    }
