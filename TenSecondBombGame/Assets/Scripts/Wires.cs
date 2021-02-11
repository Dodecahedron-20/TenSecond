using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    private void OnMouseEnter()
    {
        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        CursorController.Instance.SetWireCursor();
    }

    private void OnMouseExit()
    {
        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
        CursorController.Instance.SetDefaultCursor();
    }
}
