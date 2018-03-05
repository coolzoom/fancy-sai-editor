﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancySaiEditor.Nodes.EventNodes
{
    /// <summary>
    /// SMART_EVENT_WAYPOINT_REACHED
    /// SMART_EVENT_WAYPOINT_START
    /// </summary>
    [Node(MenuName = "Waypoint start", Type = NodeType.EVENT_WAYPOINT_START, AllowedTypes = new NodeType[] { NodeType.AI_OWNER, NodeType.ACTION })]
    public class WaypointStart : EventNode
    {
        /// <summary>
        /// Standard constructor.
        /// Initializes type, node name, tooltips and adds the connectors.
        /// </summary>
        public WaypointStart()
        {
            Type = NodeType.EVENT_WAYPOINT_START;

            //Update text
            NodeName.Content = "Waypoint start";

            AddParam(ParamId.PARAM_1, "Point Id:");
            AddParam(ParamId.PARAM_2, "Path Id:"); // TODO: Replace with param node
        }

        /// <summary>
        /// Clones the class instance.
        /// </summary>
        /// <returns>Returns clone of this class.</returns>
        public override Node Clone()
        {
            return new WaypointStart();
        }
    }
}
