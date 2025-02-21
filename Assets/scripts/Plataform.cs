using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    private Rigidbody2D rB2D;
    public float Speed = 1.0f;
    public float bounceForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rB2D.transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rB2D.transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {


            Vector2 contactPoint = collision.contacts[0].point;
            Vector2 platformCenter = GetComponent<Collider2D>().bounds.center;


            // Calcula a dire��o do impulso com base no ponto de colis�o
            float hitFactor = (contactPoint.x - platformCenter.x) / (GetComponent<Collider2D>().bounds.size.x / 2);
        }
    }
}
