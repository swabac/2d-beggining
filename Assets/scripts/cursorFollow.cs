﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorFollow : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }
}
