using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

  private GameObject _floor;
  private GameObject _wall1;

  // Use this for initialization
  void Start () {
    // 床を作る
    this._floor = new GameObject("floor");
    this._floor.transform.parent = this.transform; // 自GameObjectの子にする
    this._floor.AddComponent<MeshFilter>();
    this._floor.AddComponent<MeshRenderer>();
    MeshFilter floorMeshFilter = this._floor.GetComponent<MeshFilter>();
    Mesh floorMesh = new Mesh();
    floorMesh.vertices = new Vector3[] {
        new Vector3 (-1,  0, -1),
        new Vector3 (-1,  0,  1),       
        new Vector3 ( 1 , 0, -1),
        new Vector3 ( 1 , 0,  1),
    };
    floorMesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    floorMeshFilter.sharedMesh = floorMesh;

    // 壁を作る
    this._wall1 = new GameObject("wall1");
    this._wall1.transform.parent = this.transform; // 自GameObjectの子にする
    this._wall1.AddComponent<MeshFilter>();
    this._wall1.AddComponent<MeshRenderer>();
    MeshFilter wall1MeshFilter = this._wall1.GetComponent<MeshFilter>();
    Mesh wall1Mesh = new Mesh();
    wall1Mesh.vertices = new Vector3[] {
        new Vector3 (-1,  0,  1),
        new Vector3 (-1,  2,  1),
        new Vector3 ( 1,  0,  1),
        new Vector3 ( 1,  2,  1),
    };
    wall1Mesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    wall1MeshFilter.sharedMesh = wall1Mesh;
  }
	
	// Update is called once per frame
	void Update () {
	}
}
