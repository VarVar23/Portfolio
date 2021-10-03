using UnityEngine;

public sealed class Death
{
    /// <summary>
    /// класс переменных для выбора значений
    /// </summary>
    private ValueClass _valueClass;

    public void DeathPlayer(Player player)
    {
        Time.timeScale = 0.0f;
        GameObject.Destroy(player.PlayerGameObject);
        Debug.Log("Your player is Dead");
    }
}
