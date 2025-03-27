using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class D08_Scene02_Controller : MonoBehaviour
{
    string UserInput;
    public TMP_Text Message;

    void Start()
    {
        UserInput = PlayerPrefs.GetString("Input");
        if (string.IsNullOrEmpty(UserInput))
        {
            Message.text = "PlayerPrefs에 저장한 데이터가 없습니다.";
        }
        else
        {
            //Message를 UserInput(데이터 저장된 값)으로 대체
            Message.text = UserInput;
        }
    }

    //씬 전환
    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
