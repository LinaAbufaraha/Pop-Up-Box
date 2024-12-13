using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{

    

    public class Pop2 : MonoBehaviour
{
    public GameObject targetObject;
    private Renderer objectRenderer;
    public float speed = 2f;

    float maxScale ;
    float minScale = 0.05f;

    float scaleFactor=1 ;

        void Start()
    {
       
        maxScale=transform.localScale.y;
        scaleFactor = minScale;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            scaleFactor += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            scaleFactor -= Time.deltaTime;
        }

        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        transform.localScale = Vector3.one * scaleFactor;
    }
        
    }
}




