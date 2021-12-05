using UnityEngine;

[CreateAssetMenu(fileName = "SpeedBall", menuName = "SpeedData")]
public class SpeedBallData : ScriptableObject
{
    [SerializeField] private float horizontalSpeedBall;
    [SerializeField] private float verticalSpeedBall;


    public float VerticalSpeedBall { get { return verticalSpeedBall; } set { verticalSpeedBall = value; } }
    public float HorizontalSpeedBall { get { return horizontalSpeedBall; } set { horizontalSpeedBall = value; } }

    public void Reset()
    {
        verticalSpeedBall = -3;
    }
}