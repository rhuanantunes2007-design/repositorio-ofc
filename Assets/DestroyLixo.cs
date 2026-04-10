using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLixo : MonoBehaviour
{
    private void OnColisionEnter(Collision collision)
    {
        if(collision.gameObject.tag==("Lixo"))
        {
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
