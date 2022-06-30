using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

 public class bitis : MonoBehaviour
{
    int skor;
    string kadi;
   
    public Text skorText;
    
    void Skoryeni (int deger)
    {
        skor = deger;

    }

    public void Start()
    {
        
    }
    public void tekraroyna()
    {
        
        SceneManager.LoadScene(0);

    }

    public void kaydet()
    {

    }
}
