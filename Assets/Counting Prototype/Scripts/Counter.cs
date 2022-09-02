using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    public int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        counterText.text = "Count : " + count;
    }

    private void OnTriggerExit(Collider other)
    {
        count -= 1;
        counterText.text = "Count : " + count;
    }
}
