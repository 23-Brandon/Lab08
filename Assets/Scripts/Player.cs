using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        if (transform.position.y <= -3)
        {
            transform.position = new Vector3(-7.59f, -3.0f, 0f);
        }
        if (transform.position.y >= 5.3)
        {
            transform.position = new Vector3(-7.59f, 5.3f, 0f);
        }


    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
