﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Structure
{
    public static void MakeTree(Vector3 position, List<VoxelMod> list, int minTrunkHeight, int maxTrunkHeight)
    {
        int height = (int)(maxTrunkHeight * Noise.Get2DPerlin(new Vector2(position.x, position.z), 250f, 3f));

        if (height < minTrunkHeight)
        {
            height = minTrunkHeight;
        }

        for (int i = 1; i < height; i++)
        {
            list.Insert(0,(new VoxelMod(new Vector3(position.x, position.y + i, position.z), 6)));

        }

        list.Insert(0,(new VoxelMod(new Vector3(position.x, position.y + height, position.z), 11)));


    }

}
