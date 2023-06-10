using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFly : MonoBehaviour
{
    Light shine;

    public float timer = .15f;
    void Start()
    {
        shine = GetComponent<Light>();

        StartCoroutine(pulse());
    }

    IEnumerator pulse()
    {
        yield return new WaitForSeconds(Random.Range(timer,3));

        yield return new WaitForSeconds(timer);

        shine.intensity = 2.5f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 2.2f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 1.9f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 1.5f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 1.2f;

        yield return new WaitForSeconds(timer);

        shine.intensity = .9f;

        yield return new WaitForSeconds(timer);

        shine.intensity = .6f;

        yield return new WaitForSeconds(timer);

        shine.intensity = .3f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 0;
        transform.position = new Vector3(Random.Range(-20, -31), Random.Range(0.8f, 6.5f), Random.Range(-2.6f, 20.5f));

        yield return new WaitForSeconds(Random.Range(.15f, .75f));

        shine.intensity = .3f;

        yield return new WaitForSeconds(timer);

        shine.intensity = .6f;

        yield return new WaitForSeconds(timer); 
                                               
        shine.intensity = .9f;

        yield return new WaitForSeconds(timer); 

        shine.intensity = 1.2f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 1.5f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 1.9f;

        yield return new WaitForSeconds(timer);

        shine.intensity = 2.2f;

        StartCoroutine(pulse());
    }
}
