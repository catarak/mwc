using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody), typeof (Collider))]
public class FallingItem : MonoBehavior {
  void Awake() {
    GetComponent<Collider>().isTrigger = true;
  }

}