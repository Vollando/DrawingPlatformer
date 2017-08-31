using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreatorScript : MonoBehaviour {

    public GameObject linePrefab;

    LineScript activeLine;

	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<LineScript>();
        }
    }
}
