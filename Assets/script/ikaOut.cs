using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikaOut : MonoBehaviour
{
    public GameObject kontonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Out", 0.5f, 0.1f);
    }

    void Out()
    {
        Vector2 outPosition = new Vector2
            (-11f, Random.Range(-2.5f, 2.5f));
        Instantiate(kontonPrefab, outPosition, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
