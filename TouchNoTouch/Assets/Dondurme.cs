using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{
    GameObject oyunyonetici;

    private void Start()
    {
        oyunyonetici=GameObject.FindGameObjectWithTag("OyunYonetici");
    }

    void Update()
    {
        transform.Rotate(0,0, oyunyonetici.GetComponent<OyunYonetici>().gethiz() * Time.deltaTime);
    }
}
