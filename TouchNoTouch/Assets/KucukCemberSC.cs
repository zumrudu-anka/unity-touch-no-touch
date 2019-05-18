using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberSC : MonoBehaviour
{
    Rigidbody2D fizik;
    GameObject oyunyonetici;
    public float hiz;
    bool carpisma=false;
    void Start()
    {
        fizik=GetComponent<Rigidbody2D>();
        oyunyonetici=GameObject.FindGameObjectWithTag("OyunYonetici");

    }

    void FixedUpdate()
    {
        if (!carpisma)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DonenCember1")
        {
            carpisma=true;
            transform.SetParent(collision.transform);
        }
        if (collision.tag == transform.tag)
        {
            oyunyonetici.GetComponent<OyunYonetici>().OyunBitti();
        }
    }
}
