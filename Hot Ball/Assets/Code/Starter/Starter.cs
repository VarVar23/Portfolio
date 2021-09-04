using UnityEngine;
using TMPro;

public class Starter : MonoBehaviour
{
    [SerializeField] private GameObject _textMeshPro;
    private Score _score;

    private void Start()
    {
        _score = new Score(_textMeshPro.GetComponent<TextMeshProUGUI>());
    }

    private void FixedUpdate()
    {
        _score.FixedUpdate();
    }

    private void Update() // Временный код, для проверки сохранения счета! Когда-нибудь сохранение лучшего счета будет происходить после смерти игрока
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            _score.Save();
            Debug.Log("Сохранилось");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(_score.Load());
        }
    }
}
