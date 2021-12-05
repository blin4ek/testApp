using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private SpeedBallData speedBall;

    private float timeAccelerate = 15f;

    public void MoveUp()
    {
        speedBall.VerticalSpeedBall = -speedBall.VerticalSpeedBall;
    }

    private void Update()
    {
        if (timeAccelerate > 0)
        {
            timeAccelerate -= Time.deltaTime;
        }
        else 
        {
            speedBall.VerticalSpeedBall *= 1.5f;
            timeAccelerate = 15f; 
        };
    }
}
