using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

    public bool finished;
    public float baslangicSuresi = 30f;
    public bool basladi ;

    public GameObject playerBall;

    [HideInInspector] public float geriSayim;
    public int puan = 0;
    public int sonPuan;

    public Text clickedTxt;
    public Text normalPuanTxt;
    public Text sureTxt;


    private void Start()
    {
        clickedTxt.text = "Başlamak için bir butona basınız.";
        geriSayim = baslangicSuresi;
        finished = true;
        basladi = false;
        normalPuanTxt.text = " ";
    }

    private void BasladiMi()
    {
        if (basladi == false)
        {
            if (Input.anyKey)
            {
                finished = false;
                basladi = true;
            }
        }
    }

    private void Update()
    {
        BasladiMi();
        Gorunurluk();
        Countdown();
        SurenDoldu();
    }

    private void Gorunurluk()
    {
        if (finished == false)
        {
            if (basladi == true)
            {
                normalPuanTxt.text = "Puan: " + puan.ToString();
                clickedTxt.text = " ";
                sureTxt.text = "Süre: " + geriSayim.ToString("f0");
            }
        }
        else
        {
            ResetAtmak();

            if (basladi == true)
            {
                clickedTxt.text = "Oyun bitti. Tekrar başlamak için bir butona tıklayın...";
                normalPuanTxt.text = "Son Puan: " + sonPuan.ToString();
            }
            sureTxt.text = " ";

            if (Input.anyKey)
                finished = false;
            puan = 0;
        }
    }
    
    private void Countdown()
    {
        if (basladi == true)
        {
            if (finished == false)
            {
                geriSayim -= Time.deltaTime;
            }
        }
    }

    private void SurenDoldu()
    {
        if (geriSayim < 0)
        {
            sonPuan = puan;
            finished = true;
            geriSayim = baslangicSuresi;
        }
    }

    private void ResetAtmak()
    {
        playerBall.transform.SetPositionAndRotation(new Vector3(0.1f, 0.8f, 0.1f), Quaternion.identity);
    }

}
