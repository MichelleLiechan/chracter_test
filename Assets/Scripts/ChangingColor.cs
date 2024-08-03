using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    public SpriteRenderer head;
    public Color normal;
    public Color pink;
    public Color Blue;

    public int whatColor = 1;

    void Update()
    {
        if (whatColor == 1)
        {
            head.color = normal;
        }
        else if (whatColor == 2)
        {
            head.color = pink;
        }
        else if (whatColor == 3)
        {
            head.color = Blue;
        }
    }

    public void ChangeHeadPink()
    {
        whatColor = 2;
    }
    public void ChangeHeadBlue()
    {
        whatColor = 3;
    }
}
