using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamoScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = GameObject.Find("Paddle").transform.position;
        float x = tmp.x;
        float y = tmp.y;
        float z = tmp.z;
        if (Input.GetKey(KeyCode.UpArrow) & transform.position.y < 3.0f)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) & transform.position.y > 1.0f)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) & transform.position.x < x+3.0f)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) & transform.position.x > x-3.0f)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) & transform.position.x > -4.0f)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) & transform.position.x < 4.0f)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        Debug.Log(x);

    }
}
