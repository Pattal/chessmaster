using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    
    Vector2Int coordiantes;
    public Vector2Int Coordiantes { get { return coordiantes; } }
    Chessfiield[] Chessfiields;

    private void Start()
    {
        CalculateCoordiantes();
        Chessfiields = GameObject.FindObjectsOfType<Chessfiield>();
        Debug.Log(Chessfiields.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CalculateCoordiantes()
    {
        coordiantes.x = (int)(transform.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordiantes.y = (int)(transform.position.z / UnityEditor.EditorSnapSettings.move.z);
        
    }


}
