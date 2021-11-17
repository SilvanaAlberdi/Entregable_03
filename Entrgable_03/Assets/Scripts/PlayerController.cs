using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.localScale += new Vector3(0.5F, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += new Vector3(0, 0.5F, 0);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale += new Vector3(0, 0, 0.5F);
        }
    }
}
