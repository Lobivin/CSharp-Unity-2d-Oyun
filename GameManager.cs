using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIControl UIControl;
    private void Awake()
    {

        instance = this;
        

    }

    int skor;
    int skorr;

    void Start()
    {
        Skoryeni();
    }


    public void Skoryeni()
    {
        skor = PlayerPrefs.GetInt("skortutt");
        skorr = PlayerPrefs.GetInt("skortuttt");
        UIControl.skoryenile(skor,skorr);
    }

   public int GetSkor()
    {
        skor = PlayerPrefs.GetInt("skortutt");
        skorr = PlayerPrefs.GetInt("skortuttt");
        return skor + skorr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
