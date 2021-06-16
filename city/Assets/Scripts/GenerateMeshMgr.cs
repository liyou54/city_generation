using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMeshMgr
{
    private List<GenerateMesh> meshs;

    public void AddGenerateMesh()
    {
        
    }

    public bool DelGenerateMesh(uint id)
    {
        for (var i = 0; i < meshs.Count; i++)
        {
            if (id == meshs[i].ID)
            {
                meshs.RemoveAt(i);
                return true;
            }
        }    
        return false;
    }
    
}
