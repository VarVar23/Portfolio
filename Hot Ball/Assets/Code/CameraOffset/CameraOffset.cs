using UnityEngine;

public class CameraOffset
    {
        private Vector3 _positionOffsetCamera;
        private Vector3 _OffsetCamera;
        private GameObject _OffsetCameraGameObject;
        private Player _playerPosition;

        public CameraOffset(Player player, Vector3 offset, GameObject offsetCameraGameObject)
        {
            _playerPosition = Object.FindObjectOfType<InitGame>().Player;
            _positionOffsetCamera = offset;
            _OffsetCameraGameObject = offsetCameraGameObject;
            _OffsetCamera = _positionOffsetCamera - _playerPosition.PlayerGameObject.transform.position;
        }

        public void FollowPlayer()
        {
            _OffsetCameraGameObject.transform.position = _playerPosition.PlayerGameObject.transform.position + _OffsetCamera;
        }
    }
