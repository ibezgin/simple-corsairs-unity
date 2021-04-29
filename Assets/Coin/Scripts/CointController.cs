using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CointController : MonoBehaviour
{
    public Transform coin;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 70 * Time.deltaTime);
        Instantiate(coin, transform.position, Quaternion.identity);

    }
}
