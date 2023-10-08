using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ageableObject : MonoBehaviour
{
    public bool isAged;

    public float progress;
    public abstract void age();
}
