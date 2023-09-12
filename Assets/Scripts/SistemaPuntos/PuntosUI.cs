using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosUI : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMesh.text = ControladorPuntos.Instance.ReturnPuntos().ToString();
    }

}
