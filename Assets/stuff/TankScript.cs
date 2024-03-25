using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{

    int Move = 0;
    Vector3 rot;
    int vel;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(TankCoroutine());

    }


    void Update()
    {
        
        transform.Rotate(rot);
        transform.position += transform.forward * vel * Time.deltaTime;
    }

    IEnumerator TankCoroutine()
    {

        while (Move < 5)
        {
            // rotate for 0.5 - 1 seconds
            float wait1 = Random.Range(0.5f, 1f);
            rot = new Vector3(0, 0.1f, 0);
            yield return new WaitForSeconds(wait1);

            // stop and wait for 1 second
            rot = new Vector3(0, 0, 0);
            yield return new WaitForSeconds(1);

            // move forward for 0.5 - 3 seconds
            float wait2 = Random.Range(0.5f, 3f);
            vel = 2;
            yield return new WaitForSeconds(wait2);

            // stop and wait for 1 second
            vel = 0;
            yield return new WaitForSeconds(1);



            Move++;

        }



    }

}
