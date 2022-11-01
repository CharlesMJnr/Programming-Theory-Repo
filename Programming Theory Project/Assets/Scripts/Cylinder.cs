using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{

    public override void SpinShape()
    {
        transform.Rotate(new Vector3(0.5f, 0.5f, 0.5f));
    }
}
