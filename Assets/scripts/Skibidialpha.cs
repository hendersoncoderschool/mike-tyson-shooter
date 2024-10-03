using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skibidialpha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(transform.forward * -0.1f);            
    }
        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mike the forgotten"))
        {
            Destroy(collision.gameObject);
        }

        
    }
    


}
