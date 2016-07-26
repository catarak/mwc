using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehavior {
  public SteamVR_PlayArea steamVR_PlayArea;
  // each fallingItem must have a RigidBody and Collider isTrigger attached
  public GameObject[] fallingItems;

  private HmdQuad_t steamVrBounds;
  private SteamVR_PlayArea.Size playAreaSize;

  private float xMin;
  private float xMax;
  private float zMin;
  private float zMax;

  private void OnEnable() {
    steamVR_PlayArea = GameObject.FindObjectOfType<SteamVR_PlayArea>();
    if (steamVR_PlayArea == null) {
      Debug.LogWarning("Could not find 'SteamVR_PlayArea'. Please check if they are attached to the 'CameraRig'");
      return;
    }

    bool success = SteamVR_PlayArea.GetBounds(steamVR_PlayArea.size, ref steamVrBounds);
    if (success) {
      playAreaSize = steamVR_PlayArea.size;
      xMax = steamVrBounds.vCorners0.v0;
      zMax = steamVrBounds.vCorners0.v2;
      xMin = steamVrBounds.vCorners2.v0;
      zMin = steamVrBounds.vCorners2.v2;
    }
  }

  void Update() {
    GameObject objectToInstantiate = fallingItems[Random.Range(0, fallingItems.Length)];
    Instantiate(objectToInstantiate, new Vector3(Random.Range(xMin, xMax), 3.0f, Random.Range(zMin, zMax)), Quaternion.Identity);
  }

  public void AddPoints() {
    
  }
}