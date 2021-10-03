using UnityEngine;

public sealed class Death
    {
        /// <summary>
        /// класс переменных для выбора значений
        /// </summary>
        private ValueClass _valueClass;
        
        public void DeathPlayer(Player player)
        {
            if (_valueClass.MinimalHpCurrent == player.HpPlayerHealth.PlayerHealth)
            {
                Time.timeScale = 0.0f;
                GameObject.Destroy(Object.FindObjectOfType<InitGame>().Player.PlayerGameObject);
                Debug.Log("Your player is Dead");
            }
        }
    }
