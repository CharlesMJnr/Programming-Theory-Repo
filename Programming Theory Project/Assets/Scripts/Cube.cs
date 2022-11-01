using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{

    public override void SpinShape()
    {
        transform.Rotate(new Vector3(0.25f, 0.25f, 0.25f));
    }
}
