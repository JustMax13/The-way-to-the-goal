using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public Transform Transform { get => _transform; }
    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; }
}
