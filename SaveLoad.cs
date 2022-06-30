using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SaveData
{
    public string kadi;
    public int skor;
    
}
public class SaveLoad : MonoBehaviour
{
    public InputField kadiInput;
    public Button kaydet;
    public GameObject adTutparet;
    public GameObject kulaniciAdiobj;
    public int ksayisi;
    public static SaveLoad saveLoad;
    public  List<SaveData> kadiData;
    private void Awake()
    {
        saveLoad = this;
    }

    private void Start()
    {

        
        ksayisi = PlayerPrefs.GetInt("ksayisi");
        
        kaydet.onClick.AddListener(save);
        for (int i = 0; i < ksayisi; i++)
        {

            GameObject go = Instantiate(kulaniciAdiobj, adTutparet.transform);
            go.GetComponent<Text>().text = PlayerPrefs.GetString("kullan�c�2"+i) + ":" + PlayerPrefs.GetInt("kullan�c�1"+i);
            int skor = PlayerPrefs.GetInt("kullan�c�1" + i);

            string ad = PlayerPrefs.GetString("kullan�c�2" + i);
            SaveData SData = new SaveData();
            SData.kadi = ad;
            SData.skor = skor;
            kadiData.Add(SData);
        }

    }

    public void save()
    {
        string ad = kadiInput.text;
        int skor = GameManager.instance.GetSkor();
        SaveData data=new SaveData();
        data.kadi = ad;
        data.skor = skor;
        kadiData.Add(data);
        GameObject go = Instantiate(kulaniciAdiobj, adTutparet.transform);
        go.GetComponent<Text>().text = ad + ":" + skor;
        savekulanic(ad, skor);
        ksayisi++;
        PlayerPrefs.SetInt("ksayisi", ksayisi);
    }
    public void savekulanic(string id,int skor)
    {
        PlayerPrefs.SetInt("kullan�c�1"+ksayisi,skor);
        PlayerPrefs.SetString("kullan�c�2"+ksayisi, id);


    }
}
