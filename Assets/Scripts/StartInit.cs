using UnityEngine;

public class StartInit : MonoBehaviour
{
    [SerializeField] private GameObject prefabBall;
    [SerializeField] private CameraFolowBall cameraObject;
    [SerializeField] private SpeedBallData speedBall;

    private static GameObject ball;

    public void Init()
    {
        ball = Instantiate(prefabBall, Vector3.zero, Quaternion.identity);
        cameraObject.Init(ball.transform);
        Camera.main.transform.position = Vector3.zero;
        speedBall.Reset();
    }

    public static GameObject GetBall()
    {
        return ball;
    }
}
