﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ShipUnit : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnPressed;

    protected void OnMouseDown()
    {
        OnPressed?.Invoke();
    }
}
