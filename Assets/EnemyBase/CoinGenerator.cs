using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public int numObjects = 12;
    public GameObject prefab;

    void Start()
    {
        Vector3 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            int a = 360 / numObjects * i;
            Vector3 pos = RandomCircle(center, 1.0f, a);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
    Vector3 RandomCircle(Vector3 center, float radius, int a)
    {
        Debug.Log(a);
        float ang = a;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad) * 10;
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad) * 10;
        pos.y = center.y;
        return pos;
    }
}
