using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudCopy : MonoBehaviour
{
    public GameObject cloudCopied;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        for (int i = 6; i >= -6; i -= 3)
        {
            for (int j = 3; j >= -3; j -= 2)
            {
                GameObject go = Instantiate(cloudCopied);
                cloudCopied.transform.position = new Vector3(i, j, 0);
                Debug.Log(i);
                Debug.Log(j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
