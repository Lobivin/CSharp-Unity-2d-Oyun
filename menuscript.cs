using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{
    public void girisbutton()
    {

       SceneManager.LoadScene(1);

    }
    public void cýkýsbutton()
    {

        Application.Quit();

    }
    
}
