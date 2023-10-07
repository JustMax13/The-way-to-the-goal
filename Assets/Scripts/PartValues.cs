using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartValues : MonoBehaviour
{
    [Header("Ліві кінцівки")]
    [SerializeField] private Part[] _leftParts;

    [Header("Праві кінцівки")]
    [SerializeField] private Part[] _rightParts;

    public static Part[] LeftParts { get; private set; }
    public static Part[] RightParts { get; private set; }

    private void Awake()
    {
        LeftParts = _leftParts;
        RightParts = _rightParts;
    }
}
