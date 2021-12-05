using UnityEngine;

public class PostionObject : MonoBehaviour
{
    private Transform cameraTransform;
    private Transform objectTransform;
    private Vector3 offset;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        objectTransform = GetComponent<Transform>();
        offset = objectTransform.position - cameraTransform.position;
    }

    void Update()
    {
        objectTransform.position = cameraTransform.position + offset;
    }
}
