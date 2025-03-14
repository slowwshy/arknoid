using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void começar()
    {
        SceneManager.LoadScene(2);
    }
    public void Sair()
    {
       Application.Quit();
    }
}
