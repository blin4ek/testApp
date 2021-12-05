using UnityEngine;

public class CameraFolowBall : MonoBehaviour
{
    private Transform ball;
    private Transform transformCamera;

    public void Init(Transform ball)
    {
        this.ball = ball;
    }

    void Update()
    {
        if (ball != null)
        transformCamera.position = new Vector3(ball.position.x, transformCamera.position.y, transformCamera.position.z);
    }

    private void Awake()
    {
        transformCamera = GetComponent<Transform>();
    }
}
