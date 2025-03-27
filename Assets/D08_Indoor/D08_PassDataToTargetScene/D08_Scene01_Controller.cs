using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * PlayerPrefs: 데이터를 저장. - 비휘발
 */
public class D08_Scene01_Controller : MonoBehaviour
{

    //사용자 입력 문자열. 중간  그릇.
    private string UserInput = "";

    void Update()
    {
        //X키를 누를 시, PlayerPrefs의 데이터를 모두 지움. 테스트용
        if (Input.GetKeyDown(KeyCode.X))
        {
            //전부 지운다 == DeleteAll
            PlayerPrefs.DeleteAll();
        }
    }

    //사용자 입력을 대입
    public void OnClick_AssignData(TMP_InputField InputField)
    {
        UserInput = InputField.text;
    }

    //사용자 인풋을 디스플레이
    public void OnClick_Display_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
    }

    //"Input" 접두사: Key값.
    public void OnClick_DisplayAndSet_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
        //String을 저장
        PlayerPrefs.SetString("Input", Message.text);
    }

    //매개변수: 씬 오브젝트
    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
