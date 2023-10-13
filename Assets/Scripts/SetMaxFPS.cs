using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaxFPS : MonoBehaviour
{
    [SerializeField] private int _maxFPS;
    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.runInBackground = true;
        Application.targetFrameRate = _maxFPS;
    }
}
