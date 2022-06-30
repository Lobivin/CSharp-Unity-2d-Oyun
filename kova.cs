using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class kova : MonoBehaviour
{

   
    public float zaman = 10f;
    public  int skor = 0;
    
    public Text zamanText;
    public Text skorText;
    

    public float hýz;

    private void Start()
    {
       
    }



    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "elma")
        {
            skorText.text = skor+"";

             skor += 10;
           
            zaman = zaman+1;
            Debug.Log(skor.ToString());
            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);


        }
        if (collision.gameObject.tag == "kelma")
        {
            skorText.text = skor + "";
            skor += 50;
           
            Debug.Log(skor.ToString());
            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);


        }
        if (collision.gameObject.tag == "melma")
        {
            skorText.text = skor + "";
            skor += 30;
            
            Debug.Log(skor.ToString());
            float rast = Random.Range(1f, 11f);
            collision.gameObject.transform.position = new Vector4(rast, 8, -22);


        }
        
    }

      

    void Update()
    {
       
        zaman -= Time.deltaTime;
        zamanText.text = "Zaman" + (int)zaman;

        
        
        if (zaman <= 0)
        {
            int skortut = skor;

            PlayerPrefs.SetInt("skortutt", skor);
            SceneManager.LoadScene(2);

        }



        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(hýz*Time.deltaTime,0,0);


        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {


            transform.Translate(-hýz * Time.deltaTime, 0, 0);

        }

    }
}
