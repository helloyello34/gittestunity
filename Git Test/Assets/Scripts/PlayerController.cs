using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    Vector3 walkDirection;
    // Start is called before the first frame update
    void Start()
    {
        walkDirection = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            walkDirection.y += 1;
        if (Input.GetKey("s"))
            walkDirection.y -= 1;
        if(Input.GetKey("a"))
            walkDirection.x -= 1;
        if (Input.GetKey("d"))
            walkDirection.x += 1;

        walkDirection *= (Time.deltaTime * speed);

        Walk();
    }

    void Walk()
    {
        transform.position += walkDirection;
    }
}
