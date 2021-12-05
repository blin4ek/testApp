using UnityEngine;
using UnityEngine.UI;

public class ViewTime : MonoBehaviour
{
    [SerializeField] private Text[] text;
    [SerializeField] private Timer timer;

    void Update()
    {
        for (int i = 0; i < text.Length; i++)
        {
            text[i].text = "Time: " + timer.GetTime().ToString("00.0");
        }
    }
}
