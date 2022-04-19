using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public class GridGraph : MonoBehaviour
{
    public uint width;
    public uint height;
    public char[][] cost;
    public string xmlDocName = "Map1Data.xml";
    XmlDocument xmlDoc;


    // Start is called before the first frame update
    void Start()
    {
        xmlDoc = new XmlDocument();
        xmlDoc.Load("Assets\\Assets\\MapData\\" + xmlDocName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
