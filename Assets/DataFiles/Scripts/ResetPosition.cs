using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.localPosition;
        print(originalPos.y);
        print(originalPos.x);
        print(originalPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.localPosition.x);
        //print(transform.localPosition.y);
        //print(transform.localPosition.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("AIRPLANEWALL"))
        {
            print("Collision Occured");
            print(transform.localPosition.x);
            print(transform.localPosition.y);
            print(transform.localPosition.z);
            transform.localPosition = originalPos;
        }

        else if (other.gameObject.CompareTag("CLOUDWALL"))
        {
            print("Collision Occured");
            print(transform.localPosition.x);
            print(transform.localPosition.y);
            print(transform.localPosition.z);
            transform.localPosition = originalPos;
        }
    }


}
