using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    
    public Text skorText;
    public Text kadýText;

    private void Start()
    {
       
     
    }

    public void skoryenile(int skor ,int skorr)
    {
       
        skorText.text = (skorr+skor).ToString();
        

    }

}
