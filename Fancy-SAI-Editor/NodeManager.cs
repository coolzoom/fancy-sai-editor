﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;

namespace NodeAI
{
    public class NodeManager
    {
        public NodeManager(Canvas _nodeEditor)
        {
            nodeEditor = _nodeEditor;

            nodeTrees = new List<NodeTree>();
        }

        private static NodeManager _instance = null;

        public static NodeManager Instance
        {
            get { Debug.Assert(_instance != null); return _instance; }
            set { Debug.Assert(_instance == null); _instance = value; }
        }


        /// <summary>
        /// Adds a node to the node store and manage positioning of this node.
        /// If the creator node is given the created node is going to be connected to the creator
        /// </summary>
        public void AddNode(Node node, Node creator = null)
        {

        }

        /// <summary>
        /// Copies the selected node.
        /// To copy a node one must be selected.
        /// </summary>
        public void CopyNode()
        {

        }

        /// <summary>
        /// Pastes the copied node.
        /// Before pasting a node must be copied.
        /// </summary>
        public void PasteNode()
        {

        }

        /// <summary>
        /// Deletes the selected node
        /// </summary>
        public void DeleteNode()
        {

        }

        /// <summary>
        /// Selects the passed nodes
        /// </summary>
        public void SelectNodes(List<Node> _nodes)
        {

        }

        /// <summary>
        /// Selects the passed node
        /// </summary>
        public void SelectNode(Node _node)
        {

        }

        /// <summary>
        /// Deselects the selected nodes if one is selected
        /// </summary>
        public void DeselectNodes()
        {

        }

        /// <summary>
        /// Scales the editor for the given value
        /// </summary>
        public void Scale(float delta)
        {

        }

        /// <summary>
        /// Repositions every node view tree and removes every collision
        /// </summary>
        public void Position()
        {

        }
        
        /// <summary>
        /// Updates everything belonging to nodes
        /// </summary>
        public void Update()
        {

        }

        /// <summary>
        /// Initiates the drag of a node from the given start point.
        /// This start point is used to determine how far and in which direction the drag is going to be performed
        /// </summary>
        public void InitDrag(Point _initPoint)
        {
            
        }

        /// <summary>
        /// Connects two node connectors with each other.
        /// A visual path is going to be created and the new connected nodes are going to be sorted in the correct node tree.
        /// </summary>
        public void ConnectNodeConnectors(NodeConnector origin, NodeConnector target)
        {
            origin.ConnectTo(target);
            target.ConnectTo(origin);
        }

        /// <summary>
        /// Exports every complete and valid node tree
        /// </summary>
        public void Export()
        {
            /*// Configure open file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "SAI", // Default file name
                DefaultExt = ".sql", // Default file extension
                Filter = "SQL File (.sql)|*.sql" // Filter files by extension
            };

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                SqlExporter exporter = new SqlExporter(nodes);
                exporter.Export(dlg.FileName);
            }*/
        }

        /// <summary>
        /// Exports the selected node tree if it's complete and valid
        /// </summary>
        public void ExportSelectedNodeTree()
        {

        }

        private Canvas nodeEditor;
        private List<NodeTree> nodeTrees;
    }
}