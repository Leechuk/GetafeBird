using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sangre : MonoBehaviour
{
    void OnParticleSystemStopped()
    {
        GameManager.Reload();
    }
}
