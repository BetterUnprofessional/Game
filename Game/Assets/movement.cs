using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
             Debug.Log("Space");
            //Spacebar was pressed
             transform.Translate(Vector3.forward * Time.deltaTime);
            
        }
    }
}
