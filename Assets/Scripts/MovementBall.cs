using UnityEngine;

public class MovementBall : MonoBehaviour
{
    [SerializeField] private SpeedBallData speedBall;

    private Transform transformBall;
    private Vector2 newPos;

    private void Start()
    {
        transformBall = GetComponent<Transform>();
    }

    private void Update()
    {
        newPos.x = transformBall.position.x + speedBall.HorizontalSpeedBall * Time.deltaTime;
        newPos.y = transformBall.position.y + speedBall.VerticalSpeedBall * Time.deltaTime;
        transformBall.position = newPos;
    }
}
