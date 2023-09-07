using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InputName : MonoBehaviour
{
    public InputField InputPlayerName;

    public void OnName()
    {
        PlayerPrefs.SetString("PlayerName", InputPlayerName.text.ToString());

        SceneManager.LoadScene("SampleScene");
    }
}
