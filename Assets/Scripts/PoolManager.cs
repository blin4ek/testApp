using System;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private GameObject[] items;
    [SerializeField] private GameObject item;
    [SerializeField] private int numberOfItem;

    private void Start()
    {
        items = new GameObject[numberOfItem];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = Instantiate(item);
            items[i].transform.SetParent(transform);
            items[i].SetActive(false);
        }
        GameOverEvent.RegHandler(Reset);
    }

    public void Reset()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].SetActive(false);
        }
    }

    public static void ReturnItem(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public static void TakeItem(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public GameObject GetFreeItem()
    {

        for (int i = 0; i < items.Length; i++)
        {
            if (!items[i].activeSelf) { return items[i]; }
        }
        return null;
    }
}
