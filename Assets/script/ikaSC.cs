using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ikaSC: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(3f, 0, 0) * Time.deltaTime * 8;

        if (transform.position.x > 10) { Destroy(gameObject); }
    }
}
