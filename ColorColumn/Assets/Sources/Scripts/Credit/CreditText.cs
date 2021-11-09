using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditText : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y <= 6000)
        {
            transform.Translate(new Vector3(0, Time.deltaTime * 100, 0));
        }
    }
}
