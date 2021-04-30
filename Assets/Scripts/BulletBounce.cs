using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBounce : MonoBehaviour
{
    public int bounceAmount=4;
    public float bounceMagnitude = 500;
    private Vector3 forceDirection;
    public GameObject particle;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //do
        //{
        //    bounceAmount--;
        //    Debug.Log(bounceAmount);


        //} while (collision.gameObject.tag == "BounceObject");
        if (collision.gameObject.CompareTag("BounceObject"))
        {
            bounceAmount--;
            
            forceDirection = transform.position - collision.transform.position;
            forceDirection.Normalize();
            gameObject.GetComponent<Rigidbody>().AddForce(forceDirection*bounceMagnitude);
        }
        Debug.Log(bounceAmount);

        if (bounceAmount == 0)
        {
            Destroy(gameObject);
            Explode();
            
        }
    }

    void Explode()
    {
        Instantiate(particle, gameObject.transform.position, Quaternion.identity);

    }

}
