﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour {

    public LineRenderer lineRenderer;

    public EdgeCollider2D edgeCol;

    List<Vector2> points;
    // difference between array and list; an array is great for storing X amount of items,
    // but only if you don't need to change the size. Lists are more resizable.

    public void UpdateLine (Vector2 point)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(point);
            return;
        }

        // Check if the mouse has moved enough for us to insert new point
        // if it has: Insert point at mouse position
    }
    // each frame that we are drawing the line we are going to be calling this update line

    void SetPoint (Vector2 point)
    {
        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
        edgeCol.points = points.ToArray();
    }
}
