using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMesh
{
    static private uint now_id;

    private uint SetId()
    {
        return ++now_id;
    }

    public uint ID
    {
        get => ID;
        private set => SetId();
    }

    GenerateMesh()
    {
    }
}