using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJumpScript : MonoBehaviour
{
    public Transform loop;
    private Vector3 first = new Vector3(0, 5, 0);
    private Vector3 second = new Vector3(5,0,0);
    private float time = 20f;

    // Start is called before the first frame update
    void Start()
    {
        first = transform.position;
        second = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(first, second, time);
    }
}
