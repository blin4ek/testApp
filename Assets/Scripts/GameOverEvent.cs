using System;
using UnityEngine;

public class GameOverEvent : MonoBehaviour
{
    private static event Action GameOver;

    public static void RegHandler(Action handler)
    {
        GameOver += handler;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver.Invoke();
    }
}
