using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public int scoreValue;
    private ScoreManager sm;
    public static bool miss;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        speed = Random.Range(5f, 15f);
        miss = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0f, -1 * speed * Time.deltaTime);
        if (transform.position.z<-20.0f)
        {
            //Debug.Log("Game Over");
            //Time.timeScale = 0;
            SceneManager.LoadScene("Game Over");
   
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            Destroy(gameObject);
            if(collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            sm.AddScore(scoreValue);

        }
    }
}
