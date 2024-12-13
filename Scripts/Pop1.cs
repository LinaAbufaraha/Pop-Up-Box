using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pop_up{
  public class Pop1 : MonoBehaviour
  {
    public float speed = 20f;
    public float minPosition = -10f;
    public float maxPosition ;

    public float positionFactor = -10f;

    
    public Vector3 finalPosition; 
    public Vector3 startPosition;
    
  
    void Start()
    {
      finalPosition = transform.position; 

      maxPosition = transform.position.y;

      startPosition = new Vector3(transform.position.x, minPosition , transform.position.z);  // Y = -10f
      transform.position =new Vector3(transform.position.x, minPosition , transform.position.z);  // Y = -10f;
      //elapsedTime = 0f; 
        
    }

   
    void Update()
    {
      if (Input.GetKey(KeyCode.RightArrow)){

        positionFactor+= Time.deltaTime*speed ;

      }else if (Input.GetKey(KeyCode.LeftArrow)){
       
        positionFactor-= Time.deltaTime*speed ;
      }

      positionFactor = Mathf.Clamp(positionFactor, minPosition, maxPosition);

      transform.position = new Vector3(transform.position.x, positionFactor , transform.position.z);

        
    }

  }

}
