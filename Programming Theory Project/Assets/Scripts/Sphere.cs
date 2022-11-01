using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape //INHERITANCE
{
    public override void SpinShape()//POLYMORPHISM
    {
        transform.Rotate(new Vector3(1, 1, 1));
    }

}
