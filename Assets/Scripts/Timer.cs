using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float time;
    private Coroutine coroutine;
    private float stepTime = 0.1f;

    private void Start()
    {
        GameOverEvent.RegHandler(StopTimer);
    }

    private void StopTimer()
    {
        StopCoroutine(coroutine);
    }

    public void StartTimer()
    {
        time = 0;
        coroutine = StartCoroutine(IncreaseTime());
    }

    IEnumerator IncreaseTime()
    {
        WaitForSeconds delay = new WaitForSeconds(stepTime);
        while (true)
        {
            yield return delay;
            time += stepTime;
        }
    }

    public float GetTime()
    {
        return time;
    }
}
