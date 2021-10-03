using UnityEngine;

namespace Code
{
    public sealed class Death
    {
        /// <summary>
        /// класс переменных для выбора значений
        /// </summary>
        private ValueClass _valueClass;
        
        public void DeathPlayer(Player player)
        {
            player.HpPlayerHealth.PlayerHealth = _valueClass.MinimalHpCurrent;
            if (player.HpPlayerHealth.PlayerHealth <= 0)
            {
                Time.timeScale = 0.0f;
                GameObject.Destroy(Object.FindObjectOfType<InitGame>().Player.PlayerGameObject);
                Debug.Log("Your player is Dead");
            }
        }
    }
}