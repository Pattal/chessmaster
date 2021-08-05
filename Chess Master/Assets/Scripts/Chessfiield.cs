using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessfiield : MonoBehaviour
{
    Chessman[] ChessPiecies;
    bool isChessmanPlaced = true;
    public bool IsChessmanPlaced { get { return isChessmanPlaced; } }
    [SerializeField] Vector2Int Coordiantes;
    private void Awake()
    {
        
    }
    void Start()
    {
        CalculateCoordiantes();
        ChessPiecies = GameObject.FindObjectsOfType<Chessman>();
        CanBePlaced();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CanBePlaced()
    {
        
        foreach(Chessman chessman in ChessPiecies)
        {
            if(chessman.Coordiantes.x == Coordiantes.x && chessman.Coordiantes.y == Coordiantes.y)
            {
                isChessmanPlaced = false;
            }
            else
            {
                isChessmanPlaced = true;
            }

            
        }
    
    }

    private void CalculateCoordiantes()
    {
        Coordiantes.x = (int)(transform.position.x / UnityEditor.EditorSnapSettings.move.x);
        Coordiantes.y = (int)(transform.position.z / UnityEditor.EditorSnapSettings.move.z);
    }
}
