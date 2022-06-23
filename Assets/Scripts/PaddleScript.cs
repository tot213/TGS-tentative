using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    //private float speed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //speed = 5f;
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.A)& transform.position.x > -4.0f)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)& transform.position.x < 4.0f)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
