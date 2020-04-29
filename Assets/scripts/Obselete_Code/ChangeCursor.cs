using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    static public ChangeCursor myCursor;
    private Vector3 cursorPos;
    public GameObject redReticle;
    public float PosZ;

    private void Start()
    {
        myCursor = this;
        Cursor.visible = false;
    }

    private void Update()
    {
        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPos.z = PosZ;
        transform.position = cursorPos;
    }
}
