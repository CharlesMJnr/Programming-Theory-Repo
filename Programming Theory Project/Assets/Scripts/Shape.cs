using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnMouseDown()
    {
        DisplayText();
    }

    public abstract void DisplayText();
}
