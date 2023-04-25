using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class TimeCounter : MonoBehaviour
{
    private TMP_Text _timeCounterText;
   
    [SerializeField] private float timeLeft;
    [SerializeField] private GameObject info;
    [SerializeField] private GameObject nnfo;
    bool asd = true;
    End end;
    
    //TMP Metin çekmemize yariyor.
    private void Awake()
    {
        _timeCounterText = GetComponent<TMP_Text>();
       
    }

   
    /*
     * zamani dakika ve saniye cinsinden ekrana yazdirmamizi sagliyor, eger zaman 1 in altindaysa gameover fonksiyonuna indeks sayisini gönderyor.
     */
    void Update()
    {
        if (!End.isComleted)
        {
            Time();
        }
        
    }

    public void Time()
    {
        if (asd)
        {
            nnfo.SetActive(true);
        }
        if (timeLeft < 1)
        {
           info.SetActive(false);
           nnfo.SetActive(false);

        }
        else
        {
            gameObject.SetActive(true);
            _timeCounterText.enabled=true;
            //FloorToInt  ondalikli sayiyi dönüþtürür, FlorrToInt cikan sonucu int degiþkene atayabilir Florr dan farki budur.
            //FloorToInt her hangi bir ondalikli sayiyi taban kismina göre verir.
            //Floor sadece float degiskene atayabilir.

            timeLeft -= UnityEngine.Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeLeft / 60f);
            int seconds = Mathf.FloorToInt(timeLeft % 60f);
            // string format int gelen deðeri stringe cevirir ve texte atar, text de ekranda yazdirilmasini saglar. 
            _timeCounterText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
        }
       
    }
}
