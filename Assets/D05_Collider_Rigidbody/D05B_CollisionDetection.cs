using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class D05B_CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print($"{gameObject.name} has detected CollisionEnter: {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        print($"{gameObject.name} has detected TriggerEnter: {other.name}");

        //y기준으로 체크x 무조건 트리거닿으면 500만큼 푸시
        //Cube2 본인이 isTrigger체크되어있음 -> OnTriggerEnter로 감지.
        if (gameObject.name == "Cube2")
        {
            PushUp(500);
        }
    }

    private void Update()
    {
        if (transform.position.y < -2f)
        {
            PushUp(100);
        }
       
    }

    void PushUp(float speed)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {            
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = new Vector3(0, 0, 0);
            rb.AddForce(Vector3.up * speed);
        }
    }
}
