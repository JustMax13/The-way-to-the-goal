using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonValues : MonoBehaviour
{
    [Header("Ліві кнопки повороту")]
    [SerializeField] private RotateButton[] _leftRotateButtons;
    [Header("Праві кнопки повороту")]
    [SerializeField] private RotateButton[] _rightRotateButtons;

    public static RotateButton[] LeftRotateButtons { get; private set; }
    public static RotateButton[] RightRotateButtons { get; private set; }

    private void Awake()
    {
        LeftRotateButtons = _leftRotateButtons;
        RightRotateButtons = _rightRotateButtons;
    }
}
