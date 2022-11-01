using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI displayText;
    protected string ShapeName { get; set; }

    protected string ShapeColor { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        ShapeName = $"{this.gameObject.name}";
        ShapeColor = $"{GetComponent<Renderer>().materials[0].name}";
        ShapeColor = ShapeColor.Remove(ShapeColor.IndexOf(' '));
    }

    private void Update()
    {
        SpinShape();
    }

    public abstract void SpinShape();

    protected void OnMouseDown()
    {
        displayText.text = $"This is a {ShapeColor} {ShapeName}";
    }

}
