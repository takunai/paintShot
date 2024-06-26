using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(-3, 0, 0);// 左
            }
        }

        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(3, 0, 0);// 右
            }
        }
    }
}
