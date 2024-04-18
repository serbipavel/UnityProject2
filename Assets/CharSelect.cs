using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    [SerializeField] GameObject AdvMale;
    [SerializeField] GameSystem gs;
    // Start is called before the first frame update
    public void Char1()
    {
        gs.player = AdvMale;
    }
}
