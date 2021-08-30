using UnityEngine;
using TMPro;

public class Starter : MonoBehaviour
{
    [SerializeField] private GameObject _textMeshPro;
    private Score score;

    private void Start()
    {
        score = new Score(_textMeshPro.GetComponent<TextMeshProUGUI>());
    }

    private void FixedUpdate()
    {
        score.FixedUpdate();
    }
}
