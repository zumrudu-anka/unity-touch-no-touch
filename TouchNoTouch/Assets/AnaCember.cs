using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject kucukcember;
    GameObject OyunYonetici;
    bool kosul=true;
    void Start()
    {
        OyunYonetici=GameObject.FindGameObjectWithTag("OyunYonetici");
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && kosul)
        {
            kucukcemberolustur();
        }
    }
    void kucukcemberolustur()
    {
        Instantiate(kucukcember,transform.position,transform.rotation);
        OyunYonetici.GetComponent<OyunYonetici>().kucukcembersayi();
    }
    public void setkucukcemberolustur(bool x)
    {
        kosul=x;
    }
}
