using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void SpinShape()
    {
        transform.Rotate(new Vector3(1, 1, 1));
    }

}
