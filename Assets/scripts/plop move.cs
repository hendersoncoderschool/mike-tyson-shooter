using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plopmove : MonoBehaviour

{
    public float speed = 10.0f;
    public float HorizontalInput;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -10) {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 10) {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown("space")){
            Instantiate(projectile, transform.position + new Vector3(0, 2, 0), projectile.transform.rotation); 
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);

    }
}
