using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zemin : MonoBehaviour
{
  

   public int skor = 0;
    public Text kskorText;

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {

            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);

        }
        if (collision.gameObject.tag == "kelma")
        {

            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);

        }
        if (collision.gameObject.tag == "melma")
        {

            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);

        }


        if (collision.gameObject.tag == "elma")
            {
           kskorText.text= skor + "";
            skor -= 10;
                Debug.Log(skor.ToString());


            }
        if (collision.gameObject.tag == "kelma")
        {
            kskorText.text = skor + "";
            skor -= 60;
            Debug.Log(skor.ToString());


        }
        if (collision.gameObject.tag == "melma")
        {
            kskorText.text = skor + "";
            skor -= 40;
            Debug.Log(skor.ToString());


        }

        

    }
    public void Update()
    {
        PlayerPrefs.SetInt("skortuttt", skor);
    }

}
