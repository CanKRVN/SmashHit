using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass_Shatter : MonoBehaviour
{
    public GameObject shatteredObject;
    GameObject asdfg;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("destructive"))
        {
            //int objectIndex = Random.Range(0, shatteredObject.Length);
            asdfg = Instantiate(shatteredObject, transform.position, Quaternion.Euler(0, 0, 0));
            asdfg.transform.Rotate(0, 0, 0, Space.Self);
            Destroy(gameObject);
        }
    }
}
