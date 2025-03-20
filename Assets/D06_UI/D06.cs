using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D06 : MonoBehaviour
{
    public void Onclick_LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Onclick_Destroy(GameObject Target)
    {
        Destroy(Target);
    }
}
