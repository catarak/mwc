using UnityEngine;
using System.Collections;

//Similar thing for ground plane--keep track of how many items dropped
[RequireComponent (typeof (Collider))]
public class BasketController : MonoBehavior {
  void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "blah") {
      //then do something
      //itemDropper.addPoints()
      Destroy(other.gameObject);
    }
  }
}