using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinatesLabeler : MonoBehaviour
{
    TextMeshPro Label;
    Vector2Int Coordiantes;

    // Start is called before the first frame update
    private void Awake()
    {
        Label = GetComponent<TextMeshPro>();
        DisplayCooardinates();
        ChangeName();
        Label.enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisplayCooardinates()
    {
        Coordiantes.x = (int) (transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        Coordiantes.y = (int) (transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        Label.text = Coordiantes.x + "," + Coordiantes.y;
    }

    private void ChangeName()
    {
        transform.parent.name = Coordiantes.ToString();
    }
}
