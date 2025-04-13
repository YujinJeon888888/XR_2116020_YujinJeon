using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class D12_Heart : MonoBehaviour
{
    /**
     * 
     * 
     */
    public GameObject UI_Controller;
    
    //오버라이딩
    void OnMouseDown()
    {
        print($"{gameObject.name} clicked");
        //다른 오브젝트의 함수를 호출하는 모습이다.
        /*여기 호출이안됨. 다시확인*/
        D12_UI UIScript = UI_Controller.GetComponent<D12_UI>();
        UIScript.Test();
        
    }
}
