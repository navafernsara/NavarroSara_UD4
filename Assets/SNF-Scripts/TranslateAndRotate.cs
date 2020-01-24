using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateAndRotate : MonoBehaviour
{
    [SerializeField] float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(2f * Time.deltaTime, 0f, 0f);
            transform.Rotate(0f, 25f * Time.deltaTime, 0f);
    }
}
