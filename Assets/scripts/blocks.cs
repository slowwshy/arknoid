using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class blocks : MonoBehaviour
{
    public TMP_Text Pontos;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        Pontos.text = "Pontos : 0";
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            points++;
            Destroy(this.gameObject);
            if(points > 0)
            {
                Pontos.text = "Pontos : 1";
            }
        }
    }
}
