using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject tickXanh;
    public bool checkTich = true;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("AmThanh")) PlayerPrefs.SetInt("AmThanh", 1);

        if (PlayerPrefs.GetInt("AmThanh")==0)
        {
            tickXanh.SetActive(false);
            checkTich = false;
        }
        else
        {
            tickXanh.SetActive(true);
            checkTich = true;
        }
    }
    public void CheckTickAmThanh()
    {
        if (checkTich)
        {
            tickXanh.SetActive(false);
            checkTich = false;
            PlayerPrefs.SetInt("AmThanh", 0);
        }
        else 
        {
            tickXanh.SetActive(true); 
            checkTich = true;
            PlayerPrefs.SetInt("AmThanh", 1);
        }
    }
}
