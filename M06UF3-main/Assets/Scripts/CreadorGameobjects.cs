 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreadorGameobjects : MonoBehaviour
{

    [SerializeField]
    private int slotsNum = 1;
    private float[] x;
    private float[] y;
    [SerializeField] private GameObject slot;

    private bool isCreatingSlots = false;
    private List<GameObject> slotsList  = new List<GameObject>();

    private void Awake()
    {
        x = new float[slotsNum];
        y = new float[slotsNum];

        for( int i= 0; i < slotsNum; i++)
        {
            for( int j= 0; j < slotsNum; j++)
            {
                y[i] = (float)i;
                x[j] = (float)j;
                Vector2 pos = new Vector2(x[j], y[i]);
                slotsList.Add(Instantiate(slot, pos, Quaternion.identity, this.transform));
            }
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            slotsNum++;
            isCreatingSlots = true;
        }

        if (isCreatingSlots)
        {
            for (int i= 0;i < slotsList.Count; i++) 
            {
                Destroy(slotsList[i]);
            }

            x = new float[slotsNum];
            y = new float[slotsNum];

            for(int i= 0; i< slotsNum; i++)
            {
                for(int j= 0;j < slotsNum; j++)
                {
                    y[i] = (float)i;
                    x[j] = (float)j;
                    Vector2 pos = new Vector2(x[j], y[i]);
                    slotsList.Add(Instantiate(slot, pos, Quaternion.identity, this.transform));
                }
            }
            isCreatingSlots=false;

        }


    }


}
