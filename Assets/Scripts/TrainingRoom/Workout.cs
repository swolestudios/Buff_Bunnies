﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workout : MonoBehaviour
{
    public GameObject textBox;
    public void ClickTheButton()
    {
        GlobalWorkout.WorkoutCount += 1;
    }
}
