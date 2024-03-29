﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreatorScript : MonoBehaviour {

    public GameObject linePrefab;

    LineScript activeLine;

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<LineScript>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
        }
    }
}
