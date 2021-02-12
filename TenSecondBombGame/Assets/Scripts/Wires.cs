using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : MonoBehaviour
{
    public GameObject redWire;
    public GameObject redWireCut;
    public GameObject blueWire;
    public GameObject blueWireCut;
    public GameObject greenWire;
    public GameObject greenWireCut;
    public GameObject yellowWire;
    public GameObject yellowWireCut;

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        redWire.SetActive(true);
        blueWire.SetActive(true);
        greenWire.SetActive(true);
        yellowWire.SetActive(true);

        redWireCut.SetActive(false);
        blueWireCut.SetActive(false);
        greenWireCut.SetActive(false);
        yellowWireCut.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

        }
    }

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
