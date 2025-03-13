using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_input_keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello world\n");
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 키 입력을 받고 움직이는 구현
         */
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //어디로 움직일 지 (입력 받을 때 움직이고 싶은 vector를(x,y,z값) 인자로 넣어준다.
            transform.Translate(0,0,1.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        /*
         입력키에 따라 모양 바꾸기
         */

    }
}
