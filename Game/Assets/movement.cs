using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Vector3 Move;

    // Start is called before the first frame update
    void Start()
    {
        Move = new Vector3(5, 6, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
             Debug.Log("Space");
            //Spacebar was pressed
             transform.Translate(Move.z * Time.deltaTime);
             Debug.Log(transform.position.y);
            
        }
    }
}
