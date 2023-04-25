using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class End : MonoBehaviour
{
    [SerializeField] private GameObject[] _total;
    private int _totalGeo;
    public static bool isComleted;


    private void Start()
    {
        isComleted = false;

    }


    /*
    * liste içindeki tüm elemanlarý esitleyerek, eleman kalmadigi taktirde oyunu bitirecek kod.
    * */
    public void LevelEnd()
    {

        _totalGeo++;
        if (_totalGeo == _total.Length)
        {
            isComleted = true;
            MenuPanel.Instance.Winn(0);
 
            Debug.Log("oyun bitti;");
            
        }
    }
   



}
