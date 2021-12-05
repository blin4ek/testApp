using UnityEngine;

public class CounterAttempts : MonoBehaviour
{
    private int attempts;

    private void Start()
    {
        attempts = 0;
    }

    public void Increase()
    {
        attempts++;
    }

    public int GetAttempts()
    {
        return attempts;
    }
}
