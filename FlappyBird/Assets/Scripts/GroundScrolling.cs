using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScrolling : MonoBehaviour
{
    public float scrollSpeed;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x >= -23.9)
        {
            transform.Translate(-scrollSpeed * Time.deltaTime, 0, 0);
        } else
        {
            transform.position = originalPos;
        }
    }
}
