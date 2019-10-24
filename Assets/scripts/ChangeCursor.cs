using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    static public ChangeCursor myCursor;
    public GameObject redReticle;

    private void Start()
    {
        myCursor = this;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }
}
