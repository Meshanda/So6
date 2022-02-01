using System;
using UnityEngine;

namespace BehaviourTree
{
    public class BehaviourTreeRunner : MonoBehaviour
    {
        public BehaviourTree tree;

        private void Start()
        {
            tree = tree.Clone();
            tree.Bind();
        }

        private void Update()
        {
            tree.Update();
        }
    }
}
