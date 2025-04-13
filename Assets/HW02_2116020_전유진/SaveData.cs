using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public GameObject TurnOnLamp;
    public GameObject TurnOffLamp;


    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Indoor")
        {
            if(PlayerPrefs.GetString("IndoorLamp")=="true"){
                TurnOnLamp.SetActive(true);
            }
            else
            {
                TurnOffLamp.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene().name == "Outdoor")
        {
            if (PlayerPrefs.GetString("OutdoorLamp") == "true")
            {
                TurnOnLamp.SetActive(true);
            }
            else
            {
                TurnOffLamp.SetActive(true);
            }
        }

    }
    public void OnClickSaveLampData()
    {
        if (SceneManager.GetActiveScene().name == "Outdoor")
        {
            if (TurnOnLamp.activeSelf)
            {
                PlayerPrefs.SetString("OutdoorLamp", "true");
            }
            else
            {
                PlayerPrefs.SetString("OutdoorLamp", "false");
            }
        }
        if (SceneManager.GetActiveScene().name == "Indoor")
        {
            if (TurnOnLamp.activeSelf)
            {
                PlayerPrefs.SetString("IndoorLamp", "true");
            }
            else
            {
                PlayerPrefs.SetString("IndoorLamp", "false");
            }
        }
    }

    public void OnClickSwitchScene()
    {
        Debug.Log("Clicked!");
        if (SceneManager.GetActiveScene().name == "Outdoor")
        {
            SceneManager.LoadScene("Indoor");
        }
        if (SceneManager.GetActiveScene().name == "Indoor")
        {
            SceneManager.LoadScene("Outdoor");

        }
    }
}
