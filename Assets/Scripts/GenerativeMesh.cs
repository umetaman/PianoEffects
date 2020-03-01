using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class GenerativeMesh : MonoBehaviour
{
    [Header("Renderer")]
    public MeshRenderer rendererRef;
    public MeshFilter filterRef;
    private Mesh mesh;

    [Header("Mesh Properties")]
    public float OneSideSize = 100f;
    public int OneSideNum = 1000;

    private List<Vector3> vertices = new List<Vector3>();
    private List<int> triangles = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        //OneSideNumが割り切れなかったら1足す
        if(OneSideNum % 2 != 0)
        {
            OneSideNum += 1;
        }

        //Meshを作る
        mesh = new Mesh();
        vertices = new List<Vector3>(OneSideNum * OneSideNum);
        //頂点
        for(int y = 0; y < OneSideNum; y++)
        {
            for(int x = 0; x < OneSideNum; x++)
            {
                var intervalSize = OneSideSize / OneSideNum;
                vertices[x * OneSideNum + y] = new Vector3(intervalSize * x, intervalSize * y, 0f);
            }
        }
        //Index
        triangles = new List<int>((OneSideNum / 2) * (OneSideNum / 2));
        for(int y = 0; y < OneSideNum - 1; y++)
        {
            for(int x = 0; x < OneSideNum - 1; x++)
            {
                //var triUnit = new 
            }
        }
        //mesh = new Mesh();
        //mesh.vertices = new Vector3[]
        //{
        //    new Vector3(0, 1f, 0),
        //    new Vector3(1f, -1f, 0),
        //    new Vector3(-1f, -1f, 0),
        //};
        //mesh.triangles = new int[]
        //{
        //    0, 1, 2
        //};
        //mesh.RecalculateNormals();
        //filterRef.sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        rendererRef = GetComponent<MeshRenderer>();
        filterRef = GetComponent<MeshFilter>();
    }
}
