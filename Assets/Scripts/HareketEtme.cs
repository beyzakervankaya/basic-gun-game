using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HareketEtme : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 hareket = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
        Vector3 hizlan= hareket * Time.deltaTime * speed;
        transform.Translate(hizlan);
    }
}
