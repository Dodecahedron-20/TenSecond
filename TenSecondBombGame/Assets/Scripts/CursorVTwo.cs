using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVTwo : MonoBehaviour
{
    [SerializeField]
    private Texture2D wirecutters;
    [SerializeField]
    private CursorMode cursorMode = CursorMode.Auto;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(wirecutters, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
