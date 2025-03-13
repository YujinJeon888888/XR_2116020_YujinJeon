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
         * Ű �Է��� �ް� �����̴� ����
         */
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //���� ������ �� (�Է� ���� �� �����̰� ���� vector��(x,y,z��) ���ڷ� �־��ش�.
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
         �Է�Ű�� ���� ��� �ٲٱ�
         */

    }
}
