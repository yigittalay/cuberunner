using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    private void Awake()
    {
        Instance = this;
    }
}