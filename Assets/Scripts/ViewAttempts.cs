using UnityEngine;
using UnityEngine.UI;

public class ViewAttempts : MonoBehaviour
{
    [SerializeField] private Text[] text;
    [SerializeField] private CounterAttempts counter;

    private void Start()
    {
        GameOverEvent.RegHandler(DisplayAttempts);
    }

    private void DisplayAttempts()
    {
        for (int i = 0; i < text.Length; i++)
        {
            text[i].text = "Attempts: " + counter.GetAttempts();
        }
    }
}
