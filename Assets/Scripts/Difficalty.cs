using UnityEngine;

public class Difficalty : MonoBehaviour
{
    [SerializeField] private SpeedBallData speedBall;

    public void Change(float speed)
    {
        speedBall.HorizontalSpeedBall = speed;
    }
}
