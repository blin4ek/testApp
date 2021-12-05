using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        PoolManager.ReturnItem(gameObject);
    }
}
