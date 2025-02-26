﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.PlayerInput
{
public abstract class AbstractInputData : ScriptableObject
{
    public float Horizontal;
    public float Vertical;
    public abstract void ProcessInput();
}
}
