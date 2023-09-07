using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text NameTxt;

    void Start()
    {
        NameTxt.text = PlayerPrefs.GetString("PlayerName");
    }

    void Update()
    {
        
    }
}
