
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField]private int points = 0;
    public TMP_Text Pontos;
    private AudioSource Click;
    

    // Start is called before the first frame update
    void Start()
    {
        Click = GetComponent<AudioSource>();
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
            Click.Play();
            
            points++;
            Pontos.text = "Pontos : " + points;
            

        }
        if(points >= 79)
        {
            SceneManager.LoadScene("Vitória");
        }
        if(collision.gameObject.CompareTag("Death"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Death");

        }
    }
    

}
