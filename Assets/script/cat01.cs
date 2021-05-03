using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat01 : MonoBehaviour
{
    public GameObject catPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cat", 0.5f, 0.1f);
    }
    void Cat()
    {
        Vector2 outPosition1 = new Vector2
               (Random.Range(-5f, 5f), Random.Range(-2.5f, 2.5f));
        

        Instantiate(catPrefab, outPosition1, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
