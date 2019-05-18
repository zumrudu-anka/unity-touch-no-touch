using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYonetici : MonoBehaviour
{
    GameObject DonenCember,AnaCember;
    public Animator animator;
    public Text donencemberlevel,bir,iki,uc;
    int kackucukcember=3;
    int level=1;
    float hiz=100.0f;
    bool kontrol=true;
    private void Start()
    {
        DonenCember=GameObject.FindGameObjectWithTag("DonenCember1");
        AnaCember=GameObject.FindGameObjectWithTag("AnaCember");
        donencemberlevel.text = level.ToString();
        if (kackucukcember < 2)
        {
            bir.text=kackucukcember.ToString();
        }
        else if(kackucukcember < 3)
        {
            bir.text=kackucukcember.ToString();
            iki.text=(kackucukcember-1).ToString();
        }
        else
        {
            bir.text = kackucukcember.ToString();
            iki.text = (kackucukcember - 1).ToString();
            uc.text = (kackucukcember - 2).ToString();
        }

    }
    public float gethiz()
    {
        return hiz;
    }

    public void kucukcembersayi()
    {
        kackucukcember--;
        if (kackucukcember < 2)
        {
            bir.text = kackucukcember.ToString();
            iki.text = "";
            uc.text = "";
        }
        else if (kackucukcember < 3)
        {
            bir.text = kackucukcember.ToString();
            iki.text = (kackucukcember - 1).ToString();
            uc.text = "";
        }
        else
        {
            bir.text = kackucukcember.ToString();
            iki.text = (kackucukcember - 1).ToString();
            uc.text = (kackucukcember - 2).ToString();
        }
        if (kackucukcember == 0 && kontrol)
        {
            
            AnaCember.GetComponent<AnaCember>().setkucukcemberolustur(false);
            animator.SetTrigger("YeniLevel");
            StartCoroutine(yenilevel());
        }
    }

    IEnumerator yenilevel()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject[] yikim;
        yikim = GameObject.FindGameObjectsWithTag("KucukCember");
        for (int i = 0; i < yikim.Length; i++)
        {
            Destroy(yikim[i]);
        }
        AnaCember.GetComponent<AnaCember>().setkucukcemberolustur(true);
        animator.ResetTrigger("YeniLevel");
        kackucukcember = 5 + level*2;
        level++;
        donencemberlevel.text = level.ToString();
        hiz += 25f;
        if (kackucukcember < 2)
        {
            bir.text = kackucukcember.ToString();
            iki.text = "";
            uc.text = "";
        }
        else if (kackucukcember < 3)
        {
            bir.text = kackucukcember.ToString();
            iki.text = (kackucukcember - 1).ToString();
            uc.text = "";
        }
        else
        {
            bir.text = kackucukcember.ToString();
            iki.text = (kackucukcember - 1).ToString();
            uc.text = (kackucukcember - 2).ToString();
        }
        if (kackucukcember == 0 && kontrol)
        {
            AnaCember.GetComponent<AnaCember>().setkucukcemberolustur(false);
            animator.SetTrigger("YeniLevel");
            StartCoroutine(yenilevel());
        }
    }
    public void OyunBitti()
    {
        StartCoroutine(CagrilanMetot());
    }

    IEnumerator CagrilanMetot()
    {
        DonenCember.GetComponent<Dondurme>().enabled = false;
        AnaCember.GetComponent<AnaCember>().enabled = false;
        animator.SetTrigger("oyunBitti");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("AnaMenu");
    }
    
        


 
}
