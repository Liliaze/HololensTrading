﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Sharing.SyncModel;
using HoloToolkit.Sharing;
using HoloToolkit.Sharing.Spawning;
using HoloToolkit.Unity;


public class SharePosition : MonoBehaviour
{
    SyncSpawnedObject sync;
    public bool receive_data;
    // Use this for initialization
    void Start()
    {
        sync = transform.GetComponent<DefaultSyncModelAccessor>().SyncModel as SyncSpawnedObject;
        receive_data = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (receive_data)
        {
            transform.position = sync.Position.Value;
            transform.rotation = sync.Rotation.Value;
            transform.localScale = sync.Scale.Value;
        }
    }

}

