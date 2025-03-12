using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("block"))
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Death"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(1);

        }
    }

}
